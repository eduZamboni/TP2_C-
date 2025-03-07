using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite a temperatura em graus Celsius: ");
        double celsius = double.Parse(Console.ReadLine());

        double fahrenheit = celsius * 9 / 5 + 32;
        double kelvin = celsius + 273.15;

        Console.WriteLine($"Fahrenheit: {fahrenheit:F2}");
        Console.WriteLine($"Kelvin: {kelvin:F2}");
    }
}