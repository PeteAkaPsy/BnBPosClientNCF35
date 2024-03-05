using System;

namespace BnBPosClientNCF35
{
    [Serializable]
    public class ServerCfg
    {
        public string ServerName;
        public string ServerUri;
        /// <summary>
        /// only save the auth token, never the username/password
        /// </summary>
        public string AccountToken;

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