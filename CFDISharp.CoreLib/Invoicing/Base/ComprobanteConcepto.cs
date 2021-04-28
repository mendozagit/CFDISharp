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
using System.Xml;
using System.Xml.Serialization;

namespace CFDISharp.CoreLib.Invoicing.Base
{
   
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
    public partial class ComprobanteConcepto
    {
        public ComprobanteConcepto()
        {

        }
        private ComprobanteConceptoImpuestos impuestosField;

        private ComprobanteConceptoInformacionAduanera[] informacionAduaneraField;

        private ComprobanteConceptoCuentaPredial cuentaPredialField;

        private ComprobanteConceptoComplementoConcepto complementoConceptoField;

        private ComprobanteConceptoParte[] parteField;

        private string claveProdServField;

        private string noIdentificacionField;

        private decimal cantidadField;

        private string claveUnidadField;

        private string unidadField;

        private string descripcionField;

        private decimal valorUnitarioField;

        private decimal importeField;

        private decimal descuentoField;

        private bool descuentoFieldSpecified;


        public ComprobanteConceptoImpuestos Impuestos
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


        [XmlElement("InformacionAduanera")]
        public ComprobanteConceptoInformacionAduanera[] InformacionAduanera
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


        public ComprobanteConceptoCuentaPredial CuentaPredial
        {
            get
            {
                return cuentaPredialField;
            }
            set
            {
                cuentaPredialField = value;
            }
        }


        public ComprobanteConceptoComplementoConcepto ComplementoConcepto
        {
            get
            {
                return complementoConceptoField;
            }
            set
            {
                complementoConceptoField = value;
            }
        }


        [XmlElement("Parte")]
        public ComprobanteConceptoParte[] Parte
        {
            get
            {
                return parteField;
            }
            set
            {
                parteField = value;
            }
        }


        [XmlAttribute()]
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


        [XmlAttribute()]
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


        [XmlAttribute()]
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


        [XmlAttribute()]
        public string ClaveUnidad
        {
            get
            {
                return claveUnidadField;
            }
            set
            {
                claveUnidadField = value;
            }
        }


        [XmlAttribute()]
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


        [XmlAttribute()]
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


        [XmlAttribute()]
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


        [XmlAttribute()]
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


        [XmlAttribute()]
        public decimal Descuento
        {
            get
            {
                return descuentoField;
            }
            set
            {
                descuentoField = value;
                descuentoFieldSpecified = true;
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
    }
}