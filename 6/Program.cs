using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite seu peso (kg): ");
        double peso = double.Parse(Console.ReadLine());

        Console.Write("Digite sua altura (m): ");
        double altura = double.Parse(Console.ReadLine());

        double imc = peso / (altura * altura);
        Console.WriteLine($"Seu IMC é {imc:F2}");

        if (imc < 18.5) Console.WriteLine("Abaixo do peso");
        else if (imc < 24.9) Console.WriteLine("Peso normal");
        else if (imc < 29.9) Console.WriteLine("Sobrepeso");
        else if (imc < 34.9) Console.WriteLine("Obesidade Grau I");
        else if (imc < 39.9) Console.WriteLine("Obesidade Grau II");
        else Console.WriteLine("Obesidade Grau III ou Mórbida");
    }
}