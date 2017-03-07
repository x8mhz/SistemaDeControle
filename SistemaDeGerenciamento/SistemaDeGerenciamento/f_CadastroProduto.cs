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
         
            if (!c_ValidarProduto.ValidarProduto(txt_Produto.Text).Equals(true))
            {

            }
            else
            {
                if (!c_ValidarProduto.ValidarProduto(txt_Marca.Text).Equals(true))
                {

                }
                else
                {
                    if (!c_ValidarProduto.ValidarProduto(txt_Modelo.Text).Equals(true))
                    {

                    }
                    else
                    {               
                        c_EnviarProdutoBanco produto = new c_EnviarProdutoBanco(c_ContadorBanco.ContadorProduto(), txt_Produto.Text, txt_Marca.Text, txt_Modelo.Text);
                        produto.EnviarProdutoBanco();
                        MessageBox.Show("Adicionado com sucesso!", "Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Dispose();
                    }
                }
            }          
        }
    }
}
