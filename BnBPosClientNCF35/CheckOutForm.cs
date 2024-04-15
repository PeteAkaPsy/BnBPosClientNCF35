using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;
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
    public partial class CheckOutForm : Form
    {
        private const int Element_Height = 40;
        private const int Element_Space = 2;
        private const int Reload_Time = 5; //ToDo: move to cfg to be able ton conf it

        private BCReader.IBCReader bcr;

        private UserData userData;
        private List<SellItemData> sellItems;
        private List<AuctItemData> auctItems;

        private Form subForm = null;

        public CheckOutForm(UserData userData)
        {
            this.userData = userData;
            this.sellItems = new List<SellItemData>();
            this.auctItems = new List<AuctItemData>();

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
            Pools.RecycleTwoColTxtBtnCollection(panel2.Controls);
            this.panel2.Height = (this.sellItems.Count() + 1) * (Element_Height + Element_Space);

            for (int i = 0; i < sellItems.Count(); i++)
            {
                SellItemData data = this.sellItems[i];
                TwoColTxtButton btn = Pools.TwoColTxtBtnPool.Get();
                btn.Width = this.panel2.Width;
                btn.Height = Element_Height;
                btn.Init(data.Name, data.Price.CurrencyStr(), this.OnEntryClicked, null, null); //no delete of single elements on checkin/out
                btn.SetPos(0, i * (Element_Height + Element_Space));
                btn.EntryId = i;
                this.panel2.Controls.Add(btn);
            }

            for (int i = 0; i < auctItems.Count(); i++)
            {
                AuctItemData data = this.auctItems[i];
                TwoColTxtButton btn = Pools.TwoColTxtBtnPool.Get();
                btn.Width = this.panel2.Width;
                btn.Height = Element_Height;
                btn.Init(data.Name, data.StartPrice.CurrencyStr(), this.OnEntryClicked, null, null); //no delete of single elements on checkin/out
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
                            if (item.ItemState != (uint)ItemStates.Sold)
                                this.sellItems.Add(item);
                        }
                        foreach (AuctItemData item in result.AuctItems)
                        {
                            if (item.ItemState != (uint)ItemStates.Sold)
                                this.auctItems.Add(item);
                        }
                        this.UpdateView();
                    }
                },
                errors =>
                {
                });
        }

        private void OnEntryClicked(long index)
        {
            if (index < 0) return;

            long id = 0;
            ScannedType st = ScannedType.None;

            if (index >= this.sellItems.Count)
            {
                st = ScannedType.Auction;
                long tIndex = index - this.sellItems.Count;
                id = this.auctItems.ElementAt((int)tIndex).Id;
            }
            else
            {
                st = ScannedType.Sale;
                id = this.sellItems.ElementAt((int)index).Id;
            }

            switch (st)
            {
                case ScannedType.Sale:
                    {
                        Program.rest.Get<SellItemDataWithImg>("/r/sellcheckin", new Dictionary<string, string>() { { "id", id.ToString() } },
                            result =>
                            {
                                if (result != null)
                                {
                                    if (result.Images == null || result.Images.Length == 0)
                                    {
                                        this.subForm = new CheckOutItemForm(result);
                                        this.subForm.Show();
                                    }
                                }
                            },
                            errors =>
                            {
                            });
                    } break;
                case ScannedType.Auction:
                    {
                        Program.rest.Get<AuctItemDataWithImg>("/r/auctioncheckin", new Dictionary<string, string>() { { "id", id.ToString() } },
                            result =>
                            {
                                if (result != null)
                                {
                                    this.subForm = new CheckOutItemForm(result);
                                    this.subForm.Show();
                                }
                            },
                            errors =>
                            {
                            });
                    } break;
            }
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
            if (data.DType == (uint)ScannedType.Sale)
            {
                Program.rest.Get<SellItemDataWithImg>("/r/sellcheckout", new Dictionary<string, string>() { { "id", data.ID.ToString() } },
                    result =>
                    {
                        CloseSubForm();
                        Reload();
                    },
                    errors =>
                    {
                    });
            }
            else if (data.DType == (uint)ScannedType.Auction)
            {
                Program.rest.Get<SellItemDataWithImg>("/r/auctioncheckout", new Dictionary<string, string>() { { "id", data.ID.ToString() } },
                    result =>
                    {
                        CloseSubForm();
                        Reload();
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
            //Form frm = new ManualInputForm(this.OnBarcodeScanned);
            //frm.Show();
        }

        private void CloseSubForm()
        {
            if (this.subForm == null) return;

            this.subForm.Close();
            this.subForm = null;
        }

        private void Clear()
        {
            this.sellItems.Clear();
            this.auctItems.Clear();
            Pools.RecycleTwoColTxtBtnCollection(this.panel2.Controls);
        }
    }
}