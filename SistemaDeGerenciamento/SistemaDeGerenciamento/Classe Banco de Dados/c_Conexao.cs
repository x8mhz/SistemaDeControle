using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeGerenciamento.Classe_Banco_de_Dados
{
    class c_Conexao
    {
        private SqlConnection con { get; set; }
        public SqlCommand cmd { get; set; }
        public SqlDataReader dr { get; set; }

        public c_Conexao()
        {
            con = new SqlConnection(@"");
            con.Open();
        }

        public void Escrita(string str_cmd)
        {
            cmd = new SqlCommand(str_cmd);
            cmd.Connection = con;
        }

        public void SemConsulta()
        {
            cmd.ExecuteNonQuery();
        }

        public void Leitura(string str_cmd)
        {
            cmd = new SqlCommand(str_cmd);
            dr = cmd.ExecuteReader();
        }

        public void FecharConexao()
        {
            con.Close();
        }
    }

}
