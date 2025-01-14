using System;

class Program
{
    static void Main()
    {
        double sp = 67836.43;
        double rj = 36678.66;
        double mg = 29229.88;
        double es = 27165.48;
        double outros = 19849.53;

        double total = sp + rj + mg + es + outros;

        Console.WriteLine($"Percentual de SP: {((sp / total) * 100):F2}%");
        Console.WriteLine($"Percentual de RJ: {((rj / total) * 100):F2}%");
        Console.WriteLine($"Percentual de MG: {((mg / total) * 100):F2}%");
        Console.WriteLine($"Percentual de ES: {((es / total) * 100):F2}%");
        Console.WriteLine($"Percentual de Outros: {((outros / total) * 100):F2}%");
    }
}
