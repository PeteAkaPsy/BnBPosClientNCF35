using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RetroLab.REST;

namespace BnBPosClientNCF35
{
    public partial class MainForm : Form
    {
        private const int CenterSpacing = 2;
        private ServerCfg _cfg;
        private IRestClient rest = null;

        public MainForm(ServerCfg cfg)
        {
            this._cfg = cfg;
            this.rest = new RestClient(this._cfg.ServerUri, this._cfg.AccountToken);

            InitializeComponent();

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
    }
}