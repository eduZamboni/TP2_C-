using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o salário bruto: ");
        double salarioBruto = double.Parse(Console.ReadLine());
        double desconto = 0.0;

        if (salarioBruto <= 2000)
        {
            desconto = 0; // Isento
        }
        else if (salarioBruto <= 3000)
        {
            desconto = salarioBruto * 0.08; // 8%
        }
        else if (salarioBruto <= 4500)
        {
            desconto = salarioBruto * 0.18; // 18%
        }
        else
        {
            desconto = salarioBruto * 0.27; // 27%
        }

        double salarioLiquido = salarioBruto - desconto;

        Console.WriteLine($"\nSalário Bruto: {salarioBruto:C2}");
        Console.WriteLine($"Descontos: {desconto:C2}");
        Console.WriteLine($"Salário Líquido: {salarioLiquido:C2}");
    }
}