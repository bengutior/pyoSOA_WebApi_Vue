using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiRegistro.Transfers;

namespace WebApiRegistro.Models
{
    public partial class Interes
    {
        //REGISTRAR
        public static interesdt RegistrarIntereses(interesdt ointeresdt)
        {
            PlatziEntities bd = new PlatziEntities();
            Interes inte = new Interes()
            {
                idalumno = ointeresdt.idalumno,     //Ingresa el idalumno a la tabla Interes
                interes_nombre = ointeresdt.interes_nombre
            };
            bd.Interes.Add(inte);
            bd.SaveChanges();
            ointeresdt.idinteres = inte.idinteres;

            return ointeresdt;

        }
    }
}