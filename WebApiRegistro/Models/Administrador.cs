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
    
    public partial class Administrador
    {
        public int idadministrador { get; set; }
        public string usunombre { get; set; }
        public Nullable<int> perfil { get; set; }
        public string correo { get; set; }
        public string contrasena { get; set; }
        public string estado { get; set; }
    
        public virtual Perfil Perfil1 { get; set; }
    }
}
