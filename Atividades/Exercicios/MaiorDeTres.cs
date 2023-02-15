using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividades.Exercicios
{
    internal class MaiorDeTres
    {
        public static void MaiorDeTresNumeros()
        {
            Console.WriteLine("Primeiro número: ");
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Segundo número: ");
            int numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Terceiro número: ");
            int numero3 = int.Parse(Console.ReadLine());

            if (numero1 > numero2)
            {
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine(" ");
                Console.WriteLine("O maior número é o" + numero1);
                Console.WriteLine(" ");
                Console.WriteLine("-----------------------------------------------------------");
            }
            else
            {
                if (numero2 > numero1)
                {
                    Console.WriteLine("-----------------------------------------------------------");
                    Console.WriteLine(" ");
                    Console.WriteLine("O maior número é o " + numero2);
                    Console.WriteLine(" ");
                    Console.WriteLine("-----------------------------------------------------------");
                }

                else
                {
                    Console.WriteLine("-----------------------------------------------------------");
                    Console.WriteLine(" ");
                    Console.WriteLine("O maior número é o " + numero3);
                    Console.WriteLine(" ");
                    Console.WriteLine("-----------------------------------------------------------");
                }
            }
        }
    }
}
