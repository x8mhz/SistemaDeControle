
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
                return true;
            }
            return false;
        }

        public static bool ValidarModelo(string mod)
        {
            if (!mod.Equals(""))
            {
                return true;
            }
            return false;
        }
    }
}
