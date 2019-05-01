using System;
using System.Collections.Generic;
using System.Text;

namespace ProgInternetIII
{
    abstract class Pessoa
    {
        //public static int NumeroDePessoas { get; set; } //verificar implementação
        public int Id { get; set; }
        public string Endereco { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
    }

}
