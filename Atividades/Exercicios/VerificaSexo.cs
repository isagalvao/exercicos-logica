using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividades.Exercicios
{
    internal class VerificaSexo
    {
        public static void VerificaLetra()
        {

            Console.WriteLine("Digite F - Feminino, M - Masculino:");
            string verificaLetra = Console.ReadLine();

            if (verificaLetra == "F" && verificaLetra == "f")
            {
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine(" ");
                Console.WriteLine("Sexo feminino");
                Console.WriteLine(" ");
                Console.WriteLine("-----------------------------------------------------------");
            }
            else
            {
                if (verificaLetra == "M" && verificaLetra == "m") 
                {
                    Console.WriteLine("-----------------------------------------------------------");
                    Console.WriteLine(" ");
                    Console.WriteLine("Sexo masculino");
                    Console.WriteLine(" ");
                    Console.WriteLine("-----------------------------------------------------------");

                }
                else
                {
                    Console.WriteLine("-----------------------------------------------------------");
                    Console.WriteLine(" ");
                    Console.WriteLine("Sexo invalido");
                    Console.WriteLine(" ");
                    Console.WriteLine("-----------------------------------------------------------");
                }
            }
        }
    }
}
