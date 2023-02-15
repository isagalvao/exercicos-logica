
using Atividades.Exercicios;

namespace Atividades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        //MENU para chamar os Exercicios
        static void Menu()
        {

            Console.WriteLine("Bem vindo Lucas :) ! Selecione a uma das opções abaixo para avaliar:");
            Console.WriteLine("(0) - FINALIZAR");
            Console.WriteLine("(1) - Converter Metros em CM:");
            Console.WriteLine("(2) - Calculadora da área de um circulo:");
            Console.WriteLine("(3) - Calculadora da área de um quadrado:");
            Console.WriteLine("(4) - Converter temperatuda  de *F em Celsius:");
            Console.WriteLine("(5) - Informe dois valores e verificamos qual é o maior:");
            Console.WriteLine("(6) - Verificar se o valor é positivo ou negativo:");
            Console.WriteLine("(7) - Verifica qual sexo foi informado:");
            Console.WriteLine("(8) -  Calcular a média alcançada pelos alunos");
            Console.WriteLine("(9) - Informe três valores e diremos qual é o maior:");
            Console.WriteLine("(10) - Informe x valores e diremos qual é o maior e qual é o menor:");
            Console.WriteLine("(11) - Informe x valores mostraremos em ordem decrescente: ");
            Console.WriteLine("(12) - Reajuste Salarial Organizações Tabajara:");
            Console.WriteLine("(12) - Calcular a média de aproveitamento dos alunos:");

            short option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: MenuConversor(); break;
                case 2: MenuAreaCirculo(); break;
                case 3: MenuAreaQuadrado(); break;
                case 4: MenuTemperatura(); break;
                case 5: MenuMaiorDe2Numeros(); break;
                case 6: MenuPositivoNegativo(); break;
                case 7: MenuVerificaSexo(); break;
                case 8: MenuMediaAluno(); break;
                case 9: MenuMaiorDe3Numeros(); break;
                case 10: MenuMaiorMenor(); break;
                case 11: MenuOrdenaValores(); break;
                case 12: MenuReajusteSalarial(); break;
                case 13: MenuMediaAproveitamento(); break;
                default: Menu(); break;
            }

            //Exercicio 1
            static void MenuConversor()
            {
                Console.Clear();
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("-- Conversor de metros/centimetros --");
                Conversor.ConversorDeMetros();
                Console.WriteLine("");

                Menu();
            }

            //Exercicio 2

            static void MenuAreaCirculo()
            {

                Console.Clear();
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("-- Calculador da área de um circulo --");
                CalculaAreaCirculo.Calcula();
                Console.WriteLine("");
                Menu();
            }

            //Exercicio 3

            static void MenuAreaQuadrado()
            {

                Console.Clear();
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("-- Calculador da área de um quadrado --");
                CalculaAreaQuadrado.CalculaQuadrado();
                Console.WriteLine("");
                Menu();
            }

            //Exercicio 4
            static void MenuTemperatura()
            {

                Console.Clear();
                Console.WriteLine("------------------------------------------------------------");
                Console.WriteLine("-- Conversor de temperatura > Fahrenheit em graus Celsius --");
                TranformaTemperatura.ConversorDeTemperatura();
                Console.WriteLine("");
                Menu();
            }

            //Exercicio 5
            static void MenuMaiorDe2Numeros()
            {

                Console.Clear();
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("-- Informe dois valores e diremos qual é o maior: --");
                MaiorDeDois.VerificaMaiorNumero();
                Console.WriteLine("");
                Menu();
            }

            //Exercicio 6
            static void MenuPositivoNegativo()
            {

                Console.Clear();
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine("-- Informe um valor e diremos se é positivo ou negativo: --");
                PositivoNegativo.VerificaPositivoNegativo();
                Console.WriteLine("");
                Menu();
            }

            //Exercicio 7
            static void MenuVerificaSexo()
            {

                Console.Clear();
                Console.WriteLine("----------------------------------------------------------------");
                Console.WriteLine("-- Digite F ou M e diremos se o Sexo é Feminino  ou Masculino --");
                VerificaSexo.VerificaLetra();
                Console.WriteLine("");
                Menu();
            }

            //Exercicio 8
            static void MenuMediaAluno()
            {

                Console.Clear();
                Console.WriteLine("-------------------------------------------------------------------------------------------------");
                Console.WriteLine("-- Digite duas notas e informaremos se o aluno foi Aprovado com Distinção, Aprovado, Reprovado --");
                MediaAluno.VerificaMediaAluno();
                Console.WriteLine("");
                Menu();
            }


            //Exercicio 9
            static void MenuMaiorDe3Numeros()
            {

                Console.Clear();
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine("-- Informe três valores e diremos qual é o maior --");
                MaiorDeTres.MaiorDeTresNumeros();
                Console.WriteLine("");
                Menu();
            }

            //Exercicio 10
            static void MenuMaiorMenor()
            {

                Console.Clear();
                Console.WriteLine("---------------------------------------------------------------");
                Console.WriteLine("-- Informe valores e diremos qual é o maior e qual é o menor --");
                MaiorMenor.VerificaMaiorMenor();
                Console.WriteLine("");
                Menu();
            }

            //Exercicio 11
            static void MenuOrdenaValores()
            {

                Console.Clear();
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("-- Informe valores mostraremos em ordem decrescente --");
                OrdenaValores.Ordena3Valores();
                Console.WriteLine("");
                Menu();
            }
            //Exercicio 12
            static void MenuReajusteSalarial()
            {

                Console.Clear();
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("-- informe o valor do salário do funcionário e iremos realizar o reajuste --");
                ReajusteSalarial.VerificaReajusteSalarial();
                Console.WriteLine("");
                Menu();
            }

            //Exercicio 13
            static void MenuMediaAproveitamento()
            {

                Console.Clear();
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("-- Digite duas notas e informaremos o aproveitamento do aluno --");
                
                Console.WriteLine("");
                Menu();
            }
        }

    }
}