using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Metodos;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Realizar un programa que defina un vector llamado “vector_numeros” de 10 enteros, a
             * continuación lo inicialice con valores aleatorios (del 1 al 10) y posteriormente muestre en
             * pantalla cada elemento del vector junto con su cuadrado y su cubo.
             */
            Funcion fun = new Funcion();
            int[] vector_numeros = new int[10];
            fun.CargarVectorRandom(vector_numeros,1,10);
            foreach (var item in vector_numeros)
            {
                Console.WriteLine($"Elemento: {item} su cuadrado {Math.Pow(item,2)} y su cubo {Math.Pow(item,3)}");
            }
        }
    }
}
