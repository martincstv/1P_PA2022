using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Metodos;

namespace Ejercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Diseñar el algoritmo correspondiente a un programa, que:
             * • Crea una tabla bidimensional de longitud 5x5 y nombre ‘diagonal’.
             * • Carga la tabla de forma que los componentes pertenecientes a la diagonal de la matriz 
             * tomen el valor 1 y el resto el valor 0.
             * • Muestra el contenido de la tabla en pantalla.
             */
            Funcion fun = new Funcion();
            int[,] diagonal = new int[5,5] { {1,0,0,0,0},
                                             {0,1,0,0,0},
                                             {0,0,1,0,0},
                                             {0,0,0,1,0},
                                             {0,0,0,0,1}};
            fun.ImprimirMatrizBidimensional(diagonal);
        }
    }
}
