using System.Text.RegularExpressions;

namespace SistemaDeGerenciamento
{
    class c_ValidarEntrada
    {


        public static bool ValidarProduto(string pro)
        {
            if (!pro.Equals(""))
            {
                return true;
            }
            return false;
        }

        public static bool ValidarCliente(string cli)
        {
            if (!cli.Equals(""))
            {
                return true;
            }
            return false;
        }

        public static bool ValidarEntrada(string ent)
        {
            Regex rx = new Regex(@"^([0]?[0-9]|[12][0-9]|[3][01])[./-]([0]?[1-9]|[1][0-2])[./-]([0-9]{4}|[0-9]{2})$");
            if (rx.IsMatch(ent))
            {
                return true;
            }
            return false;
        }

        public static bool ValidarSaida(string sai)
        {
            Regex rx = new Regex(@"^([0]?[0-9]|[12][0-9]|[3][01])[./-]([0]?[1-9]|[1][0-2])[./-]([0-9]{4}|[0-9]{2})$");
            if (rx.IsMatch(sai))
            {
                return true;
            }
            return true;
        }

        public static bool ValidarValor(string val)
        {
            // PARA CASO FUTURAMENTE QUEIRA RESRINGIR 
            return true;
        }

        public static bool ValidarDefeito(string def)
        {
            // PARA CASO FUTUTAMENTE QUERIA RESTRINGIR
            return true;
        }
    }
}
