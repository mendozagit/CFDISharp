using SW.Services.Cancelation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFDISharp.Winforms.Helpers
{
    public class WSCancelationResponse
    {
        public Data Data { get; set; }
        public string Status { get; set; }
        public string Message { get; set; }
        public string MessageDetail { get; set; }
    }
}
