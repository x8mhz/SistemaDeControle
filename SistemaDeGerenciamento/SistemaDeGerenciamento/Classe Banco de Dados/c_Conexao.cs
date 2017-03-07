﻿using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeGerenciamento
{
    class c_Conexao
    {
        private SqlConnection con { get; set; }
        public SqlCommand cmd { get; set; }
        public SqlDataReader dr { get; set; }

        public c_Conexao()
        {
            con = new SqlConnection(@"Data Source=DESKTOP-NTF36S4;Initial Catalog=BD_SistemaGerenciamento;Integrated Security=True");
            con.Open();
        }

        public void CommandText(string str_cmd)
        {
            cmd = new SqlCommand(str_cmd);
            cmd.Connection = con;
        }

        public void NoQuery()
        {
            cmd.ExecuteNonQuery();
        }

        public int Contador()
        {
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                return dr.GetInt32(0);
            }
            else
            {
                return -1;
            }               
        }

        public void FecharConexao()
        {
            con.Close();
        }
    }

}
