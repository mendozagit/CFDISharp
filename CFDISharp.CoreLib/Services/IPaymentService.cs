using CFDISharp.CoreLib.Complements.Payments;
using CFDISharp.CoreLib.Invoicing.Base;
using System;
using System.Collections.Generic;

namespace CFDISharp.CoreLib.Services
{
    public interface IPaymentService
    {
        void AddEmisor(ComprobanteEmisor pEmisor);
        void AddEmisor(string rfc, string razonSocial, string claveRegimenFiscal);
        void AddPago(DateTime fechaP, string formaPagoP, decimal importeP, string monedaP, decimal tipoCambioP, string uuidDR, string monedaDR, string metodoPagoDR);
        void AddPago(List<PagosPagoDoctoRelacionado> doctosRelacionados, DateTime fechaP, string formaPagoP, decimal importeP, string monedaP, decimal tipoCambioP);
        void AddPago(PagosPago pago, List<PagosPagoDoctoRelacionado> doctoRelacionados);
        void AddReceptor(ComprobanteReceptor pReceptor);
        void AddReceptor(string rfc, string razonSocial, string claveUsoCfdi);
        Comprobante CalculaComprobante();
        bool SetDocumentElement();
    }
}