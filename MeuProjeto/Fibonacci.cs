using System;

class Fibonacci
{
    public static void Executar()
    {
        Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());

        int a = 0, b = 1, soma = 0;

        while (soma < numero)
        {
            soma = a + b;
            a = b;
            b = soma;
        }

        if (soma == numero || numero == 0)
            Console.WriteLine($"{numero} pertence à sequência de Fibonacci.");
        else
            Console.WriteLine($"{numero} NÃO pertence à sequência de Fibonacci.");
    }
}