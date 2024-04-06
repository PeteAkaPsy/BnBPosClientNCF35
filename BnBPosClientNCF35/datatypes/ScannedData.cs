using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace BnBPosClientNCF35
{
    [Serializable]
    public class ScannedData
    {
        public uint DType;
        public long ID;
        public string Name;
        public float Price;
        public bool AdultOnly;
    }

    public enum ScannedType : uint
    {
        None = 0,
        Sale = 1,
        Auction = 2,
    }
}
