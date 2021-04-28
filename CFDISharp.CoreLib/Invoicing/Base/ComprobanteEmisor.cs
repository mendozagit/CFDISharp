using Newtonsoft.Json;

namespace CFDISharp.CoreLib.Invoicing.Base
{
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
    
    public partial class ComprobanteEmisor
    {

        private string rfcField;

        private string nombreField;

        private string regimenFiscalField;


        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Rfc
        {
            get
            {
                return rfcField;
            }
            set
            {
                rfcField = value;
            }
        }


        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Nombre
        {
            get
            {
                return nombreField;
            }
            set
            {
                nombreField = value;
            }
        }


        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RegimenFiscal
        {
            get
            {
                return regimenFiscalField;
            }
            set
            {
                regimenFiscalField = value;
            }
        }
    }
}