using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeGerenciamento
{
    class c_Entrada
    {
        public int CodigoEntrada { get; set; }
        public string ProdutoEntrada { get; set; }
        public string ClienteEntrada { get; set; }
        public string DataEntrada { get; set; }
        public string DataSaida { get; set; }
        public decimal ValorEntrada { get; set; }
        public string PagoEntrada { get; set; }
        public string DefeitoEntrada { get; set; }

        public c_Entrada(int codigoEntrada, string produtoEntrada, string clienteEntrada, string dataEntrada, string dataSaida, decimal valorEntrada, string pagoEntrada, string defeitoEntrada)
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
    }
}
