// See https://aka.ms/new-console-template for more information



using System;
using System.Diagnostics;
using System.IO;

namespace Atividade3 // Note: actual namespace depends on the project name.
{
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    internal class NewBaseType
    {

        internal class Atividade3 : NewBaseType
        {
            static void Main(string[] args)
            {




                Console.WriteLine("=== EXERCÍCIOS - LISTA 3 ===");

                Console.WriteLine("+-------------------------------------------------------+");
                Console.WriteLine("| 1 - Tabuada com Arquivo                               |");
                Console.WriteLine("| 2 - Ler e imprimir arquivo de texto                   |");
                Console.WriteLine("| 3 - Operações básicas com a Main                      |");
                Console.WriteLine("| 4 - Exponenciação com Precisão Arbitrária             |");
                Console.WriteLine("| 5 - Nome aleatório de 5 pessoas                       |");
                Console.WriteLine("| 6 - Calcular Raio e Área                              |");
                Console.WriteLine("| 7 - Avaliar se TXT tem C#                             |");
                Console.WriteLine("| 8 - 10 primeiros dígitos                              |");
                Console.WriteLine("| 9 - Área com a Main                                   |");
                Console.WriteLine("| 10 - Receba nome de arquivo na Main com valores       |");
                Console.WriteLine("| 11 - Ler e imprimir arquivo de texto                  |");
                Console.WriteLine("+-------------------------------------------------------+");

                Console.WriteLine("Digite a opção desejada : ");
                int atv2 = Int32.Parse(Console.ReadLine());
                switch (atv2)
                {
                    case 1:
                        TabuadaArquivo();
                        break;
                    case 2:
                        LereImprimir();
                        break;
                    case 3:
                        OPreaçãobasica();
                        break;
                    case 4:
                        Exponenciacao();
                        break;
                    case 5:
                        NomeAleatorio();
                        break;
                    case 6:
                        CalcularRaio();
                        break;
                    case 7:
                        Avaliarsetxt();
                        break;
                    case 8:
                        DezDigitos();
                        break;
                    case 9:
                        AreaMain();
                        break;
                    case 10:
                        arquivonaMaincomvalores();
                        break;
                    case 11:
                        lerarquivodetexto();
                        break;
                }
            }



            private static void TabuadaArquivo()
            {
                Console.WriteLine("Insira o valor para a tabuada:");
                int value = Convert.ToInt32(Console.ReadLine());

                string filePath = "tabuada.txt";
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    for (int i = 1; i <= 10; i++)
                    {
                        int result = value * i;
                        writer.WriteLine(value + " x " + i + " = " + result);
                    }
                }

                Console.WriteLine("Tabuada salva com sucesso em " + filePath);
            }
        }

        private static void LereImprimir()
        {
            Console.WriteLine("Insira o caminho do arquivo:");
            string filePath = Console.ReadLine();

            if (!File.Exists(filePath))
            {
                Console.WriteLine("Arquivo não encontrado");
                return;
            }

            Console.WriteLine("Conteúdo do arquivo:");
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);

                }
            }
        }


        private static void Exponenciacao()
        {
            Console.WriteLine("Insira o caminho do arquivo:");
            string filePath = Console.ReadLine();

            if (!File.Exists(filePath))
            {
                Console.WriteLine("Arquivo não encontrado");
                return;
            }

            Console.WriteLine("Conteúdo do arquivo:");
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
                Console.WriteLine("Resultado: " + filePath);




            }

        }

        private static void OPreaçãobasica()
        {
            Console.WriteLine("Insira o primeiro valor:");
            float value1 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Insira o segundo valor:");
            float value2 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Escolha a operação (+, -, *, /):");
            string operation = Console.ReadLine();

            float result;
            switch (operation)
            {
                case "+":
                    result = value1 + value2;
                    break;
                case "-":
                    result = value1 - value2;
                    break;
                case "*":
                    result = value1 * value2;
                    break;
                case "/":
                    result = value1 / value2;
                    break;
                default:
                    Console.WriteLine("Operação inválida");
                    return;
            }
        }
        private static void NomeAleatorio()
        {
            Console.WriteLine("Insira o caminho do arquivo:");
            string filePath = Console.ReadLine();

            if (!File.Exists(filePath))
            {
                Console.WriteLine("Arquivo não encontrado");
                return;
            }

            Console.WriteLine("Conteúdo do arquivo:");
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
        private static void CalcularRaio()
        {
            Console.WriteLine("Insira o valor do raio:");
            double radius = Convert.ToDouble(Console.ReadLine());

            double circumference = 2 * Math.PI * radius;
            double area = Math.PI * Math.Pow(radius, 2);

            Console.WriteLine("Circunferência: " + circumference);
            Console.WriteLine("Área: " + area);
        }
        private static void Avaliarsetxt()
        {
            Console.WriteLine("Insira o caminho do arquivo:");
            string filePath = Console.ReadLine();

            if (!File.Exists(filePath))
            {
                Console.WriteLine("Arquivo não encontrado.");
                return;
            }

            string fileContent = File.ReadAllText(filePath);

            if (fileContent.Contains("C#"))
            {
                Console.WriteLine("Arquivo possui a string 'C#'.");
            }
            else
            {
                Console.WriteLine("Arquivo não possui a string 'C#'.");
            }
        }

        private static void DezDigitos()
        {
            Console.WriteLine("Insira o caminho do arquivo:");
            string filePath = Console.ReadLine();

            if (!File.Exists(filePath))
            {
                Console.WriteLine("Arquivo não encontrado.");
                return;
            }

            string[] fileLines = File.ReadAllLines(filePath);

            foreach (string line in fileLines)
            {
                string firstTenDigits = line.Length >= 10 ? line.Substring(0, 10) : line;
                Console.WriteLine(firstTenDigits);
            }

        }

        private static void AreaMain()
        {
            Console.WriteLine("Insira o valor do primeiro lado:");
            double lado1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o valor do segundo lado:");
            double lado2 = double.Parse(Console.ReadLine());

            double area = lado1 * lado2;

            Console.WriteLine("A área é: " + area);
        }

        private static void arquivonaMaincomvalores()
        {
            Console.WriteLine("Insira o nome do arquivo de texto:");
            string fileName = Console.ReadLine();

            if (!File.Exists(fileName))
            {
                Console.WriteLine("Arquivo não encontrado");
                return;
            }

            double sum = 0;

            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    double value = double.Parse(line);
                    sum += value;
                }
            }

            Console.WriteLine("A soma dos valores no arquivo é: " + sum);
        }

        private static void lerarquivodetexto()
        {
            string fileName = "words.txt";
            string[] words = File.ReadAllLines(fileName);

            Random random = new Random();
            int wordIndex = random.Next(0, words.Length);

            string word = words[wordIndex].ToUpper();
            char[] guessedWord = new char[word.Length];
            for (int i = 0; i < word.Length; i++)
            {
                guessedWord[i] = '_';
            }

            int lives = 6;
            while (lives > 0)
            {
                Console.WriteLine("Adivinhe a palavra: " + new string(guessedWord));
                Console.WriteLine("Vidas restantes: " + lives);

                Console.WriteLine("Digite uma letra:");
                char guess = Console.ReadLine().ToUpper()[0];

                bool correctGuess = false;
                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i] == guess)
                    {
                        guessedWord[i] = guess;
                        correctGuess = true;
                    }
                }

                if (!correctGuess)
                {
                    lives--;
                }

                if (new string(guessedWord) == word)
                {
                    Console.WriteLine("Você ganhou! A palavra era " + word);
                    return;
                }
            }

            Console.WriteLine("Você perdeu! A palavra era " + word);
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string? ToString()
        {
            return base.ToString();
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }

}













