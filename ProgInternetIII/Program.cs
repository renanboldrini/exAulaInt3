using System;
using System.Collections;

namespace ProgInternetIII
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaFisica pf = new PessoaFisica("Daniela", "Strich", "888888888", "88899977712", new DateTime(1995, 12, 20),
                            6000, "rua xyz, bairro fff", "33334444", "algumacoisa@tttt.dot");

            PessoaJuridica pj = new PessoaJuridica(3333333, "teste inc", "alguma coisa", 666,
            new DateTime(1995, 12, 24), 6000, "rua lugaralgum, 666", "12345678", "testeinc@tes.dot");

            PessoaFisica pf2 = new PessoaFisica("Roberto", "Rosa", "888444888", "88899444442", new DateTime(1993, 11, 20),
                            4000, "rua abc, bairro ooo", "99934444", "outracoisa@tttt.dot");

            PessoaJuridica pj2 = new PessoaJuridica(5555555, "outro inc", "outra coisa", 999,
            new DateTime(1999, 12, 24), 4000, "rua lugaralgum2, 555", "87654321", "outroinc@tes.dot");

            Banco b = new Banco();



            b.cadastroPessoa("pf",pf); 
            b.cadastroPessoa("pj", pj);
            b.cadastroPessoa("pf", pf2);
            b.cadastroPessoa("pj", pj2);

            b.adicionaPfNoPj(0, 1);//se eu precisasse ver     
            b.adicionaPfNoPj(2, 1);

            b.criaContaSalario(2, 0004, 000171);
            b.criaContaPoupanca(0, 0002, 000987);
            b.criaContaCorrente(1, 0001, 000878, "ESPECIAL");

            b.mostraPessoas();
            b.mostraContas();

        }
    }
}
