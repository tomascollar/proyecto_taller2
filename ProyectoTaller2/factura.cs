//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoTaller2
{
    using System;
    using System.Collections.Generic;
    
    public partial class factura
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public factura()
        {
            this.factura_detalle = new HashSet<factura_detalle>();
        }
    
        public int id_factura { get; set; }
        public System.DateTime fecha { get; set; }
        public string tipo_pago { get; set; }
        public int id_cliente { get; set; }
        public int id_usuario { get; set; }
    
        public virtual clientes clientes { get; set; }
        public virtual usuario usuario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<factura_detalle> factura_detalle { get; set; }
    }
}
