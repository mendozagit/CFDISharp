using System.IO;
using System.Text;

namespace CFDISharp.CoreLib.Helpers
{
    public class Utf8StringWriter : StringWriter
    {
        public override Encoding Encoding
        {
            get { return Encoding.UTF8; }
        }
    }
}
