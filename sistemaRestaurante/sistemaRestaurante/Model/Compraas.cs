//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace sistemaRestaurante.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Compraas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Compraas()
        {
            this.DetallesCompra = new HashSet<DetallesCompra>();
        }
    
        public int idCompra { get; set; }
        public Nullable<System.DateTime> fechadeCompra { get; set; }
        public Nullable<decimal> totalaPagar { get; set; }
        public Nullable<int> idProveedor { get; set; }
        public string nombredeUsuario { get; set; }
    
        public virtual Proveedores Proveedores { get; set; }
        public virtual Usuarios Usuarios { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetallesCompra> DetallesCompra { get; set; }
    }
}
