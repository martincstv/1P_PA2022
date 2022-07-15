using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo07_DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int limiteSuperior = 20;
            int contador = 1;
            Console.WriteLine("IMPRIMIR LOS NUMEROS DEL 1 AL 20");
            do
            {
                Console.WriteLine("Valor: {0}", contador);
                contador += 1;
            } while (contador <= limiteSuperior);
        }
    }
}
