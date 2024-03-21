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
    public partial class PayOut : Form
    {
        private Action OnOk;

        public PayOut(float payout, Action onOk)
        {
            this.OnOk = onOk;
            this.label2.Text = payout.CurrencyStr();
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            if (this.OnOk != null)
                this.OnOk.Invoke();
            this.Close();
        }
    }
}