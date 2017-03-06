using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeGerenciamento
{
    class c_Produto
    {
        public int IDProduto { get; set; }
        public string TipoProduto { get; set; }
        public string MarcaProduto { get; set; }
        public string ModeloProduto { get; set; }

        public c_Produto(int iDProduto, string tipoProduto, string marcaProduto, string modeloProduto)
        {
            IDProduto = iDProduto;
            TipoProduto = tipoProduto;
            MarcaProduto = marcaProduto;
            ModeloProduto = modeloProduto;
        }
    }
}
