using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace BnBPosClientNCF35
{
    [Serializable]
    public class AuctItemChangedData
    {
        public long Id;
	    public float SellPrice;
        public uint ItemState;
    }
}
