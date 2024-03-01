using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RetroLab.REST;
using System.Diagnostics;

namespace BnBPosClientNCF35
{
    public partial class ConnectForm : Form
    {
        public Action<string, string> OnLoginSuccess;

        public ConnectForm()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            RestClient restClient = new RestClient(serverUriTB.Text);

            LoginData ld = new LoginData() {userName = usernameTB.Text, passwd = passwordTB.Text};

            restClient.RequestAuth<LoginData>("r/login", ld,
                result => {
                    if (!string.IsNullOrEmpty(result))
                    {
                        Debug.WriteLine(result);
                        if (OnLoginSuccess != null)
                        {
                            OnLoginSuccess.Invoke(serverUriTB.Text, result);
                            Close();
                        }
                    }
                    else
                        MessageBox.Show("Error: Login Failed!");
                }, errors => {
                    MessageBox.Show("Error: Could not connect!");
                });
        }
    }
}