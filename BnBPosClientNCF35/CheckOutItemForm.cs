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
    public partial class CheckOutItemForm : Form
    {
        private SellItemDataWithImg sellItem = null;
        private AuctItemDataWithImg auctItem = null;

        public CheckOutItemForm(SellItemDataWithImg sellItem) : this(sellItem, null) {}
        public CheckOutItemForm(AuctItemDataWithImg auctItem) : this(null, auctItem) {}

        public CheckOutItemForm(SellItemDataWithImg sellItem, AuctItemDataWithImg auctItem)
        {
            this.sellItem = sellItem;
            this.auctItem = auctItem;

            InitializeComponent();

            UpdateView();
        }

        private void UpdateView()
        {
            this.nameLabel.Text = sellItem != null ? sellItem.Name : auctItem.Name;
            //this.categoryLabel.Text = sellItem != null ? sellItem.Name : auctItem.Name;
            this.nameLabel.Text = sellItem != null ? sellItem.Name : auctItem.Name;
            //ToDo: maybe the old image needs cleanup?
            if (this.pictureBox1.Image != null)
            {
                this.pictureBox1.Image.Dispose();
                this.pictureBox1.Image = null;
            }
            this.pictureBox1.Image = Ext.GetImgFromB64( sellItem != null ? sellItem.Images[0].Data : auctItem.Images[0].Data);
        }

        private void imageButton2_Click(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}