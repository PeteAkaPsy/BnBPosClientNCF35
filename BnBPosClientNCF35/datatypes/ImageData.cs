using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace BnBPosClientNCF35
{
    [Serializable]
    public class ImageData
    {
        public long Id; //ImageId on Receive, sell/auctId on add
        public string Data;
    }
}
