using System;

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

        public string EventName = "Test2025";
        public string CurrencySymbol = "$";

        public string LabelPrinterName = "LP2824";
        public string LabelPrinterIP = "192.168.178.40";
        public int LabelPrinterPort = 9100;

        public string LabelTestFile = "Labels\\Test.zpl";
        public string LabelHeaderFile = "Labels\\D3825_H.zpl"; //header label used as user/seller identifier
        public string LabelTemplateFile = "Labels\\D3825_T.zpl"; //template describing the look of the label
        public string LabelDataFile = "Labels\\D3825_D.zpl"; //the data file allowing batch printing with different data for the template

        public string DocPrinterName = "CLP-680ND";
        public string DocPrinterIP = "192.168.178.58";
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