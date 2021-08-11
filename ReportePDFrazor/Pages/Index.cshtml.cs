using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using ReportePDFrazor.Datos;
using ReportePDFrazor.Models;
using ReportePDFrazor.Reports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReportePDFrazor.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IWebHostEnvironment _oHostEnvironment;

        public IndexModel(ILogger<IndexModel> logger,
            IWebHostEnvironment oHostEnvironment)
        {
            _logger = logger;
            _oHostEnvironment = oHostEnvironment;
        }

        public void OnGet()
        {

        }
        public FileContentResult OnGetReporte(int id)
        {
            //ComponenteCalculadoraReport rpt = new ComponenteCalculadoraReport(_oHostEnvironment);
            //var dto = ObtenerComponenteDTO();
            //var pdf = File(rpt.Report(dto), "application/pdf");
            //return pdf;

            ReporteEjemplo1 rtp = new ReporteEjemplo1(_oHostEnvironment);
            DatosFisco _dotosDelFisco = new DatosFisco();
            var pdf = File(rtp.Report(_dotosDelFisco), "application/pdf");
            return pdf;

            //List<Student> oStudents = new List<Student>();
            //for (int i = 1; i <= 10; i++)
            //{
            //    Student oStudent = new Student();
            //    oStudent.Id = i;
            //    oStudent.Name = "Student" + i;
            //    oStudent.Address = "Address" + i;
            //    oStudents.Add(oStudent);
            //}
            //StudentReport rpt = new StudentReport(_oHostEnvironment);
            //return File(rpt.Report(oStudents), "application/pdf");
        }


        public FileContentResult PrintStudent(int param)
        {
            List<Student> oStudents = new List<Student>();
            for (int i = 1; i <= 10; i++)
            {
                Student oStudent = new Student();
                oStudent.Id = i;
                oStudent.Name = "Student" + i;
                oStudent.Address = "Address" + i;
                oStudents.Add(oStudent);
            }
            StudentReport rpt = new StudentReport(_oHostEnvironment);
            return File(rpt.Report(oStudents), "application/pdf");
        }
    }
}
