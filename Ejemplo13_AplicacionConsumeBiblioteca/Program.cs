using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Ejemplo13_BibliotecaClases;
namespace Ejemplo13_AplicacionConsumeBiblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valor1 = 100, valor2 = 4;
            Operaciones operaciones = new Operaciones();
            Console.WriteLine("Suma: 100 y 4 = {0}", operaciones.Sumar(valor1, valor2));
            Console.WriteLine("Resta: 100 y 4 = {0}", operaciones.Restar(valor1, valor2));
            Console.WriteLine("Multiplicacion: 100 y 4 = {0}", operaciones.Multiplicar(valor1, valor2));
            Console.WriteLine("Division: 100 y 4 = {0}", operaciones.Dividir(valor1, valor2));
            Console.WriteLine("Potencia: 100 y 4 = {0}", operaciones.Potencia(valor1, valor2));
            Console.WriteLine("Residuo: 100 y 4 = {0}", operaciones.Residuo(valor1, valor2));
            Console.WriteLine("Mayor: 100 y 4 = {0}", operaciones.MayorDeDosNumeros(valor1, valor2));

            Console.ReadKey();
        }
    }
}
