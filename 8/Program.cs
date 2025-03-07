using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite uma nota de 0 a 10: ");
        double nota = double.Parse(Console.ReadLine());

        if (nota < 0 || nota > 10)
        {
            Console.WriteLine("Nota inválida!");
        }
        else if (nota < 5)
        {
            Console.WriteLine("Insuficiente");
        }
        else if (nota < 7)
        {
            Console.WriteLine("Regular");
        }
        else if (nota < 9)
        {
            Console.WriteLine("Bom");
        }
        else
        {
            Console.WriteLine("Excelente");
        }
    }
}