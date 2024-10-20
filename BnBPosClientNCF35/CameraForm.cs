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

        bool isAlreadyRunning = false;
        bool isAutoClosing = false;

        IImager img;
        bool bcrStartedBefore = false;

        public CameraForm(ScannedType actionType, long id, Action<long,string> onCapture)
        {
            Debug.WriteLine("Open CameraForm!!!");
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

#if !DEBUG
            this.imageButton1.Enabled = false;
#endif
        }

        private void OnCapture(Image img)
        {
            if (this.OnCaptured != null)
            {
                Debug.WriteLine("SendImage Back!");
                this.OnCaptured(Id, Ext.GetB64(img));
            }

            this.isAutoClosing = this.img.CloseWhenImageTaken();
            if (this.isAutoClosing)
            {
                this.img.StopImager();
                Debug.WriteLine("STOPPPPPP");
            }
            this.Close();
        }

        private void CameraForm_Activate(object sender, EventArgs e)
        {
            if (isAlreadyRunning) return;

            Debug.WriteLine("CameraForm ActivateStart");
            isAlreadyRunning = true;
            //if (this.isAutoClosing)
            //{
            //    this.Close();
            //    Debug.WriteLine("CameraForm Trying to Autoclose");
            //    return;
            //}

            Debug.WriteLine(Program.barcodeReader.IsStarted().ToString());
            this.img.OnImageTaken += OnCapture;
            this.img.SetPB(this.pictureBox1);
            this.img.StartImager();
            Debug.WriteLine("CameraForm ActivateEnd!!!!!!!!");

            this.lightButton.Image = this.img.IsLampEnabled() ? Resources.LightOffIcon_64 : Resources.LightOnIcon_64;
        }

        private void CameraForm_Closed(object sender, EventArgs e)
        {
            this.pictureBox1.Image.Dispose();
            this.pictureBox1.Image = null;
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

        private void imageButton1_Click(object sender, EventArgs e)
        {
            this.img.ChangeToNext();
        }
    }
}