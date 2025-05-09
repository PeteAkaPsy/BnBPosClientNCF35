﻿using System;
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

        public ScannedData ToScanData()
        {
            return new ScannedData()
            {
                DT = (uint)ScannedType.Sale,
                ID = this.Id,
                UID = this.UserId,
                CID = this.CategoryId,
                N = this.Name,
                P = this.Price,
                AO = this.AdultOnly
            };
        }
    }

    [Serializable]
    public class SellItemDataWithImg //: SellItemData can not deserialize inherited members
    {
        public long Id;
        public long UserId;
        public string Name;
        public long CategoryId;
        public bool AdultOnly;
        public float Price;
        public uint ItemState;
        public ImageData[] Images;

        public SellItemData ToSellItem()
        {
            return new SellItemData()
            {
                Id = this.Id,
                UserId = this.UserId,
                Name = this.Name,
                CategoryId = this.CategoryId,
                AdultOnly = this.AdultOnly,
                Price = this.Price,
                ItemState = this.ItemState
            };
        }
    }
}
