using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeGerenciamento
{
    class c_ContadorBanco
    {
        public static int ContadorBanco()
        {
            c_Conexao con = new c_Conexao();
            con.CommandText(@"SELECT COUNT(*) FROM tb_Entrada");
            return 1 + con.Contador();
        }
    }
}
