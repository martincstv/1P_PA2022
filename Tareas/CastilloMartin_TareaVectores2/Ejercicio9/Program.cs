using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Metodos;

namespace Ejercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Queremos guardar la temperatura mínima y máxima de 5 días. realiza un programa que de la 
             * siguiente información:
             * • La temperatura media de cada día
             * • Los días con menos temperatura
             * • Se lee una temperatura por teclado y se muestran los días cuya temperatura máxima 
             * coincide con ella. si no existe ningún día se muestra un mensaje de información.
             */
            Funcion fun = new Funcion();
            int[] temperaturaMinima = new int[] {12, 12, 11, 12, 10};
            int[] temperaturaMaxima = new int[] {22, 21, 23, 24, 20};
            int[] temperaturaMediaDia = new int[5];
            string[] diasSemana = new string[] {"Lunes", "Martes", "Miercoles", "Jueves", "Viernes"};
            for (int i = 0; i < temperaturaMediaDia.Length; i++)
            {
                temperaturaMediaDia[i] = (temperaturaMinima[i] + temperaturaMaxima[i]) / 2;
            }
            fun.ImprimirVector(temperaturaMediaDia);
            int diaMenosTemperatura = Array.IndexOf(temperaturaMinima,temperaturaMinima.Min());
            Console.WriteLine(diasSemana[diaMenosTemperatura]);
            var temperatura = fun.Lectura("Ingrese una temperatura");
            int index = Convert.ToInt32(Array.IndexOf(temperaturaMaxima, temperatura).ToString());
            if (index >= 0)
            {
                Console.WriteLine(diasSemana[index]);
            }
            else
                MessageBox.Show("La temperatura ingresada no coincide con ningún dia..",
            "Mensaje de información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
