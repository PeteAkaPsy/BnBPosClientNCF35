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

            List<ServerCfg> tcfg = new List<ServerCfg>(Configs);
            tcfg.Add(newCfg);
            Configs = tcfg.ToArray();
        }

        public void RemoveServer(ServerCfg cfgToRemove)
        {
            List<ServerCfg> tcfg = new List<ServerCfg>(Configs);
            tcfg.Remove(cfgToRemove);
            Configs = tcfg.ToArray();
        }

        public void RemoveServerAt(long index)
        {
            List<ServerCfg> tcfg = new List<ServerCfg>(Configs);
            tcfg.RemoveAt((int)index);
            Configs = tcfg.ToArray();
        }
    }
}
