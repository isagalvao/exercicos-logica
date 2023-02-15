using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividades.Exercicios
{
    internal class MaiorDeDois
    {
        public static void VerificaMaiorNumero()
        {
            Console.WriteLine("Primeiro número: ");
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Segundo número: ");
            int numero2 = int.Parse(Console.ReadLine());

            if (numero1 > numero2)
            {
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine(" ");
                Console.WriteLine(numero1 + " é maior que " + numero2);
                Console.WriteLine(" ");
                Console.WriteLine("-----------------------------------------------------------");
            }
            else
            {
                if (numero2 > numero1)
                {
                    Console.WriteLine("-----------------------------------------------------------");
                    Console.WriteLine(" ");
                    Console.WriteLine(numero2 + " é maior que " + numero1);
                    Console.WriteLine(" ");
                    Console.WriteLine("-----------------------------------------------------------");
                }
                else
                {
                    Console.WriteLine("-----------------------------------------------------------");
                    Console.WriteLine(" ");
                    Console.WriteLine(" Os valores são iguais");
                    Console.WriteLine("-----------------------------------------------------------");
                    Console.WriteLine(" ");
                }
            }
        }
    }
}
