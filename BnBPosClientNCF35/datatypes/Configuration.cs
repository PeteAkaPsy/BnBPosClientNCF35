using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace BnBPosClientNCF35
{
    [Serializable]
    public class Configuration
    {
        /// <summary>
        /// this is set to false if when the imager api is not supported. -> e.g. MC65
        /// especially because the native captureForm has a very delayed cleanup blocking the imaging/scanning devices
        /// </summary>
        public bool allowImgCapture = true;

        public ServerCfg[] Configs;
        public int activeCfg = -1;
        public ServerCfg CurrentCfg
        {
            get {
                if (activeCfg < 0 || Configs == null || activeCfg >= Configs.Length)
                    return null;

                return Configs[activeCfg];
            }
        }

        public void AddServer(ServerCfg newCfg)
        {
            //int newAmmount = Configs != null ? Configs.Count() : 0;

            List<ServerCfg> tcfg = this.Configs == null ? new List<ServerCfg>() : new List<ServerCfg>(this.Configs);
            tcfg.Add(newCfg);
            this.Configs = tcfg.ToArray();
        }

        public void RemoveServer(ServerCfg cfgToRemove)
        {
            if (this.Configs == null) return;
            List<ServerCfg> tcfg = new List<ServerCfg>(this.Configs);
            tcfg.Remove(cfgToRemove);
            this.Configs = tcfg.ToArray();
        }

        public void RemoveServerAt(long index)
        {
            if (this.Configs == null) return;
            List<ServerCfg> tcfg = new List<ServerCfg>(this.Configs);
            tcfg.RemoveAt((int)index);
            this.Configs = tcfg.ToArray();
        }
    }
}
