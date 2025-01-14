using System;
using System.Collections.Generic;
using System.Linq;

class PercentualEstados
{
    public static void Executar()
    {
        Dictionary<string, double> faturamentoEstados = new Dictionary<string, double>
        {
            { "SP", 67836.43 },
            { "RJ", 36678.66 },
            { "MG", 29229.88 },
            { "ES", 27165.48 },
            { "Outros", 19849.53 }
        };

        double total = faturamentoEstados.Values.Sum();

        Console.WriteLine("\nPercentual de participação por estado:");
        foreach (var estado in faturamentoEstados)
        {
            Console.WriteLine($"{estado.Key}: {(estado.Value / total) * 100:F2}%");
        }
    }
}
