using CFDISharp.Winforms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFDISharp.Winforms.Helpers.SellosHelper
{
    public class MxPrivateKey
    {
        private readonly SatFile satFile;
        public MxPrivateKey(SatFile satFile)
        {
            this.satFile = satFile;
        }


        public byte[] PrivateKeyBytes()
        {
            var bytes = Convert.FromBase64String(satFile.Base64File);
            return bytes;
        }
    }
}
