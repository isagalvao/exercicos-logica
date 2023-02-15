using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividades.Exercicios
{
    internal class CalculaAreaCirculo
    {

        public static void Calcula()
        {
            Console.WriteLine("Informe o tamanho do raio do circulo para que seja calculado a área.");
            double raio = double.Parse(Console.ReadLine());

            double areaDoCirculo = Math.Round(Math.PI * (raio * raio));
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine(" ");
            Console.WriteLine("A área do circulo é:" + areaDoCirculo);
            Console.WriteLine(" ");
            Console.WriteLine("-----------------------------------------------------------");
        }
    }
}
