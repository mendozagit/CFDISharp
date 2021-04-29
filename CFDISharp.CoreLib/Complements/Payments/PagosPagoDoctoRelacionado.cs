using System;
using System.Xml.Serialization;

namespace CFDISharp.CoreLib.Complements.Payments
{
    
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/Pagos")]
    public partial class PagosPagoDoctoRelacionado
    {
        private string idDocumentoField;

        private string serieField;

        private string folioField;

        private string monedaDRField;

        private decimal tipoCambioDRField;

        private bool tipoCambioDRFieldSpecified;

        private string metodoDePagoDRField;

        private string numParcialidadField;

        private decimal impSaldoAntField;

        private bool impSaldoAntFieldSpecified;

        private decimal impPagadoField;

        private bool impPagadoFieldSpecified;

        private decimal impSaldoInsolutoField;

        private bool impSaldoInsolutoFieldSpecified;

        
        [XmlAttribute()]
        public string IdDocumento
        {
            get
            {
                return this.idDocumentoField;
            }
            set
            {
                this.idDocumentoField = value;
            }
        }

        
        [XmlAttribute()]
        public string Serie
        {
            get
            {
                return this.serieField;
            }
            set
            {
                this.serieField = value;
            }
        }

        
        [XmlAttribute()]
        public string Folio
        {
            get
            {
                return this.folioField;
            }
            set
            {
                this.folioField = value;
            }
        }

        
        [XmlAttribute()]
        public string MonedaDR
        {
            get
            {
                return this.monedaDRField;
            }
            set
            {
                this.monedaDRField = value;
            }
        }

        
        [XmlAttribute()]
        public decimal TipoCambioDR
        {
            get
            {
                return this.tipoCambioDRField;
            }
            set
            {
                this.tipoCambioDRField = value;
                this.tipoCambioDRFieldSpecified = true;
            }
        }

        
        [XmlIgnore()]
        public bool TipoCambioDRSpecified
        {
            get
            {
                return this.tipoCambioDRFieldSpecified;
            }
            set
            {
                this.tipoCambioDRFieldSpecified = value;
            }
        }

        
        [XmlAttribute()]
        public string MetodoDePagoDR
        {
            get
            {
                return this.metodoDePagoDRField;
            }
            set
            {
                this.metodoDePagoDRField = value;
            }
        }

        
        [XmlAttribute(DataType = "integer")]
        public string NumParcialidad
        {
            get
            {
                return this.numParcialidadField;
            }
            set
            {
                this.numParcialidadField = value;

            }
        }

        
        [XmlAttribute()]
        public decimal ImpSaldoAnt
        {
            get
            {
                return this.impSaldoAntField;
            }
            set
            {
                this.impSaldoAntField = value;
                this.impSaldoAntFieldSpecified = true;
            }
        }

        
        [XmlIgnore()]
        public bool ImpSaldoAntSpecified
        {
            get
            {
                return this.impSaldoAntFieldSpecified;
            }
            set
            {
                this.impSaldoAntFieldSpecified = value;

            }
        }

        
        [XmlAttribute()]
        public decimal ImpPagado
        {
            get
            {
                return this.impPagadoField;
            }
            set
            {
                this.impPagadoField = value;
                this.impPagadoFieldSpecified = true;
            }
        }

        
        [XmlIgnore()]
        public bool ImpPagadoSpecified
        {
            get
            {
                return this.impPagadoFieldSpecified;
            }
            set
            {
                this.impPagadoFieldSpecified = value;

            }
        }

        
        [XmlAttribute()]
        public decimal ImpSaldoInsoluto
        {
            get
            {
                return this.impSaldoInsolutoField;
            }
            set
            {
                this.impSaldoInsolutoField = value;
                this.impSaldoInsolutoFieldSpecified = true;
            }
        }

        
        [XmlIgnore()]
        public bool ImpSaldoInsolutoSpecified
        {
            get
            {
                return this.impSaldoInsolutoFieldSpecified;
            }
            set
            {
                this.impSaldoInsolutoFieldSpecified = value;

            }
        }
    }
}
