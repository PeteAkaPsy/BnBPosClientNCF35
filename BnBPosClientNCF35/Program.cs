using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using RetroLab.REST;
using RetroLab.Json;

namespace BnBPosClientNCF35
{
    static class Program
    {
        const string cfgFilePath = "./config.json";
        public static RestClient rest;
        public static BCReader.IBCReader barcodeReader;
        public static BCReader.IImager imager;
        public static Configuration cfg;


        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [MTAThread]
        static void Main()
        {
            rest = new RestClient();
            barcodeReader = BCReader.BCR.Get();
            imager = BCReader.IMG.Get();

            if (File.Exists(cfgFilePath))
            {
                cfg = Converter.Deserialize<Configuration>(Ext.ReadAllText(cfgFilePath));
            }
            LoadConfig();

            //if (!Directory.Exists(@".\tmp"))
            //    Directory.CreateDirectory(@".\tmp");

            Application.Run(new ServerPickerForm());

            barcodeReader.StopReader();
        }

        public static void LoadConfig()
        {
            if (cfg == null)
            {
                cfg = new Configuration();
                cfg.allowImgCapture = imager.IsUsable();
#if DEBUG
                // add test server without me painfully adding it every time but only when the conf is not found
                RestClient rest = Program.rest;
                ServerCfg scfg = new ServerCfg() { ServerName = "Test", ServerUri = "http://192.168.178.67:8081" }; // change this uri to your test server
                rest.baseURL = scfg.ServerUri;
                LoginData ld = new LoginData() { userName = "Admin", passwd = "Admin" };

                rest.RequestAuth<LoginData>("r/login", ld,
                    result =>
                    {
                        if (!string.IsNullOrEmpty(result))
                        {
                            scfg.AccountToken = result;
                        }
                        else
                            Debug.WriteLine("Error: TestServer Login Failed!");
                    }, null);

                if (!string.IsNullOrEmpty(scfg.AccountToken))
                    cfg.AddServer(scfg);
#endif
            }
        }
    }
}