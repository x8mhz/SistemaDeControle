using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeGerenciamento.Classe_Banco_de_Dados
{
    class c_EnviarClienteBanco : c_Cliente
    {
        private c_Conexao con;

        public c_EnviarClienteBanco(int iDClinte, string nomeCliente, string enderecoCliente, string telefoneCliente, string celularCliente) : base(iDClinte, nomeCliente, enderecoCliente, telefoneCliente, celularCliente)
        {
            try
            {
                con = new c_Conexao();
                con.Escrita(@"INSERT INTO -------- (nome, endereco, telefone, celular) VALUES (@nome, @endereco, @telefone, @celular)");
                con.cmd.Parameters.AddWithValue(@"nome", NomeCliente);
                con.cmd.Parameters.AddWithValue(@"endereco", EnderecoCliente);
                con.cmd.Parameters.AddWithValue(@"telefone", TelefoneCliente);
                con.cmd.Parameters.AddWithValue(@"celular", CelularCliente);

                con.SemConsulta();
                con.FecharConexao();
            }
            catch (Exception)
            {
                // ...
            }
        }

    }
}
