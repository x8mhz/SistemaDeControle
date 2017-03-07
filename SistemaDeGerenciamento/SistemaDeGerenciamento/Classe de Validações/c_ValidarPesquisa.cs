
namespace SistemaDeGerenciamento
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
