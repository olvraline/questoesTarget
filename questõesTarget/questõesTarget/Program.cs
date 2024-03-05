

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

/* questão 3

a) 1, 3, 5, 7, ___

Está aumentando de dois em dois. O próximo é 9.
b) 2, 4, 8, 16, 32, 64, ___

Cada número é o dobro do anterior. Então, o próximo é 128.
c) 0, 1, 4, 9, 16, 25, 36, ___

É tipo os quadrados dos números naturais. O próximo é 7², que é 49.
d) 4, 16, 36, 64, ___

Esses são os quadrados dos números pares. Então, o próximo é 8², que é 64.
e) 1, 1, 2, 3, 5, 8, ___

Aqui é a sequência de Fibonacci, somando sempre os dois anteriores. O próximo é 5 + 8, que dá 13.
f) 2, 10, 12, 16, 17, 18, 19, ___

Está aumentando de oito em oito. O próximo é 19 + 8, que é 27.
Essas sequências são meio malucas, mas cada uma tem a sua lógica especial!



/* questão 4 

Primeira rodada:

ligaria o primeiro interruptor e daria uma pausa.
Desligo o primeiro e boto o segundo pra funcionar.
Segunda rodada:

na sala das lâmpadas.
Se a primeira tá acesa, é porque o primeiro interruptor é dela.
Agora, vou sentir a lâmpada que tá apagada.
Se ela tá quente, o segundo interruptor é dela.
Se ela tá fria, é o terceiro interruptor.


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