using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06___Palindromo
{
    class Ejercicio06
    {
        static void Main()
        {
            string texto = PalabraUOracion(PedirPalabra());

            bool palindromo = EsPalindromo(texto.ToUpper());

            MostrarResultado(palindromo);
        }

        static string PedirPalabra()
        {
            Console.Write("Ingrese una palabra: ");
            return Console.ReadLine();
        }

        static bool EsPalindromo(string texto)
        {
            bool palindromo = false;

            if (texto.Length <= 1)
            {
                palindromo = true;
            }
            else if (texto[0] != texto[texto.Length - 1])
            {
                palindromo = false;
            }
            else 
            {
                palindromo = EsPalindromo(texto.Substring(1, texto.Length - 2));
            }

            return palindromo;
        }

        static void MostrarResultado(bool esPalindromo)
        {
            if (esPalindromo)
            {
                Console.WriteLine("La palabra es palíndroma.");
            }
            else
            {
                Console.WriteLine("La palabra no es palíndroma.");
            }
        }

        static string PalabraUOracion(string palabra)
        {
            if (palabra.Contains(" "))
            {
                string[] oracionUnida = palabra.Split();

                return string.Join("", oracionUnida);
            }
            else
            {
                return palabra;
            }
        }
    }
}
