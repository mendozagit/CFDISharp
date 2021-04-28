using Newtonsoft.Json;

namespace CFDISharp.CoreLib.Invoicing.Base
{
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
   
    public partial class ComprobanteReceptor
    {
        private string rfcField;

        private string nombreField;

        private string residenciaFiscalField;

        private bool residenciaFiscalFieldSpecified;

        private string numRegIdTribField;

        private string usoCFDIField;


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
        public string ResidenciaFiscal
        {
            get
            {
                return residenciaFiscalField;
            }
            set
            {
                residenciaFiscalField = value;
            }
        }


        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ResidenciaFiscalSpecified
        {
            get
            {
                return residenciaFiscalFieldSpecified;
            }
            set
            {
                residenciaFiscalFieldSpecified = value;
            }
        }


        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NumRegIdTrib
        {
            get
            {
                return numRegIdTribField;
            }
            set
            {
                numRegIdTribField = value;
            }
        }


        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string UsoCFDI
        {
            get
            {
                return usoCFDIField;
            }
            set
            {
                usoCFDIField = value;
            }
        }
    }
}