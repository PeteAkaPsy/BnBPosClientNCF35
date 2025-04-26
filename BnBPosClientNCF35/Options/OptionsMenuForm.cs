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

        private void jsonDbgBtn_Click(object sender, EventArgs e)
        {
            string json = "{\"DT\":1,\"ID\":59,\"UID\":7,\"CID\":11,\"N\":\"user7 Item 0\",\"P\":37.73,\"AO\":false}";
            ScannedData data;
            data = RetroLab.Json.Converter.Deserialize<ScannedData>(json);
            //Debug.WriteLine("Deserialized! -> calling OnItemScanned");
        }
    }
}