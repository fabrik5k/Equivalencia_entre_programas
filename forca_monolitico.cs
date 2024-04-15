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


        R1: List<string> palavras = new List<string> { "computador" }; machine.AddOperation("A"); goto R2;
        R2: Random random = new Random(); machine.AddOperation("B"); goto R3;
        R3: string palavra = palavras[random.Next(palavras.Count)]; machine.AddOperation("C"); goto R4;
        R4: char[] descoberto = new char[palavra.Length]; machine.AddOperation("D"); goto R5;
        R5: List<char> tentativas = new List<char>(); machine.AddOperation("E"); goto R6;
        R6: int i = 0; machine.AddOperation("F"); goto R7;
        R7: if (i < descoberto.Length) goto R8; else goto R9;
        R8: machine.AddOperation("H"); descoberto[i] = '_'; i++; goto R7;
        R9: int erro = 0; machine.AddOperation("J"); goto R10;
        R10: if (erro < 6 && new string(descoberto).Contains('_')) goto R11; else goto Rx;
        R11: machine.AddOperation("K"); Console.WriteLine("\nPalavra: " + new string(descoberto)); goto R12;
        R12: Console.WriteLine("Erros: " + erro); goto R13;
        R13: Console.Write("Tentativas: "); goto R14;
        R14: i = 0; machine.AddOperation("F"); goto R15;
        R15: if (i < tentativas.Count) goto R16; else goto R19;
        R16: machine.AddOperation("L"); var tentativa = tentativas[i]; goto R17;
        R17: Console.Write(tentativa + " "); goto R18;
        R18: i++; goto R15;
        R19: Console.WriteLine("\nDigite uma letra:"); machine.AddOperation("K"); goto R20;
        R20: char n = Console.ReadKey().KeyChar; goto R21;
        R21: Console.WriteLine(); goto R22;
        R22: if (tentativas.Contains(n)) goto R23; else goto R24;
        R23: Console.Clear(); Console.WriteLine("Letra já tentada."); machine.AddOperation("M"); goto R10;
        R24: tentativas.Add(n); machine.AddOperation("N"); goto R25;
        R25: if (palavra.Contains(n.ToString())) goto R26; else goto R30;
        R26: machine.AddOperation("O"); machine.AddOperation("F"); i = 0; goto R27;
        R27: if (i < palavra.Length) { machine.AddOperation("P"); goto R28; } else { machine.AddOperation("O"); Console.Clear(); goto R10; }
        R28: if (palavra[i] == n) { machine.AddOperation("Q"); descoberto[i] = n; } goto R29;
        R29: i++; goto R27;
        R30: machine.AddOperation("R"); Console.Clear(); erro++; goto R10;


        Rx: if (!new string(descoberto).Contains('_')) goto Rx1; else goto Rx2;
        Rx1: Console.WriteLine("Você venceu! A palavra era: " + palavra); machine.AddOperation("S"); goto Fim;
        Rx2: Console.WriteLine("Você perdeu. A palavra era: " + palavra); machine.AddOperation("T"); goto Fim;

        Fim: Console.WriteLine("Programa encerrado");

        machine.PrintTrace();
    }
}
