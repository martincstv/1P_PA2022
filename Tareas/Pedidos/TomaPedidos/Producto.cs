﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomaPedidos
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public float Precio { get; set; }

        public Producto(int id, string nombre, float precio)
        {
            Id = id;
            Nombre = nombre;
            Precio = precio;
        }
    }
}
