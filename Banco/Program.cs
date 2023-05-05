using Banco;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        /*char RespInicial;

        Console.WriteLine("Introduza os dados da nova conta bancária:");
        Console.WriteLine("Número de conta: ");
        int numconta = int.Parse(Console.ReadLine());
        Console.WriteLine("Nome do titular: ");
        string nometitular = Console.ReadLine();

        Console.WriteLine("Deseja fazer um depósito inicial?: s/n");
        RespInicial = char.Parse(Console.ReadLine());
                
        if (RespInicial == 's')
        {
            Console.WriteLine("Depósito inicial: ");
            double depinicial = double.Parse(Console.ReadLine());
            ContaBancaria cb = new ContaBancaria(numconta, nometitular, depinicial);
            Console.WriteLine("Conta: " + cb);
            Console.WriteLine();
            Console.WriteLine("Indique a quantia a depositar: ");
            double valor1 = double.Parse(Console.ReadLine());
            cb.Deposito(valor1);
            Console.WriteLine();
            Console.WriteLine("Conta actualizada: Conta: " + cb);
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("Indique a quantia a levantar: ");
            double valor2 = double.Parse(Console.ReadLine());
            cb.Levantamento(valor2);
            Console.WriteLine();
            Console.WriteLine("Conta actualizada: Conta: " + cb);
            Console.WriteLine();
        }
        
        if (RespInicial == 'n')
        {
            double depinicial = 0;
            ContaBancaria cb = new ContaBancaria(numconta, nometitular, depinicial);
            Console.WriteLine("Conta: " + cb); Console.WriteLine();
            Console.WriteLine("Indique a quantia a depositar: ");
            double valor1 = double.Parse(Console.ReadLine());
            cb.Deposito(valor1);
            Console.WriteLine();
            Console.WriteLine("Conta actualizada: Conta: " + cb);
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("Indique a quantia a levantar: ");
            double valor2 = double.Parse(Console.ReadLine());
            cb.Levantamento(valor2);
            Console.WriteLine();
            Console.WriteLine("Conta actualizada: Conta: " + cb);
            Console.WriteLine();
        }*/

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

        cb.NomeTitular = "Maria";
        Console.WriteLine(cb);
    }
}