using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RetroLab.Json;
using Retrolab;

namespace BnBPosClientNCF35
{
    public partial class ServerPickerForm : Form
    {
        private const int Element_Height = 40;
        private const int Element_Space = 2;
        const string cfgFilePath = "./config.json";
        Configuration cfg;

        public ServerPickerForm()
        {
            if (File.Exists(cfgFilePath))
            {
                cfg = Converter.Deserialize<Configuration>(Ext.ReadAllText(cfgFilePath));
            }

            InitializeComponent();

            if (cfg == null)
                cfg = new Configuration();

        }

        private void UpdateView()
        {
            //List<CollectionsData> collections = collectionsDb.CollTbl.Select();
            Pools.RecycleRowBtnCollection(panel1.Controls);
            panel1.Height = (cfg.Configs.Count() + 1) * (Element_Height + Element_Space);

            for (int i = 0; i < cfg.Configs.Count(); i++)
            {
                //ToDo: add with Data, positioning,scrolling
                RowButton btn = Pools.RowBtnPool.Get();
                btn.Width = panel1.Width;
                btn.Height = Element_Height;
                btn.Init(cfg.Configs[i].ServerUri, OnClickElement, B64Res.EditIcon, OnClickEditElement, B64Res.DeleteIcon, OnClickDeleteElement);
                btn.SetPos(0, i * (Element_Height + Element_Space));
                btn.EntryId = i;
                panel1.Controls.Add(btn);
            }

            vScrollBar1.UpdateVScroll(panel2);
        }

        private void UpdateData(ServerCfg newServer)
        {
            if (String.IsNullOrEmpty(newServer.ServerName) || String.IsNullOrEmpty(newServer.ServerUri) || String.IsNullOrEmpty(newServer.AccountToken)) return;

            this.cfg.AddServer(newServer);

            UpdateView();
        }

        private void OnClickElement(long index)
        {
            // check if server was reachable and token is valid first


            MainForm frm = new MainForm(this.cfg.Configs[index]);
            frm.Show();
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
            UpdateView();
        }

        private void addEntryIBtn_Click(object sender, EventArgs e)
        {
            ConnectForm frm = new ConnectForm();
            frm.OnLoginSuccess += UpdateData;
            frm.Show();
        }
    }
}