using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividades.Exercicios
{
    internal class Conversor
    {
       public static void ConversorDeMetros() {
            Console.WriteLine("\n");
     
            Console.WriteLine("Quantos metros deseja converter para centimetros?");
            double metros = double.Parse(Console.ReadLine());

            double centimetros = Math.Round((metros * 100));
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine(" ");
            Console.WriteLine(" é igual a " + centimetros + " Centimetros");
            Console.WriteLine(" ");
            Console.WriteLine("-----------------------------------------------------------");
        }
       
            
    }
}
