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

    [Serializable]
    public class AuctItemDataWithImg //: AuctItemData //can not deserialize inherited members
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
        public ImageData[] Images;

        public AuctItemData ToAuctItem()
        {
            return new AuctItemData() {
                Id = this.Id,
                UserId = this.UserId,
                Name = this.Name,
                Descr = this.Descr,
                CategoryId = this.CategoryId,
                AdultOnly = this.AdultOnly,
                StartPrice = this.StartPrice,
                SellPrice = this.SellPrice,
                ItemState = this.ItemState
            };
        }
    }
}
