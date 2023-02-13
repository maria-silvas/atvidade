
// See https://aka.ms/new-console-template for more information

using System;
using System.Diagnostics;
using System.IO;

public class NewBaseType
{
    private static void ContaCorrente()
    {
    }

    public class ExercicioQuatro : NewBaseType
    {
        public static void call(Scanner scanner)
        {
            Console.WriteLine("=== EXERCÍCIOS - LISTA 5 ===");

            Console.WriteLine("+-------------------------------------------------------+");
            Console.WriteLine("| 1 - Criar Pessoa                                      |");
            Console.WriteLine("| 2 - IMC de Pessoa                                     |");
            Console.WriteLine("| 3 - Conta Corrente                                    |");
            Console.WriteLine("| 4 - Movimentacao Conta                                |");
            Console.WriteLine("| 5 - Circunferencia                                    |");
            Console.WriteLine("| 6 - Cifra de César                                    |");
            Console.WriteLine("+-------------------------------------------------------+");

            Console.WriteLine("Digite a opção desejada : ");
            int atv2 = Int32.Parse(Console.ReadLine());
            switch (atv2)
            {
                case 1:
                    CriarPessoa();
                    break;
                case 2:
                    ImcPessoa();
                    break;
                case 3:
                    ContaCorrente();
                    break;
                case 4:
                    Movementacao();
                    break;
                case 5:
                    Circuferencia();
                    break;
                case 6:
                    CifradeCesar();
                    break;

            }


        }

        private static void CriarPessoa()
        {

        }

        private static void ImcPessoa()
        {
            Pessoa pessoa = new Pessoa
            {
                Nome = "João Silva",
                Peso = 75.0,
                Altura = 1.75,
                DataNascimento = new DateTime(1985, 12, 1)
            };

            // Calcula o IMC da pessoa
            double imc = pessoa.IMC();

            // Verifica a classificação do IMC
            string classificacao;
            if (imc < 18.5)
            {
                classificacao = "Abaixo do Peso";
            }
            else if (imc >= 18.5 && imc <= 24.9)
            {
                classificacao = "Peso Ideal";
            }
            else if (imc >= 25.0 && imc <= 29.9)
            {
                classificacao = "Levemente acima do peso";
            }
            else if (imc >= 30.0 && imc <= 34.9)
            {
                classificacao = "Obesidade Grau I";
            }
            else if (imc >= 35.0 && imc <= 39.9)
            {
                classificacao = "Obesidade Grau II";
            }
            else
            {
                classificacao = "Obesidade Grau III (mórbida)";
            }

            // Imprime os resultados
            Console.WriteLine("Nome: " + pessoa.Nome);
            Console.WriteLine("IMC: " + imc);
            Console.WriteLine("Classificação: " + classificacao);

            Console.ReadLine();
        }

        public int NumeroConta { get; set; }
        public int Agencia { get; set; }
        public double Saldo { get; set; }
        public string NomeTitular { get; set; }

        public Conta(int numeroConta, int agencia, double saldo, string nomeTitular)
        {
            NumeroConta = numeroConta;
            Agencia = agencia;
            Saldo = saldo;
            NomeTitular = nomeTitular;
        }

        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public void Saque(double valor)
        {
            if (valor <= Saldo)
            {
                Saldo -= valor;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente.");
            }
        }

        public double SaldoTotal()
        {
            return Saldo;
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

    private static void Circuferencia()
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o raio da circunferência:");
            double raio = Convert.ToDouble(Console.ReadLine());
            Circunferencia circunferencia = new Circunferencia(raio);
            Console.WriteLine("A área da circunferência é: " + circunferencia.Area());
        }
    }



    private static CifradeCesar(string mensagem, int valorConstante)
    {
        this.mensagem = mensagem;
        this.valorConstante = valorConstante;
    }

    private static string Criptografia()
    {
        string mensagemCifrada = "";
        char[] alfabeto = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        char[] mensagemArray = mensagem.ToCharArray();

        for (int i = 0; i < mensagemArray.Length; i++)
        {
            int posicaoLetra = Array.IndexOf(alfabeto, char.ToLower(mensagemArray[i]));
            int posicaoCifrada = (posicaoLetra + valorConstante) % alfabeto.Length;

            mensagemCifrada += alfabeto[posicaoCifrada];
        }

        return mensagemCifrada;
    }
}














