using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16_Enumeraciones2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona(Persona.Emociones.Enamorado);
            persona.Imprimir();
            Console.ReadKey();
        }
    }
}
