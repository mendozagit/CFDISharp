using System;
using System.Xml.Serialization;

namespace CFDISharp.CoreLib.Complements.Payments
{


    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/Pagos")]
    [XmlRoot(Namespace = "http://www.sat.gob.mx/Pagos", IsNullable = false)]
    public partial class Pagos
    {

        private PagosPago[] pagoField;

        private string versionField;


        public Pagos()
        {
            this.versionField = "1.0";
        }

        
        [XmlElement("Pago")]
        public PagosPago[] Pago
        {
            get
            {
                return this.pagoField;
            }
            set
            {
                this.pagoField = value;
            }
        }

        
        [XmlAttribute()]
        public string Version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }
    }
}
