using System;
using System.Collections.Generic;
using System.Text;

namespace ProgInternetIII
{
    class ContaSalario : Conta
    {
        public ContaSalario(Pessoa titular, long numero, int agencia, double saldo, double taxaSaque)
        {
            this.Titular = titular;
            this.Numero = numero;
            this.Agencia = agencia;
            this.Saldo = saldo;
            this.TaxaSaque = taxaSaque;
        }

        public override double Consultar()
        {
            Console.WriteLine("Saldo disponivel: " + Saldo);
            return Saldo;
        }

        public override void Sacar(double valor)
        {
            if (valor <= Saldo)
            {
                Saldo = Saldo - valor;
                Console.WriteLine("saque efetuado. Saldo restante = " + Saldo);
            }
            else {
                Console.WriteLine("Saldo insuficiente");
            }
        }

        public override void Transferir(Conta conta, double valor)
        {
            if (conta.Titular == Titular && Saldo >= valor)
            {
                Saldo = Saldo - valor;
                conta.Saldo = conta.Saldo + valor;
                Console.WriteLine("transiçao efetuada");
            }
            else
            {
                Console.WriteLine("falha na transiçao");
            }
        }
    }
}
