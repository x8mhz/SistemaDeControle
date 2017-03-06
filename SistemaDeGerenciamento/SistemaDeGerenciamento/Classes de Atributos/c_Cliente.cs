using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeGerenciamento
{
    class c_Cliente
    {
        public int IDClinte { get; set; }
        public string NomeCliente { get; set; }
        public string EnderecoCliente { get; set; }
        public string TelefoneCliente { get; set; }
        public string CelularCliente { get; set; }

        public c_Cliente(int iDClinte, string nomeCliente, string enderecoCliente, string telefoneCliente, string celularCliente)
        {
            IDClinte = iDClinte;
            NomeCliente = nomeCliente;
            EnderecoCliente = enderecoCliente;
            TelefoneCliente = telefoneCliente;
            CelularCliente = celularCliente;
        }
    }
}
