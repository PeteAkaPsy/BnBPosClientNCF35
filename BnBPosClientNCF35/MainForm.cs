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
    public partial class MainForm : Form
    {
        private const int CenterSpacing = 2;

        public MainForm()
        {
            InitializeComponent();

            SetMainIconPos();
        }

        private void SetMainIconPos()
        {
            int centerX = ClientSize.Width / 2;
            int centerY = ClientSize.Height / 2;

            //CheckIn
            checkInBtn.Location = new Point(
                centerX - checkInBtn.Width - CenterSpacing,
                centerY - checkInBtn.Height - CenterSpacing - checkInLabel.Height - CenterSpacing);
            checkInLabel.Location = new Point(
                centerX - checkInLabel.Width - CenterSpacing,
                centerY - checkInLabel.Height - CenterSpacing);
            //Sell
            sellBtn.Location = new Point(
                centerX + CenterSpacing,
                centerY - checkInBtn.Height - CenterSpacing - checkInLabel.Height - CenterSpacing);
            sellLabel.Location = new Point(
                centerX + CenterSpacing,
                centerY - sellLabel.Height - CenterSpacing);

            //CheckOut
            checkOutBtn.Location = new Point(
                centerX - checkOutBtn.Width - CenterSpacing,
                centerY + CenterSpacing);
            checkOutLabel.Location = new Point(
                centerX - checkOutBtn.Width - CenterSpacing,
                centerY + CenterSpacing + checkOutBtn.Height + CenterSpacing);
            //tmp/unknown
            imageButton1.Location = new Point(
                centerX + CenterSpacing,
                centerY + CenterSpacing);
            //missing label

        }
    }
}