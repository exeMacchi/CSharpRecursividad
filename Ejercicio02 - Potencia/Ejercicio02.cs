using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02___Potencia
{
    class Ejercicio02
    {
        static void Main()
        {
            // Desarrollar una función potencia recursiva

            // Se le pide al usuario tanto la base como el exponente, se realiza el
            // cálculo, y se muestra en pantalla el resultado.
            MostrarPotencia( PedirBase(), PedirExponente() );
        }

        static int PedirBase()
        {
            Console.Write("Ingrese la base: ");
            int basePotencia = Convert.ToInt32(Console.ReadLine());
            return basePotencia;
        }

        static int PedirExponente()
        {
            int exponentePotencia = 0;

            do
            {
                Console.Write("Ingrese el exponente: ");
                exponentePotencia = Convert.ToInt32(Console.ReadLine());
                if (exponentePotencia < 0)
                {
                    Console.WriteLine("Error: el exponente no puede ser negativo.");
                }
            } while (exponentePotencia < 0);

            return exponentePotencia;
        }

        static void MostrarPotencia(int basePotencia, int exponentePotencia)
        {
            Console.WriteLine($"{basePotencia} ^ {exponentePotencia} = " +
                              $"{Potencia(basePotencia, exponentePotencia)}");
        }

        static int Potencia(int basePotencia, int exponentePotencia)
        {
            int resultado = 1;

            if (exponentePotencia == 0)
            {
                return resultado;
            }
            else
            {
                resultado = basePotencia * Potencia(basePotencia, 
                                                   (exponentePotencia - 1));
            }

            return resultado;
        }
    }
}
