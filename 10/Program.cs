using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número inteiro: ");
        int numero = int.Parse(Console.ReadLine());

        Console.Write("Contagem regressiva: ");
        for (int i = numero; i >= 0; i--)
        {
            if (i > 0)
                Console.Write($"{i}, ");
            else
                Console.Write($"{i}");
        }
        Console.WriteLine();
    }
}