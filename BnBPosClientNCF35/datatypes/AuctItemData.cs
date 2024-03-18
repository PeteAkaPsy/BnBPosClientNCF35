using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace BnBPosClientNCF35
{
    [Serializable]
    public class AuctItemData
    {
        public long Id;
	    public long UserId;
	    public string Name;
	    public string Descr;
	    public long CategoryId;
	    public bool AdultOnly;
	    public float StartPrice;
	    public float SellPrice;
        public uint ItemState;
    }
}
