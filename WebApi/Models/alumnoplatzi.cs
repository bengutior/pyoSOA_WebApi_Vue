using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApi.Transfers;

namespace WebApi.Models
{
    public partial class Alumno
    {

            //REGISTRAR
            public static alumnodt RegistrarDatos(alumnodt oalumnodt)
            {
                PlatziEntities1 bd = new PlatziEntities1();
                Alumno alu = new Alumno()
                {
                    alu_nombres = oalumnodt.nombres,
                    aluapellidos = oalumnodt.apellidos,
                    alu_correo = oalumnodt.correo,
                    usu_nombre = oalumnodt.usuario,
                    alu_contrasena = oalumnodt.contraseña,
                    alutelefono = oalumnodt.alutelefono,
                    resp_w = oalumnodt.resp_w,
                    compromiso_hr=oalumnodt.compromiso_hr,                    
                    interes=oalumnodt.interes,
                    escuela=oalumnodt.escuela
                };
                bd.Alumno.Add(alu);
                bd.SaveChanges();
                oalumnodt.id = alu.idalumno;

                return oalumnodt;
            }


            public static alumnodt ObtenerPorId(int idalumno)
            {
                PlatziEntities1 db = new PlatziEntities1();
                Alumno alu = db.Alumno.Where(t => t.idalumno == idalumno).SingleOrDefault();
                alumnodt obj = new alumnodt()
                {
                    id = alu.idalumno,
                    nombres = alu.alu_nombres,
                    apellidos = alu.aluapellidos,
                    alutelefono = alu.alutelefono,
                    compromiso_hr = alu.compromiso_hr,
                    usuario = alu.usu_nombre,
                    contraseña = alu.alu_contrasena
                };
                return obj;
            }


        /*
            public static alumnodt RegistrarCompromiso(alumnodt oalumnodt)
            {
                PlatziEntities bd = new PlatziEntities();
                Alumno alu = bd.Alumno.Where(t => t.idalumno == oalumnodt.id).SingleOrDefault();
                alu.compromiso_hr = oalumnodt.compromiso_hr;
                bd.Entry(alu).State = EntityState.Modified;
                bd.SaveChanges();
                return Alumno.ObtenerPorId(oalumnodt.id);
            }

            public static alumnodt AccesoContrasena(alumnodt oalumnodt)
            {
                PlatziEntities bd = new PlatziEntities();
                Alumno alu = bd.Alumno.Where(t => t.idalumno == oalumnodt.id).SingleOrDefault();
                alu.usu_nombre = oalumnodt.usuario;
                alu.alu_contrasena = oalumnodt.contraseña;
                bd.Entry(alu).State = EntityState.Modified;
                bd.SaveChanges();
                return Alumno.ObtenerPorId(oalumnodt.id);
            }


            public static alumnodt ObtenerPorId(int idalumno)
            {
                PlatziEntities db = new PlatziEntities();
                Alumno alu = db.Alumno.Where(t => t.idalumno == idalumno).SingleOrDefault();
                alumnodt obj = new alumnodt()
                {
                    id = alu.idalumno,
                    nombres = alu.alu_nombres,
                    apellidos = alu.aluapellidos,
                    alutelefono = alu.alutelefono,
                    compromiso_hr = alu.compromiso_hr,
                    usuario = alu.usu_nombre,
                    contraseña = alu.alu_contrasena
                };
                return obj;
            }*/

    }
}