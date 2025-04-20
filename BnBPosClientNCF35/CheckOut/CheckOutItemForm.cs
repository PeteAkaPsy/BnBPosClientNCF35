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
            if (sellItem != null)
            {
                this.nameLabel.Text = sellItem.Name;
                //this.categoryLabel.Text = sellItem.Name;
                this.nameLabel.Text = sellItem.Name;
                //ToDo: maybe the old image needs cleanup?
                SetNewPB1Img(Ext.GetImgFromB64(sellItem.Images != null && sellItem.Images.Length > 0 ? sellItem.Images[0].Data : null));
            }
            else if (auctItem != null)
            {
                this.nameLabel.Text = auctItem.Name;
                //this.categoryLabel.Text = auctItem.Name;
                this.nameLabel.Text = auctItem.Name;
                //ToDo: maybe the old image needs cleanup?
                SetNewPB1Img(Ext.GetImgFromB64(auctItem.Images != null && auctItem.Images.Length > 0 ? auctItem.Images[0].Data : null));
            }
        }

        private void SetNewPB1Img(Image img)
        {
            if (this.pictureBox1.Image != null)
            {
                this.pictureBox1.Image.Dispose();
                this.pictureBox1.Image = null;
            }
            this.pictureBox1.Image = img;
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