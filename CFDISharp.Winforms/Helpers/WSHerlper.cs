
using CFDISharp.CoreLib.Helpers;
using SW.Services.Stamp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFDISharp.Winforms.Helpers
{
    public class WSHerlper
    {
        private Stamp request;
        private StampResponseV3 response;
        public WSHerlper()
        {
            request = new Stamp(Constants.WS_ENDPOINT, Constants.WS_TOKEN);
        }


        public WSResponse Timbrar(string xmlStringFile)
        {
            response = request.TimbrarV3(xmlStringFile);

            return new WSResponse
            {
                Data = response.data,
                Status = response.status,
                Message = response.message,
                MessageDetail = response.messageDetail
            };
        }

    }
}
