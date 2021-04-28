//*********************************************************************************
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
    
    public partial class ComprobanteEmisor
    {

        private string rfcField;

        private string nombreField;

        private string regimenFiscalField;


        [XmlAttribute()]
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


        [XmlAttribute()]
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


        [XmlAttribute()]
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