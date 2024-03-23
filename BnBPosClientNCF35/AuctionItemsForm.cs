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
        private BCReader.IBCReader bcr;

        //private List<SellItemData> items;
        //private Dictionary<long,AuctItemData> items;

        public AuctionItemsForm()
        {
            //this.items = new Dictionary<long,AuctItemData>();

            InitializeComponent();

            this.bcr = Program.barcodeReader;

            if (this.bcr != null)
            {
                this.bcr.OnScan += this.OnBarcodeScanned;
                this.bcr.StartReader();
            }
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
                //Show MSGBox on Repeat and play fail sfx
                return;
            }

            Program.rest.Get<AuctItemData>("/r/auctionitem", new Dictionary<string, string>() { { "", "" } }, 
                result => {
                    if (result != null)
                    {
                        this.nameLabel.Text = result.Name;
                        this.descriptionTB.Text = result.Descr;
                        this.startPriceLabel.Text = result.StartPrice.CurrencyStr();
                    }
                }, 
                errors => {
                });
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
            Form frm = new ManualInputForm(this.OnItemScanned, ScannedType.Auction);
            frm.Show();
        }
    }
}