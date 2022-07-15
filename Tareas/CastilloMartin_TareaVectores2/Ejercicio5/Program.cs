using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Metodos;

namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Hacer un programa que inicialice un vector de números con valores aleatorios, y posterior 
             * ordene los elementos de menor a mayor.
             */
            Funcion fun = new Funcion();
            int[] vectorAleatorios = new int[10];
            fun.CargarVectorRandom(vectorAleatorios, 23);
            Console.WriteLine("     GENERADO ALEATORIO");
            fun.ImprimirVector(vectorAleatorios);
            var vectorOrdenado = vectorAleatorios.OrderBy(x => x).ToArray();
            Console.WriteLine("     ORDENADO");
            fun.ImprimirVector(vectorOrdenado);
        }
    }
}
