using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeGerenciamento
{
    class c_ContadorBanco
    {
        public static int ContadorEntrada()
        {
            c_Conexao con = new c_Conexao();
            con.CommandText(@"SELECT COUNT(*) FROM tb_Entrada");
            return 1 + con.Contador();
        }

        public static int ContadorCliente()
        {
            c_Conexao con = new c_Conexao();
            con.CommandText(@"SELECT COUNT(*) FROM tb_Cliente");
            return 1 + con.Contador();
        }
    }
}
