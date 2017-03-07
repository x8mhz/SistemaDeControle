using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeGerenciamento
{
    class c_EnviarProdutoBanco : c_Produto
    {
        public c_EnviarProdutoBanco(int iDProduto, string tipoProduto, string marcaProduto, string modeloProduto)
        {
            IDProduto = iDProduto;
            TipoProduto = tipoProduto;
            MarcaProduto = marcaProduto;
            ModeloProduto = modeloProduto;
        }

        private c_Conexao con;

        public void EnviarProdutoBanco()
        {
            try
            {
                con = new c_Conexao();
                con.CommandText(@"INSERT INTO tb_Produto(codProduto, produto, marca, modelo) VALUES(@codProduto, @produto, @marca, @modelo)");
                con.cmd.Parameters.AddWithValue("@codProduto", IDProduto);
                con.cmd.Parameters.AddWithValue("@produto", TipoProduto);
                con.cmd.Parameters.AddWithValue("@marca", MarcaProduto);
                con.cmd.Parameters.AddWithValue("@modelo", ModeloProduto);

                con.NoQuery();
                con.FecharConexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
           
        }
    }
}
