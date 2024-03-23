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
    public partial class SumPayForm : Form
    {
        private float sumToPay;
        private Action OnPaymentCompleted;

        public SumPayForm(float sumToPay, Action onPaymentCompleted)
        {
            this.sumToPay = sumToPay;
            this.OnPaymentCompleted = onPaymentCompleted;

            InitializeComponent();

            this.sumLabel.Text = this.sumToPay.CurrencyStr();

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

        private void sumPayedBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.handedTB.Text)) return;

            float input = Convert.ToSingle(this.handedTB.Text);
            if (input < this.sumToPay)
            {
                MessageBox.Show("Not enough Money given!");
                return;
            }

            if (input > this.sumToPay)
            {
                Form frm = new PayOut(input - this.sumToPay, () =>
                {
                    if (this.OnPaymentCompleted != null) this.OnPaymentCompleted.Invoke();
                    this.Close();
                });
                frm.Show();
                return;
            }

            if (this.OnPaymentCompleted != null)
                this.OnPaymentCompleted.Invoke();
            this.Close();
        }
    }
}