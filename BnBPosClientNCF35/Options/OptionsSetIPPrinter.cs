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
        private ServerCfg cfg;

        public OptionsSetIPPrinter()
        {
            this.cfg = Program.cfg.CurrentCfg;

            InitializeComponent();

            this.lpNameTB.Text = this.cfg.LabelPrinterName;
            this.lpUriTB.Text = this.cfg.LabelPrinterIP;
            this.lpPortTB.Text = this.cfg.LabelPrinterPort.ToString();

            this.stdpNameTB.Text = this.cfg.DocPrinterName;
            this.stdUriTB.Text = this.cfg.DocPrinterIP;
            this.stdpPortTB.Text = this.cfg.DocPrinterPort.ToString();
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
            string path = Path.Combine(Program.Path(), Program.cfg.CurrentCfg.LabelTestFile);
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
            string path = Path.Combine(Program.Path(), "documents\\test2.pdf");//worked!
            //string path = Path.Combine(Program.Path(), "documents\\test2.ps");
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

        private void saveBtn_Click(object sender, EventArgs e)
        {
            this.cfg.LabelPrinterName = this.lpNameTB.Text;
            this.cfg.LabelPrinterIP = this.lpUriTB.Text;
            try
            {
                this.cfg.LabelPrinterPort = Convert.ToInt32(this.lpPortTB.Text);
            }
            catch
            {
                //ToDo: log error
            }

            this.cfg.DocPrinterName = this.stdpNameTB.Text;
            this.cfg.DocPrinterIP = this.stdUriTB.Text;
            try
            {
                this.cfg.DocPrinterPort = Convert.ToInt32(this.stdpPortTB.Text);
            }
            catch
            {
                //ToDo: log error
            }
        }
    }
}