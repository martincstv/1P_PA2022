using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Ingles : ILanguageBasics
    {
        public void Agradecer()
        {
            Console.WriteLine("Agradecer:");
            Console.WriteLine("Thank you..!");
        }

        public void Ayudar()
        {
            Console.WriteLine("Ayudar:");
            Console.WriteLine("Can I give you a hand?..");
        }

        public void Despedirse()
        {
            Console.WriteLine("Despedirse:");
            Console.WriteLine("See you later..!");
        }

        public void NoEntiendo()
        {
            Console.WriteLine("No Entiendo:");
            Console.WriteLine("I don't understand..");
        }

        public void Pedir_Ayuda()
        {
            Console.WriteLine("Pedir Ayuda:");
            Console.WriteLine("Can you help me?..");
        }

        public void Saludar()
        {
            Console.WriteLine("Saludar:");
            Console.WriteLine("Hello, nice to meet you..!");
        }
    }
}
