using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace BnBPosClientNCF35
{
    [Serializable]
    public class Configuration
    {
        public ServerCfg[] Configs;

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
