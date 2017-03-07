using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeGerenciamento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // HORA ATUAL DA DATA DE ENTRADA E RODAPÉ
            txt_DataEntrada.Text = lbl_DataHoraAtual.Text = Convert.ToString(DateTime.Now);
            // CONTADOR DE USUÁRIOS
            txt_Codigo.Text =  Convert.ToString(c_ContadorBanco.ContadorBanco());                   
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            string checa_Pago;   

                if (!c_ValidarEntrada.ValidarProduto(txt_Produto.Text).Equals(true))
                {
                MessageBox.Show("ERRO1");
                }
                else
                {
                    if (!c_ValidarEntrada.ValidarCliente(txt_Cliente.Text).Equals(true))
                    {
                    MessageBox.Show("ERRO2");
                }
                    else
                    {
                        if (!c_ValidarEntrada.ValidarEntrada(txt_DataEntrada.Text).Equals(true))
                        {
                        MessageBox.Show("ERRO3");
                    }
                        else
                        {
                            if (!c_ValidarEntrada.ValidarSaida(txt_DataSaida.Text).Equals(true))
                            {
                            MessageBox.Show("ERRO4");
                        }
                            else
                            {
                                if (!c_ValidarEntrada.ValidarValor(txt_Valor.Text).Equals(true))
                                {
                                MessageBox.Show("ERRO5");
                            }
                                else
                                {
                                    if (!check_PagoNao.Equals(false) && check_PagoSim.Equals(true))
                                    {
                                    MessageBox.Show("ERRO6");
                                }
                                    else
                                    {
                                        if (check_PagoNao.Equals(true))
                                        {
                                            checa_Pago = "NÃO";
                                        }
                                        else
                                        {
                                            checa_Pago = "SIM";
                                        }
                                        if (!c_ValidarEntrada.ValidarDefeito(txt_Defeito.Text).Equals(true))
                                        {
                                        MessageBox.Show("ERRO1");
                                    }
                                        else
                                        {
                                            // ENVIA OS DADOS DE CADASTRO PARA O BANCO DE 
                                            c_EnviarEntradaBanco Enviar = new c_EnviarEntradaBanco(c_ContadorBanco.ContadorBanco(),txt_Produto.Text, txt_Cliente.Text, txt_DataEntrada.Text, txt_DataSaida.Text, Convert.ToDecimal(txt_Valor.Text), checa_Pago, txt_Defeito.Text);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }        
        }

        private void btn_AddCliente_Click(object sender, EventArgs e)
        {
            f_CadastroCliente cadastro_Cliente = new f_CadastroCliente();
            cadastro_Cliente.Visible = true;
        }

        private void btn_AddProduto_Click(object sender, EventArgs e)
        {
            f_CadastroProduto cadastro_Produto = new f_CadastroProduto();
            cadastro_Produto.Visible = true;
        }
    }
}
