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
    public partial class f_CadastroCliente : Form
    {
        public f_CadastroCliente()
        {
            InitializeComponent();
        }

        private void btn_SalvarCliente_Click(object sender, EventArgs e)
        {
            if (c_ValidarCliente.ValidarNomeCliente(txt_NomeCliente.Text).Equals(false))
            {

            }
            else
            {
                if (c_ValidarCliente.ValidarEnderecoCliente(txt_EnderecoCliente.Text).Equals(false))
                {

                }
                else
                {
                    if (c_ValidarCliente.ValidarTelefone(txt_TelefoneCliente.Text).Equals(false))
                    {

                    }
                    else
                    {
                        if (c_ValidarCliente.ValidarTelefone(txt_CelularCliente.Text).Equals(false))
                        {

                        }
                        else
                        {
                            // ENVIAR PARA O BANCO DE CLIENTE
                            int contador = Convert.ToInt32(c_ContadorBanco.ContadorBanco());
                            c_Cliente cliente = new c_Cliente(contador, txt_NomeCliente.Text, txt_EnderecoCliente.Text, txt_TelefoneCliente.Text, txt_CelularCliente.Text);    
                        }
                    }
                }
            }
        }
    }
}
