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
    
    public partial class Empleo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Empleo()
        {
            this.Alumno_Empleo = new HashSet<Alumno_Empleo>();
        }
    
        public int idempleo { get; set; }
        public Nullable<int> idempl_ciudad { get; set; }
        public Nullable<int> idcat { get; set; }
        public string empl_modalidad { get; set; }
        public Nullable<System.DateTime> empl_fec_publ { get; set; }
        public string empl_detalle { get; set; }
        public string empl_nom_emp { get; set; }
        public string empl_titulo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Alumno_Empleo> Alumno_Empleo { get; set; }
        public virtual Categoria_Empleo Categoria_Empleo { get; set; }
        public virtual Ciudad Ciudad { get; set; }
    }
}
