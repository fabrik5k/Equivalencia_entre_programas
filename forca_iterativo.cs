using System;

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


        List<string> palavras = new List<string> { "computador" }; machine.AddOperation("A");
        Random random = new Random(); machine.AddOperation("B");
        string palavra = palavras[random.Next(palavras.Count)]; machine.AddOperation("C");
        char[] descoberto = new char[palavra.Length]; machine.AddOperation("D");
        List<char> tentativas = new List<char>(); machine.AddOperation("E");
        int i = 0; machine.AddOperation("F");
        while (i < descoberto.Length) { machine.AddOperation("H"); descoberto[i] = '_'; i++; }
        int erro = 0; machine.AddOperation("J");


        while (erro < 6 && new string(descoberto).Contains('_'))
        {
            machine.AddOperation("K");
            Console.WriteLine("\nPalavra: " + new string(descoberto));
            Console.WriteLine("Erros: " + erro);
            Console.Write("Tentativas: ");
            i = 0; machine.AddOperation("F");
            while (i < tentativas.Count)
            {
                machine.AddOperation("L");
                Console.Write(tentativas[i] + " ");
                i++;
            }
            machine.AddOperation("K");
            Console.WriteLine("\nDigite uma letra:");
            char n = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (tentativas.Contains(n))
            {
                machine.AddOperation("M");
                Console.Clear();
                Console.WriteLine("Letra já tentada.");
                continue;
            }
            else
            {
                machine.AddOperation("N");
                tentativas.Add(n);
                if (palavra.Contains(n.ToString()))
                {
                    machine.AddOperation("O");
                    i = 0; machine.AddOperation("F");
                    while (i < palavra.Length) { machine.AddOperation("P"); if (palavra[i] == n) { machine.AddOperation("Q"); descoberto[i] = n; } i++; }
                    machine.AddOperation("O");
                    Console.Clear();
                    continue;
                }
                else
                {
                    machine.AddOperation("R");
                    Console.Clear();
                    erro++;
                    continue;
                }
            }
        }

        if (!new string(descoberto).Contains('_'))
        {
            machine.AddOperation("S");
            Console.WriteLine("Você venceu! A palavra era: " + palavra);
        }
        else
        {
            machine.AddOperation("T");
            Console.WriteLine("Você perdeu. A palavra era: " + palavra);
        }
        machine.PrintTrace();
    }
}

