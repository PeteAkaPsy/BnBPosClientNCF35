using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace BnBPosClientNCF35
{
    [Serializable]
    public class ScannedData
    {
        public uint DT;
        public long ID;
        public long UID;
        public long CID;
        public string N;
        public float P;
        public bool AO;
    }

    public enum ScannedType : uint
    {
        None = 0,
        Sale = 1,
        Auction = 2,
    }
}
