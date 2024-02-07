
/* questão 1

explicação:

O código está somando números de 1 a 13. A variável SOMA armazena a soma desses números. No final, o valor de SOMA será 91.



/* questão 2
class program
{

    static void Main()
    {
        Console.Write("informe um  numero: ");
        int numeroInformado = Convert.ToInt32(Console.ReadLine());

        if
        (IsFibonacci(numeroInformado))

            Console.WriteLine($"O numero {numeroInformado} pertence à sequencia de Finbonacci. ");
        {


else
            {

                Console.WriteLine($"O numero {numeroInformado} não pertence à sequencia de Finbonacci. ");
            }
        }

        static bool IsFibonacci(int n)
        {

            int a = 0, b = 1;
            while (b <= n)

            {
                if (b == n)
                    return true;

                int temp = a;
                a = b;
                b = temp + b;

            }
            return false;
        }
}

/*questão 3
class Program
{
    static void Main()
    {
        double[] faturamentoDiario = { 876,4,674,34,34,5874,36486,9,12,54};

        if (faturamentoDiario.Length > 0)
        {
            double menorFaturamento = faturamentoDiario.Min();
            double maiorFaturamento = faturamentoDiario.Max();
            int diasAcimaMedia = ContarDiasAcimaMedia(faturamentoDiario);

            Console.WriteLine($"Menor faturamento: {menorFaturamento}");
            Console.WriteLine($"Maior faturamento: {maiorFaturamento}");
            Console.WriteLine($"Dias acima da média anual: {diasAcimaMedia}");
        }
        else
        {
            Console.WriteLine("O vetor de faturamento diário está vazio.");
        }
    }

    static int ContarDiasAcimaMedia(double[] faturamento)
    {
        double mediaAnual = faturamento.Where(valor => valor > 0).DefaultIfEmpty(0).Average();
        return faturamento.Count(valor => valor > mediaAnual);
    }
}


/*questão 4
class Program
{
    static void Main()
    {
        double[] faturamento = { 67836.43, 36678.66, 29229.88, 27165.48, 19849.53 };

        double totalFaturamento = faturamento.Sum();

        Console.WriteLine("Percentual de representação por estado:");
        faturamento.Select((valor, index) =>
        {
            double percentual = (valor / totalFaturamento) * 100;
            Console.WriteLine($"{ObterEstado(index)}: {percentual:F2}%");
            return percentual;
        }).ToList();
    }

    static string ObterEstado(int index)
    {
        string[] estados = { "SP", "RJ", "MG", "ES", "Outros" };
        return estados[index];
    }
}

/* questão 5

{
    static void Main()
    {
        Console.WriteLine("Digite uma palavra/string:");
        string inputString = Console.ReadLine();

        string reversedString = InverterString(inputString);

        Console.WriteLine($"String invertida: {reversedString}");
    }

    static string InverterString(string str)
    {
        char[] charArray = str.ToCharArray();
        int length = charArray.Length;

        for (int i = 0; i < length / 2; i++)
        {
            char temp = charArray[i];
            charArray[i] = charArray[length - i - 1];
            charArray[length - i - 1] = temp;
        }

        return new string(charArray);
    }
}