using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05___Invertir_cadena
{
    class Ejercicio05
    {
        static void Main()
        {
            string texto = PedirCadena();

            Console.WriteLine($"El texto al revés: {InvertirCadena(texto)}");
        }

        static string PedirCadena()
        {
            Console.Write("Ingrese un pequeño texto: ");
            return Console.ReadLine();
        }

        static string InvertirCadena (string texto)
        {
            if (texto.Length <= 1)
            {
                return texto;
            }
            else
            {
                return InvertirCadena(texto.Substring(1)) + texto[0];
            }
        }
    }
}
