using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeGerenciamento
{
    class c_ValidarEntrada
    {

        public static bool ValidarCodigo(string cod)
        {
            if (cod.Equals(""))
            {
                return true;
            }
            return false;
        }

        public static bool ValidarProduto( string pro)
        {
            if (pro.Equals(""))
            {
                return true;
            }
            return false;
        }

        public static bool ValidarCliente(string cli)
        {
            if (cli.Equals(""))
            {
                return true;
            }
            return false;
        }

        public static bool ValidarEntrada(string ent)
        {
            if (ent.Equals(""))
            {
                return true;
            }
            return false;
        }

        public static bool ValidarSaida(string sai)
        {
            if (sai.Equals(""))
            {
                return true;
            }
            return true;
        }

        public static bool ValidarValor(string val)
        {
            if (val.Equals(""))
            {
                return true;
            }
            return false;
        }

        public static bool ValidarDefeito(string def)
        {
            if (def.Equals(""))
            {
                return true;
            }
            return true;
        }
    }
}
