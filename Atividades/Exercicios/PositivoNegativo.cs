using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividades.Exercicios
{
    internal class PositivoNegativo
    {
        public static void VerificaPositivoNegativo()
        {
            Console.WriteLine("Número:");
            double numero = double.Parse(Console.ReadLine());

            if (numero > 0)
            {
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine(" ");
                Console.WriteLine("O numero " + numero + " é positivo");
                Console.WriteLine(" ");
                Console.WriteLine("-----------------------------------------------------------");
            }

            else
            {
                if (numero < 0)
                {
                    Console.WriteLine("-----------------------------------------------------------");
                    Console.WriteLine(" ");
                    Console.WriteLine("O numero " + numero + " é negativo");
                    Console.WriteLine(" ");
                    Console.WriteLine("-----------------------------------------------------------");
                }
                else
                {
                    Console.WriteLine("-----------------------------------------------------------");
                    Console.WriteLine(" ");
                    Console.WriteLine("O numero informado é zero");
                    Console.WriteLine("");
                    Console.WriteLine(" ");
                    Console.WriteLine("-----------------------------------------------------------");
                }
            }
        }
    }
}
