using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo10_Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Saludar();
            //Console.WriteLine(DevolverPrimerNombre());
            //foreach (var item in DevolverNumeroAccidentesTransito())
            //{
            //    Console.WriteLine("Cantidad de Accidentes: {0}", item);
            //}
            foreach (var item in DevolverNumeroAccidentesTransitoMayoresAlValor2(7))
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
        static void Saludar()
        {
            Console.WriteLine("Saludos terricolas..!!");
        }

        static string DevolverPrimerNombre()
        {
            return "Martin";
        }

        static float DevolverEstaturaEnMetros()
        {
            return 1.66F;
        }
        /// <summary>
        /// El metodo devuelve la cantidad de accidentes de transito en Ambato, a travez de una lista de Enteros
        /// </summary>
        /// <returns>Retorna los ultimos 5 dias de accidentes de transito</returns>
        static List<int> DevolverNumeroAccidentesTransito()
        {
            List<int> numeroAccidentes = new List<int>() { 5, 6, 7, 8, 9, 10 };
            return numeroAccidentes;
        }

        /// <summary>
        /// El metodo devuelve la cantidad de accidentes de transito en Ambato, a travez de una lista de Enteros
        /// </summary>
        /// <returns>Retorna los ultimos 5 dias de accidentes de transito</returns>
        static List<int> DevolverNumeroAccidentesTransitoMayoresAlValor(int valorReferencia)
        {
            //Lista total de casos
            List<int> numeroAccidentes = new List<int>() { 5, 6, 7, 8, 9, 10 };
            //Lista resultado de la busqueda por valor de referencia
            List<int> listaFiltrada = new List<int>();
            //Algoritmo de Seleccion de dependencia de parametro
            foreach (var item in numeroAccidentes)
            {
                if (item > valorReferencia)
                    listaFiltrada.Add(item);
            }
            return listaFiltrada;
        }

        static List<int> DevolverNumeroAccidentesTransitoMayoresAlValor2(int valorReferencia)
        {
            //Expresiones Lambda
            List<int> numeroAccidentes = new List<int>() { 5, 6, 7, 8, 9, 10 };
            return numeroAccidentes.Where(x => x > valorReferencia).ToList();
        }
    }
}
