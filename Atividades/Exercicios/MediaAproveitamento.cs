using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividades.Exercicios
{
    internal class MediaAproveitamento
    {
        public static void VerificaMediaAproveitamento()
        {
            Console.WriteLine("Primeira nota: ");
            double nota1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Segunda nota: ");
            double nota2 = int.Parse(Console.ReadLine());

            double mediaAluno = (nota1 + nota2) / 2;

            if (mediaAluno >= 90 && mediaAluno == 100)
            {
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine(" ");
                Console.WriteLine("Desempenho A, média do aluno: " + mediaAluno);
                Console.WriteLine(" ");
                Console.WriteLine("-----------------------------------------------------------");
            }
            else
            {
                if (mediaAluno >= 75 && mediaAluno < 90)
                {
                    Console.WriteLine("-----------------------------------------------------------");
                    Console.WriteLine(" ");
                    Console.WriteLine("Desempenho B, média do aluno: " + mediaAluno);
                    Console.WriteLine(" ");
                    Console.WriteLine("-----------------------------------------------------------");
                }

                else if (mediaAluno >= 60 && mediaAluno < 75)
                {
                    Console.WriteLine("-----------------------------------------------------------");
                    Console.WriteLine(" ");
                    Console.WriteLine("Desempenho C, média do aluno: " + mediaAluno);
                    Console.WriteLine(" ");
                    Console.WriteLine("-----------------------------------------------------------");
                }

                else if (mediaAluno >= 40 && mediaAluno < 60)
                {
                    Console.WriteLine("-----------------------------------------------------------");
                    Console.WriteLine(" ");
                    Console.WriteLine("Desempenho D, média do aluno: " + mediaAluno);
                    Console.WriteLine(" ");
                    Console.WriteLine("-----------------------------------------------------------");
                }

                else if (mediaAluno >= 0 && mediaAluno < 40)
                {
                    Console.WriteLine("-----------------------------------------------------------");
                    Console.WriteLine(" ");
                    Console.WriteLine("Desempenho E, média do aluno :" + mediaAluno);
                    Console.WriteLine(" ");
                    Console.WriteLine("-----------------------------------------------------------");
                }
            }
        }
    }
}

