//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApiRegistro.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Alumno_Empleo
    {
        public int id_alu_empl { get; set; }
        public Nullable<int> idempleo { get; set; }
        public Nullable<int> idalumno { get; set; }
        public Nullable<System.DateTime> fecha_postulacion { get; set; }
    
        public virtual Alumno Alumno { get; set; }
        public virtual Empleo Empleo { get; set; }
    }
}