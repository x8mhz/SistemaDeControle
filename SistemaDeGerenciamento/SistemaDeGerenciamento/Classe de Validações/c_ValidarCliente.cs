using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeGerenciamento
{
    class c_ValidarCliente
    {
        public static bool ValidarNomeCliente(string nom)
        {
            if (nom.Equals(""))
            {
                return true;
            }
            return false;
        }

        public static bool ValidarEnderecoCliente(string end)
        {
            if (end.Equals(""))
            {
                return true;
            }
            return false;
        }

        public static bool ValidarTelefone(string tel)
        {
            if (tel.Equals(""))
            {
                return true;
            }
            return false;
        }
    }
}
