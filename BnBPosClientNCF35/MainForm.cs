﻿using System;
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
        private IRestClient rest;

        public MainForm()
        {
            this.rest = Program.rest;
            //this.rest = new RestClient(this._cfg.ServerUri, this._cfg.AccountToken);

            Ext.CurrencyToUse = Program.cfg.CurrentCfg.CurrencySymbol;

            InitializeComponent();


            if (this.ClientSize.Width == 480)
            {
                this.backBtn.Width *= 2;
                this.backBtn.Height *= 2;
                this.backBtn.Image = Resources.BackIcon_64;
                this.optionsButton.Width *= 2;
                this.optionsButton.Height *= 2;
                Point pt = this.optionsButton.Location;
                pt.X -= this.optionsButton.Width / 2;
                this.optionsButton.Location = pt;
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
                this.auctionBtn.Width *= 2;
                this.auctionBtn.Height *= 2;
                this.auctionLabel.Width *= 2;
                this.auctionLabel.Height *= 2;
            }
            else
            {
                this.backBtn.Image = Resources.BackIcon_32;
            }

            this.SetMainIconPos();
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
            //Auction
            this.auctionBtn.Location = new Point(
                centerX + CenterSpacing,
                centerY + CenterSpacing);
            this.auctionLabel.Location = new Point(
                centerX + CenterSpacing,
                centerY + CenterSpacing + this.auctionBtn.Height + CenterSpacing);

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void optionsButton_Click(object sender, EventArgs e)
        {
            Form frm = new OptionsMenuForm();
            frm.Show();
        }

        private void checkInBtn_Click(object sender, EventArgs e)
        {
            //Form frm = new CheckInForm();
            Form frm = new CheckInScanUIDForm();
            frm.Show();
        }

        private void sellBtn_Click(object sender, EventArgs e)
        {
            Form frm = new SellItemsForm();
            frm.Show();
        }

        private void checkOutBtn_Click(object sender, EventArgs e)
        {
            Form frm = new CheckOutScanUIDForm();
            frm.Show();
        }

        private void auctionBtn_Click(object sender, EventArgs e)
        {
            Form frm = new AuctionItemsForm();
            frm.Show();
        }
    }
}