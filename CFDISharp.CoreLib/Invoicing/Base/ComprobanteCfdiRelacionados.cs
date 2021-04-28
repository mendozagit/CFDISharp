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

    public partial class ComprobanteCfdiRelacionados
    {

        private ComprobanteCfdiRelacionadosCfdiRelacionado[] cfdiRelacionadoField;

        private string tipoRelacionField;


        [XmlElement("CfdiRelacionado")]
        public ComprobanteCfdiRelacionadosCfdiRelacionado[] CfdiRelacionado
        {
            get
            {
                return cfdiRelacionadoField;
            }
            set
            {
                cfdiRelacionadoField = value;
            }
        }


        [XmlAttribute()]
        public string TipoRelacion
        {
            get
            {
                return tipoRelacionField;
            }
            set
            {
                tipoRelacionField = value;
            }
        }
    }
}