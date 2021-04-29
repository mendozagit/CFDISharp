﻿//*********************************************************************************
// <Author>
//     Jesús Mendoza Jaurez. 
//     mendoza.git@gmail.com
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto.

//     Este código no ofrece ningún tipo de garantía, se generó para ayudar a la 
//     Comunidad open source, siéntanse libre de utilizarlo, sin ninguna garantía.
//     Nota: Mantenga este comentario para respetar al autor.
// </Author>
//*********************************************************************************


using System;
using System.Xml.Schema;
using System.Xml.Serialization;
using CFDISharp.CoreLib.Invoicing.Base;

namespace CFDISharp.CoreLib.Invoicing.Base
{
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
    [XmlRoot(Namespace = "http://www.sat.gob.mx/cfd/3", IsNullable = false)]


    public class Comprobante
    {
        private ComprobanteCfdiRelacionados cfdiRelacionadosField;

        private ComprobanteEmisor emisorField;

        private ComprobanteReceptor receptorField;

        private ComprobanteConcepto[] conceptosField;

        private ComprobanteImpuestos impuestosField;

        private ComprobanteComplemento[] complementoField;

        private ComprobanteAddenda addendaField;

        private string versionField;

        private string serieField;

        private string folioField;

        private string fechaField;

        private string selloField;

        private string formaPagoField;

        private bool formaPagoFieldSpecified;

        private string noCertificadoField;

        private string certificadoField;

        private string condicionesDePagoField;

        private decimal subTotalField;

        private decimal descuentoField;

        private bool descuentoFieldSpecified;

        private string monedaField;

        private decimal tipoCambioField;

        private bool tipoCambioFieldSpecified;

        private decimal totalField;

        private string tipoDeComprobanteField;

        private string metodoPagoField;

        private bool metodoPagoFieldSpecified;

        private string lugarExpedicionField;

        private string confirmacionField;


        [XmlAttribute("schemaLocation", Namespace = XmlSchema.InstanceNamespace)]
        public string XsiSchemaLocation =
            "http://www.sat.gob.mx/cfd/3 " +
            "http://www.sat.gob.mx/sitio_internet/cfd/3/cfdv32.xsd " +
            "http://www.sat.gob.mx/Pagos " +
            "http://www.sat.gob.mx/sitio_internet/cfd/Pagos/Pagos10.xsd";

        public Comprobante()
        {
            versionField = "3.3";
        }


        public ComprobanteCfdiRelacionados CfdiRelacionados
        {
            get
            {
                return cfdiRelacionadosField;
            }
            set
            {
                cfdiRelacionadosField = value;
            }
        }


        public ComprobanteEmisor Emisor
        {
            get
            {
                return emisorField;
            }
            set
            {
                emisorField = value;
            }
        }


        public ComprobanteReceptor Receptor
        {
            get
            {
                return receptorField;
            }
            set
            {
                receptorField = value;
            }
        }


        [XmlArrayItem("Concepto", IsNullable = false)]
        public ComprobanteConcepto[] Conceptos
        {
            get
            {
                return conceptosField;
            }
            set
            {
                conceptosField = value;
            }
        }


        public ComprobanteImpuestos Impuestos
        {
            get
            {
                return impuestosField;
            }
            set
            {
                impuestosField = value;
            }
        }


        [XmlElement("Complemento")]
        public ComprobanteComplemento[] Complemento
        {
            get
            {
                return complementoField;
            }
            set
            {
                complementoField = value;
            }
        }


        public ComprobanteAddenda Addenda
        {
            get
            {
                return addendaField;
            }
            set
            {
                addendaField = value;
            }
        }


        [XmlAttribute()]
        public string Version
        {
            get
            {
                return versionField;
            }
            set
            {
                versionField = value;
            }
        }


        [XmlAttribute()]
        public string Serie
        {
            get
            {
                return serieField;
            }
            set
            {
                serieField = value;
            }
        }


        [XmlAttribute()]
        public string Folio
        {
            get
            {
                return folioField;
            }
            set
            {
                folioField = value;
            }
        }


        [XmlAttribute()]
        public string Fecha
        {
            get
            {
                return fechaField;
            }
            set
            {
                fechaField = value;
            }
        }


        [XmlAttribute()]
        public string Sello
        {
            get
            {
                return selloField;
            }
            set
            {
                selloField = value;
            }
        }


        [XmlAttribute()]
        public string FormaPago
        {
            get
            {
                return formaPagoField;
            }
            set
            {
                formaPagoFieldSpecified = true;
                formaPagoField = value;
            }
        }


        [XmlIgnore()]
        public bool FormaPagoSpecified
        {
            get
            {
                return formaPagoFieldSpecified;
            }
            set
            {
                formaPagoFieldSpecified = value;
            }
        }


        [XmlAttribute()]
        public string NoCertificado
        {
            get
            {
                return noCertificadoField;
            }
            set
            {
                noCertificadoField = value;
            }
        }


        [XmlAttribute()]
        public string Certificado
        {
            get
            {
                return certificadoField;
            }
            set
            {
                certificadoField = value;
            }
        }


        [XmlAttribute()]
        public string CondicionesDePago
        {
            get
            {
                return condicionesDePagoField;
            }
            set
            {
                condicionesDePagoField = value;
            }
        }


        [XmlAttribute()]
        public decimal SubTotal
        {
            get
            {
                return subTotalField;
            }
            set
            {
                subTotalField = value;
            }
        }


        [XmlAttribute()]
        public decimal Descuento
        {
            get
            {
                return descuentoField;
            }
            set
            {
                descuentoFieldSpecified = true;
                descuentoField = value;
            }
        }


        [XmlIgnore()]
        public bool DescuentoSpecified
        {
            get
            {
                return descuentoFieldSpecified;
            }
            set
            {
                descuentoFieldSpecified = value;
            }
        }


        [XmlAttribute()]
        public string Moneda
        {
            get
            {
                return monedaField;
            }
            set
            {
                monedaField = value;
            }
        }


        [XmlAttribute()]
        public decimal TipoCambio
        {
            get
            {
                return tipoCambioField;
            }
            set
            {
                tipoCambioFieldSpecified = true;
                tipoCambioField = value;
            }
        }


        [XmlIgnore()]
        public bool TipoCambioSpecified
        {
            get
            {
                return tipoCambioFieldSpecified;
            }
            set
            {
                tipoCambioFieldSpecified = value;
            }
        }


        [XmlAttribute()]
        public decimal Total
        {
            get
            {
                return totalField;
            }
            set
            {
                totalField = value;
            }
        }


        [XmlAttribute()]
        public string TipoDeComprobante
        {
            get
            {
                return tipoDeComprobanteField;
            }
            set
            {
                tipoDeComprobanteField = value;
            }
        }


        [XmlAttribute()]
        public string MetodoPago
        {
            get
            {
                return metodoPagoField;
            }
            set
            {
                metodoPagoFieldSpecified = true;
                metodoPagoField = value;
            }
        }


        [XmlIgnore()]
        public bool MetodoPagoSpecified
        {
            get
            {
                return metodoPagoFieldSpecified;
            }
            set
            {
                metodoPagoFieldSpecified = value;
            }
        }


        [XmlAttribute()]
        public string LugarExpedicion
        {
            get
            {
                return lugarExpedicionField;
            }
            set
            {
                lugarExpedicionField = value;
            }
        }


        [XmlAttribute()]
        public string Confirmacion
        {
            get
            {
                return confirmacionField;
            }
            set
            {
                confirmacionField = value;
            }
        }
    }
}