class TraceMachine
{
    private List<string> trace = new List<string>();

    public void AddOperation(string operation)
    {
        trace.Add(operation);
    }

    public void PrintTrace()
    {
        string tracer = "";
        foreach (var operation in trace)
        {
            tracer += operation;
        }
        Console.WriteLine(tracer);
    }
}


class Program
{
    static void Main(string[] args)
    {
        TraceMachine machine = new TraceMachine();


        // Lista de palavras
        List<string> palavras = new List<string> { "exemplo", "forca", "programacao", "computador" }; machine.AddOperation("A");
        Random random = new Random(); machine.AddOperation("B");
        string palavra = palavras[random.Next(palavras.Count)]; machine.AddOperation("C");
        char[] descoberto = new char[palavra.Length]; machine.AddOperation("D");
        List<char> tentativas = new List<char>(); machine.AddOperation("E");
        int i = 0; machine.AddOperation("F");
        machine.AddOperation("G");
        descoberto = PreencherDescobertoRecursivamente(descoberto, i);
        int erro = 0; machine.AddOperation("J");

        Jogar(descoberto, tentativas, erro, palavra, random, i);

        machine.PrintTrace();

        void ImprimirTentativas(List<char> tentativas, int i)
        {
            if (i < tentativas.Count)
            {
                machine.AddOperation("L");
                Console.Write(tentativas[i] + " ");

                ImprimirTentativas(tentativas, i + 1);
            }
        }

        char[] PreencherDescobertoRecursivamente(char[] descoberto, int i)
        {
            if (i < descoberto.Length)
            {
                machine.AddOperation("H");
                descoberto[i] = '_';
                PreencherDescobertoRecursivamente(descoberto, i + 1);
            }
            return descoberto;
        }

        char[] ColocarLetraNoArray(int i, string palavra, char n, char[] descoberto)
        {
            machine.AddOperation("P");
            if (i >= palavra.Length)
            {
                return descoberto;
            }

            if (palavra[i] == n)
            {
                machine.AddOperation("Q");
                descoberto[i] = n;
            }
            return ColocarLetraNoArray(i + 1, palavra, n, descoberto);
        }

        void Jogar(char[] descoberto, List<char> tentativas, int erro, string palavra, Random random, int i)
        {
            if (erro < 6 && new string(descoberto).Contains('_'))
            {
                machine.AddOperation("K");
                Console.WriteLine("\nPalavra: " + new string(descoberto));
                Console.WriteLine("Erros: " + erro);
                Console.Write("Tentativas: ");
                ImprimirTentativas(tentativas, i);
                machine.AddOperation("K");
                Console.WriteLine("\nDigite uma letra:");
                char n = Console.ReadKey().KeyChar;
                Console.WriteLine();

                if (tentativas.Contains(n))
                {
                    machine.AddOperation("M");
                    Console.Clear();
                    Console.WriteLine("Letra já tentada.");
                    Jogar(descoberto, tentativas, erro, palavra, random, i);
                }
                else
                {
                    machine.AddOperation("N");
                    tentativas.Add(n);
                    if (palavra.Contains(n.ToString()))
                    {
                        machine.AddOperation("O");
                        descoberto = ColocarLetraNoArray(i, palavra, n, descoberto);
                        machine.AddOperation("O");
                        Console.Clear();
                        Jogar(descoberto, tentativas, erro, palavra, random, i);
                    }
                    else
                    {
                        machine.AddOperation("R");
                        Console.Clear();
                        erro++;
                        Jogar(descoberto, tentativas, erro, palavra, random, i);
                    }
                }
            }

            else if (!new string(descoberto).Contains('_'))
            {
                machine.AddOperation("S");
                Console.WriteLine("Você venceu! A palavra era: " + palavra);
            }
            else
            {
                machine.AddOperation("T");
                Console.WriteLine("Você perdeu. A palavra era: " + palavra);
            }
        }
    }
}
