namespace CFDISharp.Winforms.Helpers
{
    public interface IWSHelperTest
    {
        WSCancelationResponse Cancel(string base64Certificate, string base64PrivateKey, string rfcEmisor, string plainPrivateKeyPass, string uuidToCancel);
        WSResponse Transmit(string xmlStringFile);
    }
}