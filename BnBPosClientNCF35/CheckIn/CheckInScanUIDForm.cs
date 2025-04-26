using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;
using Retrolab;
using BnBPosClientNCF35.Properties;

namespace BnBPosClientNCF35
{
    public partial class CheckInScanUIDForm : Form
    {
        private const int Element_Height = 40;
        private const int Element_Space = 2;

        private BCReader.IBCReader bcr;

        public CheckInScanUIDForm()
        {
            InitializeComponent();

            this.bcr = Program.barcodeReader;

            if (this.bcr != null)
            {
                this.bcr.OnScan += this.OnBarcodeScanned;
                this.bcr.StartReader();
            }
        }

        private void OnBarcodeScanned(string bcode)
        {
            Debug.WriteLine("CheckInUID Scanned BarCode:" + bcode);

            try
            {
                long bcodeVal = Convert.ToInt64(bcode);

                if (bcodeVal == 0)
                {
                    Debug.WriteLine("Checked in Value could not be converted to an integer");
                    return;
                }

                OnCheckUser(bcodeVal);
            }
            catch
            {
                Debug.WriteLine("");
            }
        }

        private void OnCheckUser(long id)
        {
            Program.rest.Get<UserData>("/r/adm/user", new Dictionary<string, string>() { { "id", id.ToString() } },
                result =>
                {
                    if (result != null)
                    {
                        Form frm = new CheckInForm(result);
                        frm.Show();
                        this.SaveClose();
                    }
                },
                errors =>
                {
                });
        }

        private void imageButton2_Click(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            if (this.bcr != null)
            {
                this.bcr.StopReader();
                this.bcr.OnScan -= this.OnBarcodeScanned;
            }
            this.SaveClose();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.idTB.Text)) return;

            long idVal = Convert.ToInt64(this.idTB.Text);
            if (idVal <= 0)
            {
                //ToDo: show msgBox
                return;
            }

            OnCheckUser(idVal);
        }

        private void SaveClose()
        {
            if (this.bcr != null)
            {
                this.bcr.StopReader();
                this.bcr.OnScan -= this.OnBarcodeScanned;
            }
            this.Close();
        }
    }
}