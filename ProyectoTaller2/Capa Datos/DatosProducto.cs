using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTaller2.Capa_Datos
{
    internal class DatosProducto
    {
        public void InsertarProducto(productos nuevoProducto)
        {
            using(var context = new proyecto_taller2Entities())
            {
                context.productos.Add(nuevoProducto);
                context.SaveChanges();
            }
        }

        public List<productos> ObtenerProductos()
        {
            using (var context = new proyecto_taller2Entities())
            {
                return context.productos.ToList();
            }
        }
    }
}
