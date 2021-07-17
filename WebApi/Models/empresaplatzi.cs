using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApi.Transfers;

namespace WebApi.Models
{
    public partial class Empresa
    {


        //REGISTRAR
        public static empresadt RegistrarDatos(empresadt oempresadt)
        {
            PlatziEntities1 bd = new PlatziEntities1();
            Empresa emp = new Empresa()
            {
                nombre = oempresadt.nombre,
                correo = oempresadt.correo,
                razon = oempresadt.correo,
                telefono = oempresadt.telefono,
                tamaño = oempresadt.tamaño,
                nro_sus = oempresadt.nro_sus
            };
            bd.Empresa.Add(emp);
            bd.SaveChanges();
            oempresadt.id = emp.idempresa;

            return oempresadt;
        }
    }
}