using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Hosting;
using ReportePDFrazor.Datos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ReportePDFrazor.Reports
{
    public class ReporteEjemplo1
    {
        private IWebHostEnvironment _oHostEnvironment;
        public ReporteEjemplo1(IWebHostEnvironment oHostEnvironment)
        {
            _oHostEnvironment = oHostEnvironment;
        }

        #region Declaracion
        int _maxColumn = 3;
        Document _document;
        Font _fontStyle;
        PdfPCell _pdfCell;
        PdfPTable _pdfTable = new PdfPTable(3);
        MemoryStream _memoryStream = new MemoryStream();

        //List<Student> _oStudents = new List<Student>();

        DatosFisco _dotosDelFisco = new DatosFisco();
        #endregion

        public byte[] Report(DatosFisco dotosDelFisco)
        {
            _dotosDelFisco = dotosDelFisco;

            _document = new Document();

            _document.SetPageSize(PageSize.Letter);
            _document.SetMargins(50f, 50f, 50f, 50f);

            PdfWriter docWrite = PdfWriter.GetInstance(_document, _memoryStream);

            _document.Open();

            _fontStyle = FontFactory.GetFont("Arial", 16, Font.BOLD, new BaseColor(221, 226, 234));

            var tituloTable = new PdfPTable(1);
            tituloTable.HorizontalAlignment = 40;
            tituloTable.SpacingBefore = 10;
            tituloTable.SpacingAfter = 10;
            tituloTable.DefaultCell.Border = 0;

            tituloTable.AddCell(new Phrase("            REPORTE DE DEUDA TRIBUTARIA.", _fontStyle));

            _document.Add(tituloTable);

            _fontStyle = FontFactory.GetFont("Arial", 12, Font.NORMAL, new BaseColor(0, 64, 128));

            var Subtitulo = new PdfPTable(1);
            Subtitulo.HorizontalAlignment = 40;
            Subtitulo.SpacingBefore = 10;
            Subtitulo.SpacingAfter = 10;
            Subtitulo.DefaultCell.Border = 0;

            Subtitulo.AddCell(new Phrase("El presente es un cálculo de carácter referencial, considerando los datos registrados.", _fontStyle));

            _document.Add(Subtitulo);

            //Numero de tramite Arial 14
            //El numero Arial 48
            //todo Arial 10

            //Señor Contribuyente: 
            //Este es el número de trámite en línea que acaba de obtener como constancia de la presentación de Boleta de Pago direccionada a una Facilidad de Pago, realizada a través de la Oficina Virtual del SIN.Tome en cuenta los siguientes aspectos:

            //Ya que el importe consignado es mayor a cero (0), debe aproximarse a la Entidad Financiera autorizada a efectivizar el pago. 

            //Si la presentación está siendo realizada en día sábado, domingo y/o feriado, los accesorios (intereses y mantenimiento     de valor) son calculados al primer día hábil siguiente a la fecha de confirmación de envío y pago. 

            //Para la "Certificación de Boletas de Pago", ingrese a la Oficina Virtual, elija la opción "CERTIFICACIÓN    DD.JJ.", seleccione el formulario, N° de orden y periodo fiscal; luego presione el botón "Consultar" e imprimir, si así lo requiere para su constancia. 

            //Para consultar el "Trámite" o "Formulario", ingrese a la Oficina Virtual, seleccione la opción de "DCLARO - NEWTON / DECLARACIONES JURADAS" y desde la sección de Consultas ingrese a NEWTON y acceda a la opción Consultas de "Trámite" o "Formulario". Consigne el código de formulario o el periodo inicial y final, posteriormente presione el botón. "Consultar". 

            //Para obtener el "Extracto Tributario", ingrese a la Oficina Virtual, seleccione la opción "EXTRACTO TRIBUTARIO", ingrese año, mes desde-hasta y presione el botón "Consultar" e imprimir, si así lo requiere. 

            //Una vez realizado el pago, vuelva a ingresar a la opción "Facilidades de Pago / Consultas de Seguimiento" y verifique que su pago haya sido reconocido por su Plan de Pagos.


            //El otro formulario 2.frx

            //Señor Contribuyente: 
            //Este es el número de trámite en línea que acaba de obtener como constancia de la presentación de Boleta de Pago direccionada a una Facilidad de Pago, realizada a través de la Oficina Virtual del SIN.Tome en cuenta los siguientes aspectos:

            //Ya que el importe consignado es mayor a cero (0), debe aproximarse a la Entidad Financiera autorizada a efectivizar el pago.

            //Si la presentación está siendo realizada en día sábado, domingo y/o feriado, los accesorios (intereses y mantenimiento de valor) son calculados al primer día hábil siguiente a la fecha de confirmación de envío y pago. 

            //Para la "Certificación de Boletas de Pago", ingrese a la Oficina Virtual, elija la opción "CERTIFICACIÓN DD.JJ.", seleccione el formulario, N° de orden y periodo fiscal; luego presione el botón "Consultar" e imprimir, si así lo requiere para su constancia.

            //Para consultar el "Trámite" o "Formulario", ingrese a la Oficina Virtual, seleccione la opción de "DCLARO - NEWTON / DECLARACIONES JURADAS" y desde la sección de Consultas ingrese a NEWTON y acceda a la opción Consultas de "Trámite" o "Formulario". Consigne el código de formulario o el periodo inicial y final, posteriormente presione el botón. "Consultar". 

            //Para obtener el "Extracto Tributario", ingrese a la Oficina Virtual, seleccione la opción "EXTRACTO TRIBUTARIO", ingrese año, mes desde-hasta y presione el botón "Consultar" e imprimir, si así lo requiere.

            //Una vez realizado el pago, vuelva a ingresar a la opción "Facilidades de Pago / Consultas de Seguimiento" y verifique que su pago haya sido reconocido por su Plan de Pagos.



            var titleFont = FontFactory.GetFont("Arial", 18, Font.BOLD);
            var subTitleFont = FontFactory.GetFont("Arial", 14, Font.BOLD);
            var boldTableFont = FontFactory.GetFont("Arial", 12, Font.BOLD);
            var endingMessageFont = FontFactory.GetFont("Arial", 10, Font.ITALIC);
            var bodyFont = FontFactory.GetFont("Arial", 12, Font.NORMAL);

            var orderInfoTable = new PdfPTable(2);
            orderInfoTable.HorizontalAlignment = 0;
            orderInfoTable.SpacingBefore = 10;
            orderInfoTable.SpacingAfter = 10;
            orderInfoTable.DefaultCell.Border = 0;
            orderInfoTable.SetWidths(new int[] { 1, 4 });

            orderInfoTable.AddCell(new Phrase("Order:", boldTableFont));
            orderInfoTable.AddCell("hola");
            orderInfoTable.AddCell(new Phrase("Price:", boldTableFont));
            orderInfoTable.AddCell("Como andas");

            _document.Add(orderInfoTable);

            //this.ReportHeader();

            _document.Close();

            return _memoryStream.ToArray();
        }        
    }
}
