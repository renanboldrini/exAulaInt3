using System;
using System.Collections.Generic;
using System.Text;

namespace ProgInternetIII
{
    class ContaCorrente : Conta, Depositavel
    {
        public string Tipo { get; set; }

        public double Limite { get; set; }

        public double TaxaDoLimite { get; set; }

        public ContaCorrente(string tipo, double limite, double taxaDoLimite, Pessoa titular, long numero, int agencia, double saldo, double taxaSaque)
        {
            this.Tipo = tipo;
            this.Limite = limite;
            this.TaxaDoLimite = taxaDoLimite;
            this.Titular = titular;
            this.Numero = numero;
            this.Agencia = agencia;
            this.Saldo = saldo;
            this.TaxaSaque = taxaSaque;
        }

        public void Pagar(string codigoBarras)
        {
            //nao foi especificado
        }

        public void Emprestimo(double Valor) {
            //nao foi especificado
        }
        public override double Consultar()
        {
            Console.WriteLine("Saldo disponivel: " + Saldo);
            return Saldo;
        }

        public void Depositar(double valor)
        {
            Saldo = Saldo + valor;
            Console.WriteLine("sdeposito efetuado com sucesso");
        }

        public override void Sacar(double valor)
        {
            if (valor + TaxaSaque <= (Saldo + Limite))
            {
                Saldo = Saldo - (valor + TaxaSaque);
                Console.WriteLine("saque efetuado. Saldo restante = " + Saldo);
            }
            else {
                Console.WriteLine("Saldo insuficiente");
            }
        }

        public override void Transferir(Conta conta, double valor)
        {
            if ((Saldo + Limite) >= valor)
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
