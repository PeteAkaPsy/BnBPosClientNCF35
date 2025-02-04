using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace BnBPosClientNCF35
{
    public partial class OptionsSetIPPrinter : Form
    {
        public OptionsSetIPPrinter()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lpSearchBtn_Click(object sender, EventArgs e)
        {
            Form frm = new OptionsFindIPPrinter();
            frm.Show();
        }

        private void imageButton1_Click(object sender, EventArgs e)
        {
            Form frm = new OptionsFindIPPrinter();
            frm.Show();
        }

        private void lpTestBtn_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(Program.Path(), "Labels\\Test.zpl");
            if (!File.Exists(path))
            {
                MessageBox.Show("the Testlabel: " + path + " was not found!");
                return;
            }

            PosPrinter.Connector con = new PosPrinter.Connector();
            con.InitTCP(this.lpUriTB.Text, Convert.ToInt32(this.lpPortTB.Text));

            string testLabel = Ext.ReadAllText(path);

            con.Print(testLabel);
        }

        private void stdpTestBtn_Click(object sender, EventArgs e)
        {
            //string path = Path.Combine(Program.Path(), "documents\\test2.pdf");//worked!
            string path = Path.Combine(Program.Path(), "documents\\test2.ps");
            if (!File.Exists(path))
            {
                MessageBox.Show("the TestPDF: " + path + " was not found!");
                return;
            }

            PosPrinter.Connector con = new PosPrinter.Connector();
            con.InitTCP(this.stdUriTB.Text, Convert.ToInt32(this.stdpPortTB.Text));

            byte[] testLabel = Ext.ReadAllBytes(path);

            con.Print(testLabel);
        }
    }
}