using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
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

        private Dictionary<long, SellItemData> sellItems;
        private Dictionary<long, AuctItemData> auctItems;

        public CheckInForm()
        {
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
            }
            catch (RetroLab.Json.JsonException ex)
            {
                Debug.WriteLine("Decoding Json from BarCode Failed:\n" + ex.Message);
                Debug.WriteLine(ex.StackTrace);
            }
        }

        private void OnItemScanned(ScannedData data)
        {
            if (data.DType == (uint)ScannedType.Sale)
            {

                Program.rest.Get<SellItemDataWithImg>("/r/sellcheckin", new Dictionary<string, string>() { { "id", data.ID.ToString() } },
                    result =>
                    {
                        if (result != null && !this.sellItems.ContainsKey(result.Id))
                        {
                            this.sellItems.Add(result.Id, result.ToSellItem());
                            if (result.Images == null || result.Images.Length == 0)
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
            else if (data.DType == (uint)ScannedType.Auction)
            {
                Program.rest.Get<AuctItemDataWithImg>("/r/auctioncheckin", new Dictionary<string, string>() { { "id", data.ID.ToString() } },
                    result =>
                    {
                        if (result != null && !this.sellItems.ContainsKey(result.Id))
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
            Program.rest.Post<bool, ImageData>("/r/sellitem/image", new ImageData() { ID = sellId, Data = data },
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
            Program.rest.Post<bool, ImageData>("/r/auctitem/image", new ImageData() { ID = auctId, Data = data },
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

        private void imageButton2_Click(object sender, EventArgs e)
        {

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
    }
}