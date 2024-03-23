using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Retrolab;
using RetroLab.REST;
using BnBPosClientNCF35.Properties;

namespace BnBPosClientNCF35
{
    public partial class ServerPickerForm : Form
    {
        private const int Element_Height = 40;
        private const int Element_Space = 2;
        private Configuration cfg;

        public ServerPickerForm()
        {
            InitializeComponent();

            this.cfg = Program.cfg;

            this.addEntryIBtn.Image = Resources.AddIcon_32;

            this.UpdateView();

        }

        private void UpdateView()
        {
            //List<CollectionsData> collections = collectionsDb.CollTbl.Select();
            Pools.RecycleRowBtnCollection(this.panel2.Controls);
            this.panel2.Height = (this.cfg.Configs.Count() + 1) * (Element_Height + Element_Space);

            for (int i = 0; i < this.cfg.Configs.Count(); i++)
            {
                //ToDo: add with Data, positioning,scrolling
                RowButton btn = Pools.RowBtnPool.Get();
                btn.Width = this.panel2.Width;
                btn.Height = Element_Height;
                btn.Init(this.cfg.Configs[i].ServerName, this.OnClickElement, Resources.EditIcon_32, this.OnClickEditElement, Resources.DeleteIcon_32, this.OnClickDeleteElement);
                btn.SetPos(0, i * (Element_Height + Element_Space));
                btn.EntryId = i;
                this.panel2.Controls.Add(btn);
            }

            this.vScrollBar1.UpdateVScroll(this.panel1);
        }

        private void UpdateData(ServerCfg newServer)
        {
            if (String.IsNullOrEmpty(newServer.ServerName) || String.IsNullOrEmpty(newServer.ServerUri) || String.IsNullOrEmpty(newServer.AccountToken)) return;

            this.cfg.AddServer(newServer);

            this.UpdateView();
        }

        private void OnClickElement(long index)
        {
            Program.rest.baseURL = this.cfg.Configs[index].ServerUri;
            Program.rest.SetAuthToken(this.cfg.Configs[index].AccountToken);

            // check if server was reachable and token is valid first
            Program.rest.Get("r/ping", null,
                (bool valid) => {
                    if (valid)
                    {
                        Debug.WriteLine("Ping: valid");
                        MainForm frm = new MainForm();
                        frm.Show();
                    }
                    else
                    {
                        MessageBox.Show(Loca.TokenInvalid);
                    }
            }, null); 

            //MainForm frm = new MainForm();
            //frm.Show();
        }

        private void OnClickEditElement(long index)
        {
            //ServerCfg collData = collectionsDb.CollTbl.Select(id);
            ConnectForm frm = new ConnectForm(this.cfg.Configs[index]);
            frm.OnLoginSuccess += UpdateData;
            frm.Show();
        }

        private void OnClickDeleteElement(long index)
        {
            //TODO: encapsulate in msgBox to prevent unwanted deletion
            this.cfg.RemoveServerAt(index);
            this.UpdateView();
        }

        private void addEntryIBtn_Click(object sender, EventArgs e)
        {
            ConnectForm frm = new ConnectForm();
            frm.OnLoginSuccess += this.UpdateData;
            frm.Show();
        }
    }
}