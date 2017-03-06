using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeGerenciamento.Classe_Banco_de_Dados
{
    class c_EnviarEntradaBanco : c_Entrada
    {
        private c_Conexao con;
        public c_EnviarEntradaBanco(int codigoEntrada, c_Produto produtoEntrada, c_Cliente clienteEntrada, string dataEntrada, string dataSaida, string valorEntrada, string pagoEntrada, string defeitoEntrada) : base(codigoEntrada, produtoEntrada, clienteEntrada, dataEntrada, dataSaida, valorEntrada, pagoEntrada, defeitoEntrada)
        {
            try
            {
                con = new c_Conexao();
                con.Escrita(@"INSERT INTO -------- (produto, cliente, entrada, saida, valor, pago, defeito) VALUES (@produto, @cliente, @entrada, @saida, @valor, @pago, @defeito");
                con.cmd.Parameters.AddWithValue("@produto", ProdutoEntrada);
                con.cmd.Parameters.AddWithValue(@"cliente", ClienteEntrada);
                con.cmd.Parameters.AddWithValue(@"entrada", DataEntrada);
                con.cmd.Parameters.AddWithValue(@"saida", DataSaida);
                con.cmd.Parameters.AddWithValue(@"valor", ValorEntrada);
                con.cmd.Parameters.AddWithValue(@"pago", PagoEntrada);
                con.cmd.Parameters.AddWithValue(@"defeito", DefeitoEntrada);

                con.SemConsulta();
                con.FecharConexao();
            }
            catch(Exception)
            {
                // ...
            }


        }
    }
}
