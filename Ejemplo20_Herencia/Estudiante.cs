using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo20_Herencia
{
    internal class Estudiante : pERSONA
    {
        public Estudiante(string nombre, string cedula, string genero, int edad) : base(nombre, cedula, genero, edad)
        {
        }

        public int Creditos { get; set; }
    }
}
