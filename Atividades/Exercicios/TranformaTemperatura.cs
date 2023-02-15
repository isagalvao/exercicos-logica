using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividades.Exercicios
{
    internal class TranformaTemperatura
    {
        public static void ConversorDeTemperatura()
        {
            Console.WriteLine("Informe a temperatura em Fahrenheit que deseja converter:");
            double fahrenheit = double.Parse(Console.ReadLine());

            double celsius = Math.Round(5 * ((fahrenheit - 32) / 9));

            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine(" ");
            Console.WriteLine("A temperatura em celsius é de:" + celsius);
            Console.WriteLine(" ");
            Console.WriteLine("-----------------------------------------------------------");
            
        }
    }
}
