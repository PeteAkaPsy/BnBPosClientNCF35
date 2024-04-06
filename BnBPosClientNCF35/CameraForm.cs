using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.WindowsMobile.Forms;
using System.Diagnostics;

namespace BnBPosClientNCF35
{
    public partial class CameraForm : Form
    {
        long Id;
        ScannedType actionType;
        Action<long, string> OnCaptured;

        public CameraForm(ScannedType actionType, long id, Action<long,string> onCapture)
        {
            this.Id = id;
            this.actionType = actionType;
            this.OnCaptured = onCapture;

            Program.barcodeReader.StopReader(); //just do start & Stop in this class as this is used only 

            InitializeComponent();
        }

        private void CameraForm_Load(object sender, EventArgs e)
        {
            //ToDo: change cam stuff to symbol imager
            CameraCaptureDialog camera = new CameraCaptureDialog();
            camera.InitialDirectory = @".\tmp";
            //camera.InitialDirectory = @"\My Documents";
            camera.DefaultFileName = @"capture.jpg";
            camera.Title = "CaptureImage";
            camera.Mode = CameraCaptureMode.Still;
            camera.StillQuality = CameraCaptureStillQuality.High;

            //bool ok = false;
            try
            {
                DialogResult res = camera.ShowDialog();
                if (res == DialogResult.OK)
                {
                    if (this.OnCaptured != null)
                        this.OnCaptured.Invoke(this.Id, Ext.GetB64(camera.FileName));

                    this.Close();
                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show("Could not access the Camera.\n");
                Debug.WriteLine("SE-Could not access the Camera.\n Barcode/Imager still running?" + ex.Message);
            }
        }

        private void CameraForm_Closed(object sender, EventArgs e)
        {
            //Program.barcodeReader.StartReader();// restart of the reader here is too fast
        }
    }
}