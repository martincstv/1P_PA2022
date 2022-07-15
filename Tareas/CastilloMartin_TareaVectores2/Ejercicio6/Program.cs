using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Metodos;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Crea un programa que pida un número al usuario un número de mes (por ejemplo, el 4) y diga 
             * cuántos días tiene (por ejemplo, 30) y el nombre del mes. Debes usar un vector. Para 
             * simplificarlo vamos a suponer que febrero tiene 28 días.
             */
            Funcion fun = new Funcion();
            int[] diasMes = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            string[] meses = new string[] {"Enero", "Febrero", "Marzo", "Abril",
                                            "Mayo","Junio","Julio","Agosto",
                                            "Septiembre","Octubre","Noviembre","Diciembre"};
            var numeroMes = fun.Lectura("Ingrese el número de un mes");
            Console.WriteLine($"{meses[numeroMes - 1]} tiene {diasMes[numeroMes - 1]} días");

        }
    }
}
