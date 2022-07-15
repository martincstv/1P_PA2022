using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo08_For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int limiteSuperior = 20;
            Console.WriteLine("IMPRIMIR LOS NUMEROS DEL 1 AL 20");
            //for (int i = 1; i <= limiteSuperior; i++)
            //{
            //    Console.WriteLine("Valor: {0}", i);
            //}
            //for (int i = limiteSuperior; i >= 1; i--)
            //{
            //    Console.WriteLine("Valor: {0}", i);
            //}
            for (int i = limiteSuperior; i >= 1; i -= 3)
            {
                Console.WriteLine("Valor: {0}", i);
            }
        }
    }
}
