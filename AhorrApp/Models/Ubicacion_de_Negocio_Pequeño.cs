//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AhorrApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ubicacion_de_Negocio_Pequeño
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ubicacion_de_Negocio_Pequeño()
        {
            this.Flujo = new HashSet<Flujo>();
        }
    
        public int negocioid { get; set; }
        public string descripcion { get; set; }
        public string direccion { get; set; }
        public string distrito { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Flujo> Flujo { get; set; }
    }
}
