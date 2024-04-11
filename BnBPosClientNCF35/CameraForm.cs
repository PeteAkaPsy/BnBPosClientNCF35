using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using BCReader;
using BnBPosClientNCF35.Properties;

namespace BnBPosClientNCF35
{
    public partial class CameraForm : Form
    {
        long Id;
        ScannedType actionType;
        Action<long, string> OnCaptured;

        IImager img;
        bool bcrStartedBefore = false;

        public CameraForm(ScannedType actionType, long id, Action<long,string> onCapture)
        {
            this.Id = id;
            this.actionType = actionType;
            this.OnCaptured = onCapture;

            this.img = Program.imager;

            if (Program.barcodeReader.IsStarted())
            {
                this.bcrStartedBefore = true;
                Program.barcodeReader.StopReader();
            }

            InitializeComponent();
        }

        private void OnCapture(Image img)
        {
            if (this.OnCaptured != null)
            {
                this.OnCaptured(Id, Ext.GetB64(img));
            }
            this.Close();
        }

        private void CameraForm_Load(object sender, EventArgs e)
        {
            this.img.OnImageTaken += OnCapture;
            this.img.SetPB(this.pictureBox1);
            this.img.StartImager();

            this.lightButton.Image = this.img.IsLampEnabled() ? Resources.LightOffIcon_64 : Resources.LightOnIcon_64;
        }

        private void CameraForm_Closed(object sender, EventArgs e)
        {
            this.img.StopImager();
            this.img.SetPB(null);
            this.img.OnImageTaken -= OnCapture;

            if (this.bcrStartedBefore)
            {
                Program.barcodeReader.StartReader();
            }
        }

        private void CameraForm_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == System.Windows.Forms.Keys.Escape))
            {
                this.img.Reset();
            }
        }

        private void lightButton_Click(object sender, EventArgs e)
        {
            this.img.EnableLamp(!this.img.IsLampEnabled());
            this.lightButton.Image = this.img.IsLampEnabled() ? Resources.LightOffIcon_64 : Resources.LightOnIcon_64;
        }
    }
}