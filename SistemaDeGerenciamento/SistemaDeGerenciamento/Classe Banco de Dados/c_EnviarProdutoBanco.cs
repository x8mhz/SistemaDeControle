using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeGerenciamento
{
    class c_EnviarProdutoBanco : c_Produto
    {
        public c_EnviarProdutoBanco(int iDProduto, string tipoProduto, string marcaProduto, string modeloProduto) : base(iDProduto, tipoProduto, marcaProduto, modeloProduto)
        {
            c_Conexao con = new c_Conexao();
            con.CommandText(@"INSERT INTO tb_Produto(id, produto, marca, modelo) VALUES(@id, @produto, @marca, @modelo)");
            con.cmd.Parameters.AddWithValue("@id", IDProduto);
            con.cmd.Parameters.AddWithValue("@produto", TipoProduto);
            con.cmd.Parameters.AddWithValue("@marca", MarcaProduto);
            con.cmd.Parameters.AddWithValue("@modelo", ModeloProduto);

            con.NoQuery();
            con.FecharConexao();
        }
    }
}
