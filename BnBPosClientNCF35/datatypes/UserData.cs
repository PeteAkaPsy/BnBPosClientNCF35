using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace BnBPosClientNCF35
{
    [Serializable]
    public class UserData
    {
        public long Id;
        public short State;
        public string UserName;
        public string MailAddress;
    }
}
