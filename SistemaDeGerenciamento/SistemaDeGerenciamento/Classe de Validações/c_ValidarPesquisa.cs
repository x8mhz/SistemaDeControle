using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeGerenciamento.Classe_de_Validações
{
    class c_ValidarPesquisa
    {
        public static bool ValidarPesquisa(string pes)
        {
            if (pes.Equals(""))
            {
                return true;
            }
            return false;
        }
    }
}
