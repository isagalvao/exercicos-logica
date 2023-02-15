using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividades.Exercicios
{
    internal class MaiorMenor
    {
        public static void VerificaMaiorMenor()
        {
            int i = 0;
            int tl = 0;
            double maior = 0;
            double menor = 0;
            Double[] valores = new Double[50];

            Console.WriteLine("Quantos números deseja informar:");
            tl = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i < tl; i++)
            {
                Console.WriteLine("Informe um número:");
                valores[i] = Convert.ToDouble(Console.ReadLine());
            }

            i = 0;

            if (tl > 0) 
            {
                maior = valores[0];
                menor = valores[0];

                for (i = 1; i < tl; i++)
                {
                    if(maior < valores[i])
                    {
                        maior = valores[i];
                    }

                    if (menor > valores[i])
                    {
                        menor = valores[i];
                    }
                }
             }

            else 
            {
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine(" ");
                Console.WriteLine("Nenhum valor informado!");
                Console.WriteLine(" ");
                Console.WriteLine("-----------------------------------------------------------");
            }
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine(" ");
            Console.WriteLine("Maior valor: "+ maior);
            Console.WriteLine("Menor valor: "+ menor);
            Console.WriteLine(" ");
            Console.WriteLine("-----------------------------------------------------------");
            Console.ReadKey();
        }
    }
}
