using CFDISharp.CoreLib.Invoicing.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFDISharp.CoreLib.Services
{
    public class PaymentService
    {
        public Comprobante Comprobante;
        private List<ComprobanteCfdiRelacionadosCfdiRelacionado> cfdiRelacionados;
        private List<ComprobanteConcepto> conceptos;
        private List<PagosPagoDoctoRelacionado> doctosRelacionados;
        private PagosPagoDoctoRelacionado doctoRelacionado;
        private Pagos pagosElemento;
        private List<PagosPago> pagos;
        private PagosPago pago;
        private XmlDocument xmlComplemento;
        private XmlSerializerNamespaces xmlNameSpacePago;
        private XmlWriter xmlWriter;
        private XmlSerializer xmlSerializer;
        private readonly int decimalesItem;
        private readonly int decimalesHeader;

    }
}
