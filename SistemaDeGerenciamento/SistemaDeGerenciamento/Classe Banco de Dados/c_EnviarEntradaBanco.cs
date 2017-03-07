using SistemaDeGerenciamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeGerenciamento
{
    class c_EnviarEntradaBanco : c_Entrada
    {
        public c_EnviarEntradaBanco(int codigoEntrada, string produtoEntrada, string clienteEntrada, string dataEntrada, string dataSaida, decimal valorEntrada, string pagoEntrada, string defeitoEntrada)
        {
            CodigoEntrada = codigoEntrada;
            ProdutoEntrada = produtoEntrada;
            ClienteEntrada = clienteEntrada;
            DataEntrada = dataEntrada;
            DataSaida = dataSaida;
            ValorEntrada = valorEntrada;
            PagoEntrada = pagoEntrada;
            DefeitoEntrada = defeitoEntrada;
        }

        private c_Conexao con;
        public void EnviarEntradaBanco()
        {
            try
            {
                con = new c_Conexao();
                con.CommandText(@"INSERT INTO tb_Entrada(codEntrada, produto, cliente, entrada, saida, valor, pago, defeito) VALUES(@codEntrada, @produto, @cliente, @entrada, @saida, @valor, @pago, @defeito)");
                con.cmd.Parameters.AddWithValue("@codEntrada", CodigoEntrada);
                con.cmd.Parameters.AddWithValue("@produto", ProdutoEntrada);
                con.cmd.Parameters.AddWithValue("@cliente", ClienteEntrada);
                con.cmd.Parameters.AddWithValue("@entrada", DataEntrada);
                con.cmd.Parameters.AddWithValue("@saida", DataSaida);
                con.cmd.Parameters.AddWithValue("@valor", ValorEntrada);
                con.cmd.Parameters.AddWithValue("@pago", PagoEntrada);
                con.cmd.Parameters.AddWithValue("@defeito", DefeitoEntrada);

                con.NoQuery();
                con.FecharConexao();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }


        }
    }
}
