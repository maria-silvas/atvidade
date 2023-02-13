// See https://aka.ms/new-console-template for more information



using System;
using System.Diagnostics;
using System.IO;

namespace Atividade3 // Note: actual namespace depends on the project name.
{
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    internal class NewBaseType
    {
        internal class NewBaseType
        {
            private Dictionary<TKey, TValue> dicionario;



            private static void GerenciarInformacoes()
            {
                static void Main(string[] args)
                {




                    Console.WriteLine("=== EXERCÍCIOS - LISTA 3 ===");

                    Console.WriteLine("+-------------------------------------------------------+");
                    Console.WriteLine("| 1 - Gerenciar Informações                             |");
                    Console.WriteLine("| 2 - Continuação                                       |");
                    Console.WriteLine("| 3 - Controle de Produto                               |");
                    Console.WriteLine("| 4 -Continuacaao                                       |");
                    Console.WriteLine("+-------------------------------------------------------+");

                    Console.WriteLine("Digite a opção desejada : ");
                    int atv2 = Int32.Parse(Console.ReadLine());
                    switch (atv2)
                    {
                        case 1:
                            GerenciarInformacoes();
                            break;
                        case 2:
                            Continuacao();
                            break;
                        case 3:
                            ControledeProduto();
                            break;
                        case 4:
                            Continuacaao();
                            break;

                    }
                }
            }

            private static void ImprimirInformacoes()
            {
                foreach (KeyValuePair<TKey, TValue> item in dicionario)
                {
                    Console.WriteLine("Chave: {0} Valor: {1}", item.Key, item.Value);
                }
            }

            private static void AdicionarInformacao(TKey chave, TValue valor)
            {
                dicionario.Add(chave, valor);
            }

            internal class Atividade3 : NewBaseType, NewBaseType
            {
                public GerenciadorInformacoes()
                {
                    dicionario = new Dictionary<TKey, TValue>();
                }
            }

            class Program
            {
                static void Main(string[] args)
                {
                    // Adicionar informações do aluno
                    GerenciadorInformacoes<string, double> notasAluno = new GerenciadorInformacoes<string, double>();
                    notasAluno.AdicionarInformacao("João", 8.5);
                    notasAluno.AdicionarInformacao("Maria", 9.0);

                    // Adicionar informações do conceito do aluno
                    GerenciadorInformacoes<string, string> conceitoAluno = new GerenciadorInformacoes<string, string>();
                    conceitoAluno.AdicionarInformacao("João", "Bom");
                    conceitoAluno.AdicionarInformacao("Maria", "Ótimo");

                    // Adicionar informações do funcionário
                    GerenciadorInformacoes<int, string> funcionarios = new GerenciadorInformacoes<int, string>();
                    funcionarios.AdicionarInformacao(1, "João");
                    funcionarios.AdicionarInformacao(2, "Maria");

                    // Adicionar informações da localização
                    GerenciadorInformacoes<Tuple<int, int>, string> localizacoes = new GerenciadorInformacoes<Tuple<int, int>, string>();
                    localizacoes.AdicionarInformacao(Tuple.Create(1, 2), "Localização 1");
                    localizacoes.AdicionarInformacao(Tuple.Create(3, 4), "Localização 2");

                    // Imprimir informações
                    Console.WriteLine("Notas dos Alunos:");
                    notasAluno.ImprimirInformacoes();

                    Console.WriteLine("\nConceito dos Alunos:");
                    conceitoAluno.ImprimirInformacoes();

                    Console.WriteLine("\nFuncionários:");
                    funcionarios.ImprimirInformacoes();
                }


                private static void Continuacao()
                {
                    // ... código que adiciona informações aos objetos da classe Information

                    // Adicionar informações aos objetos da classe Information
                    Information<string, string> info1 = new Information<string, string>("Nome Aluno", "Nota Aluno");
                    Information<string, string> info2 = new Information<string, string>("Nome Aluno", "Conceito Aluno");
                    Information<int, string> info3 = new Information<int, string>(1, "Nome Funcionário");
                    Information<double, double> info4 = new Information<double, double>(2.0, 3.0);

                    // Imprimir o conteúdo das informações
                    PrintInformation(info1);
                    PrintInformation(info2);
                    PrintInformation(info3);
                    PrintInformation(info4);
                }

                static void PrintInformation(Information<TKey, TValue> info)
                {
                    Console.WriteLine("Chave: {0}, Valor: {1}", info.Key, info.Value);
                }
            }

            class Information<TKey, TValue>
            {
                public TKey Key { get; set; }
                public TValue Value { get; set; }

                public Information(TKey key, TValue value)
                {
                    Key = key;
                    Value = value;
                }

            }

        }

        private static void ControledeProduto()
        {
            CodigoRastreio.Inicializar("ALM", 1);
            Produto produto1 = new Produto(1, "Produto 1");
            Console.WriteLine("ID: " + produto1.ID);
            Console.WriteLine("Nome: " + produto1.Nome);
            Console.WriteLine("Código de Rastreio: " + produto1.CodigoRastreio);

            Produto produto2 = new Produto(2, "Produto 2");
            Console.WriteLine("ID: " + produto2.ID);
            Console.WriteLine("Nome: " + produto2.Nome);
            Console.WriteLine("Código de Rastreio: " + produto2.CodigoRastreio);

            Console.ReadLine();

        }
        private static void Continuacaao()
        {

        }

    }
}











