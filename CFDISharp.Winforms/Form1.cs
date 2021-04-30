using CFDISharp.CoreLib.Helpers;
using CFDISharp.CoreLib.Invoicing.Base;
using CFDISharp.CoreLib.Services;
using CFDISharp.Winforms.Helpers;
using CFDISharp.Winforms.Helpers.SellosHelper;
using CFDISharp.Winforms.Models;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CFDISharp.Winforms
{
    public partial class Form1 : Form
    {
        private readonly AppdbContext context;
        private readonly IInvoiceService invoiceService;
        private readonly IPaymentService paymentService;
        private readonly ICFDIHelper cFDIHelper;
        private readonly IWSHelperTest wsHelperTest;

        public Form1(AppdbContext context,
            IInvoiceService invoiceService,
            IPaymentService paymentService,
            ICFDIHelper cFDIHelper,
            IWSHelperTest wsHelperTest)
        {
            InitializeComponent();
            this.context = context;
            this.invoiceService = invoiceService;
            this.paymentService = paymentService;
            this.cFDIHelper = cFDIHelper;
            this.wsHelperTest = wsHelperTest;
        }

        private void BtnFactura_Click(object sender, EventArgs e)
        {
            Factura();
        }

        private void Factura()
        {
            try
            {


                cFDIHelper.Initialize("I");
                invoiceService.Initialize("I");

                //var repository = new MoqFilesRepository(context);
                //repository.AddFile(Constants.CerPath, "cer");
                //repository.AddFile(Constants.KeyPath, "key");
                //repository.AddPassword(csdService.EncodeToBase64(Constants.Pass), "pass");
                //return;


                var certificatedb = context.SatFiles.FirstOrDefault(x => x.Type.ToLower().Equals("cer"));
                var privateKeydb = context.SatFiles.FirstOrDefault(x => x.Type.ToLower().Equals("key"));
                var passworddb = context.SatFiles.FirstOrDefault(x => x.Type.ToLower().Equals("pass"));


                var mxCertificate = new MxCertificate(certificatedb);
                var mxPrivateKey = new MxPrivateKey(privateKeydb);
                var password = passworddb.Base64File.DecodeFromBase64();


                cFDIHelper.CertificateBytes = mxCertificate.CertificateBytes();
                cFDIHelper.PrivateKeyBytes = mxPrivateKey.PrivateKeyBytes();
                cFDIHelper.Password = password;
                cFDIHelper.XSLTPath = Constants.XSLT_PATH;


                invoiceService.Comprobante.Fecha = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
                invoiceService.Comprobante.Sello = "MiCadenaDeSello";
                invoiceService.Comprobante.NoCertificado = mxCertificate.CertificateNumber();
                invoiceService.Comprobante.Certificado = certificatedb.Base64File;
                invoiceService.Comprobante.Moneda = "MXN";
                invoiceService.Comprobante.TipoDeComprobante = "I";
                invoiceService.Comprobante.LugarExpedicion = "38020";
                invoiceService.Comprobante.TipoDeComprobante = "I";
                invoiceService.Comprobante.Serie = "F";
                invoiceService.Comprobante.FormaPago = "01";
                invoiceService.Comprobante.MetodoPago = "PUE";


                //Concepto 1
                var concepto1 = new ComprobanteConcepto();
                concepto1.ClaveProdServ = "01010101";
                concepto1.ClaveUnidad = "H87";
                concepto1.NoIdentificacion = "P001";
                concepto1.Unidad = "Tonelada";
                concepto1.Descripcion = "Producto ACERO";
                concepto1.Cantidad = 1.5M;
                concepto1.ValorUnitario = 1500000;
                concepto1.Descuento = 10;
                concepto1.Importe = 2250000;
                invoiceService.AddConcepto(concepto1, "002", 0.160000m, 2250000, 360000, "Tasa", "003", 0.530000m, 2250000, 1192500, "Tasa");



                //Concepto 2
                var concepto2 = new ComprobanteConcepto();
                concepto2.ClaveProdServ = "01010101";
                concepto2.ClaveUnidad = "H87";
                concepto2.NoIdentificacion = "P001";
                concepto2.Unidad = "Tonelada";
                concepto2.Descripcion = "Producto ALUMINIO";
                concepto2.Cantidad = 1.6M;
                concepto2.ValorUnitario = 1500;
                concepto2.Descuento = 10;
                concepto2.Importe = 2400;
                invoiceService.AddConcepto(concepto2, "002", 0.160000m, 2400, 384, "Tasa", "003", 0.530000m, 2400, 1272, "Tasa");

                //Concepto 3
                var concepto3 = new ComprobanteConcepto();
                concepto3.ClaveProdServ = "01010101";
                concepto3.ClaveUnidad = "H87";
                concepto3.NoIdentificacion = "P003";
                concepto3.Unidad = "Tonelada";
                concepto3.Descripcion = "Producto ZAMAC";
                concepto3.Cantidad = 1.7M;
                concepto3.ValorUnitario = 10000;
                concepto3.Descuento = 10;
                concepto3.Importe = 17000;
                invoiceService.AddConcepto(concepto3, "002", 0.160000m, 17000, 2720, "Tasa", "002", 0.160000m, 17000, 2720, "Tasa");



                //Emisor
                invoiceService.AddEmisor("XIA190128J61", "XENON INDUSTRIAL ARTICLES S DE CV", "601");

                //Receptor
                invoiceService.AddReceptor("MEJJ940824C61", "JESUS MENDOZA JUAREZ", "G01");


                invoiceService.Comprobante = invoiceService.CalculaComprobante();




                //1  SerializeToXmlStringFile
                var xmlStringFile = cFDIHelper.SerializeToXmlStringFile(invoiceService.Comprobante);



                //2 Get candena orginal and Sign
                var cadenaOriginal = cFDIHelper.GetOriginalStringByXmlStringFile(xmlStringFile);
                invoiceService.Comprobante.Sello = cFDIHelper.Sign(cadenaOriginal);

                //3 SerializeToXmlStringFile (again but signed)
                xmlStringFile = cFDIHelper.SerializeToXmlStringFile(invoiceService.Comprobante);

                File.WriteAllText("Invoice.XML", xmlStringFile);

                var response = wsHelperTest.Transmit(xmlStringFile);
                MessageBox.Show(response.Status);

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void BtnNC_Click(object sender, EventArgs e)
        {
            NotadeCredito();
        }
        private void NotadeCredito()
        {
            try
            {



                cFDIHelper.Initialize("E");
                invoiceService.Initialize("E");




                var certificatedb = context.SatFiles.FirstOrDefault(x => x.Type.ToLower().Equals("cer"));
                var privateKeydb = context.SatFiles.FirstOrDefault(x => x.Type.ToLower().Equals("key"));
                var passworddb = context.SatFiles.FirstOrDefault(x => x.Type.ToLower().Equals("pass"));


                var mxCertificate = new MxCertificate(certificatedb);
                var mxPrivateKey = new MxPrivateKey(privateKeydb);
                var password = cFDIHelper.DecodeFromBase64(passworddb.Base64File);


                cFDIHelper.CertificateBytes = mxCertificate.CertificateBytes();
                cFDIHelper.PrivateKeyBytes = mxPrivateKey.PrivateKeyBytes();
                cFDIHelper.Password = password;
                cFDIHelper.XSLTPath = Constants.XSLT_PATH;


                invoiceService.Comprobante.Fecha = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
                invoiceService.Comprobante.Sello = "MiCadenaDeSello";
                invoiceService.Comprobante.NoCertificado = mxCertificate.CertificateNumber();
                invoiceService.Comprobante.Certificado = certificatedb.Base64File;
                invoiceService.Comprobante.Moneda = "MXN";
                invoiceService.Comprobante.TipoDeComprobante = "I";
                invoiceService.Comprobante.LugarExpedicion = "38020";
                invoiceService.Comprobante.TipoDeComprobante = "I";
                invoiceService.Comprobante.Serie = "F";
                invoiceService.Comprobante.FormaPago = "01";
                invoiceService.Comprobante.MetodoPago = "PUE";


                //Concepto 1
                var concepto1 = new ComprobanteConcepto();
                concepto1.ClaveProdServ = "01010101";
                concepto1.ClaveUnidad = "H87";
                concepto1.NoIdentificacion = "P001";
                concepto1.Unidad = "Tonelada";
                concepto1.Descripcion = "Producto ACERO";
                concepto1.Cantidad = 1.5M;
                concepto1.ValorUnitario = 1500000;
                concepto1.Descuento = 10;
                concepto1.Importe = 2250000;
                invoiceService.AddConcepto(concepto1, "002", 0.160000m, 2250000, 360000, "Tasa", "003", 0.530000m, 2250000, 1192500, "Tasa");



                //Concepto 2
                var concepto2 = new ComprobanteConcepto();
                concepto2.ClaveProdServ = "01010101";
                concepto2.ClaveUnidad = "H87";
                concepto2.NoIdentificacion = "P001";
                concepto2.Unidad = "Tonelada";
                concepto2.Descripcion = "Producto ALUMINIO";
                concepto2.Cantidad = 1.6M;
                concepto2.ValorUnitario = 1500;
                concepto2.Descuento = 10;
                concepto2.Importe = 2400;
                invoiceService.AddConcepto(concepto2, "002", 0.160000m, 2400, 384, "Tasa", "003", 0.530000m, 2400, 1272, "Tasa");

                //Concepto 3
                var concepto3 = new ComprobanteConcepto();
                concepto3.ClaveProdServ = "01010101";
                concepto3.ClaveUnidad = "H87";
                concepto3.NoIdentificacion = "P003";
                concepto3.Unidad = "Tonelada";
                concepto3.Descripcion = "Producto ZAMAC";
                concepto3.Cantidad = 1.7M;
                concepto3.ValorUnitario = 10000;
                concepto3.Descuento = 10;
                concepto3.Importe = 17000;
                invoiceService.AddConcepto(concepto3, "002", 0.160000m, 17000, 2720, "Tasa", "002", 0.160000m, 17000, 2720, "Tasa");


                //Cfdi Relacionado
                invoiceService.AddRelacionado("5CB8D806-7BDF-4D24-AC4C-4C469EB4F57A", "01");

                //Emisor
                invoiceService.AddEmisor("XIA190128J61", "XENON INDUSTRIAL ARTICLES S DE CV", "601");

                //Receptor
                invoiceService.AddReceptor("MEJJ940824C61", "JESUS MENDOZA JUAREZ", "G01");


                invoiceService.Comprobante = invoiceService.CalculaComprobante();


                //1
                var xmlStringFile = cFDIHelper.SerializeToXmlStringFile(invoiceService.Comprobante);



                //2
                var cadenaOriginal = cFDIHelper.GetOriginalStringByXmlStringFile(xmlStringFile);
                invoiceService.Comprobante.Sello = cFDIHelper.Sign(cadenaOriginal);

                //3
                xmlStringFile = cFDIHelper.SerializeToXmlStringFile(invoiceService.Comprobante);



                //var xml = XmlTools.ToXml2(cfdiService.Comprobante, typeof(Comprobante));
                File.WriteAllText("CreditNote.XML", xmlStringFile);

                var response = wsHelperTest.Transmit(xmlStringFile);
                MessageBox.Show(response.Status);


            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void BtnCompInd_Click(object sender, EventArgs e)
        {

        }

        private void BtnCompGrup_Click(object sender, EventArgs e)
        {

        }
    }
}
