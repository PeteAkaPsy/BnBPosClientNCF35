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
    public partial class AuctionItemsForm : Form
    {
        private const int Element_Height = 40;
        private const int Element_Space = 2;

        private BCReader.IBCReader bcr;

        //private List<SellItemData> items;
        private Dictionary<long,SellItemData> items;

        public AuctionItemsForm()
        {
            this.items = new Dictionary<long,SellItemData>();

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
            panel2.Height = (items.Count() + 1) * (Element_Height + Element_Space);

            for (int i = 0; i < items.Count(); i++)
            {
                //ToDo: add with Data, positioning,scrolling
                TwoColTxtButton btn = Pools.TwoColTxtBtnPool.Get();
                btn.Width = panel2.Width;
                btn.Height = Element_Height;
                btn.Init(items[i].Name, items[i].Price.CurrencyStr(), Resources.DeleteIcon_32, OnClickDeleteElement);
                btn.SetPos(0, i * (Element_Height + Element_Space));
                btn.EntryId = i;
                panel2.Controls.Add(btn);
            }

            vScrollBar1.UpdateVScroll(panel1);
        }

        private void OnBarcodeScanned(string bcode)
        {
            Debug.WriteLine("CheckIn Scanned BarCode:" + bcode);

            long bcodeVal = Convert.ToInt64(bcode);

            if (bcodeVal == 0)
            {
                Debug.WriteLine("Checked in Value could not be converted to an integer");
                return;
            }

            Program.rest.Get<SellItemData>("/r/sellitem", new Dictionary<string, string>() { { "", "" } }, 
                result => {
                    if (result != null && !this.items.ContainsKey(result.Id))
                    {
                        this.items.Add(result.Id, result);
                        UpdateView();
                    }
                }, 
                errors => {
                });
        }

        private void OnClickDeleteElement(long index)
        {

        }

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
            this.Close();
        }

        private void manualInputButton_Click(object sender, EventArgs e)
        {
            //Form frm = new ManualInputForm(this.OnBarcodeScanned);
            //frm.Show();
        }
    }
}