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
    
    public partial class Pago_Tarjeta
    {
        public int idpago_tarjeta { get; set; }
        public Nullable<int> idpago { get; set; }
        public Nullable<int> idtipo_pago { get; set; }
        public string nombre_titular { get; set; }
        public Nullable<int> numero { get; set; }
        public Nullable<int> mm { get; set; }
        public Nullable<int> aa { get; set; }
        public Nullable<int> cvc { get; set; }
        public Nullable<int> estado { get; set; }
    
        public virtual Pago Pago { get; set; }
        public virtual Tipo_Pago Tipo_Pago { get; set; }
    }
}