using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividades.Exercicios
{
    internal class ReajusteSalarial
    {

        public static void VerificaReajusteSalarial()
        {
            double reajuste20 = 0.20;
            double reajuste15 = 0.15;
            double reajuste10 = 0.10;
            double reajuste05 = 0.05;

            double aumento;
            double salarioReajustado;
            Console.WriteLine("Digite o valor do salário do funcionário: ");
            double salario = double.Parse(Console.ReadLine());

            if (salario <= 280)
            {
                aumento = salario * reajuste20;
                salarioReajustado = salario + aumento;

                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine(" ");
                Console.WriteLine("o salário antes do reajuste: " + salario);
                Console.WriteLine("percentual de aumento aplicado: 20%");
                Console.WriteLine("valor do aumento: " + aumento);
                Console.WriteLine("o salário com o reajuste:" + salarioReajustado);
                Console.WriteLine(" ");
                Console.WriteLine("-----------------------------------------------------------");
            }

            else
            {
                if (salario >= 280 && salario < 700)
                {
                    aumento = salario * reajuste15;
                    salarioReajustado = salario + aumento;

                    Console.WriteLine("-----------------------------------------------------------");
                    Console.WriteLine(" ");
                    Console.WriteLine("o salário antes do reajuste: " + salario);
                    Console.WriteLine("percentual de aumento aplicado: 15%");
                    Console.WriteLine("valor do aumento: " + aumento);
                    Console.WriteLine("o salário com o reajuste:" + salarioReajustado);
                    Console.WriteLine(" ");
                    Console.WriteLine("-----------------------------------------------------------");
                }

                else if (salario >= 700 && salario < 1500)
                {
                    aumento = salario * reajuste10;
                    salarioReajustado = salario + aumento;

                    Console.WriteLine("-----------------------------------------------------------");
                    Console.WriteLine(" ");
                    Console.WriteLine("o salário antes do reajuste: " + salario);
                    Console.WriteLine("percentual de aumento aplicado: 10%");
                    Console.WriteLine("valor do aumento: " + aumento);
                    Console.WriteLine("o salário com o reajuste:" + salarioReajustado);
                    Console.WriteLine(" ");
                    Console.WriteLine("-----------------------------------------------------------");
                }
                else if (salario >= 1500)
                {
                    aumento = salario * reajuste05;
                    salarioReajustado = salario + aumento;

                    Console.WriteLine("-----------------------------------------------------------");
                    Console.WriteLine(" ");
                    Console.WriteLine("o salário antes do reajuste: " + salario);
                    Console.WriteLine("percentual de aumento aplicado: 05%");
                    Console.WriteLine("valor do aumento: " + aumento);
                    Console.WriteLine("o salário com o reajuste:" + salarioReajustado);
                    Console.WriteLine(" ");
                    Console.WriteLine("-----------------------------------------------------------");

                }
            }
        }
    }
}
