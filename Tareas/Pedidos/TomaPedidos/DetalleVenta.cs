using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomaPedidos
{
    public class DetalleVenta
    {
        public string NombreProducto { get; set; }
        public float Precio { get; set; }
        public int Cantidad { get; set; }
        public float Subtotal { get; set; }

        public DetalleVenta(string nombreProducto, float precio, int cantidad, float subtotal)
        {
            NombreProducto = nombreProducto;
            Precio = precio;
            Cantidad = cantidad;
            Subtotal = subtotal;
        }
    }
}
