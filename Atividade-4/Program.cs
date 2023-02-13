
// See https://aka.ms/new-console-template for more information

using System;
using System.Diagnostics;
using System.IO;
public class ExercicioQuatro
{
    public static void call(Scanner scanner)
    {
        Console.WriteLine("=== EXERCÍCIOS - LISTA 4 ===");




        Console.WriteLine("+-------------------------------------------------------+");
        Console.WriteLine("| 1 -  Calculo de Media                                 |");
        Console.WriteLine("| 2 -  Array com Forech                                 |");
        Console.WriteLine("| 3 -  Imprimir Array                                   |");
        Console.WriteLine("| 4 -  Pares ou Impares                                 |");
        Console.WriteLine("| 5 -  Cartas do Baralho com Collection                 |");
        Console.WriteLine("| 6 -  Unindo duas listas                               |");
        Console.WriteLine("| 7 -  Fila de Atendimento Banco                        |");
        Console.WriteLine("| 8 -  Temperatura Media Anual                          |");
        Console.WriteLine("| 9 -  Criação de Array intercalado                     |");
        Console.WriteLine("| 10 - Valores inferiores a média                       |");
        Console.WriteLine("+-------------------------------------------------------+");

        Console.WriteLine("Digite a opção desejada : ");
        int atv2 = Int32.Parse(Console.ReadLine());
        switch (atv2)
        {
            case 1:
                calculaMedia();
                break;
            case 2:
                ArraycomForech();
                break;
            case 3:
                ImprimirArray();
                break;
            case 4:
                ParesouImpares();
                break;
            case 5:
                CartasdoBaralho();
                break;
            case 6:
                UnindoduasListas();
                break;
            case 7:
                FiladeAtendimento();
                break;
            case 8:
                TemperaturaMediaAnual();
                break;
            case 9:
                CriaçãodeArrayintercalado();
                break;
            case 10:
                Valoresinferioresamédia();
                break;

        }


    }

    private static void calculaMedia()
    {
        Console.WriteLine("Quantas notas você deseja informar?");
        int quantidadeNotas = int.Parse(Console.ReadLine());

        int[] notas = new int[quantidadeNotas];
        int somaNotas = 0;

        for (int i = 0; i < quantidadeNotas; i++)
        {
            Console.WriteLine("Informe a nota " + (i + 1) + ":");
            notas[i] = int.Parse(Console.ReadLine());
            somaNotas += notas[i];
        }

        int media = somaNotas / quantidadeNotas;
        Console.WriteLine("A média das notas é: " + media);
    }

    private static void ArraycomForech()
    {
        int[] numeros = { 1, 2, 3, 4, 5 };

        Console.WriteLine("Números no array:");
        foreach (int numero in numeros)
        {
            Console.WriteLine(numero);
        }

    }

    private static void ImprimirArray()
    {

        int[] valores = new int[10];

        Console.WriteLine("Informe 10 valores inteiros:");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Informe o valor " + (i + 1) + ":");
            valores[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Valores lidos:");
        foreach (int valor in valores)
        {
            if (valor % 2 == 0)
            {
                Console.WriteLine(valor + " é par");
            }
            else
            {
                Console.WriteLine(valor + " é ímpar");
            }
        }
    }

    private static void ParesouImpares()
    {
        int[] valores = new int[10];

        Console.WriteLine("Informe 10 valores inteiros:");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Informe o valor " + (i + 1) + ":");
            valores[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Valores lidos:");
        foreach (int valor in valores)
        {
            if (valor % 2 == 0)
            {
                Console.WriteLine(valor + " é par");
            }
            else
            {
                Console.WriteLine(valor + " é ímpar");
            }
        }

    }

    private static void CartasdoBaralho()
    {
        {

            List<string> deck = new List<string>();



            string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            foreach (string suit in suits)
            {
                foreach (string rank in ranks)
                {
                    deck.Add(rank + suit);
                }
            }
            foreach (string card in deck)
            {
                Console.WriteLine(card);
            }

            Console.ReadLine();

        }
    }


    private static void UnindoduasListas1()
    {
        List<int> list1 = new List<int> { 1, 2, 3, 4, 5 };
        List<int> list2 = new List<int> { 6, 7, 8, 9, 10 };


        List<int> mergedList = new List<int>();


        mergedList.AddRange(list1);
        mergedList.AddRange(list2);

        // Imprime a terceira lista
        foreach (int number in mergedList)
        {
            Console.WriteLine(number);
        }

        Console.ReadLine();
    }
    private static void FiladeAtendimento()
    {

        Queue<string> queue = new Queue<string>();

        // Adiciona alguns clientes à fila
        queue.Enqueue("Cliente 1");
        queue.Enqueue("Cliente 2");
        queue.Enqueue("Cliente 3");
        queue.Enqueue("Cliente 4");
        queue.Enqueue("Cliente 5");

        Console.WriteLine("Fila de atendimento do banco:");
        Console.WriteLine("-----------------------------");


        foreach (string customer in queue)
        {
            Console.WriteLine(customer);
        }

        Console.WriteLine();


        Console.WriteLine("Atendendo o próximo cliente...");
        Console.WriteLine(queue.Dequeue() + " foi atendido.");

        Console.WriteLine();
        Console.WriteLine("Fila de atendimento do banco:");
        Console.WriteLine("-----------------------------");


        foreach (string customer in queue)
        {
            Console.WriteLine(customer);
        }

        Console.ReadLine();
    }
    private static void FiladeAtendimento()
    {
        const int NUMERO_DE_MESES = 12;

        double[] temperaturas = new double[NUMERO_DE_MESES];
        double soma = 0.0;

        for (int i = 0; i < NUMERO_DE_MESES; i++)
        {
            Console.Write("Informe a temperatura média do mês " + (i + 1) + ": ");
            temperaturas[i] = Convert.ToDouble(Console.ReadLine());
            soma += temperaturas[i];
        }

        double mediaAnual = soma / NUMERO_DE_MESES;
        Console.WriteLine("A temperatura média anual é: " + mediaAnual);
    }


    private static void TemperaturaMediaAnual()
    {


        const int NUMERO_DE_MESES = 12;

        double[] temperaturas = new double[NUMERO_DE_MESES];
        double soma = 0.0;

        for (int i = 0; i < NUMERO_DE_MESES; i++)
        {
            Console.Write("Informe a temperatura média do mês " + (i + 1) + ": ");
            temperaturas[i] = Convert.ToDouble(Console.ReadLine());
            soma += temperaturas[i];
        }

        double mediaAnual = soma / NUMERO_DE_MESES;
        Console.WriteLine("A temperatura média anual é: " + mediaAnual);
    }
    private static void CriaçãodeArrayintercalado()
    {
        const int TAMANHO_ARRAYS = 10;

        int[] array1 = new int[TAMANHO_ARRAYS];
        int[] array2 = new int[TAMANHO_ARRAYS];
        int[] array3 = new int[TAMANHO_ARRAYS * 2];

        Console.WriteLine("Informe os valores do primeiro array:");
        for (int i = 0; i < TAMANHO_ARRAYS; i++)
        {
            Console.Write("Posição " + (i + 1) + ": ");
            array1[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Informe os valores do segundo array:");
        for (int i = 0; i < TAMANHO_ARRAYS; i++)
        {
            Console.Write("Posição " + (i + 1) + ": ");
            array2[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 0, j = 0; i < TAMANHO_ARRAYS * 2; i += 2, j++)
        {
            array3[i] = array1[j];
            array3[i + 1] = array2[j];
        }

        Console.WriteLine("Primeiro array:");
        for (int i = 0; i < TAMANHO_ARRAYS; i++)
        {
            Console.WriteLine("Posição " + (i + 1) + ": " + array1[i]);
        }

        Console.WriteLine("Segundo array:");
        for (int i = 0; i < TAMANHO_ARRAYS; i++)
        {
            Console.WriteLine("Posição " + (i + 1) + ": " + array2[i]);
        }

        Console.WriteLine("Terceiro array:");
        for (int i = 0; i < TAMANHO_ARRAYS * 2; i++)
        {
            Console.WriteLine("Posição " + (i + 1) + ": " + array3[i]);
        }
    }




    private static void Valoresinferioresamédia()
    {

        const int NUMERO_VALORES = 20;

        int[] valores = new int[NUMERO_VALORES];
        int soma = 0;
        double media;

        Console.WriteLine("Informe 20 valores:");
        for (int i = 0; i < NUMERO_VALORES; i++)
        {
            Console.Write("Valor " + (i + 1) + ": ");
            valores[i] = Convert.ToInt32(Console.ReadLine());
            soma += valores[i];
        }

        media = soma / NUMERO_VALORES;

        Console.WriteLine("Valores abaixo da média (" + media + "):");
        for (int i = 0; i < NUMERO_VALORES; i++)
        {
            if (valores[i] < media)
            {
                Console.WriteLine("Valor " + (i + 1) + ": " + valores[i]);
            }
        }
    }

}














