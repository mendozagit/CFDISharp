using System;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using System.Xml.Xsl;
using System.Xml;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;

namespace CFDISharp.CoreLib.Helpers
{
    public class CFDIHelper : ICFDIHelper
    {
        private AsymmetricKeyParameter asymmetricKeyParameter;
        private RsaKeyParameters rsaKeyParameters;
        private ISigner signer;
        private XslCompiledTransform xslCompiledTransform;
        private XmlSerializerNamespaces namespaces;
        private XmlSerializer xmlSerializer;
        private StringWriter stringWriter;
        private StringReader stringReader;
        private XmlReader xmlReader;
        private bool keyInitialized;

        public byte[] CertificateBytes { get; set; }
        public byte[] PrivateKeyBytes { get; set; }
        public string Password { get; set; }
        public string XSLTPath { get; set; }
        public string InvoiceType { get; set; }



        public void Initialize(string invoiceType)
        {
            namespaces = new XmlSerializerNamespaces();
            InvoiceType = invoiceType;

            if (invoiceType.ToUpper().Equals("I") || invoiceType.ToUpper().Equals("E"))
            {
                namespaces.Add("cfdi", "http://www.sat.gob.mx/cfd/3");
                namespaces.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");

            }
            else if (invoiceType.ToUpper().Equals("P"))
            {
                namespaces.Add("cfdi", "http://www.sat.gob.mx/cfd/3");
                namespaces.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");
                namespaces.Add("pago10", "http://www.sat.gob.mx/Pagos");
            }
            keyInitialized = false;
        }



        /// <summary>
        /// Serialize an object of any type
        /// </summary>
        /// <typeparam name="T">Generic Type</typeparam>
        /// <param name="tToSerialize">Object to serialize </param>
        /// <returns></returns>
        public string SerializeToXmlStringFile<T>(T tToSerialize)
        {
            xmlSerializer = new XmlSerializer(tToSerialize.GetType());

            using (stringWriter = new Utf8StringWriter())
            {
                xmlSerializer.Serialize(stringWriter, tToSerialize, namespaces);
                return stringWriter.ToString();
            }
        }


        /// <summary>
        /// Transform XML documents into Pipe character in accordance with the schemes established in Mexican legislation.
        /// </summary>
        /// <param name="xmlStringFile"> Xml file as string</param>
        /// <returns></returns>
        public string GetOriginalStringByXmlStringFile(string xmlStringFile)
        {
            using (stringReader = new StringReader(xmlStringFile))
            {
                using (xmlReader = XmlReader.Create(stringReader))
                {
                    using (stringWriter = new Utf8StringWriter())
                    {
                        XsltSettings sets = new XsltSettings(true, true);
                        var resolver = new XmlUrlResolver();
                        xslCompiledTransform = new XslCompiledTransform();
                        xslCompiledTransform.Load(XSLTPath, sets, resolver);
                        xslCompiledTransform.Transform(xmlReader, null, stringWriter);
                        return stringWriter.ToString();
                    }
                }
            }
        }



        /// <summary>
        /// signs the original invoice string with the specified algorithm
        /// </summary>
        /// <param name="originalStringPhrase"> output of GetOriginalStringByXmlStringFile method</param>
        /// <returns></returns>
        public string Sign(string originalStringPhrase)
        {
            try
            {
                if (!keyInitialized)
                    InitializePrivateKey();

                signer.BlockUpdate(Encoding.UTF8.GetBytes(originalStringPhrase), 0, Encoding.UTF8.GetBytes(originalStringPhrase).Length);
                var signedBytes = signer.GenerateSignature();
                return Convert.ToBase64String(signedBytes);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                return string.Empty;
            }
        }


        /// <summary>
        /// Initialize the crypto objects to sign the original string of the invoice
        /// </summary>
        public void InitializePrivateKey()
        {
            try
            {
                asymmetricKeyParameter = PrivateKeyFactory.DecryptKey(Password.ToCharArray(), PrivateKeyBytes);
                rsaKeyParameters = (RsaKeyParameters)asymmetricKeyParameter;
                signer = SignerUtilities.GetSigner(Constants.ALGORITHM_MX);
                signer.Init(true, rsaKeyParameters);
                keyInitialized = true;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }







        public string FileToBase64(string fullFilePath)
        {
            byte[] bytes = File.ReadAllBytes(fullFilePath);
            return Convert.ToBase64String(bytes);
        }

        public byte[] FileToBytes(string fullFilePath)
        {
            return File.ReadAllBytes(fullFilePath);
        }

        public byte[] Base64ToBytes(string base64EncodedData)
        {
            return Convert.FromBase64String(base64EncodedData);
        }

        public void Base64ToFile(string base64EncodedData, string fullFilePathToWrite)
        {
            File.WriteAllBytes(fullFilePathToWrite, Convert.FromBase64String(base64EncodedData));
        }

        public string EncodeToBase64(string plainText)
        {
            var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            return Convert.ToBase64String(plainTextBytes);
        }

        public string DecodeFromBase64(string base64EncodedData)
        {
            var base64EncodedBytes = Convert.FromBase64String(base64EncodedData);
            return Encoding.UTF8.GetString(base64EncodedBytes);
        }
    }
}
