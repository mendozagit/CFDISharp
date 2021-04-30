using CFDISharp.Winforms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CFDISharp.Winforms.Helpers.SellosHelper
{
    public class MxCertificate
    {
        private readonly SatFile satFile;

        private X509Certificate2 X509Certificate { get; set; }

        public MxCertificate(SatFile satFile)
        {
            this.satFile = satFile;

            if (satFile != null)
                X509Certificate = new X509Certificate2(CertificateBytes());
        }
        public string CertificateBase64()
        {
            return Convert.ToBase64String(X509Certificate.Export(X509ContentType.Cert));
        }

        public byte[] CertificateBytes()
        {
            var bytes = Convert.FromBase64String(satFile.Base64File);
            return bytes;
        }

        public string CertificateNumber()
        {
            return Encoding.ASCII.GetString(X509Certificate.GetSerialNumber().Reverse().ToArray());
        }
    }
}
