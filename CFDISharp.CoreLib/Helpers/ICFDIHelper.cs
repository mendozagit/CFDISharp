namespace CFDISharp.CoreLib.Helpers
{
    public interface ICFDIHelper
    {
        byte[] CertificateBytes { get; set; }
        string InvoiceType { get; set; }
        string Password { get; set; }
        byte[] PrivateKeyBytes { get; set; }
        string XSLTPath { get; set; }

        byte[] Base64ToBytes(string base64EncodedData);
        void Base64ToFile(string base64EncodedData, string fullFilePathToWrite);
        string DecodeFromBase64(string base64EncodedData);
        string EncodeToBase64(string plainText);
        string FileToBase64(string fullFilePath);
        byte[] FileToBytes(string fullFilePath);
        string GetOriginalStringByXmlStringFile(string xmlStringFile);
        void Initialize(string invoiceType);
        void InitializePrivateKey();
        string SerializeToXmlStringFile<T>(T tToSerialize);
        string Sign(string originalStringPhrase);
    }
}