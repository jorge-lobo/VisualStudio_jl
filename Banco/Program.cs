using Banco;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        ContaBancaria cb;

        Console.WriteLine("Entre com o nº de conta: ");
        int numconta = int.Parse(Console.ReadLine());
        Console.WriteLine("Nome do titular de conta");
        string nometitular = Console.ReadLine();
        Console.WriteLine("Deseja fazer um depósito inicial?");
        char resp = char.Parse(Console.ReadLine());
        if (resp == 's' || resp == 'S')
        {
            Console.WriteLine("Qual é o valor do depósito inicial?");
            double depositoIncial = double.Parse(Console.ReadLine());
            cb = new ContaBancaria(numconta, nometitular, depositoIncial);
        }
        else
        {
            cb = new ContaBancaria(numconta, nometitular);
        }

        Console.WriteLine();
        Console.WriteLine("Dados da conta: ");
        Console.WriteLine(cb);
        Console.WriteLine();

        Console.WriteLine("Valor a depositar: ");
        double quantia = double.Parse(Console.ReadLine());
        cb.Deposito(quantia);
        Console.WriteLine("Dados actualizados da conta: ");
        Console.WriteLine(cb);
        Console.WriteLine();

        Console.WriteLine("Valor a levantar: ");
        quantia = double.Parse(Console.ReadLine());
        cb.Levantamento(quantia);
        Console.WriteLine("Dados actualizados da conta: ");
        Console.WriteLine(cb);

        cb.NomeTitular = "Teresa";
        Console.WriteLine(cb);
    }
}