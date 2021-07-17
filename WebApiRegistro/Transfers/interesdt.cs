using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiRegistro.Transfers
{
    public class interesdt
    {
        public int idalumno { get; set; }
        public int idinteres { get; set; }
        public String interes_nombre { get; set; }
        public int compromiso_hr { get; set; }

        public IEnumerable<alumnodt> alumnos{ get; set; }

    }
}