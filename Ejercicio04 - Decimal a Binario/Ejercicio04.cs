using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04___Decimal_a_Binario
{
    class Ejercicio04
    {
        static void Main()
        {
            int numero = PedirNumero();
            string resultado = DecimalABinario(numero);
            Console.WriteLine($"El número {numero} en binario es: {resultado}");
            Console.ReadKey();
        }

        static int PedirNumero()
        {
            Console.Write("Ingrese un número decimal: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        static string DecimalABinario(int numero)
        {
            if (numero <= 1)
            {
                return numero.ToString();
            }
            else
            {
                return DecimalABinario(numero / 2) + (numero % 2).ToString();
            }
        }
    }
}
