using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Español : ILanguageBasics
    {
        public void Agradecer()
        {
            Console.WriteLine("Agradecer:");
            Console.WriteLine("Gracias..!");
        }

        public void Ayudar()
        {
            Console.WriteLine("Ayudar:");
            Console.WriteLine("     Te puedo ayudar en algo..?");
        }

        public void Despedirse()
        {
            Console.WriteLine("Despedirse:");
            Console.WriteLine("     Te veo pronto..!");
        }

        public void NoEntiendo()
        {
            Console.WriteLine("No Entiendo:");
            Console.WriteLine("     No entiendo nada..!");
        }

        public void Pedir_Ayuda()
        {
            Console.WriteLine("Pedir Ayuda:");
            Console.WriteLine("     Por favor puede ayudarme..?");
        }

        public void Saludar()
        {
            Console.WriteLine("Saludar:");
            Console.WriteLine("     Hola, encantado de conocerte..!");
        }
    }
}
