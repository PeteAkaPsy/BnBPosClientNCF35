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
    public partial class SellItemsForm : Form
    {
        private const int Element_Height = 40;
        private const int Element_Space = 2;

        private BCReader.IBCReader bcr;

        //private List<SellItemData> items;
        private Dictionary<long,SellItemData> items;

        public SellItemsForm()
        {
            this.items = new Dictionary<long,SellItemData>();

            InitializeComponent();

            this.bcr = Program.barcodeReader;

            if (this.bcr != null)
            {
                this.bcr.OnScan += this.OnBarcodeScanned;
                this.bcr.StartReader();
            }

            this.UpdateView();
        }

        private void UpdateView()
        {
            Pools.RecycleTwoColTxtBtnCollection(this.panel2.Controls);
            this.panel2.Height = (this.items.Count() + 1) * (Element_Height + Element_Space);

            float tempSum = 0.0f;

            long[] keys = this.items.Keys.ToArray();
            for (int i = 0; i < this.items.Count(); i++)
            {
                SellItemData data = this.items[keys[i]];
                tempSum += data.Price;
                TwoColTxtButton btn = Pools.TwoColTxtBtnPool.Get();
                btn.Width = this.panel2.Width;
                btn.Height = Element_Height;
                btn.Init(data.Name, data.Price.CurrencyStr(), Resources.DeleteIcon_32, this.OnClickDeleteElement);
                btn.SetPos(0, i * (Element_Height + Element_Space));
                btn.EntryId = data.Id;
                this.panel2.Controls.Add(btn);
            }

            this.vScrollBar1.UpdateVScroll(this.panel1);
            this.tempSumLabel.Text = tempSum.CurrencyStr();
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
            if (data.DType == (uint)ScannedType.Auction)
            {
                //Show MSGBox on Repeat and play fail sfx
                return;
            }

            Program.rest.Get<SellItemData>("/r/sellitem", new Dictionary<string, string>() { { "id", data.ID.ToString() } }, 
                result => {
                    if (result != null && !this.items.ContainsKey(result.Id))
                    {
                        this.items.Add(result.Id, result);
                        this.UpdateView();
                        if (result.AdultOnly)
                        {
                            Form frm = new WarningForm(Loca.AdultsOnlyWarning);
                            frm.Show();
                        }
                    }
                }, 
                errors => {
                });
        }

        private void OnClickDeleteElement(long index)
        {
            if (!this.items.ContainsKey(index))
            {
                //error
                return;
            }

            this.items.Remove(index);
            this.UpdateView();
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
            this.Clear();
            this.Close();
        }

        private void manualInputButton_Click(object sender, EventArgs e)
        {
            //ToDo: configure to only allow only sale items
            Form frm = new ManualInputForm(this.OnItemScanned, ScannedType.Sale);
            frm.Show();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Clear();
            this.UpdateView();
        }

        private void Clear()
        {
            this.items.Clear();
            Pools.RecycleTwoColTxtBtnCollection(this.panel2.Controls);
        }

        private void payButton_Click(object sender, EventArgs e)
        {
            float sum = 0;
            long[] keys = this.items.Keys.ToArray();
            for (int i = 0; i < this.items.Count; i++)
                sum += this.items[keys[i]].Price;

            SumPayForm frm = new SumPayForm(sum, this.markSold);
            frm.Show();
        }

        private void markSold()
        {
            long[] keys = this.items.Keys.ToArray();

            Program.rest.Post<bool, long[]>("/r/sellitems/sold", keys,
                    result =>
                    {
                        if (result != true)
                        {
                            //if false put into log list for action later
                        }
                        this.items.Clear();
                        this.UpdateView();
                    },
                    errors =>
                    {
                        //check the error and put into log list
                        this.items.Clear();
                        this.UpdateView();
                    });
        }
    }
}