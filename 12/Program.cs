using System;

class Program
{
    static void Main()
    {
        Random rnd = new Random();
        int numeroSecreto = rnd.Next(1, 101);
        int palpite = 0;

        Console.WriteLine("Adivinhe o número (1 a 100):");

        while (palpite != numeroSecreto)
        {
            Console.Write("Seu palpite: ");
            palpite = int.Parse(Console.ReadLine());

            if (palpite < numeroSecreto)
                Console.WriteLine("O número é maior!");
            else if (palpite > numeroSecreto)
                Console.WriteLine("O número é menor!");
            else
                Console.WriteLine("Parabéns, você acertou!");
        }
    }
}