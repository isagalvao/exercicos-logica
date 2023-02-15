using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividades.Exercicios
{
    internal class CaixaEletrônico
    {

        public static void Caixa()
        {
            Console.WriteLine("Digite o valor que deseja sacar:");
            int valor = Convert.ToInt32(Console.ReadLine());

            int n100 = valor / 100;
            int resto = valor - (n100 * 100);

            int n50 = resto / 50;
            resto = resto - (n50 * 50);

            int n20 = resto / 20;
            resto = resto - (n20 * 20);

            int n10 = resto / 10;
            resto = resto - (n10 * 10);

            int n5 = resto / 5;
            resto = resto - (n5 * 5);

            int n1 = resto / 1;
            resto = resto - (n1* 1);

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine(" ");
            Console.WriteLine("Quantidade de notas:");
            Console.WriteLine();
            Console.WriteLine("Notas de 100R$:  " + n100);
            Console.WriteLine();
            Console.WriteLine("Notas de 50R$:  " + n50);
            Console.WriteLine();
            Console.WriteLine("Notas de 20R$:  " + n20);
            Console.WriteLine();
            Console.WriteLine("Notas de 10R$:  " + n10);
            Console.WriteLine();
            Console.WriteLine("Notas de 5R$:  " + n5);
            Console.WriteLine();
            Console.WriteLine("Notas de 1R$:  " + n1);
            Console.WriteLine(" ");
            Console.WriteLine("--------------------------------------------------");
            Console.ReadKey();
        }
    }
}
