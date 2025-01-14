using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nEscolha o teste para rodar:");
            Console.WriteLine("1 - Soma Progressiva");
            Console.WriteLine("2 - Verificar Fibonacci");
            Console.WriteLine("3 - Análise de Faturamento");
            Console.WriteLine("4 - Percentual de Estados");
            Console.WriteLine("5 - Inverter String");
            Console.WriteLine("0 - Sair");
            Console.Write("Opção: ");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    SomaProgressiva.Executar();
                    break;
                case "2":
                    Fibonacci.Executar();
                    break;
                case "3":
                    Faturamento.Executar();
                    break;
                case "4":
                    PercentualEstados.Executar();
                    break;
                case "5":
                    InverterString.Executar();
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Opção inválida, tente novamente.");
                    break;
            }
        }
    }
}
