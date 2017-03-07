using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeGerenciamento
{
    class c_EnviarClienteBanco : c_Cliente
    {
        public c_EnviarClienteBanco(int iDClinte, string nomeCliente, string enderecoCliente, string telefoneCliente, string celularCliente)
        {
            IDClinte = iDClinte;
            NomeCliente = nomeCliente;
            EnderecoCliente = enderecoCliente;
            TelefoneCliente = telefoneCliente;
            CelularCliente = celularCliente;
        }
        private c_Conexao con;

        public void EnviarClienteBanco()
        {
            try
            {
                con = new c_Conexao();
                con.CommandText(@"INSERT INTO tb_Cliente(codCliente, nome, endereco, telefone, celular) VALUES(@codCliente, @nome, @endereco, @telefone, @celular)");
                con.cmd.Parameters.AddWithValue("@codCliente", IDClinte);
                con.cmd.Parameters.AddWithValue("@nome", NomeCliente);
                con.cmd.Parameters.AddWithValue("@endereco", EnderecoCliente);
                con.cmd.Parameters.AddWithValue("@telefone", TelefoneCliente);
                con.cmd.Parameters.AddWithValue("@celular", CelularCliente);

                con.NoQuery();
                con.FecharConexao();
            }
            catch (Exception es)
            {
                MessageBox.Show("ERRO: " + es);
            }
        }

    }
}
