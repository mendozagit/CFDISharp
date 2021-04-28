using Newtonsoft.Json;

namespace CFDISharp.CoreLib.Invoicing.Base
{
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
    
    public partial class ComprobanteConceptoParte
    {

        private ComprobanteConceptoParteInformacionAduanera[] informacionAduaneraField;

        private string claveProdServField;

        private string noIdentificacionField;

        private decimal cantidadField;

        private string unidadField;

        private string descripcionField;

        private decimal valorUnitarioField;

        private bool valorUnitarioFieldSpecified;

        private decimal importeField;

        private bool importeFieldSpecified;


        [System.Xml.Serialization.XmlElementAttribute("InformacionAduanera")]
        public ComprobanteConceptoParteInformacionAduanera[] InformacionAduanera
        {
            get
            {
                return informacionAduaneraField;
            }
            set
            {
                informacionAduaneraField = value;
            }
        }


        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ClaveProdServ
        {
            get
            {
                return claveProdServField;
            }
            set
            {
                claveProdServField = value;
            }
        }


        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NoIdentificacion
        {
            get
            {
                return noIdentificacionField;
            }
            set
            {
                noIdentificacionField = value;
            }
        }


        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Cantidad
        {
            get
            {
                return cantidadField;
            }
            set
            {
                cantidadField = value;
            }
        }


        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Unidad
        {
            get
            {
                return unidadField;
            }
            set
            {
                unidadField = value;
            }
        }


        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Descripcion
        {
            get
            {
                return descripcionField;
            }
            set
            {
                descripcionField = value;
            }
        }


        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal ValorUnitario
        {
            get
            {
                return valorUnitarioField;
            }
            set
            {
                valorUnitarioField = value;
            }
        }


        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ValorUnitarioSpecified
        {
            get
            {
                return valorUnitarioFieldSpecified;
            }
            set
            {
                valorUnitarioFieldSpecified = value;
            }
        }


        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Importe
        {
            get
            {
                return importeField;
            }
            set
            {
                importeField = value;
            }
        }


        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ImporteSpecified
        {
            get
            {
                return importeFieldSpecified;
            }
            set
            {
                importeFieldSpecified = value;
            }
        }
    }
}