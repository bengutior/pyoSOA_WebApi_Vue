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
    public class AlumnoController : ApiController
    {
        [HttpGet]
        [Route("api/AlumnoController/RegistrarDatos")]
        public alumnodt RegistrarDatos(string nom, string ape, string usu, string pass, string corr, string r_w, int tel, int comp_hr, string inte, string esc)
        {
            alumnodt obj = new alumnodt()
            {
                nombres = nom,
                apellidos = ape,
                correo = corr,
                usuario=usu,
                contraseña=pass,
                resp_w = r_w,
                alutelefono = tel,
                compromiso_hr=comp_hr,
                interes=inte,
                escuela=esc
            };
            return Alumno.RegistrarDatos(obj);
        }




/*
        [HttpGet]
        [Route("api/AlumnoController/RegistrarIntereses")]
        public interesdt RegistrarIntereses(int idalumno, string nomescuela, string nominteres)
        {
            interesdt obj = new interesdt()
            {
                idalumno = idalumno,
                interes_nombre = nominteres
            };
            escueladt obj2 = new escueladt()
            {
                idalumno = idalumno,
                esc_nombre = nomescuela
            };
            Escuela.RegistrarEscuelas(obj2);
            return Interes.RegistrarIntereses(obj);
        }



        [HttpPut]
        [Route("api/AlumnoController/RegistrarCompromiso")]
        public alumnodt RegistrarCompromiso(alumnodt oalumnodt)
        {
            alumnodt obj = new alumnodt()
            {
                id = oalumnodt.id,
                compromiso_hr = oalumnodt.compromiso_hr
            };
            return Alumno.RegistrarCompromiso(obj);
        }


        [HttpPut]
        [Route("api/AlumnoController/AccesoContrasena")]
        public alumnodt AccesoContrasena(alumnodt oalumnodt)
        {
            alumnodt obj = new alumnodt()
            {
                id = oalumnodt.id,
                usuario = oalumnodt.usuario,
                contraseña = oalumnodt.contraseña
            };
            return Alumno.AccesoContrasena(obj);
        }*/
    }
}
