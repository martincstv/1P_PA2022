using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo20_Herencia
{
    internal class pERSONA
    {
        public pERSONA(string nombre, string cedula, string genero, int edad)
        {
            Nombre = nombre;
            Cedula = cedula;
            Genero = genero;
            Edad = edad;
        }

        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string Genero { get; set; }
        public int Edad { get; set; }
    }
}
