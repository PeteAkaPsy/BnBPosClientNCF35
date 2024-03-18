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
    }

    public enum ScannedType : uint
    {
        Sale = 0,
        Auction = 1,
    }
}
