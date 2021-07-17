using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiRegistro.Transfers
{
    public class escueladt
    {
        public int idalumno { get; set; }
        public int idescuela { get; set; }
        public String esc_nombre { get; set; }
        public IEnumerable<alumnodt> alumnos { get; set; }
    }
}