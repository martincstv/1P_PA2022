using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Metodos;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Crear un vector de 5 elementos de cadenas de caracteres, inicializa el vector con datos leídos
             * por el teclado. Copia los elementos del vector en otro vector pero en orden inverso, y
             * muéstralo por la pantalla.
             */
            Funcion fun = new Funcion();
            string[] cadenas = new string[5];
            string[] cadenas2 = new string[5];
            Console.WriteLine("     INGRESAR NOMBRES");
            fun.CargarVector(cadenas);
            cadenas2 = cadenas.Reverse().ToArray();
            Console.WriteLine("     ELEMENTOS EN ORDEN INVERSO");
            fun.ImprimirVector(cadenas2);
        }
    }
}
