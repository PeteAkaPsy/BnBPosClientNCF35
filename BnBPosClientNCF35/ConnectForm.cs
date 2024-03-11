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
        public Action<ServerCfg> OnLoginSuccess;
        private string _token = "";

        public ConnectForm()
        {
            InitializeComponent();

            if (string.IsNullOrEmpty(this.serverUriTB.Text))
                this.serverUriTB.Text = "http://";
        }

        public ConnectForm(ServerCfg cfg) : this()
        {
            this.serverNameTB.Text = cfg.ServerName;
            this.serverUriTB.Text = cfg.ServerUri;
            this._token = cfg.AccountToken;
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            RestClient restClient = new RestClient(this.serverUriTB.Text);

            if (!string.IsNullOrEmpty(this.usernameTB.Text) && !string.IsNullOrEmpty(this.passwordTB.Text))
            {
                if (!string.IsNullOrEmpty(this._token))
                {
                    //TODO: put a logout of the old token here
                }

                LoginData ld = new LoginData() { userName = this.usernameTB.Text, passwd = this.passwordTB.Text };

                restClient.RequestAuth<LoginData>("r/login", ld,
                    result =>
                    {
                        if (!string.IsNullOrEmpty(result))
                        {
                            Debug.WriteLine(result);
                            if (OnLoginSuccess != null)
                            {
                                OnLoginSuccess.Invoke(new ServerCfg() { ServerName = this.serverNameTB.Text, ServerUri = this.serverUriTB.Text, AccountToken = result });
                                Close();
                                return;
                            }
                        }
                        else
                            MessageBox.Show("Error: Login Failed!");
                    }, errors =>
                    {
                        MessageBox.Show("Error: Could not connect!");
                    });
            }
            else if (!string.IsNullOrEmpty(this._token))
            {
                if (OnLoginSuccess != null)
                {
                    OnLoginSuccess.Invoke(new ServerCfg() { ServerName = this.serverNameTB.Text, ServerUri = this.serverUriTB.Text, AccountToken = this._token });
                    Close();
                    return;
                }
            }

            //TODO: show failed here
        }
    }
}