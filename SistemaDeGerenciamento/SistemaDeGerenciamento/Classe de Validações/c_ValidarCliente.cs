
namespace SistemaDeGerenciamento
{
    class c_ValidarCliente
    {
        public static bool ValidarNomeCliente(string nom)
        {
            if (!nom.Equals(""))
            {
                return true;
            }
            return false;
        }

        public static bool ValidarEnderecoCliente(string end)
        {
            // PARA CASO QUERIA COLOCAR UMA RESTRIÇÃO
            return false;
        }

        public static bool ValidarTelefone(string tel)
        {
            if (!tel.Equals(""))
            {
                return true;
            }
            return false;
        }
    }
}
