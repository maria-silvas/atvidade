// See https://aka.ms/new-console-template for more information

using System;
using System.Linq;

namespace ATV1 // Note: actual namespace depends on the project name.
{
    internal class atividade
    {

        internal class Atividade2
        {
            static void Main(string[] args)
            {
                Console.WriteLine("=== EXERCÍCIOS - LISTA 2 ===");

                Console.WriteLine("+-------------------------------------------------------+");
                Console.WriteLine("| 1 - Calcule a Média                                   |");
                Console.WriteLine("| 2 - Mês do Ano                                        |");
                Console.WriteLine("| 3 - Forca                                             |");
                Console.WriteLine("| 4 - Tabuada                                           |");
                Console.WriteLine("| 5 - Letra a Letra                                     |");
                Console.WriteLine("| 6 - Número ímpares multiplos de 7                     |");
                Console.WriteLine("| 7 - Calcule a Média de Notas informadas               |");
                Console.WriteLine("| 8 - Fatorial                                          |");
                Console.WriteLine("| 9 - Calculo IMC                                       |");
                Console.WriteLine("| 10 - Operadores                                       |");
                Console.WriteLine("| 11 - DESAFIO                                          |");
                Console.WriteLine("+-------------------------------------------------------+");

                Console.WriteLine("Digite a opção desejada : ");
                int atv2 = Int32.Parse(Console.ReadLine());
                switch (atv2)
                {
                    case 1:
                        calculaMedia();
                        break;
                    case 2:
                        MesdoAno();
                        break;
                    case 3:
                        Forca();
                        break;
                    case 4:
                        calculaTabuada();
                        break;
                    case 5:
                        LetraaLetra();
                        break;
                    case 6:
                        MultiplosdeSete();
                        break;
                    case 7:
                        calculaaMediadeNotas();
                        break;
                    case 8:
                        calculaFatorial();
                        break;
                    case 9:
                        calculaImc();
                        break;
                    case 10:
                        calculaOPeradores();
                        break;
                    case 11:
                        Desafio();
                        break;
                }
            }



            private static void calculaMedia()
            {
                Console.WriteLine("Calculo da média das notas");

                Console.Write("Digite a primeira nota: ");
                float nota1 = float.Parse(Console.ReadLine());

                Console.Write("Digite a segunda nota: ");
                float nota2 = float.Parse(Console.ReadLine());

                Console.Write("Digite a terceira nota: ");
                float nota3 = float.Parse(Console.ReadLine());

                float media = (nota1 + nota2 + nota3) / 3;

                Console.WriteLine("A média das notas é: " + media);

                if (media >= 7)
                {
                    Console.WriteLine("O aluno está aprovado.");
                }
                else
                {
                    Console.WriteLine("O aluno está reprovado.");
                }

                Console.ReadKey();
            }


            private static void MesdoAno()
            {

                int numero;

                Console.WriteLine("Digite o número do mês: ");
                numero = int.Parse(Console.ReadLine());

                switch (numero)
                {
                    case 1:
                        Console.WriteLine("Janeiro");
                        break;
                    case 2:
                        Console.WriteLine("Fevereiro");
                        break;
                    case 3:
                        Console.WriteLine("Março");
                        break;
                    case 4:
                        Console.WriteLine("Abril");
                        break;
                    case 5:
                        Console.WriteLine("Maio");
                        break;
                    case 6:
                        Console.WriteLine("Junho");
                        break;
                    case 7:
                        Console.WriteLine("Julho");
                        break;
                    case 8:
                        Console.WriteLine("Agosto");
                        break;
                    case 9:
                        Console.WriteLine("Setembro");
                        break;
                    case 10:
                        Console.WriteLine("Outubro");
                        break;
                    case 11:
                        Console.WriteLine("Novembro");
                        break;
                    case 12:
                        Console.WriteLine("Dezembro");
                        break;
                    default:
                        Console.WriteLine("Número inválido");
                        break;
                }
                Console.ReadLine();
            }

            private static void Forca()
            {
                string palavraOculta;
                string palavraAdivinhar = "";
                int tentativas;
                char letra;
                int acertos = 0;
                int erros = 0;

                Console.WriteLine("Digite a palavra oculta: ");
                palavraOculta = Console.ReadLine();

                Console.WriteLine("Digite a quantidade de tentativas: ");
                tentativas = int.Parse(Console.ReadLine());

                for (int i = 0; i < palavraOculta.Length; i++)
                {
                    palavraAdivinhar += "_ ";
                }

                Console.WriteLine(palavraAdivinhar);

                while (acertos < palavraOculta.Length && erros < tentativas)
                {
                    Console.WriteLine("Digite uma letra: ");
                    letra = char.Parse(Console.ReadLine());

                    if (palavraOculta.Contains(letra))
                    {
                        for (int i = 0; i < palavraOculta.Length; i++)
                        {
                            if (palavraOculta[i] == letra)
                            {
                                acertos++;
                                palavraAdivinhar = palavraAdivinhar.Remove(i * 2, 1).Insert(i * 2, letra.ToString());
                            }
                        }
                    }
                    else
                    {
                        erros++;
                        Console.WriteLine("Errou! Tentativas restantes: " + (tentativas - erros));
                    }

                    Console.WriteLine(palavraAdivinhar);
                }

                if (acertos == palavraOculta.Length)
                {
                    Console.WriteLine("Acertou a palavra");
                }
                else
                {
                    Console.WriteLine("Enforcado");
                }

                Console.ReadLine();

            }

            private static void calculaTabuada()
            {

                for (int i = 0; i <= 10; i++)
                {
                    for (int j = 0; j <= 10; j++)
                    {
                        Console.WriteLine(i + " x " + j + " = " + i * j);
                    }
                }
                Console.ReadLine();
            }
            private static void LetraaLetra()
            {
                for (int i = 0; i <= 10; i++)
                {
                    for (int j = 0; j <= 10; j++)
                    {
                        Console.WriteLine(i + " x " + j + " = " + i * j);
                    }
                }
                Console.ReadLine();
            }
            private static void MultiplosdeSete()
            {
                int sum = 0;
                for (int i = 1; i <= 500; i++)
                {
                    if (i % 7 == 0 && i % 2 != 0)
                    {
                        sum += i;
                    }
                }
                Console.WriteLine("A soma dos números ímpares e múltiplos de 7 entre 1 e 500 são: " + sum);

            }
            private static void calculaaMediadeNotas()
            {
                double grade, sum = 0, count = 0;
                Console.WriteLine("Digite as notas do aluno (digite um número negativo para encerrar):");
                while (true)
                {
                    grade = Convert.ToDouble(Console.ReadLine());
                    if (grade < 0)
                    {
                        break;
                    }
                    sum += grade;
                    count++;
                }
                Console.WriteLine("A média das notas é: " + sum / count);

            }
            private static void calculaFatorial()
            {
                Console.WriteLine("Entre com um número:");
                int num = int.Parse(Console.ReadLine());
                int result = CalcularFatorial(num);
                Console.WriteLine(num + "! = " + result);
            }

            static int CalcularFatorial(int n)
            {
                if (n == 0)
                {
                    return 1;
                }
                else
                {
                    return n * CalcularFatorial(n - 1);
                }
            }

            private static void calculaImc()
            {
                Console.WriteLine("Entre com sua altura (em metros):");
                double altura = double.Parse(Console.ReadLine());
                Console.WriteLine("Entre com seu peso (em kg):");
                double peso = double.Parse(Console.ReadLine());
                double imc = CalcularIMC(altura, peso);
                Console.WriteLine("Seu IMC é: " + imc);
                Console.WriteLine("Classificação: " + ClassificarIMC(imc));
            }

            static double CalcularIMC(double altura, double peso)
            {
                return peso / (altura * altura);
            }

            static string ClassificarIMC(double imc)
            {
                if (imc < 18.5)
                {
                    return "Abaixo do peso";
                }
                else if (imc >= 18.5 && imc <= 24.9)
                {
                    return "Peso ideal";
                }
                else if (imc >= 25.0 && imc <= 29.9)
                {
                    return "Levemente acima do peso";
                }
                else if (imc >= 30.0 && imc <= 34.9)
                {
                    return "Obesidade Grau I";
                }
                else if (imc >= 35.0 && imc <= 39.9)
                {
                    return "Obesidade Grau II";
                }
                else
                {
                    return "Obesidade Grau III (mórbida)";
                }
            }
            private static void calculaOPeradores()
            {
                Console.WriteLine("Insira o primeiro valor:");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Insira o segundo valor:");
                double num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Insira a operação a ser realizada (+ - * /):");
                char operation = Convert.ToChar(Console.ReadLine());

                double result;
                switch (operation)
                {
                    case '+':
                        result = num1 + num2;
                        break;
                    case '-':
                        result = num1 - num2;
                        break;
                    case '*':
                        result = num1 * num2;
                        break;
                    case '/':
                        result = num1 / num2;
                        break;
                    default:
                        Console.WriteLine("Operação inválida");
                        return;
                }

                Console.WriteLine("Resultado: " + result);
            }
            private static void Desafio()
            {
                int[] notes = new int[] { 100, 50, 10, 5, 1 };

                Console.WriteLine("Insira o valor em reais:");
                int value = Convert.ToInt32(Console.ReadLine());

                int count = 0;
                foreach (int note in notes)
                {
                    count += value / note;
                    value %= note;

                    if (value == 0)
                    {
                        break;
                    }
                }

                Console.WriteLine("Quantidade de notas: " + count);
            }
        }
    }

}







