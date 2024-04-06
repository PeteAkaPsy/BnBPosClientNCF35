using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BnBPosClientNCF35.Properties;

namespace BnBPosClientNCF35
{
    public partial class WarningForm : Form
    {
        public WarningForm(string text) : this(text, null) { }

        public WarningForm(string text, Image image)
        {
            InitializeComponent();

            this.label.Text = text;

            if (image == null)
            {
                this.okButton.Image = Resources.AdultOnlyIcon_128;
            }
        }

        private void payButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}