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


        [XmlElement("InformacionAduanera")]
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


        [XmlIgnore()]
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


        [XmlIgnore()]
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