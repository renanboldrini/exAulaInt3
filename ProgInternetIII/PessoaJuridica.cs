using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ProgInternetIII
{
    class PessoaJuridica : Pessoa
    {
        public ArrayList Socios { get; set; }

        public int Cnpj { get; set; }

        public String RazaoSocial { get; set; }

        public String NomeFantasia { get; set; }

        public int InscrEstadual { get; set; }

        public DateTime DataAbertura { get; set; }

        public double Faturamento { get; set; }
        public static Auxiliar Auxiliar { get; set; }

        public PessoaJuridica(int cnpj, string razaoSocial, string nomeFantasia, int inscrEstadual,
            DateTime dataAbertura, double faturamento, string endereco, string tel, string email)
        {
            Endereco = endereco;
            Tel = tel;
            Email = email;
            Socios = new ArrayList();
            Cnpj = cnpj;
            RazaoSocial = razaoSocial;
            NomeFantasia = nomeFantasia;
            InscrEstadual = inscrEstadual;
            DataAbertura = dataAbertura;
            Faturamento = faturamento;
            Auxiliar = new Auxiliar();
        }

        public int Idade()
        {
            return Auxiliar.CalculaIdade(this.DataAbertura);

        }

        public void addSocio() {

        }
    }
}
