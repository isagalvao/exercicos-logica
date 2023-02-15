using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividades.Exercicios
{
    internal class MediaAluno
    {
        public static void VerificaMediaAluno()
        {
            Console.WriteLine("Primeira nota: ");
            double nota1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Segunda nota: ");
            double nota2 = int.Parse(Console.ReadLine());

            double mediaAluno = (nota1 + nota2) / 2;

            if (mediaAluno < 70)
            {
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine(" ");
                Console.WriteLine("Aluno Reprovado, por baixo desempenho");
                Console.WriteLine(" ");
                Console.WriteLine("-----------------------------------------------------------");
            }
            else
            {
                if (mediaAluno == 100)
                {
                    Console.WriteLine("-----------------------------------------------------------");
                    Console.WriteLine(" ");
                    Console.WriteLine("Aprovado com Distinção");
                    Console.WriteLine(" ");
                    Console.WriteLine("-----------------------------------------------------------");
                }

                else if (mediaAluno >= 70)
                {
                    Console.WriteLine("-----------------------------------------------------------");
                    Console.WriteLine(" ");
                    Console.WriteLine("Aluno Aprovado");
                    Console.WriteLine(" ");
                    Console.WriteLine("-----------------------------------------------------------");
                }    
            }
        }

    }
}
