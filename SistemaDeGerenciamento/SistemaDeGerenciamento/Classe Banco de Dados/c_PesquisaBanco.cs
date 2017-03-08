using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeGerenciamento
{
    class c_PesquisaBanco
    {
        c_Conexao con;

        public string Pesquisar(string pes)
        {
            try
            {
                con = new c_Conexao();
                con.CommandText("SELECT cliente FROM tb_Entrada WHERE cliente = '" + pes + "'");
                return pes = con.Pesquisa();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Não encontrado. Erro: " + ex,"Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return "";
            }
        }
    }
}
