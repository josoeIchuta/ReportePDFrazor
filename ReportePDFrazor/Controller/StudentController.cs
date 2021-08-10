using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReportePDFrazor.Models;
using ReportePDFrazor.Reports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReportePDFrazor.Controller
{
    [Route("[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IWebHostEnvironment _oHostEnvironment;
        public StudentController(IWebHostEnvironment oHostEnvironment)
        {
            _oHostEnvironment = oHostEnvironment;
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
