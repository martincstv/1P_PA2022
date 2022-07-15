using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo20_Herencia
{
    internal class Trabajador : pERSONA
    {
        public Trabajador(string nombre, string cedula, string genero, int edad) 
            : base(nombre, cedula, genero, edad)
        {
        }
        public float Salario { get; set; }
    }
}
