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
    public partial class ManualInputForm : Form
    {
        private Action<ScannedData> OnInputFinished;

        //ToDo: add preconfiguration for Sale/Auction to disallow input of an auction in sellForm and vice versa

        public ManualInputForm(Action<ScannedData> onInputFinished) : this(onInputFinished, ScannedType.None) {}

        public ManualInputForm(Action<ScannedData> onInputFinished, ScannedType typeToForce)
        {
            this.OnInputFinished = onInputFinished;

            InitializeComponent();


            this.sellRB.Enabled = typeToForce == ScannedType.Sale || typeToForce == ScannedType.None;
            this.auctRB.Enabled = typeToForce == ScannedType.Auction || typeToForce == ScannedType.None;

            if (typeToForce != ScannedType.None)
            {
                this.sellRB.Checked = this.sellRB.Enabled;
                this.auctRB.Checked = this.auctRB.Enabled;
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.idTB.Text)) return;

            if (this.OnInputFinished != null)
            {
                this.OnInputFinished.Invoke(new ScannedData() { DType = (uint)(this.sellRB.Checked ? ScannedType.Sale : ScannedType.Auction), ID = Convert.ToInt64(this.idTB.Text) });
            }

            this.Close();
        }

        //needs testing
        private void sellRB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void auctRB_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}