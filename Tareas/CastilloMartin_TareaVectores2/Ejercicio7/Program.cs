using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Metodos;
namespace Ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Programa que declare tres vectores ‘vector1’, ‘vector2’ y ‘vector3’ de cinco enteros cada uno, 
             * pida valores para ‘vector1’ y ‘vector2’ y calcule vector3 = vector1 + vector2.
             */
            Funcion fun = new Funcion();
            int[] vector1 = new int[5];
            int[] vector2 = new int[5];
            int[] vector3 = new int[5];
            Console.WriteLine("     CARGAR VECTOR 1");
            fun.CargarVector(vector1);
            Console.WriteLine("     CARGAR VECTOR 2");
            fun.CargarVector(vector2);
            for (int i = 0; i < vector1.Length; i++)
            {
                vector3[i] = vector1[i] + vector2[i];
            }
            Console.WriteLine("     IMPRIMIR VECTOR 3");
            fun.ImprimirVector(vector3);
        }
    }
}
