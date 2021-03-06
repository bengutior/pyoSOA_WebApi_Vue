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
    
    public partial class Alumno
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Alumno()
        {
            this.Interes = new HashSet<Interes>();
            this.Notificaciones = new HashSet<Notificaciones>();
            this.Alumno_Empleo = new HashSet<Alumno_Empleo>();
            this.Itinerario_Aprendizaje = new HashSet<Itinerario_Aprendizaje>();
            this.Suscripcion = new HashSet<Suscripcion>();
        }
    
        public int idalumno { get; set; }
        public Nullable<int> alu_perfil { get; set; }
        public string usu_nombre { get; set; }
        public string alu_correo { get; set; }
        public string alu_contrasena { get; set; }
        public string alu_nombres { get; set; }
        public string aluapellidos { get; set; }
        public string alugenero { get; set; }
        public Nullable<int> alutelefono { get; set; }
        public Nullable<int> idpais { get; set; }
        public Nullable<System.DateTime> alucumpleanos { get; set; }
        public string alunivel { get; set; }
        public string aluexperiencia { get; set; }
        public Nullable<int> alu_tiempo_exp { get; set; }
        public string alu_medio_labor { get; set; }
        public string resp_w { get; set; }
        public Nullable<int> compromiso_hr { get; set; }


        public virtual Perfil Perfil { get; set; }
        public virtual Pais Pais { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Interes> Interes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Notificaciones> Notificaciones { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Alumno_Empleo> Alumno_Empleo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Itinerario_Aprendizaje> Itinerario_Aprendizaje { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Suscripcion> Suscripcion { get; set; }
    }
}
