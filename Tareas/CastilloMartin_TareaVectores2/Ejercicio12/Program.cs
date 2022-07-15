using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Metodos;

namespace Ejercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Diseñar el algoritmo correspondiente a un programa, que:
             * • Crea una tabla bidimensional de longitud 5x15 y nombre ‘marco’.
             * • Carga la tabla con dos únicos valores 0 y 1, donde el valor uno ocupará las posiciones 
             * o elementos que delimitan la tabla, es decir, las más externas, mientras que el resto 
             * de los elementos contendrán el valor 0.
             * • 111111111111111
             * • 100000000000001
             * • 100000000000001
             * • 100000000000001
             * • 111111111111111
             * • Visualiza el contenido de la matriz en pantalla.
             */
            Funcion fun = new Funcion();
            byte[,] marco = new byte[5, 15] {{1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},
                                             {1,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
                                             {1,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
                                             {1,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
                                             {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1}};
            fun.ImprimirMatrizBidimensional(marco);

        }
    }
}
