using System;
using System.Collections.Generic;
using System.Text;

namespace ProgInternetIII
{
    class PessoaFisica : Pessoa
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNasc { get; set; }
        public double Renda { get; set; }
        public static Auxiliar Auxiliar { get; set; }

        public PessoaFisica(string nome, string sobrenome, string rg, string cpf, DateTime dataNasc, 
                            double renda, string endereco, string tel, string email)
        {
            Endereco = endereco;
            Tel = tel;
            Email = email;
            Nome = nome;
            Sobrenome = sobrenome;
            Rg = rg;
            Cpf = cpf;
            DataNasc = dataNasc;
            Renda = renda;
            Auxiliar = new Auxiliar();
        }

        public int Idade()
        {
            return Auxiliar.CalculaIdade(this.DataNasc);

        }

        public string FaixaEtaria()
        {
            return Auxiliar.FaixaEtaria(this.Idade());
        }

    }
}
