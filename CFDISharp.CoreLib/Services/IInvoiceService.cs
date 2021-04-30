using CFDISharp.CoreLib.Invoicing.Base;
using System.Collections.Generic;

namespace CFDISharp.CoreLib.Services
{
    public interface IInvoiceService
    {
        Comprobante Comprobante { get; set; }

        void AddConcepto(ComprobanteConcepto pconcepto, List<ComprobanteConceptoImpuestosTraslado> traslados = null, List<ComprobanteConceptoImpuestosRetencion> retenciones = null);
        void AddConcepto(ComprobanteConcepto nConcepto, string nImpuesto, decimal nTasaOCuota, decimal nBase, decimal nImporte, string nTipoFactor, bool isTraslado = true);
        void AddConcepto(ComprobanteConcepto nConcepto, string trasladoImpuesto, decimal trasladoTasaOCuota, decimal trasladoBase, decimal trasladoImporte, string trasladoTipoFactor, string retencionImpuesto, decimal retencionTasaOCuota, decimal retencionBase, decimal retencionImporte, string retencionTipoFactor);
        void AddEmisor(ComprobanteEmisor pEmisor);
        void AddEmisor(string rfc, string razonSocial, string claveRegimenFiscal);
        void AddReceptor(ComprobanteReceptor pReceptor);
        void AddReceptor(string rfc, string razonSocial, string claveUsoCfdi);
        void AddRelacionado(ComprobanteCfdiRelacionadosCfdiRelacionado cfdirelacionado, string tipoRelacion = "01");
        void AddRelacionado(List<ComprobanteCfdiRelacionadosCfdiRelacionado> cfdirelacionadosList, string tipoRelacion = "01");
        void AddRelacionado(string uuidRelacionado, string tipoRelacion = "01");
        Comprobante CalculaComprobante();
        void Initialize(string tipoDeComprobante = "I", string version = "3.3", int decimalesConcepto = 6, int decimalesComprobante = 2);
    }
}