using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 
Solicitados cinco números por teclado, calcular cuál es el
de mayor valor y cuál el de menor y mostrarlos por pantalla. 
 */
namespace n09.MayorYMenor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0, menor = 2147483647, mayor = 0, count = 0;
            Console.WriteLine("Dame 5 números por teclado");
            while (count < 5)
            {
                if (int.TryParse(Console.ReadLine(), out num))
                {
                    if (num < menor)
                    {
                        menor = num;
                    }
                    else
                    {
                        if (mayor < num)
                        {
                            mayor = num;
                        }
                    }
                    count++;
                }
                else
                {
                    Console.WriteLine("Dato introducido inválido"); //Como Clarita
                }
            }
            Console.WriteLine($"El menor es {menor} y el mayor es {mayor}");
            Console.WriteLine("\nPulsa una tecla para finalizar");
            Console.ReadKey();
        }
    }
}