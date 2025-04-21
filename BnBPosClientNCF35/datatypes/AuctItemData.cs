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

        public ScannedData ToScanData()
        {
            return new ScannedData()
            {
                DT = (uint)ScannedType.Auction,
                ID = this.Id,
                UID = this.UserId,
                CID = this.CategoryId,
                N = this.Name,
                P = this.StartPrice,
                AO = this.AdultOnly
            };
        }
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
