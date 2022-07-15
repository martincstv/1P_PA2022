using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Frances : ILanguageBasics
    {
        public void Agradecer()
        {
            Console.WriteLine("Agradecer:");
            Console.WriteLine("     Merci..!");
        }

        public void Ayudar()
        {
            Console.WriteLine("Ayudar:");
            Console.WriteLine("     Je peux vous aider avec quelque chose..?");
        }

        public void Despedirse()
        {
            Console.WriteLine("Despedirse:");
            Console.WriteLine("A plus tard..!");
        }

        public void NoEntiendo()
        {
            Console.WriteLine("No Entiendo:");
            Console.WriteLine("     Je ne comprends rien..!");
        }

        public void Pedir_Ayuda()
        {
            Console.WriteLine("Pedir Ayuda:");
            Console.WriteLine("     peut m'aider..?");
        }

        public void Saludar()
        {
            Console.WriteLine("Saludar:");
            Console.WriteLine("Bonjour, ravi de vous rencontrer..!");
        }
    }
}
