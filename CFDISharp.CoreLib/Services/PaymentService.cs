using CFDISharp.CoreLib.Complements.Payments;
using CFDISharp.CoreLib.Invoicing.Base;
using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

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

        public PaymentService(string tipoDeComprobante, string version, int decimalesItems = 2, int decimalesHeader = 0)
        {

            this.decimalesItem = decimalesItems;
            this.decimalesHeader = decimalesHeader;

            conceptos = new List<ComprobanteConcepto>();
            cfdiRelacionados = new List<ComprobanteCfdiRelacionadosCfdiRelacionado>();
            Comprobante = new Comprobante { Version = version, TipoDeComprobante = tipoDeComprobante };

            //Complemento pago

            AddConceptoStandard();
            AddHeaderStandard();
            pagosElemento = new Pagos();
            pagos = new List<PagosPago>();
            doctosRelacionados = new List<PagosPagoDoctoRelacionado>();
            xmlComplemento = new XmlDocument();
            xmlSerializer = new XmlSerializer(pagosElemento.GetType());
            xmlNameSpacePago = new XmlSerializerNamespaces();
            xmlNameSpacePago.Add("pago10", "http://www.sat.gob.mx/Pagos");
            Comprobante.Complemento = new ComprobanteComplemento[1];
            Comprobante.Complemento[0] = new ComprobanteComplemento();
        }


        private void AddConceptoStandard()
        {
            var concepto = new ComprobanteConcepto();
            concepto.ClaveProdServ = "84111506";
            concepto.Cantidad = 1;
            concepto.ClaveUnidad = "ACT";
            concepto.Descripcion = "Pago";
            concepto.ValorUnitario = 0;
            concepto.Importe = 0;
            conceptos.Add(concepto);
        }
        private void AddHeaderStandard()
        {
            //Encabezado
            Comprobante.Fecha = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
            Comprobante.SubTotal = 0;
            Comprobante.Moneda = "XXX";
            Comprobante.Total = 0;
            // Comprobante.Version = "3.3";
            //Comprobante.Serie = "P";
            //Comprobante.TipoDeComprobante = "P";
            //Comprobante.Folio = CXCP.NoRef.ToString();
            //Comprobante.NoCertificado = noCertificado;
            //Comprobante.LugarExpedicion = empresa.Cp;
        }


        /// <summary>
        /// Emisor del comprobante
        /// </summary>
        /// <param name="pEmisor"></param>
        public void AddEmisor(ComprobanteEmisor pEmisor)
        {
            if (pEmisor != null)
            {
                Comprobante.Emisor = pEmisor;
            }
        }


        /// <summary>
        /// Emisor del comprobante
        /// </summary>
        /// <param name="rfc"></param>
        /// <param name="razonSocial"></param>
        /// <param name="claveRegimenFiscal"></param>
        public void AddEmisor(string rfc, string razonSocial, string claveRegimenFiscal)
        {
            Comprobante.Emisor = new ComprobanteEmisor();
            Comprobante.Emisor.Rfc = rfc;
            Comprobante.Emisor.Nombre = razonSocial;
            Comprobante.Emisor.RegimenFiscal = claveRegimenFiscal;

        }



        /// <summary>
        /// Receptor del comprobante
        /// </summary>
        /// <param name="pReceptor"></param>
        public void AddReceptor(ComprobanteReceptor pReceptor)
        {
            if (pReceptor != null)
            {
                Comprobante.Receptor = pReceptor;
            }
        }


        /// <summary>
        /// Receptor del comprobante
        /// </summary>
        /// <param name="rfc"></param>
        /// <param name="razonSocial"></param>
        /// <param name="claveUsoCfdi"></param>
        public void AddReceptor(string rfc, string razonSocial, string claveUsoCfdi)
        {

            Comprobante.Receptor = new ComprobanteReceptor();
            Comprobante.Receptor.Rfc = rfc;
            Comprobante.Receptor.Nombre = razonSocial;
            Comprobante.Receptor.UsoCFDI = claveUsoCfdi;
        }


        /// <summary>
        /// Agrega un pago tanto el pago como el doc relacionado es en variables
        /// El metodo se usa cuando el pago corresponde a una sola factura (doc relacionado)
        /// </summary>
        /// <param name="fechaP"></param>
        /// <param name="formaPagoP"></param>
        /// <param name="importeP"></param>
        /// <param name="monedaP"></param>
        /// <param name="tipoCambioP"></param>
        /// <param name="uuidDR"></param>
        /// <param name="monedaDR"></param>
        /// <param name="metodoPagoDR"></param>
        public void AddPago(
        DateTime fechaP,
        string formaPagoP,
        decimal importeP,
        string monedaP,
        decimal tipoCambioP,
        string uuidDR,
        string monedaDR,
        string metodoPagoDR)
        {
            pago = new PagosPago();
            pago.FechaPago = fechaP.ToString("yyyy-MM-ddTHH:mm:ss");
            pago.FormaDePagoP = formaPagoP;
            pago.Monto = Math.Round(importeP, decimalesItem, MidpointRounding.AwayFromZero);
            pago.MonedaP = monedaP;
            pago.TipoCambioP = tipoCambioP;
            pago.TipoCambioPSpecified = pago.TipoCambioP != 1;


            doctoRelacionado = new PagosPagoDoctoRelacionado();
            doctoRelacionado.IdDocumento = uuidDR;
            doctoRelacionado.MonedaDR = monedaDR;
            doctoRelacionado.MetodoDePagoDR = metodoPagoDR;

            pago.DoctoRelacionado = doctosRelacionados.ToArray();
            pagos.Add(pago);
        }


        /// <summary>
        /// Agrega un pago. La informacion del pago, se pasa en variables,
        /// mientras que los docuemntos relacionados de ese pago en una lista 
        /// </summary>
        /// <param name="doctosRelacionados"></param>
        /// <param name="fechaP"></param>
        /// <param name="formaPagoP"></param>
        /// <param name="importeP"></param>
        /// <param name="monedaP"></param>
        /// <param name="tipoCambioP"></param>
        /// <param name="rfcOrdenante"></param>
        /// <param name="ctaOrdenante"></param>
        /// <param name="rfcBeneficiario"></param>
        /// <param name="ctaBeneficiario"></param>
        public void AddPago(
            List<PagosPagoDoctoRelacionado> doctosRelacionados,
            DateTime fechaP,
            string formaPagoP,
            decimal importeP,
            string monedaP,
            decimal tipoCambioP)
        {
            pago = new PagosPago();
            pago.FechaPago = fechaP.ToString("yyyy-MM-ddTHH:mm:ss");
            pago.FormaDePagoP = formaPagoP;
            pago.Monto = Math.Round(importeP, decimalesItem, MidpointRounding.AwayFromZero);
            pago.MonedaP = monedaP;
            pago.TipoCambioP = tipoCambioP;
            pago.TipoCambioPSpecified = pago.TipoCambioP != 1;



            pago.DoctoRelacionado = doctosRelacionados.ToArray();
            pagos.Add(pago);
        }

        /// <summary>
        /// Agrega un pago , recibe un objeto pago y una lista de docs relacionados
        /// </summary>
        /// <param name="pago"></param>
        /// <param name="doctoRelacionados"></param>
        public void AddPago(PagosPago pago, List<PagosPagoDoctoRelacionado> doctoRelacionados)
        {
            pago.DoctoRelacionado = doctosRelacionados.ToArray();
            pago.Monto = Math.Round(pago.Monto, decimalesItem, MidpointRounding.AwayFromZero);
            pagos.Add(pago);
        }



        public Comprobante CalculaComprobante()
        {
            Comprobante.Conceptos = conceptos.ToArray();
            pagosElemento.Pago = pagos.ToArray();

            AddCfdiRelacionadoIfExist();
            return Comprobante;
        }


        private void AddCfdiRelacionadoIfExist()
        {
            if (cfdiRelacionados.Count > 0)
                Comprobante.CfdiRelacionados.CfdiRelacionado = cfdiRelacionados.ToArray();
            else
                Comprobante.CfdiRelacionados = null;
        }

        /// <summary>
        /// Obtiene el complemento de pago en forma de XmlElement 
        /// </summary>
        /// <returns></returns>
        public bool SetDocumentElement()
        {
            try
            {


                using (xmlWriter = xmlComplemento.CreateNavigator().AppendChild())
                    xmlSerializer.Serialize(xmlWriter, pagosElemento, xmlNameSpacePago);


                Comprobante.Complemento[0].Any = new XmlElement[1];
                Comprobante.Complemento[0].Any[0] = xmlComplemento.DocumentElement;

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

    }
}
