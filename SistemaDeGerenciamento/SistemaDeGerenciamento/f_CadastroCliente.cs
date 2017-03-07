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

        // VERIFICA E SALVA O CLIENTE CADASTRADO NO BANCO DE DADOS
        private void btn_SalvarCliente_Click(object sender, EventArgs e)
        {
            if (!c_ValidarCliente.ValidarNomeCliente(txt_NomeCliente.Text).Equals(true))
            {
                lbl_AvisoNome.Visible = true;
            }
            else
            {
                lbl_AvisoNome.Visible = false;

                //if (!c_ValidarCliente.ValidarEnderecoCliente(txt_EnderecoCliente.Text).Equals(true))
                //{
                    
               // }
               // else
               // {
                    if (!c_ValidarCliente.ValidarTelefone(txt_TelefoneCliente.Text).Equals(true))
                    {
                        lbl_AvisoTelefone.Visible = true;
                    }
                    else
                    {
                        lbl_AvisoCelular.Visible = false;

                        if (!c_ValidarCliente.ValidarTelefone(txt_CelularCliente.Text).Equals(true))
                        {
                            lbl_AvisoCelular.Visible = true;
                        }
                        else
                        {
                            lbl_AvisoCelular.Visible = false;
                                                  
                            // ENVIAR PARA O BANCO DE CLIENTE
                            c_EnviarClienteBanco cliente = new c_EnviarClienteBanco(c_ContadorBanco.ContadorCliente(), txt_NomeCliente.Text, txt_EnderecoCliente.Text, txt_TelefoneCliente.Text, txt_CelularCliente.Text);
                            cliente.EnviarClienteBanco();
                            MessageBox.Show("Adicionado com sucesso!","Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Dispose();
                        }
                    //}
                }
            }
        }

        private void f_CadastroCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
