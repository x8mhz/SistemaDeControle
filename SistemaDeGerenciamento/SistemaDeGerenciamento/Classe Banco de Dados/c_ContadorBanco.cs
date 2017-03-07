
namespace SistemaDeGerenciamento
{
    // CLASS PARA CONTAR A QUANTIDADE DE LINHAS DAS TABELAS, PARA SABER O CÓDIGO ATUAL DE ENTRADA, CLIENTE E PRODUTO.
    class c_ContadorBanco
    {
        public static int ContadorEntrada()
        {
            c_Conexao con = new c_Conexao();
            con.CommandText(@"SELECT COUNT(*) FROM tb_Entrada");
            return con.Contador();
        }

        public static int ContadorCliente()
        {
            c_Conexao con = new c_Conexao();
            con.CommandText(@"SELECT COUNT(*) FROM tb_Cliente");
            return con.Contador();
        }

        public static int ContadorProduto()
        {
            c_Conexao con = new c_Conexao();
            con.CommandText(@"SELECT COUNT(*) FROM tb_Cliente");
            return con.Contador();
        }
    }
}
