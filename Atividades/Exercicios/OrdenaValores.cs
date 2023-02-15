using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividades.Exercicios
{
    internal class OrdenaValores
    {
        public static void Ordena3Valores()
        {
            Console.WriteLine("Primeiro número: ");
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Segundo número: ");
            int numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Terceiro número: ");
            int numero3 = int.Parse(Console.ReadLine());

            int aux = 0;
            if (numero1 < numero2)
            {
                aux = numero1;
                numero1= numero2;
                numero2 = aux;
            }
            if (numero1 < numero3)
            {
                aux = numero1;
                numero1 = numero3;
                numero3 = aux;
            }
            if (numero2 < numero3)
            {
                aux = numero2;
                numero2 = numero3;
                numero3 = aux;
            }
            Console.WriteLine("-----------------------------------------------------------"); 
            Console.WriteLine(" ");
            Console.WriteLine("Valores Ordenados: " + numero1 +" "+ numero2 + " " + numero3);
            Console.WriteLine(" ");
            Console.WriteLine("-----------------------------------------------------------"); 
        }
    }
}

