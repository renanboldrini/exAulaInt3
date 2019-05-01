using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ProgInternetIII
{
    class Banco
    {
        public static int NumeroDePessoas { get; set; }
        public ArrayList Pessoas { get; set; }
        public ArrayList Contas { get; set; }

        public Banco()
        {
            Pessoas = new ArrayList();
            Contas = new ArrayList();
            NumeroDePessoas = 0;
        }


        public void criaContaSalario(int idPessoa, int ag,  int conta) { //segundo o exercicio pode pf e pj
            if (this.Pessoas[idPessoa] != null) {
                ContaSalario c = new ContaSalario(((Pessoa)Pessoas[idPessoa]), conta, ag, 0, 0);
                Contas.Add(c);
            }
        }

        public void criaContaPoupanca(int idPessoa, int ag, int conta)
        { //segundo o exercicio pode pf e pj
            if (this.Pessoas[idPessoa] != null)
            {
                ContaPoupanca c = new ContaPoupanca(((Pessoa)Pessoas[idPessoa]), conta, ag, 0, 3);
                Contas.Add(c);
            }
        }

        public void criaContaCorrente(int idPessoa, int ag, int conta, string tipo)
        { //segundo o exercicio pode pf e pj / nao foi estipulado taxa de saque entao coloquei uma qualquer
            if (this.Pessoas[idPessoa] != null)
            {
                if (tipo == "ESPECIAL") {
                    if (Pessoas[idPessoa] is PessoaFisica) {
                        if (((PessoaFisica)Pessoas[idPessoa]).Renda > 5000)
                        {
                            double limite = ((PessoaFisica)Pessoas[idPessoa]).Renda * 2.5;

                            ContaCorrente cc = new ContaCorrente("ESPECIAL", limite, 2,
                                (PessoaFisica)Pessoas[idPessoa], conta, ag, 0, 2);
                            Contas.Add(cc);
                            Console.WriteLine("Conta registrada");
                        }
                        else {
                            Console.WriteLine("renda insuficiente");
                        }
                    }
                    if (Pessoas[idPessoa] is PessoaJuridica)
                    {
                        if (((PessoaJuridica)Pessoas[idPessoa]).Faturamento > 5000)
                        {
                            double limite = ((PessoaJuridica)Pessoas[idPessoa]).Faturamento * 2.5;

                            ContaCorrente cc = new ContaCorrente("ESPECIAL", limite, 2,
                                (PessoaJuridica)Pessoas[idPessoa], conta, ag, 0, 2);
                            Contas.Add(cc);
                            Console.WriteLine("Conta registrada");
                        }
                        else
                        {
                            Console.WriteLine("Faturamento insuficiente");
                        }
                    }

                }
                if (tipo == "SIMPLES")
                {
                    if (Pessoas[idPessoa] is PessoaFisica)
                    {
                        double limite = ((PessoaFisica)Pessoas[idPessoa]).Renda * 1.5;

                        ContaCorrente cc = new ContaCorrente("SIMPLES", limite, 5,
                        (PessoaFisica)Pessoas[idPessoa], conta, ag, 0, 5);
                        Contas.Add(cc);
                        Console.WriteLine("Conta registrada");
                    }
                    if (Pessoas[idPessoa] is PessoaJuridica)
                    {
                            double limite = ((PessoaJuridica)Pessoas[idPessoa]).Faturamento * 1.5;

                            ContaCorrente cc = new ContaCorrente("SIMPLES", limite, 5,
                            (PessoaJuridica)Pessoas[idPessoa], conta, ag, 0, 5);

                        Contas.Add(cc);
                        Console.WriteLine("Conta registrada");
                    }
                }


            }
        }

        public void cadastroPessoa(string tipo, Pessoa p)
        {
            if (p is PessoaFisica && tipo == "pf")
            {
                if (((PessoaFisica)p).Nome != "" && ((PessoaFisica)p).Sobrenome != ""
                    && ((PessoaFisica)p).Rg != "" && ((PessoaFisica)p).Cpf != ""
                    && ((PessoaFisica)p).DataNasc != null)
                {
                    p.Id = NumeroDePessoas;
                    Pessoas.Add(p);
                    NumeroDePessoas++;
                    Console.WriteLine("Pessoa Fisica cadastrada. Numero de registro ->" + p.Id);
                }
                else
                {
                    Console.WriteLine("falha no cadastro, faltam informações");
                }
            }
            else if (p is PessoaJuridica && tipo == "pj")
            {
                if (((PessoaJuridica)p).Socios != null && ((PessoaJuridica)p).Cnpj != null
                    && ((PessoaJuridica)p).RazaoSocial != "" && ((PessoaJuridica)p).NomeFantasia != ""
                    && ((PessoaJuridica)p).InscrEstadual != null && ((PessoaJuridica)p).DataAbertura != null)
                {
                    p.Id = NumeroDePessoas;
                    Pessoas.Add(p);
                    NumeroDePessoas++;
                    Console.WriteLine("Pessoa Juridica cadastrada. Numero de registro ->" + p.Id);
                }
                else
                {
                    Console.WriteLine("falha no cadastro, faltam informações");
                }
            }
            else
            {
                Console.WriteLine("falha no cadastro");
            }
        }

        public void adicionaPfNoPj(int idPf, int idPj) // para poder adicionar pessoas nas empresas
        {
            if (this.Pessoas[idPf] != null && this.Pessoas[idPj] != null)
            {
                if (this.Pessoas[idPf] is PessoaFisica && this.Pessoas[idPj] is PessoaJuridica)
                {
                    ((PessoaJuridica)Pessoas[idPj]).Socios.Add(Pessoas[idPf]);
                    Console.WriteLine("pf cadastrada na empresa");
                }
                else
                {
                    Console.WriteLine("Erro");
                }
            }
            else
            {
                Console.WriteLine("Erro");
            }
        }

            public void mostraPessoas() { //para poder saber qual pf e qual pj selecionar
            foreach (Pessoa p in this.Pessoas)
            {
                if (p is PessoaFisica) {
                    Console.WriteLine("PF -> "+p.Id + " - " + ((PessoaFisica)p).Nome+" "+ ((PessoaFisica)p).Sobrenome+" - "+ ((PessoaFisica)p).Cpf);
                } else {
                    Console.WriteLine("PJ -> " + p.Id + " - " + ((PessoaJuridica)p).NomeFantasia + " " + ((PessoaJuridica)p).Cnpj);
                }
            }

        }

        public void mostraContas()
        { //para poder saber qual conta selecionar
            int index = 0;
            foreach (Conta p in this.Contas)
            {
                Console.WriteLine(index+" - "+p.Agencia+"-"+p.Numero+" - "+p.Titular.Email);//fiz com o email, só para n precisar efetuar toda a verificacao novamente
                index++;
            }

        }

        public Conta retornaConta(int index) {
            if (index < Contas.Count)
            {
                return (Conta)Contas[index];
            }
            else {
                return null;
            }
        }

        public Pessoa retornaPessoa(int id)
        {
            if (id < Pessoas.Count)
            {
                return (Pessoa)Pessoas[id];
            }
            else
            {
                return null;
            }
        }

    }
}
