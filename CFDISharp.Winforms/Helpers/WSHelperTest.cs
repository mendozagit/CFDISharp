
using CFDISharp.CoreLib.Helpers;
using SW.Services.Cancelation;
using SW.Services.Stamp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFDISharp.Winforms.Helpers
{
    public class WSHelperTest : IWSHelperTest
    {
        private Cancelation cancelationRequest;
        private Stamp transmitRequest;
        private StampResponseV3 transmitResponse;
        private CancelationResponse cancelationResponse;

        public WSHelperTest()
        {
            transmitRequest = new Stamp(Constants.WS_ENDPOINT, Constants.WS_TOKEN);
            cancelationRequest = new Cancelation(Constants.WS_ENDPOINT, Constants.WS_TEST_USER, Constants.WS_TEST_PASS);

        }


        public WSResponse Transmit(string xmlStringFile)
        {
            transmitResponse = transmitRequest.TimbrarV3(xmlStringFile);

            return new WSResponse
            {
                Data = transmitResponse.data,
                Status = transmitResponse.status,
                Message = transmitResponse.message,
                MessageDetail = transmitResponse.messageDetail
            };
        }
        public WSCancelationResponse Cancel(string base64Certificate, string base64PrivateKey, string rfcEmisor, string plainPrivateKeyPass, string uuidToCancel)
        {
            cancelationResponse = cancelationRequest.CancelarByCSD(
                     base64Certificate,
                     base64PrivateKey,
                     rfcEmisor,
                     plainPrivateKeyPass,
                     uuidToCancel);


            return new WSCancelationResponse
            {
                Data = cancelationResponse.data,
                Status = cancelationResponse.status,
                Message = cancelationResponse.message,
                MessageDetail = cancelationResponse.messageDetail
            };
        }

    }

}
