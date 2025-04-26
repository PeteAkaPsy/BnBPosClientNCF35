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

            Reload();
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
                btn.BGColor = ItemStateColors.CheckInColor((ItemStates)data.ItemState);
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
                btn.BGColor = ItemStateColors.CheckInColor((ItemStates)data.ItemState);
                btn.SetPos(0, (this.sellItems.Count + i) * (Element_Height + Element_Space));
                btn.EntryId = this.sellItems.Count + i;
                this.panel2.Controls.Add(btn);
            }

            this.vScrollBar1.UpdateVScroll(this.panel1);
        }

        private void Reload()
        {
            this.sellItems.Clear();
            Program.rest.Get<AllItemsData>("/r/allitems", new Dictionary<string, string>() { { "id", userData.Id.ToString() } },
                result =>
                {
                    if (result != null)
                    {
                        foreach (SellItemData item in result.SellItems)
                        {
                            this.sellItems.Add(item.Id, item);
                        }
                        foreach (AuctItemData item in result.AuctItems)
                        {
                            this.auctItems.Add(item.Id, item);
                        }
                        this.UpdateView();
                    }
                },
                errors =>
                {
                });
        }

        private void OnBarcodeScanned(string bcode)
        {
            Debug.WriteLine("CheckIn Scanned BarCode:" + bcode);

            ScannedData data;

            try
            {
                data = RetroLab.Json.Converter.Deserialize<ScannedData>(bcode);
                Debug.WriteLine("Deserialized! -> calling OnItemScanned");
                this.Invoke(new Action(() => OnItemScanned(data)));
                //Debug.WriteLine("OnItemScanned done!");
            }
            catch (RetroLab.Json.JsonException ex)
            {
                Debug.WriteLine("Decoding Json from BarCode Failed:\n" + ex.Message);
                Debug.WriteLine(ex.StackTrace);
            }
        }

        private void OnItemScanned(ScannedData data)
        {
            if (data.UID != this.userData.Id)
            {
                Debug.WriteLine("Deserialized! -> calling OnItemScanned");
                //ToDo: play an error sound
                return;
            }

            if (data.DT == (uint)ScannedType.Sale)
            {
                Debug.WriteLine("Calling SellCheckin!");
                Program.rest.Get<SellItemDataWithImg>("/r/sellcheckin", new Dictionary<string, string>() { { "id", data.ID.ToString() } },
                    result =>
                    {
                        if (result != null && !this.sellItems.ContainsKey(result.Id))
                        {
                            Debug.WriteLine("result price: " + result.Price);
                            if (Program.cfg.allowImgCapture && (result.Images == null || result.Images.Length == 0))
                            {
                                Form frm = new CameraForm(ScannedType.Sale, result.Id, this.AddSellImg);
                                frm.Show();
                            }
                            else
                            {
                                this.Reload();
                            }
                        }
                    },
                    errors =>
                    {
                    });
            }
            else if (data.DT == (uint)ScannedType.Auction)
            {
                Debug.WriteLine("Calling AucttionCheckin!");
                Program.rest.Get<AuctItemDataWithImg>("/r/auctioncheckin", new Dictionary<string, string>() { { "id", data.ID.ToString() } },
                    result =>
                    {
                        if (Program.cfg.allowImgCapture && (result != null && !this.auctItems.ContainsKey(result.Id)))
                        {
                            if (result.Images == null || result.Images.Length == 0)
                            {
                                Form frm = new CameraForm(ScannedType.Auction, result.Id, this.AddAuctImg);
                                frm.Show();
                            }
                            else
                            {
                                this.Reload();
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
                    this.Reload();
                },
                errors =>
                {
                    this.Reload();
                });
        }

        private void AddAuctImg(long auctId, string data)
        {
            Program.rest.Post<bool, ImageData>("/r/auctitem/image", new ImageData() { Id = auctId, Data = data },
                result =>
                {
                    this.Reload();
                },
                errors =>
                {
                    this.Reload();
                });
        }

        //no delete on chekin/out
        //private void OnClickDeleteElement(long index){}

        private void printButton_Click(object sender, EventArgs e)
        {
            string printString = "";

            //update label-template ToDo: move to mainScreen/connect
            printString += ReadLabel(Program.Path(), this.cfg.LabelTemplateFile);

            //read the data template to print the actual labels(print last first)
            string label = ReadLabel(Program.Path(), this.cfg.LabelDataFile);
            label = label.Replace("__EVENTNAME__", this.cfg.EventName);
            
            string userLabel = ReadLabel(Program.Path(), this.cfg.LabelHeaderFile);
            userLabel = userLabel.Replace("__EVENTNAME__", this.cfg.EventName);
            userLabel = userLabel.Replace("__USERNAME__", this.userData.UserName);
            userLabel = userLabel.Replace("__UID__", this.userData.Id.ToString());
            //ToDo: add user specific data here e.g. name+id
            printString = userLabel.Replace("__TYPE__", "Sale") + printString;

            //init label print
            long[] sellKeys = this.sellItems.Keys.ToArray();
            for (int i = 0; i < sellKeys.Count(); i++)
            {
                SellItemData item = this.sellItems[sellKeys[i]];
                if (item.ItemState == (uint)ItemStates.New)
                {
                    printString = FillLabel(label, item.ToScanData()) + printString;
                }
            }

            printString = userLabel.Replace("__TYPE__", "Auction") + printString;

            long[] auctKeys = this.auctItems.Keys.ToArray();
            for (int i = 0; i < auctKeys.Count(); i++)
            {
                AuctItemData item = this.auctItems[auctKeys[i]];
                if (item.ItemState == (uint)ItemStates.New)
                {
                    printString = FillLabel(label, item.ToScanData()) + printString;
                }
            }
            
            PosPrinter.Connector con = new PosPrinter.Connector();
            con.InitTCP(this.cfg.LabelPrinterIP, this.cfg.LabelPrinterPort);
            con.Print(printString);
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