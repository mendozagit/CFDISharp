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


    public partial class ComprobanteImpuestos
    {

        private ComprobanteImpuestosRetencion[] retencionesField;

        private ComprobanteImpuestosTraslado[] trasladosField;

        private decimal totalImpuestosRetenidosField;

        private bool totalImpuestosRetenidosFieldSpecified;

        private decimal totalImpuestosTrasladadosField;

        private bool totalImpuestosTrasladadosFieldSpecified;


        [XmlArrayItem("Retencion", IsNullable = false)]
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


        [XmlArrayItem("Traslado", IsNullable = false)]
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


        [XmlAttribute()]
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


        [XmlIgnore()]
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


        [XmlAttribute()]
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


        [XmlIgnore()]
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