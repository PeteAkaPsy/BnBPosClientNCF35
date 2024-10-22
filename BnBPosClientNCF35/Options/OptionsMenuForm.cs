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
    public partial class OptionsMenuForm : Form
    {
        public OptionsMenuForm()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void generalSettingsBtn_Click(object sender, EventArgs e)
        {
        }

        private void printerSettingsBtn_Click(object sender, EventArgs e)
        {
            Form frm = new OptionsSetIPPrinter();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }
    }
}