using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeGerenciamento
{
    class c_ValidarProduto
    {
        public static bool ValidarProduto(string prod)
        {
            if (!prod.Equals(""))
            {
                return true;
            }
            return false;
        }

        public static bool ValidarMarca(string mar)
        {
            if (!mar.Equals(""))
            {
                return false;
            }
            return true; ;
        }

        public static bool ValidarModelo(string mod)
        {
            if (!mod.Equals(""))
            {
                return false;
            }
            return true;
        }
    }
}
