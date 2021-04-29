using System;
using System.Xml.Serialization;

namespace CFDISharp.CoreLib.Complements.Payments
{
    
    
    [Serializable()]
    
    
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/Pagos")]
    public partial class PagosPagoImpuestosRetencion
    {

        private string impuestoField;

        private decimal importeField;

        
        [XmlAttribute()]
        public string Impuesto
        {
            get
            {
                return this.impuestoField;
            }
            set
            {
                this.impuestoField = value;
            }
        }

        
        [XmlAttribute()]
        public decimal Importe
        {
            get
            {
                return this.importeField;
            }
            set
            {
                this.importeField = value;
            }
        }
    }
}
