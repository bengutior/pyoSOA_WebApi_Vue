using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;
using WebApi.Transfers;

namespace WebApi.Controllers
{
    public class EmpresaController : ApiController
    {
        [HttpGet]
        [Route("api/EmpresaController/RegistrarDatos")]
        public empresadt RegistrarDatos(string nom, string corr, string raz, string tel, string tam, int n_s)
        {
            empresadt obj = new empresadt()
            {
                nombre = nom,
                correo = corr,
                razon = raz,
                telefono = tel,
                tamaño = tam,
                nro_sus = n_s

            };
            return Empresa.RegistrarDatos(obj);
        }
    }
}
