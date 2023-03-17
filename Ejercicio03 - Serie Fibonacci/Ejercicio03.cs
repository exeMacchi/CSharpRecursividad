using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03___Serie_Fibonacci
{
    class Ejercicio03
    {
        static void Main()
        {
            int n1 = 0, n2 = 1;
            int hastaN = PedirNumeroLimite();

            Fibonacci(n1, n2, hastaN);
            Console.WriteLine();
        }
        static int PedirNumeroLimite()
        {
            int hastaX = 0;
            do
            {
	            Console.Write("Cantidad de números de la serie Fibonacci: "); 
                hastaX = Convert.ToInt32(Console.ReadLine());
                
                if (hastaX < 0)
                {
                    Console.WriteLine("Error: el número no puede ser negativo.");
                }

            } while (hastaX < 0);
            Console.WriteLine();

            return hastaX;
        }

        static void Fibonacci(int n1, int n2, int hastaN)
        {
            int n3 = n1 + n2 ;

            if (hastaN == 0)
            {
                return;
            }
            else
            {
                Console.Write(n1 + " ");
                n1 = n2;
                n2 = n3;
                Fibonacci(n1, n2, (hastaN - 1));
            }
        }
    }
}
