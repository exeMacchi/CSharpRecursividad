using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01___Factorial
{
    class Ejercicio01
    {
        static void Main()
        {
            // Desarrollar una funcion factorial recursiva.

            // Se pide un número al usuario, se realiza el factorial y se muestra en
            // pantalla
            MostrarFactorial(PedirNumero());
        }

        static int PedirNumero()
        {
            Console.Write("Ingrese un número: ");
            int num = Convert.ToInt32(Console.ReadLine());
            return num;
        }

        static void MostrarFactorial(int numUsuario)
        {
            Console.WriteLine($"El factorial de {numUsuario} es: " +
                              $"{Factorial(numUsuario)}");
        }

        static int Factorial(int numUsuario)
        {
            int resultado = 1; 

            if (numUsuario == 0)
            {
                return resultado;
            }
            else
            {
                resultado = numUsuario * Factorial(numUsuario - 1);
            }

            return resultado;
        }
    }
}
