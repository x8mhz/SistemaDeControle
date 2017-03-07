using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeGerenciamento
{
    public partial class f_CadastroProduto : Form
    {
        public f_CadastroProduto()
        {
            InitializeComponent();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            int contador = Convert.ToInt32(c_ContadorBanco.ContadorBanco());
            c_EnviarProdutoBanco produto = new c_EnviarProdutoBanco(contador, txt_Produto.Text, txt_Marca.Text, txt_Modelo.Text);
        }
    }
}
