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

namespace BnBPosClientNCF35
{
    public partial class ServerPickerForm : Form
    {
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
    }
}