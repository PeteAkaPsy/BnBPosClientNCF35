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

        public CheckInForm()
        {
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
            panel2.Height = (cfg.Configs.Count() + 1) * (Element_Height + Element_Space);

            for (int i = 0; i < cfg.Configs.Count(); i++)
            {
                //ToDo: add with Data, positioning,scrolling
                TwoColTxtButton btn = Pools.TwoColTxtBtnPool.Get();
                btn.Width = panel2.Width;
                btn.Height = Element_Height;
                btn.Init(cfg.Configs[i].ServerName, OnClickElement, Resources.DeleteIcon_32, OnClickDeleteElement);
                btn.SetPos(0, i * (Element_Height + Element_Space));
                btn.EntryId = i;
                panel2.Controls.Add(btn);
            }

            vScrollBar1.UpdateVScroll(panel1);
        }

        private void OnBarcodeScanned(string bcode)
        {
            Debug.WriteLine("CheckIn Scanned BarCode:" + bcode);

            UpdateView();
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
    }
}