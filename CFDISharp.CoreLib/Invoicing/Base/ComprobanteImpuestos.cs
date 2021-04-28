using Newtonsoft.Json;

namespace CFDISharp.CoreLib.Invoicing.Base
{
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]

   
    public partial class ComprobanteImpuestos
    {

        private ComprobanteImpuestosRetencion[] retencionesField;

        private ComprobanteImpuestosTraslado[] trasladosField;

        private decimal totalImpuestosRetenidosField;

        private bool totalImpuestosRetenidosFieldSpecified;

        private decimal totalImpuestosTrasladadosField;

        private bool totalImpuestosTrasladadosFieldSpecified;


        [System.Xml.Serialization.XmlArrayItemAttribute("Retencion", IsNullable = false)]
        public ComprobanteImpuestosRetencion[] Retenciones
        {
            get
            {
                return retencionesField;
            }
            set
            {
                retencionesField = value;
            }
        }


        [System.Xml.Serialization.XmlArrayItemAttribute("Traslado", IsNullable = false)]
        public ComprobanteImpuestosTraslado[] Traslados
        {
            get
            {
                return trasladosField;
            }
            set
            {
                trasladosField = value;
            }
        }


        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal TotalImpuestosRetenidos
        {
            get
            {
                return totalImpuestosRetenidosField;
            }
            set
            {
                totalImpuestosRetenidosField = value;
            }
        }


        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TotalImpuestosRetenidosSpecified
        {
            get
            {
                return totalImpuestosRetenidosFieldSpecified;
            }
            set
            {
                totalImpuestosRetenidosFieldSpecified = value;
            }
        }


        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal TotalImpuestosTrasladados
        {
            get
            {
                return totalImpuestosTrasladadosField;
            }
            set
            {
                totalImpuestosTrasladadosField = value;
            }
        }


        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TotalImpuestosTrasladadosSpecified
        {
            get
            {
                return totalImpuestosTrasladadosFieldSpecified;
            }
            set
            {
                totalImpuestosTrasladadosFieldSpecified = value;
            }
        }
    }
}