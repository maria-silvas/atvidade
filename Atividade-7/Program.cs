
// See https://aka.ms/new-console-template for more information

using System;
using System.Diagnostics;
using System.IO;

public class NewBaseType
{

    public class ExercicioQuatro : NewBaseType
    {
        public static void call(Scanner scanner)
        {
            Console.WriteLine("=== EXERCÍCIOS - LISTA 5 ===");

            Console.WriteLine("+-------------------------------------------------------+");
            Console.WriteLine("| 1 - Polidromo                                         |");
            Console.WriteLine("| 2 - Emprestimo                                        |");
            Console.WriteLine("| 3 - Fibonacci                                         |");
            Console.WriteLine("| 4 - Movimentacao Conta                                |");
            Console.WriteLine("| 5 - Circunferencia                                    |");
            Console.WriteLine("| 6 - Tabuada                                           |");
            Console.WriteLine("| 7 - Data Nascimento                                   |");
            Console.WriteLine("|  - Piramide                                           |");
            Console.WriteLine("|  - Idade                                             |");
            Console.WriteLine("|  - Sorteio                                            |");
            Console.WriteLine("+-------------------------------------------------------+");

            Console.WriteLine("Digite a opção desejada : ");
            int atv2 = Int32.Parse(Console.ReadLine());
            switch (atv2)
            {
                case 1:
                    Polidromo();
                    break;
                case 2:
                    Emprestimo();
                    break;
                case 3:
                    Fibonacci();
                    break;
                case 4:
                    Movimentacao();
                    break;
                case 5:
                    NumeroBinario();
                    break;
                case 6:
                    Tabuada();
                    break;
                case 7:
                    DataNascimento();
                    break;
                case 8:
                    Piramide();
                    break;
                case 9:
                    Idade();
                    break;
                case 10:
                    Sorteio();
                    break;
            }


        }

        private static void Polidromo()
        {
            Console.WriteLine("Digite uma cadeia de caracteres:");
            string input = Console.ReadLine();

            // Remove espaços em branco e especiais, convertendo tudo para minúsculo
            input = input.Replace(" ", string.Empty).Replace(".", string.Empty).Replace(",", string.Empty).Replace("!", string.Empty).ToLower();

            // Inverte a cadeia
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            string reversed = new string(charArray);

            // Verifica se a cadeia original é igual a sua inversa
            if (input == reversed)
            {
                Console.WriteLine("A cadeia de caracteres é um palíndromo.");
            }
            else
            {
                Console.WriteLine("A cadeia de caracteres não é um palíndromo.");
            }

            Console.ReadLine();
        }

        private static void Emprestimo()
        {
            Console.WriteLine("Digite o valor do empréstimo:");
            double loan = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor da prestação mensal:");
            double monthlyPayment = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a taxa de juros (em porcentagem):");
            double interestRate = Convert.ToDouble(Console.ReadLine());

            // Converte a taxa de juros para decimal
            interestRate = interestRate / 100;

            // Variáveis para armazenar o valor acumulado de juros e o valor ainda por pagar
            double accumulatedInterest = 0;
            double remainingDebt = loan;

            int month = 1;
            while (remainingDebt > 0)
            {
                // Calcula o valor dos juros
                double interest = remainingDebt * interestRate;

                // Adiciona os juros ao valor acumulado
                accumulatedInterest += interest;

                // Calcula o valor aplicado no pagamento da dívida
                double appliedToDebt = monthlyPayment - interest;

                // Subtrai o valor aplicado do valor restante
                remainingDebt -= appliedToDebt;

                Console.WriteLine("Mês " + month);
                Console.WriteLine("Juros: R$ " + interest);
                Console.WriteLine("Pagamento da dívida: R$ " + appliedToDebt);
                Console.WriteLine("Juros acumulados: R$ " + accumulatedInterest);
            }


        }



        private static void Movimentacao()
        {

            Conta conta = new Conta(123456, 123, 1000, "João Silva");

            Console.WriteLine("Saldo inicial: R$ " + conta.SaldoTotal());

            Console.WriteLine("Digite o valor do depósito:");
            double valorDeposito = Convert.ToDouble(Console.ReadLine());
            conta.Deposito(valorDeposito);
            Console.WriteLine("Novo saldo após depósito: R$ " + conta.SaldoTotal());

            Console.WriteLine("Digite o valor do saque:");
            double valorSaque = Convert.ToDouble(Console.ReadLine());
            conta.Saque(valorSaque);
            Console.WriteLine("Novo saldo após saque: R$ " + conta.SaldoTotal());
        }
        private static void Fibonacci()
        {

            Console.WriteLine("Insira um número inteiro:");
            int num = Convert.ToInt32(Console.ReadLine());

            int a = 0, b = 1, c = 0;

            while (c < num)
            {
                c = a + b;
                a = b;
                b = c;
                if (c == num)
                {
                    Console.WriteLine("O número faz parte da sequência de Fibonacci.");
                    break;
                }
            }

            if (c != num)
            {
                Console.WriteLine("O número não faz parte da sequência de Fibonacci.");
            }

            Console.ReadLine();
        }
        private static void NumeroBinario()
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Insira um número inteiro:");
                int number = int.Parse(Console.ReadLine());

                Console.WriteLine("O número em binário é: " + Convert.ToString(number, 2));
                Console.ReadLine();

            }


        }
        private static void Tabuada()
        {

            Console.WriteLine("Escolha uma das opções:");
            Console.WriteLine("1 - Tabuada");
            Console.WriteLine("2 - Sequência");
            Console.WriteLine("3 - Sair");
            Console.Write("Opção: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.Write("Digite um número entre 1 e 10: ");
                    numero = int.Parse(Console.ReadLine());

                    if (numero < 1 || numero > 10)
                    {
                        Console.WriteLine("Número inválido. Digite um número entre 1 e 10.");
                    }
                    else
                    {
                        for (int i = 1; i <= 10; i++)
                        {
                            Console.WriteLine("{0} x {1} = {2}", numero, i, numero * i);
                        }
                    }
                    break;
                case 2:
                    Console.Write("Digite o início da sequência: ");
                    inicio = int.Parse(Console.ReadLine());
                    Console.Write("Digite o fim da sequência: ");
                    fim = int.Parse(Console.ReadLine());

                    for (int i = inicio; i <= fim; i++)
                    {
                        Console.Write(i + " ");
                    }
                    Console.WriteLine();
                    break;
                case 3:
                    Console.WriteLine("Saindo...");
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
            Console.ReadKey();
        }

    }
    private static void DataNascimento()
    {

        Console.WriteLine("Informe o primeiro valor:");
        int valor1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Informe o segundo valor:");
        int valor2 = int.Parse(Console.ReadLine());

        Random random = new Random();
        int sorteado = random.Next(Math.Min(valor1, valor2), Math.Max(valor1, valor2) + 1);

        Console.WriteLine("O número sorteado é: " + sorteado);

    }
    private static void Piramide()
    {

        Console.WriteLine("Informe o número: ");
        int num = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= num; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        Console.ReadLine();

    }

    private static void Idade()
    {
        Console.WriteLine("Quantas pessoas serão cadastradas?");
        int pessoas = int.Parse(Console.ReadLine());

        int qtdHomens = 0, qtdMulheres = 0, qtdMenorIdade = 0, qtdMaiorIdade = 0;

        for (int i = 1; i <= pessoas; i++)
        {
            Console.WriteLine("Digite seu sexo (M/F):");
            char sexo = char.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua idade:");
            int idade = int.Parse(Console.ReadLine());

            if (sexo == 'M' || sexo == 'm')
            {
                qtdHomens++;
            }
            else if (sexo == 'F' || sexo == 'f')
            {
                qtdMulheres++;
            }

            if (idade < 18)
            {
                qtdMenorIdade++;
            }
            else
            {
                qtdMaiorIdade++;
            }
        }

        Console.WriteLine("Quantidade de homens: " + qtdHomens);
        Console.WriteLine("Quantidade de mulheres: " + qtdMulheres);
        Console.WriteLine("Quantidade de pessoas menores de idade: " + qtdMenorIdade);
        Console.WriteLine("Quantidade de pessoas maiores de idade: " + qtdMaiorIdade);

        Console.ReadLine();
    }
    private static void Sorteio()
    {

        Random rand = new Random();
        int numeroSorteado = rand.Next(0, 100);
        int tentativas = 0;
        int numeroInformado;

        Console.WriteLine("Tente adivinhar o número sorteado entre 0 e 100");
        do
        {
            Console.Write("Digite um número: ");
            numeroInformado = int.Parse(Console.ReadLine());
            tentativas++;

            if (numeroInformado < numeroSorteado)
            {
                Console.WriteLine("O número sorteado é maior");
            }
            else if (numeroInformado > numeroSorteado)
            {
                Console.WriteLine("O número sorteado é menor");
            }
        } while (numeroInformado != numeroSorteado);

        Console.WriteLine("Você acertou o número sorteado, que era " + numeroSorteado + " após " + tentativas + " tentativas");

    }
}
















