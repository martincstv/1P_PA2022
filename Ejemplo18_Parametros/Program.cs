using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo18_Parametros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor = 10;
            Console.WriteLine($"Valor: {valor}");

            int resultado = Duplicar(ref valor);//out
            Console.WriteLine($"Resultado: {resultado}");

            Console.WriteLine($"Valor: {valor}");
            Console.ReadKey();

        }

        private static int Duplicar(ref int valorEnFuncion)
        {
            valorEnFuncion *= 2;
            return valorEnFuncion;
        }
    }
}
