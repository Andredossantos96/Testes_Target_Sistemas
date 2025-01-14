using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string jsonPath = "dados.json";
        if (!File.Exists(jsonPath))
        {
            Console.WriteLine("Arquivo JSON não encontrado.");
            return;
        }

        string jsonString = File.ReadAllText(jsonPath);
        List<Faturamento> faturamentos = JsonSerializer.Deserialize<List<Faturamento>>(jsonString);

        var faturamentoValido = faturamentos.Where(f => f.Valor > 0).ToList();

        if (faturamentoValido.Count == 0)
        {
            Console.WriteLine("Não há dados válidos de faturamento.");
            return;
        }

        double menorFaturamento = faturamentoValido.Min(f => f.Valor);
        double maiorFaturamento = faturamentoValido.Max(f => f.Valor);
        double mediaMensal = faturamentoValido.Average(f => f.Valor);

        int diasAcimaDaMedia = faturamentoValido.Count(f => f.Valor > mediaMensal);

        Console.WriteLine($"Menor faturamento: R$ {menorFaturamento:F2}");
        Console.WriteLine($"Maior faturamento: R$ {maiorFaturamento:F2}");
        Console.WriteLine($"Dias acima da média mensal: {diasAcimaDaMedia}");
    }
}

class Faturamento
{
    public int Dia { get; set; }
    public double Valor { get; set; }
}
