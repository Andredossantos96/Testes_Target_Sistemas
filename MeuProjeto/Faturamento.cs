using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

class Faturamento
{
    public static void Executar()
    {
        string jsonPath = @"C:\Users\andre.curvina\Documents\Teste_T\MeuProjeto\dados.json";

        if (!File.Exists(jsonPath))
        {
            Console.WriteLine("Arquivo JSON não encontrado.");
            return;
        }

        try
        {
            string jsonString = File.ReadAllText(jsonPath);

            List<DadosFaturamento> faturamentos = JsonSerializer.Deserialize<List<DadosFaturamento>>(jsonString);

            var faturamentoValido = faturamentos.Where(f => f.Valor > 0).ToList();

            if (faturamentoValido.Count == 0)
            {
                Console.WriteLine("Não há dados válidos de faturamento.");
                return;
            }

            double menorFaturamento = faturamentoValido.Min(f => f.Valor);
            double maiorFaturamento = faturamentoValido.Max(f => f.Valor);
            double mediaMensal = faturamentoValido.Average(f => f.Valor);
            int diasAcimaMedia = faturamentoValido.Count(f => f.Valor > mediaMensal);

            Console.WriteLine($"Menor faturamento: R$ {menorFaturamento:F2}");
            Console.WriteLine($"Maior faturamento: R$ {maiorFaturamento:F2}");
            Console.WriteLine($"Dias acima da média mensal: {diasAcimaMedia}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao processar o arquivo JSON: {ex.Message}");
        }
    }

    class DadosFaturamento
    {
        [JsonPropertyName("dia")]
        public int Dia { get; set; }

        [JsonPropertyName("valor")]
        public double Valor { get; set; }
    }
}
