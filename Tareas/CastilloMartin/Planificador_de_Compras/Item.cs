using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planificador_de_Compras
{
    class Item
    {
        public string Producto { get; set; }
        public int Cantidad { get; set; }
        public float PrecioU { get; set; }
        public float SubTotal { get; set; }

        public Item(string producto, int cantidad, float precioU, float subTotal)
        {
            Producto = producto;
            Cantidad = cantidad;
            PrecioU = precioU;
            SubTotal = subTotal;
        }
    }
}
