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
    
    public partial class factura_detalle
    {
        public int id_venta_detalle { get; set; }
        public int id_producto { get; set; }
        public int id_factura { get; set; }
        public long importe { get; set; }
    
        public virtual factura factura { get; set; }
        public virtual productos productos { get; set; }
    }
}
