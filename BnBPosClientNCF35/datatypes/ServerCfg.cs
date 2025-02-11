﻿using System;

namespace BnBPosClientNCF35
{
    [Serializable]
    public class ServerCfg
    {
        public string ServerName;
        public string ServerUri;
        public string UserName;
        /// <summary>
        /// only save the auth token, never the username/password
        /// </summary>
        public string AccountToken;

        public string LabelPrinterIP;
        public int LabelPrinterPort = 9100;
        
        public string LabelFileName;
        public string LabelString; //maybe needs to change to byte[] for printers using ESC instead of ZPL, or maybe we will need anoter printer entry later making this comment obsolete

        public string DocPrinterIP;
        public int DocPrinterPort = 9100;
        public string DocFileName;

        public static bool operator ==(ServerCfg cfgLeft, ServerCfg cfgRight)
        {
            if (cfgRight == null && cfgLeft == null) return true;
            if (cfgRight == null || cfgLeft == null) return false;
            return cfgLeft.ServerUri == cfgRight.ServerUri;
        }

        public static bool operator !=(ServerCfg cfgLeft, ServerCfg cfgRight)
        {
            return !(cfgLeft == cfgRight);
        }
    }
}