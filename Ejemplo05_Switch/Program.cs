using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo05_Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
           * Comentario Multilinea
           * Salario de la persona es >= $500 => entonces el impuesto es de $30
           * Salario de la persona es < $500 => entonces el impuesto es de $20
           */
            var numero = 0;
            Console.WriteLine("IMPRESION DE UN NUMERO EN TEXTO");
            Console.Write("Por favor ingrese un numero entre 0 y 8: ");
            numero = Convert.ToInt32(Console.ReadLine());
            switch (numero)
            {
                case 1:
                    Console.WriteLine("UNO");
                    break;
                case 2:
                    Console.WriteLine("DOS");
                    break;
                case 3:
                    Console.WriteLine("TRES");
                    break;
                case 4:
                    Console.WriteLine("CUATRO");
                    break;
                case 5:
                    Console.WriteLine("CINCO");
                    break;
                case 6:
                    Console.WriteLine("SEIS");
                    break;
                case 7:
                    Console.WriteLine("SIETE");
                    break;
                case 8:
                    Console.WriteLine("OCHO");
                    break;
                default:
                    Console.WriteLine("El número ingresado no es esta dentro de las opciones..");
                    break;
            }
            Console.ReadKey();
            //Switch con rangos case > case < ;
        }
    }
}
