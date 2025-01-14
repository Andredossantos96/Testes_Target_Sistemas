using System;

class InverterString
{
    public static void Executar()
    {
        Console.Write("Digite uma string: ");
        string input = Console.ReadLine();

        char[] caracteres = new char[input.Length];
        for (int i = 0; i < input.Length; i++)
        {
            caracteres[i] = input[input.Length - 1 - i];
        }

        Console.WriteLine($"String invertida: {new string(caracteres)}");
    }
}
