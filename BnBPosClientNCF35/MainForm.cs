using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RetroLab.REST;
using BnBPosClientNCF35.Properties;

namespace BnBPosClientNCF35
{
    public partial class MainForm : Form
    {
        private const int CenterSpacing = 2;
        private Configuration cfg;
        private IRestClient rest;

        public MainForm()
        {
            this.cfg = Program.cfg;
            this.rest = Program.rest;
            //this.rest = new RestClient(this._cfg.ServerUri, this._cfg.AccountToken);

            InitializeComponent();


            if (this.ClientSize.Width == 480)
            {
                this.backBtn.Width *= 2;
                this.backBtn.Height *= 2;
                this.backBtn.Image = Resources.BackIcon_64;
                this.imageButton2.Width *= 2;
                this.imageButton2.Height *= 2;
                Point pt = this.imageButton2.Location;
                pt.X -= imageButton2.Width / 2;
                this.imageButton2.Location = pt;
                this.checkInBtn.Width *= 2;
                this.checkInBtn.Height *= 2;
                this.checkInLabel.Width *= 2;
                this.checkInLabel.Height *= 2;
                this.sellBtn.Width *= 2;
                this.sellBtn.Height *= 2;
                this.sellLabel.Width *= 2;
                this.sellLabel.Height *= 2;
                this.checkOutBtn.Width *= 2;
                this.checkOutBtn.Height *= 2;
                this.checkOutLabel.Width *= 2;
                this.checkOutLabel.Height *= 2;
                this.imageButton1.Width *= 2;
                this.imageButton1.Height *= 2;
                //this.missingLabel
            }
            else
            {
                this.backBtn.Image = Resources.BackIcon_32;
            }

            SetMainIconPos();
        }

        private void SetMainIconPos()
        {
            int centerX = this.ClientSize.Width / 2;
            int centerY = this.ClientSize.Height / 2;

            //CheckIn
            this.checkInBtn.Location = new Point(
                centerX - this.checkInBtn.Width - CenterSpacing,
                centerY - this.checkInBtn.Height - CenterSpacing - this.checkInLabel.Height - CenterSpacing);
            this.checkInLabel.Location = new Point(
                centerX - this.checkInLabel.Width - CenterSpacing,
                centerY - this.checkInLabel.Height - CenterSpacing);
            //Sell
            this.sellBtn.Location = new Point(
                centerX + CenterSpacing,
                centerY - this.checkInBtn.Height - CenterSpacing - this.checkInLabel.Height - CenterSpacing);
            this.sellLabel.Location = new Point(
                centerX + CenterSpacing,
                centerY - this.sellLabel.Height - CenterSpacing);

            //CheckOut
            this.checkOutBtn.Location = new Point(
                centerX - this.checkOutBtn.Width - CenterSpacing,
                centerY + CenterSpacing);
            this.checkOutLabel.Location = new Point(
                centerX - this.checkOutBtn.Width - CenterSpacing,
                centerY + CenterSpacing + this.checkOutBtn.Height + CenterSpacing);
            //tmp/unknown
            this.imageButton1.Location = new Point(
                centerX + CenterSpacing,
                centerY + CenterSpacing);
            //missing label

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void imageButton2_Click(object sender, EventArgs e)
        {

        }

        private void checkInBtn_Click(object sender, EventArgs e)
        {
            Form frm = new CheckInForm();
            frm.Show();
        }

        private void sellBtn_Click(object sender, EventArgs e)
        {

        }

        private void checkOutBtn_Click(object sender, EventArgs e)
        {

        }

        private void imageButton1_Click(object sender, EventArgs e)
        {

        }
    }
}