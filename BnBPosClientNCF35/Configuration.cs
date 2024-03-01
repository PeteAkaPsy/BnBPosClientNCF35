using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace BnBPosClientNCF35
{
    [Serializable]
    public class Configuration
    {
        public ServerCfg[] configs;
    }

    [Serializable]
    public class ServerCfg
    {
        public string ServerUri;
        /// <summary>
        /// only save the auth token, never the username/password
        /// </summary>
        public string AccountToken;
    }
}
