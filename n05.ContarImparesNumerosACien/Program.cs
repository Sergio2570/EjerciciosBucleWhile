using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 
Incluir en algoritmo anterior las suma de cuántos números
impares se muestran.
 */
namespace n05.ContarImparesNumerosACien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("Introduce un número positivo menor que 100");
            if (int.TryParse(Console.ReadLine(), out int num1))
            {
                if (0 <= num1 && num1 < 100)
                {
                    if (num1 % 2 == 0)
                    {
                        num1++;
                        while (num1 < 100)
                        {
                            Console.WriteLine(num1);
                            num1 = num1 + 2;
                            count++;
                        }
                    }
                    else
                    {
                        while (num1 < 100)
                        {
                            Console.WriteLine(num1);
                            num1 = num1 + 2;
                            count++;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("El dato introducido no está en el rango aceptable");
                }

            }
            else
            {
                Console.WriteLine("El dato introducido no es válido");
            }
            Console.WriteLine($"El contador de números es: {count}");
            Console.WriteLine("\nPulsa una tecla para finalizar");
            Console.ReadKey();
        }
    }
}
