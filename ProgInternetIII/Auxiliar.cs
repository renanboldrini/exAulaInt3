using System;
using System.Collections.Generic;
using System.Text;

namespace ProgInternetIII
{
    class Auxiliar
    {
        public int CalculaIdade(DateTime data)
        {
            int anos = DateTime.Now.Year - data.Year;
            if (DateTime.Now.Month < data.Month || (DateTime.Now.Month == data.Month && DateTime.Now.Day < data.Day))
                anos--;

            return anos;
        }

        public string FaixaEtaria(int idade)
        {
            if (idade <= 11) {
                return "criança";
            }
            else if (idade >= 12 && idade <= 21) {
                return "jovem";
            }
            else if (idade >= 22 && idade <= 59) {
                return "adulto";
            }
            else{ //(idade >= 60)
                return "idoso";
            }
        }
    }
}
