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
    
    public partial class ComprobanteConceptoImpuestosRetencion
    {

        private decimal baseField;

        private string impuestoField;

        private string tipoFactorField;

        private decimal tasaOCuotaField;

        private decimal importeField;


        [XmlAttribute()]
        public decimal Base
        {
            get
            {
                return baseField;
            }
            set
            {
                baseField = value;
            }
        }


        [XmlAttribute()]
        public string Impuesto
        {
            get
            {
                return impuestoField;
            }
            set
            {
                impuestoField = value;
            }
        }


        [XmlAttribute()]
        public string TipoFactor
        {
            get
            {
                return tipoFactorField;
            }
            set
            {
                tipoFactorField = value;
            }
        }


        [XmlAttribute()]
        public decimal TasaOCuota
        {
            get
            {
                return tasaOCuotaField;
            }
            set
            {

                tasaOCuotaField = value;
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
    }
}