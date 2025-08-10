using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaApp
{
    public class Prestamo
    {
        public int IdUsuario { get; set; }
        public int IdLibro { get; set; }
        public int Id { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime? FechaDevolucion { get; set; }
    }
}
