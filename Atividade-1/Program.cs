// See https://aka.ms/new-console-template for more information

using System;

namespace Atividade // Note: actual namespace depends on the project name.
{
    internal class Atividade
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ATIVIDADE - LISTA 01");
            Console.WriteLine("+-------------------------------------------------------+");
            Console.WriteLine("| 1 - Calcule a Média                                   |");
            Console.WriteLine("| 2 - Calcule a Área                                    |");
            Console.WriteLine("| 3 - Calcule o Volume                                  |");
            Console.WriteLine("| 4 - Valor é maior que o dobro de outro valor          |");
            Console.WriteLine("| 5 - Cálculo de Bhaskara                               |");
            Console.WriteLine("| 6 - Velocidade Média                                  |");
            Console.WriteLine("| 7 - Percentual de Imposto                             |");
            Console.WriteLine("| 8 - Valor é par ou ímpar                              |");
            Console.WriteLine("| 9 - Comparar dois valores de String                   |");
            Console.WriteLine("| 10 - Valor double em string e convertido para inteiro |");
            Console.WriteLine("| 11 - Imposto de renda de um salário                   |");
            Console.WriteLine("| 12 - DESAFIO                                          |");
            Console.WriteLine("+-------------------------------------------------------+");


            Console.WriteLine("Digite a opção desejada : ");
            int atv1 = Int32.Parse(Console.ReadLine());
            switch (atv1)
            {
                case 1:
                    calculaMedia();
                    break;
                case 2:
                    calculaArea();
                    break;
                case 3:
                    calculaVolume();
                    break;
                case 4:
                    avaliaMaiorDoisValores();
                    break;
                case 5:
                    calculaBhaskara();
                    break;
                case 6:
                    calculaVelocidadeMedia();
                    break;
                case 7:
                    calculaPercentualImposto();
                    break;
                case 8:
                    testaParImpar();
                    break;
                case 9:
                    comparaValoresString();
                    break;
                case 10:
                    converteStringParaInt();
                    break;
                case 11:
                    calculaImpostoRenda();
                    break;
            }
        }

        private static void calculaMedia()
        {
            Console.WriteLine("Digite a primeira nota: ");
            double nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota: ");
            double nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a terceira nota: ");
            double nota3 = double.Parse(Console.ReadLine());
            double media = (nota1 + nota2 + nota3) / 3;
            Console.WriteLine("A média é: " + media);
        }

        private static void calculaArea()
        {
            Console.WriteLine("Digite o lado 1: ");
            double lado1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o lado 2: ");
            double lado2 = double.Parse(Console.ReadLine());
            double area = lado1 * lado2;
            Console.WriteLine("A área é: " + area);
        }

        private static void calculaVolume()
        {
            Console.WriteLine("Digite a largura: ");
            double largura = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a altura: ");
            double altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a profundidade: ");
            double profundidade = double.Parse(Console.ReadLine());
            double volume = largura * altura * profundidade;
            Console.WriteLine("O volume é: " + volume);
        }

        private static void avaliaMaiorDoisValores()
        {
            Console.WriteLine("Digite o primeiro valor: ");
            double valor1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            double valor2 = double.Parse(Console.ReadLine());
            if (valor1 > valor2 * 2)
            {
                Console.WriteLine("O primeiro valor é maior do que o dobro do segundo valor");
            }
            else
            {
                Console.WriteLine("O primeiro valor não é maior do que o dobro do segundo valor");
            }
        }

        private static void calculaBhaskara()
        {
            Console.WriteLine("Digite o valor de a: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de b: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de c: ");
            double c = double.Parse(Console.ReadLine());
            double delta = Math.Pow(b, 2) - 4 * a * c;
            if (delta < 0)
            {
                Console.WriteLine("Não existe raiz real");
            }
            else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("O valor de x1 é: " + x1);
                Console.WriteLine("O valor de x2 é: " + x2);
            }
        }

        private static void calculaVelocidadeMedia()
        {
            Console.WriteLine("Digite a distância percorrida (km): ");
            double distancia = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o tempo gasto (h): ");
            double tempo = double.Parse(Console.ReadLine());
            double velocidadeMedia = distancia / tempo;
            Console.WriteLine("A velocidade média é: " + velocidadeMedia);
        }

        private static void calculaPercentualImposto()
        {
            Console.WriteLine("Digite o faturamento: ");
            double faturamento = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de imposto: ");
            double qtdImposto = double.Parse(Console.ReadLine());
            double percentualImposto = qtdImposto / faturamento * 100;
            Console.WriteLine("O percentual de imposto é: " + percentualImposto);
        }

        private static void testaParImpar()
        {
            Console.WriteLine("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());
            if (numero % 2 == 0)
            {
                Console.WriteLine("O número é par");
            }
            else
            {
                Console.WriteLine("O número é ímpar");
            }
        }

        private static void comparaValoresString()
        {
            Console.WriteLine("Digite o primeiro valor: ");
            string valor1 = Console.ReadLine();
            Console.WriteLine("Digite o segundo valor: ");
            string valor2 = Console.ReadLine();
            if (valor1 == valor2)
            {
                Console.WriteLine("Os valores são iguais");
            }
            else
            {
                Console.WriteLine("Os valores são diferentes");
            }
        }

        private static void converteStringParaInt()
        {
            Console.WriteLine("Digite um número: ");
            string numero = Console.ReadLine();
            int numeroConvertido = int.Parse(numero);
            Console.WriteLine("O número convertido é: " + numeroConvertido);
        }

        private static void calculaImpostoRenda()
        {
            Console.WriteLine("Digite o salário: ");
            double salario = double.Parse(Console.ReadLine());
            if (salario <= 1903.98)
            {
                Console.WriteLine("Isento de imposto de renda");
            }
            else if (salario >= 1903.99 && salario <= 2826.65)
            {
                double imposto = salario * 0.075;
                Console.WriteLine("O valor do imposto é: " + imposto);
            }
            else if (salario >= 2826.66 && salario <= 3751.05)
            {
                double imposto = salario * 0.15;
                Console.WriteLine("O valor do imposto é: " + imposto);
            }
            else if (salario >= 3751.06 && salario <= 4664.68)
            {
                double imposto = salario * 0.225;
                Console.WriteLine("O valor do imposto é: " + imposto);
            }
            else
            {
                double imposto = salario * 0.275;
                Console.WriteLine("O valor do imposto é: " + imposto);
            }
        }
    }
}
