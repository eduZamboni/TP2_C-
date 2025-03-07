using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite sua data de nascimento:");
        DateTime dataNascimento = DateTime.Parse(Console.ReadLine());
        DateTime hoje = DateTime.Today;
        DateTime proximoAniversario = new DateTime(hoje.Year, dataNascimento.Month, dataNascimento.Day);
        if (proximoAniversario < hoje) proximoAniversario = proximoAniversario.AddYears(1);
        int diasFaltam = (proximoAniversario - hoje).Days;
        Console.WriteLine($"Faltam {diasFaltam} dias para seu próximo aniversário.");
    }
}