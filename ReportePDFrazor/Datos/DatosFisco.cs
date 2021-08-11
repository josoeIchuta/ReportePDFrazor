using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReportePDFrazor.Datos
{
    public class DatosFisco
    {
        public int nit { get; set; }
        public int numeroOrden { get; set; }
        public int numeroFormulario { get; set; }
        public int periodo { get; set; }
        public int importePagar { get; set; }
        public DatosFisco()
        {
            nit = 1234567890;
            numeroOrden = 83025;
            numeroFormulario = 200;
            periodo = 8;
            importePagar = 550;
        }
    }
}
