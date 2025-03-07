using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite sua data de nascimento:");
        string input = Console.ReadLine();

        if (!DateTime.TryParse(input, out DateTime dataNascimento))
        {
            Console.WriteLine("Data inválida. Certifique-se de usar o formato.");
            return;
        }

        DateTime hoje = DateTime.Today;

        int anos = hoje.Year - dataNascimento.Year;
        int meses = hoje.Month - dataNascimento.Month;
        int dias = hoje.Day - dataNascimento.Day;

        if (dias < 0)
        {
            meses--;

            DateTime mesAnterior = hoje.AddMonths(-1);
            dias += DateTime.DaysInMonth(mesAnterior.Year, mesAnterior.Month);
        }

        if (meses < 0)
        {
            meses += 12;
            anos--;
        }

        Console.WriteLine($"Você tem {anos} anos, {meses} meses e {dias} dias de idade.");
    }
}