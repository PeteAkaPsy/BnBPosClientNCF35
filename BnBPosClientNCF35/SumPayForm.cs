using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace BnBPosClientNCF35
{
    public partial class SumPayForm : Form
    {
        private float sumToPay;
        private Action<float, float, float> OnPaymentCompleted;

        public SumPayForm(float sumToPay, Action<float,float,float> onPaymentCompleted)
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
            else
            {
                Form frm = new PayOut(input - this.sumToPay, () =>
                {
                    if (this.OnPaymentCompleted != null) this.OnPaymentCompleted.Invoke(this.sumToPay, input, input-this.sumToPay);
                    this.Close();
                });
                frm.Show();
                return;
            }

            //if (this.OnPaymentCompleted != null)
            //    this.OnPaymentCompleted.Invoke(this.sumToPay, input, input-this.sumToPay);
            Debug.WriteLine("Error: SumPayForm.sumPayedBtn() oops smth. went wrong here...");
            this.Close();
        }
    }
}