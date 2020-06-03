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
    
    public partial class ProductosVenta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProductosVenta()
        {
            this.DetallesVenta = new HashSet<DetallesVenta>();
            this.Recetas = new HashSet<Recetas>();
        }
    
        public int idProductoV { get; set; }
        public string nombre { get; set; }
        public Nullable<decimal> precio { get; set; }
        public int idCategoria { get; set; }
    
        public virtual Categorias Categorias { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetallesVenta> DetallesVenta { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Recetas> Recetas { get; set; }
    }
}
