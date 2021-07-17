using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApiRegistro.Transfers;
using WebApiRegistro.Models;

namespace WebApiRegistro.Models
{
    public partial class Alumno
    {
        //REGISTRAR
        public static alumnodt RegistrarDatos(alumnodt oalumnodt)
        {
            PlatziEntities2 bd = new PlatziEntities2();
            Alumno alu = new Alumno()
            {
                alu_nombres = oalumnodt.nombres,
                aluapellidos = oalumnodt.apellidos,
                alu_correo = oalumnodt.correo,
                alutelefono = oalumnodt.alutelefono,
                resp_w=oalumnodt.resp_w,
            };
            bd.Alumno.Add(alu);
            bd.SaveChanges();
            oalumnodt.id = alu.idalumno;

            return oalumnodt;
        }

        public static alumnodt RegistrarCompromiso(alumnodt oalumnodt)
        {
            PlatziEntities2 bd = new PlatziEntities2();
            Alumno alu = bd.Alumno.Where(t => t.idalumno == oalumnodt.id).SingleOrDefault();
            alu.compromiso_hr = oalumnodt.compromiso_hr;
            bd.Entry(alu).State = EntityState.Modified;
            bd.SaveChanges();
            return Alumno.ObtenerPorId(oalumnodt.id);
        }

        public static alumnodt AccesoContrasena(alumnodt oalumnodt)
        {
            PlatziEntities2 bd = new PlatziEntities2();
            Alumno alu = bd.Alumno.Where(t => t.idalumno == oalumnodt.id).SingleOrDefault();
            alu.usu_nombre = oalumnodt.usuario;
            alu.alu_contrasena = oalumnodt.contraseña;
            bd.Entry(alu).State = EntityState.Modified;
            bd.SaveChanges();
            return Alumno.ObtenerPorId(oalumnodt.id);
        }


        public static alumnodt ObtenerPorId(int idalumno)
        {
            PlatziEntities2 db = new PlatziEntities2();
            Alumno alu = db.Alumno.Where(t => t.idalumno == idalumno).SingleOrDefault();
            alumnodt obj = new alumnodt()
            {
                id = alu.idalumno,
                nombres=alu.alu_nombres,
                apellidos=alu.aluapellidos,
                alutelefono = alu.alutelefono,
                compromiso_hr =alu.compromiso_hr,
                usuario = alu.usu_nombre,
                contraseña = alu.alu_contrasena
            };
            return obj;
        }


    }
}