using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16_Enumeraciones2
{
    public class Persona
    {
        public Emociones EmocionPersona { get; set; }

        public enum Emociones
        {
            Feliz,
            Triste,
            Enojado,
            Asustado,
            Cansado,
            Enamorado,
            Estresado,
            Engañado,
            TasiturnoCuansiPerfecto
        }

        public Persona(Emociones emociones)
        {
            EmocionPersona = emociones;
        }

        public void Imprimir()
        {
            string mensaje = string.Empty;
            switch (EmocionPersona)
            {
                case Emociones.Feliz:
                    mensaje = "Ay, que bonita que es la vida!!";
                    break;
                case Emociones.Triste:
                    mensaje = "Maldita traición!!";
                    break;
                case Emociones.Enojado:
                    mensaje = "Estoy enojado!!";
                    break;
                case Emociones.Asustado:
                    mensaje = "Que susto";
                    break;
                case Emociones.Cansado:
                    mensaje = "Estoy en programacion avanzada";
                    break;
                case Emociones.Enamorado:
                    mensaje = "Te doy una cancion";
                    break;
                case Emociones.Estresado:
                    mensaje = "Estoy en programacion avanzada";
                    break;
                case Emociones.Engañado:
                    mensaje = "El santo cachon";
                    break;
                case Emociones.TasiturnoCuansiPerfecto:
                    mensaje = "Regueton feo";
                    break;
                default:
                    break;
            }
            Console.WriteLine(mensaje);
        }
    }
}
