using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace BnBPosClientNCF35
{
    [Serializable]
    public class BillData
    {
        public long Id;
	    public long Date;
	    public float Total;
	    public float Given;
	    public float Back;

        public long[] SellItemIds;
    }

}
