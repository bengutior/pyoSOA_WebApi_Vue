using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiRegistro.Transfers;

namespace WebApiRegistro.Models
{
    public partial class Escuela
    {
        //REGISTRAR
        public static escueladt RegistrarEscuelas(escueladt oescueladt)
        {
            PlatziEntities2 bd = new PlatziEntities2();
            Escuela esc = new Escuela()
            {
                idalumno = oescueladt.idalumno,//Ingresa el idalumno a la tabla Escuela
                esc_nombre = oescueladt.esc_nombre
            };
            bd.Escuela.Add(esc);
            bd.SaveChanges();
            oescueladt.idescuela = esc.idescuela;

            return oescueladt;

        }
    }
}