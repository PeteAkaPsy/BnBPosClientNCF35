using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace BnBPosClientNCF35
{
    [Serializable]
    public class SellItemData
    {
        public long Id;
        public long UserId;
        public string Name;
        public long CategoryId;
        public bool AdultOnly;
        public float Price;
        public uint ItemState;
    }
}
