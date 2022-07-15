using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomaPedidos
{
    public class Cliente
    {
        public int Id { get; set; }
        public string CedulaRuc { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Direccion { get; set; }

        public Cliente(int id, string cedulaRuc, string apellido, string nombre, string telefono, string celular, string direccion)
        {
            Id = id;
            CedulaRuc = cedulaRuc;
            Apellido = apellido;
            Nombre = nombre;
            Telefono = telefono;
            Celular = celular;
            Direccion = direccion;
        }
    }
}
