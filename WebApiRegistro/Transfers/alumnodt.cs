using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiRegistro.Models;

namespace WebApiRegistro.Transfers
{
    public class alumnodt
    {
        public int id { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string correo { get; set; }
        public string contraseña { get; set; }
        public string usuario { get; set; }
        public string resp_w { get; set; }
        public Nullable<int> alutelefono { get; set; }
        public Nullable<int> compromiso_hr { get; set; }

    }
}