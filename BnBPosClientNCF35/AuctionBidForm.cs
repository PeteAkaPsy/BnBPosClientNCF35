using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BnBPosClientNCF35
{
    public partial class AuctionBidForm : Form
    {
        private float minimumToPay;
        private Action<float> OnPaymentCompleted;

        public AuctionBidForm(float minimumToPay, Action<float> onPaymentCompleted)
        {
            this.minimumToPay = minimumToPay;
            this.OnPaymentCompleted = onPaymentCompleted;

            InitializeComponent();

            this.sumLabel.Text = this.minimumToPay.CurrencyStr();

            //Font tFont = sumTextLabel.Font;
            //tFont.Style = FontStyle.Bold; 
        }

        private void imageButton2_Click(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bidToPayBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.handedTB.Text)) return;

            float input = Convert.ToSingle(this.handedTB.Text);
            if (input < this.minimumToPay)
            {
                MessageBox.Show("Bid not high enough!");
                return;
            }
            else
            {
                Form frm = new SumPayForm(input, this.onBidCompleted);
                frm.Show();
                return;
            }
        }

        private void onBidCompleted()
        {
            if (this.OnPaymentCompleted != null)
                this.OnPaymentCompleted.Invoke(Convert.ToSingle(this.handedTB.Text));
            this.Close();
        }
    }
}