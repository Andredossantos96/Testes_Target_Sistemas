using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());

        if (PertenceFibonacci(numero))
        {
            Console.WriteLine($"{numero} pertence à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine($"{numero} NÃO pertence à sequência de Fibonacci.");
        }
    }

    static bool PertenceFibonacci(int n)
    {
        int a = 0, b = 1, soma = 0;

        while (soma < n)
        {
            soma = a + b;
            a = b;
            b = soma;
        }

        return soma == n || n == 0;
    }
}
