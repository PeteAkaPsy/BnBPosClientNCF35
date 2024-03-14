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
        private Action<string> OnInputFinished;

        public ManualInputForm(Action<string> onInputFinished)
        {
            this.OnInputFinished = onInputFinished;

            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.idTB.Text)) return;

            if (this.OnInputFinished != null)
            {
                OnInputFinished.Invoke(this.idTB.Text);
            }
            this.Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void idTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            //if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.') // allow input of '.'
            {
                e.Handled = true;
            }

            //only allow one decimal point
            //if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            //{
            //  e.Handeld = true;
            //}
        }
    }
}