using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    internal class ContaBancaria
    {
        // Definição de propriedades

        public int NrConta { get; }
        public string NomeTitular { get; set; }
        public double Saldo { get; private set; }


        // Construtores


        //este construtor permite instanciar contas bancárias apenas com o nº deconta e o seu titular
        public ContaBancaria(int numconta, string nometitular)
        {
            NrConta = numconta;
            NomeTitular = nometitular;
        }

        // este construtor permite instanciar uma conta a partir do seu nº de conta, titular e também do seu saldo inicial
        public ContaBancaria(int numconta, string nometitular, double saldo) : this(numconta, nometitular)
        {
            Saldo = saldo;
        }

        // Secção de Métodos

        // este é o método que permite depositar na conta

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        // este é o método que permite depositar na conta

        public void Levantamento(double quantia)
        {
            Saldo -= quantia + 5.00;
        }


        public override string ToString()
        {
            return "Conta bancária número: "
                    + NrConta
                    + ", Titular: "
                    + NomeTitular
                    + ", Saldo: "
                    + Saldo.ToString("F2")
                    + " euros.";
        }


    }
}
