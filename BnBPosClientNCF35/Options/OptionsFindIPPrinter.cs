using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace BnBPosClientNCF35
{
    public partial class OptionsFindIPPrinter : Form
    {
        private const int Element_Height = 40;
        private const int Element_Space = 2;

        public OptionsFindIPPrinter()
        {
            InitializeComponent();
        }

        private void OptionsFindIPPrinter_Activated(object sender, EventArgs e)
        {
            IPAddress ip = Ext.GetCurrentIP();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}