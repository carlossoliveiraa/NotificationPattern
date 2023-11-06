using Solucao.Notificacoes.Console;
using System.Text.Json;

internal class Program
{
    private static void Main(string[] args)
    {

        var verificacao = new Verificadora().Execute();

        Console.WriteLine(JsonSerializer.Serialize(verificacao));

        Console.ReadKey();


    }
}