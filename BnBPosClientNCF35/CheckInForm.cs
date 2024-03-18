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

        //private List<SellItemData> items;
        private Dictionary<long,SellItemData> sellItems;
        private Dictionary<long,AuctItemData> auctItems;

        public CheckInForm()
        {
            this.sellItems = new Dictionary<long,SellItemData>();

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
            //List<CollectionsData> collections = collectionsDb.CollTbl.Select();
            Pools.RecycleTwoColTxtBtnCollection(panel2.Controls);
            panel2.Height = (sellItems.Count() + 1) * (Element_Height + Element_Space);

            for (int i = 0; i < sellItems.Count(); i++)
            {
                TwoColTxtButton btn = Pools.TwoColTxtBtnPool.Get();
                btn.Width = panel2.Width;
                btn.Height = Element_Height;
                btn.Init(sellItems[i].Name, sellItems[i].Price.CurrencyStr(), null, null); //no delete of single elements on checkin/out
                btn.SetPos(0, i * (Element_Height + Element_Space));
                btn.EntryId = i;
                panel2.Controls.Add(btn);
            }

            for (int i = 0; i < auctItems.Count(); i++)
            {
                TwoColTxtButton btn = Pools.TwoColTxtBtnPool.Get();
                btn.Width = panel2.Width;
                btn.Height = Element_Height;
                btn.Init(sellItems[i].Name, auctItems[i].StartPrice.CurrencyStr(), null, null); //no delete of single elements on checkin/out
                btn.SetPos(0, (sellItems.Count + i) * (Element_Height + Element_Space));
                btn.EntryId = sellItems.Count + i;
                panel2.Controls.Add(btn);
            }

            vScrollBar1.UpdateVScroll(panel1);
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

                Program.rest.Get<SellItemData>("/r/sellcheckin", new Dictionary<string, string>() { { "id", data.ID.ToString() } },
                    result =>
                    {
                        if (result != null && !this.sellItems.ContainsKey(result.Id))
                        {
                            this.sellItems.Add(result.Id, result);
                            UpdateView();
                        }
                    },
                    errors =>
                    {
                    });
            }
            else if (data.DType == (uint)ScannedType.Auction)
            {
                Program.rest.Get<AuctItemData>("/r/auctcheckin", new Dictionary<string, string>() { { "id", data.ID.ToString() } },
                    result =>
                    {
                        if (result != null && !this.sellItems.ContainsKey(result.Id))
                        {
                            this.auctItems.Add(result.Id, result);
                            UpdateView();
                        }
                    },
                    errors =>
                    {
                    });
            }
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
            Pools.RecycleTwoColTxtBtnCollection(panel2.Controls);
        }
    }
}