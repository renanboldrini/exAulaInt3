using System;
using System.Collections.Generic;
using System.Text;

namespace ProgInternetIII
{
    abstract class Conta
    {
        public Pessoa Titular { get; set; }
        public long Numero { get; set; }
        public int Agencia { get; set; }
        public double Saldo { get; set; }
        public double TaxaSaque { get; set; }

        abstract public void Sacar(double valor);

        abstract public double Consultar();

        abstract public void Transferir(Conta conta, double valor);
    }
}
