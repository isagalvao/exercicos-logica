using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividades.Exercicios
{
    internal class CalculaAreaQuadrado
    {
        public static void CalculaQuadrado()
        {
            Console.WriteLine("Informe o lado do quadrado:");
            int lado = int.Parse(Console.ReadLine());

            int area = lado * lado;
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine(" ");
            Console.WriteLine("A área do quadrado é de:" + area );
            Console.WriteLine("O dobro da area do quadrado é de:" + area*2);
            Console.WriteLine(" ");
            Console.WriteLine("-----------------------------------------------------------");
        }
    }
}
