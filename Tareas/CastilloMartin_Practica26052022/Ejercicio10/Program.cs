using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * La suma de multiplos de 3 y 7 hasta el #14 son 3,6,7,9,12,14 = 51
             * Cual es la suma hasta el #2000
             */
            List<int> multiplos = new List<int>();
            for (int i = 0; i <= 2000; i++)
            {
                if (i % 3 == 0 || i % 7 == 0)
                    multiplos.Add(i);
            }
            Console.WriteLine($"La suma de los multiplos de 3 y 7 hasta el #2000 es: {multiplos.Sum()}");
        }
    }
}
