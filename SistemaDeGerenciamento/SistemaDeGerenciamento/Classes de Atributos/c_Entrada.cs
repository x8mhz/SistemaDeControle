using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeGerenciamento
{
    abstract class c_Entrada
    {
        public int CodigoEntrada { get; set; }
        public string ProdutoEntrada { get; set; }
        public string ClienteEntrada { get; set; }
        public string DataEntrada { get; set; }
        public string DataSaida { get; set; }
        public decimal ValorEntrada { get; set; }
        public string PagoEntrada { get; set; }
        public string DefeitoEntrada { get; set; }       
    }
}
