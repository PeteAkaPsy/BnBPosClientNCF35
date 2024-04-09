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

namespace BnBPosClientNCF35
{
    public partial class CameraForm : Form
    {
        long Id;
        ScannedType actionType;
        Action<long, string> OnCaptured;

        IImager img;

        public CameraForm(ScannedType actionType, long id, Action<long,string> onCapture)
        {
            this.Id = id;
            this.actionType = actionType;
            this.OnCaptured = onCapture;

            this.img = Program.imager;

            Program.barcodeReader.StopReader(); //just do start & Stop in this class as this is used only 

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
            this.img.EnableLamp(false);
            this.img.OnImageTaken += OnCapture;
            this.img.SetPB(this.pictureBox1);
            this.img.StartImager();
        }

        private void CameraForm_Closed(object sender, EventArgs e)
        {
            this.img.StopImager();
            this.img.SetPB(null);
            this.img.OnImageTaken -= OnCapture;
        }

        private void CameraForm_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == System.Windows.Forms.Keys.Escape))
            {
                this.img.Reset();
            }

        }
    }
}