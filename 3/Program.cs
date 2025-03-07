using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite a primeira data: ");
        DateTime data1 = DateTime.Parse(Console.ReadLine());
        Console.Write("Digite a segunda data: ");
        DateTime data2 = DateTime.Parse(Console.ReadLine());

        if (data2 < data1)
        {
            DateTime temp = data1;
            data1 = data2;
            data2 = temp;
        }

        TimeSpan intervalo = data2 - data1;

        int anos = data2.Year - data1.Year;
        int meses = data2.Month - data1.Month;
        int dias = data2.Day - data1.Day;

        if (dias < 0)
        {
            meses--;
            dias += DateTime.DaysInMonth(data2.AddMonths(-1).Year, data2.AddMonths(-1).Month);
        }

        if (meses < 0)
        {
            anos--;
            meses += 12;
        }

        Console.WriteLine($"Diferença: {anos} ano(s), {meses} mês(es) e {dias} dia(s).");
        Console.WriteLine($"Total em dias: {intervalo.Days}");
    }
}