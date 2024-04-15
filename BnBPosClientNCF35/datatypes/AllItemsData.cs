using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace BnBPosClientNCF35
{
    [Serializable]
    public class AllItemsData
    {
        public SellItemData[] SellItems;
        public AuctItemData[] AuctItems;
    }
}
