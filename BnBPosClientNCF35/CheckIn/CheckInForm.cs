using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Data;
using System.Drawing;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;
using Retrolab;
using BnBPosClientNCF35.Properties;

namespace BnBPosClientNCF35
{
    public partial class CheckInForm : Form
    {
        private const int Element_Height = 40;
        private const int Element_Space = 2;

        private BCReader.IBCReader bcr;

        private UserData userData;
        private Dictionary<long, SellItemData> sellItems;
        private Dictionary<long, AuctItemData> auctItems;
        private ServerCfg cfg;

        public CheckInForm(UserData userData)
        {
            this.cfg = Program.cfg.CurrentCfg;
            this.userData = userData;
            this.sellItems = new Dictionary<long, SellItemData>();
            this.auctItems = new Dictionary<long, AuctItemData>();

            InitializeComponent();

            this.bcr = Program.barcodeReader;

            if (this.bcr != null)
            {
                this.bcr.OnScan += this.OnBarcodeScanned;
                this.bcr.StartReader();
            }

            UpdateView();
        }

        private void UpdateView()
        {
            Pools.RecycleTwoColTxtBtnCollection(this.panel2.Controls);
            this.panel2.Height = (this.sellItems.Count() + 1) * (Element_Height + Element_Space);

            long[] sellKeys = this.sellItems.Keys.ToArray();
            for (int i = 0; i < sellKeys.Count(); i++)
            {
                SellItemData data = this.sellItems[sellKeys[i]];
                Debug.WriteLine("data.Price " + data.Price);
                TwoColTxtButton btn = Pools.TwoColTxtBtnPool.Get();
                btn.Width = this.panel2.Width;
                btn.Height = Element_Height;
                btn.Init(data.Name, data.Price.CurrencyStr(), null, null); //no delete of single elements on checkin/out
                btn.SetPos(0, i * (Element_Height + Element_Space));
                btn.EntryId = i;
                this.panel2.Controls.Add(btn);
            }

            long[] auctKeys = this.auctItems.Keys.ToArray();
            for (int i = 0; i < auctKeys.Count(); i++)
            {
                AuctItemData data = this.auctItems[auctKeys[i]];
                TwoColTxtButton btn = Pools.TwoColTxtBtnPool.Get();
                btn.Width = this.panel2.Width;
                btn.Height = Element_Height;
                btn.Init(data.Name, data.StartPrice.CurrencyStr(), null, null); //no delete of single elements on checkin/out
                btn.SetPos(0, (this.sellItems.Count + i) * (Element_Height + Element_Space));
                btn.EntryId = this.sellItems.Count + i;
                this.panel2.Controls.Add(btn);
            }

            this.vScrollBar1.UpdateVScroll(this.panel1);
        }

        private void OnBarcodeScanned(string bcode)
        {
            Debug.WriteLine("CheckIn Scanned BarCode:" + bcode);

            ScannedData data;

            try
            {
                data = RetroLab.Json.Converter.Deserialize<ScannedData>(bcode);
                OnItemScanned(data);
            }
            catch (RetroLab.Json.JsonException ex)
            {
                Debug.WriteLine("Decoding Json from BarCode Failed:\n" + ex.Message);
                Debug.WriteLine(ex.StackTrace);
            }
        }

        private void OnItemScanned(ScannedData data)
        {
            if (data.DT == (uint)ScannedType.Sale)
            {

                Program.rest.Get<SellItemDataWithImg>("/r/sellcheckin", new Dictionary<string, string>() { { "id", data.ID.ToString() } },
                    result =>
                    {
                        if (result != null && !this.sellItems.ContainsKey(result.Id))
                        {
                            Debug.WriteLine("result price: " + result.Price);
                            this.sellItems.Add(result.Id, result.ToSellItem());
                            if (Program.cfg.allowImgCapture && (result.Images == null || result.Images.Length == 0))
                            {
                                Form frm = new CameraForm(ScannedType.Sale, result.Id, this.AddSellImg);
                                frm.Show();
                            }
                            else
                            {
                                this.UpdateView();
                            }
                        }
                    },
                    errors =>
                    {
                    });
            }
            else if (data.DT == (uint)ScannedType.Auction)
            {
                Program.rest.Get<AuctItemDataWithImg>("/r/auctioncheckin", new Dictionary<string, string>() { { "id", data.ID.ToString() } },
                    result =>
                    {
                        if (Program.cfg.allowImgCapture && (result != null && !this.auctItems.ContainsKey(result.Id)))
                        {
                            this.auctItems.Add(result.Id, result.ToAuctItem());
                            if (result.Images == null || result.Images.Length == 0)
                            {
                                Form frm = new CameraForm(ScannedType.Auction, result.Id, this.AddAuctImg);
                                frm.Show();
                            }
                            else
                            {
                                this.UpdateView();
                            }
                        }
                    },
                    errors =>
                    {
                    });
            }
        }

        private void AddSellImg(long sellId, string data)
        {
            Program.rest.Post<bool, ImageData>("/r/sellitem/image", new ImageData() { Id = sellId, Data = data },
                result =>
                {
                    this.UpdateView();
                },
                errors =>
                {
                    this.UpdateView();
                });
        }

        private void AddAuctImg(long auctId, string data)
        {
            Program.rest.Post<bool, ImageData>("/r/auctitem/image", new ImageData() { Id = auctId, Data = data },
                result =>
                {
                    this.UpdateView();
                },
                errors =>
                {
                    this.UpdateView();
                });
        }

        //no delete on chekin/out
        //private void OnClickDeleteElement(long index){}

        private void printButton_Click(object sender, EventArgs e)
        {
            // print labels here
            Program.rest.Get<AllItemsData>("/r/allitems", new Dictionary<string, string>() { { "id", userData.Id.ToString() } },
                result =>
                {
                    if (result != null)
                    {
                        PosPrinter.Connector con = new PosPrinter.Connector();
                        con.InitTCP(this.cfg.LabelPrinterIP, this.cfg.LabelPrinterPort);

                        string label = ReadLabel(Program.Path(), this.cfg.LabelHeaderFile);
                        label = label.Replace("__EVENTNAME__", this.cfg.EventName);
                        //ToDo: add user specific data here e.g. name+id
                        con.Print(label);

                        label = ReadLabel(Program.Path(), this.cfg.LabelTemplateFile);
                        con.Print(label);

                        label = ReadLabel(Program.Path(), this.cfg.LabelDataFile);
                        label = label.Replace("__EVENTNAME__", this.cfg.EventName);

                        //init label print
                        foreach (SellItemData item in result.SellItems)
                        {
                            if (item.ItemState == (uint)ItemStates.New)
                            {
                                con.Print(FillLabel(label, item.ToScanData()));
                            }
                        }
                        foreach (AuctItemData item in result.AuctItems)
                        {
                            if (item.ItemState == (uint)ItemStates.New)
                            {
                                con.Print(FillLabel(label, item.ToScanData()));
                            }
                        }
                        this.UpdateView();
                    }
                },
                errors =>
                {
                });
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            if (this.bcr != null)
            {
                this.bcr.StopReader();
                this.bcr.OnScan -= this.OnBarcodeScanned;
            }
            this.Clear();
            this.Close();
        }

        private void manualInputButton_Click(object sender, EventArgs e)
        {
            Form frm = new ManualInputForm(this.OnItemScanned);
            frm.Show();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Clear();
        }

        private void Clear()
        {
            this.sellItems.Clear();
            this.auctItems.Clear();
            Pools.RecycleTwoColTxtBtnCollection(this.panel2.Controls);
        }

        private string FillLabel(string label, ScannedData item)
        {
            string json = "";
            try
            {
                json = RetroLab.Json.Converter.Serialize(item);
            }
            catch
            {
                //foo
            }

            //for now no url feature, just pure data
            //string uri = 
            //    item.DT == (uint)ScannedType.Sale ? 
            //    Program.rest.GetFullPath("/sellitem/showfj?json=") + System.Uri.EscapeDataString(json) :
            //    item.DT == (uint)ScannedType.Auction ? 
            //        Program.rest.GetFullPath("/auctionitem/showfj?json=") + System.Uri.EscapeDataString(json) :
            //        Program.rest.GetFullPath("");

            label = label.Replace("__CAT__", item.CID.ToString());
            label = label.Replace("__ID__", item.ID.ToString());
            label = label.Replace("__PRICE__", item.P.CurrencyStr());
            //label = label.Replace("__QRJSON__", uri);
            label = label.Replace("__QRJSON__", json);
            label = label.Replace("__NAME__", item.N);
            return label;
        }

        private string ReadLabel(string bPath, string fPath)
        {
            string path = Path.Combine(bPath, fPath);
            if (!File.Exists(path))
            {
                MessageBox.Show("the Labelfile: " + path + " was not found!");
                return null;
            }

            return Ext.ReadAllText(path);
        }
    }
}