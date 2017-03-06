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
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            if (c_ValidarEntrada.ValidarCodigo(txt_Codigo.Text).Equals(false))
            {

            }
            else
            {
                if (c_ValidarEntrada.ValidarProduto(txt_Produto.Text).Equals(false))
                {

                }
                else
                {
                    if (c_ValidarEntrada.ValidarCliente(txt_Cliente.Text).Equals(false))
                    {

                    }
                    else
                    {
                        if (c_ValidarEntrada.ValidarEntrada(txt_DataEntrada.Text).Equals(false))
                        {

                        }
                        else
                        {
                            if (c_ValidarEntrada.ValidarSaida(txt_DataSaida.Text).Equals(false))
                            {

                            }
                            else
                            {
                                if (c_ValidarEntrada.ValidarValor(txt_Valor.Text).Equals(false))
                                {

                                }
                                else
                                {
                                    if (check_PagoNao.Equals(false) && check_PagoSim.Equals(false))
                                    {

                                    }
                                    else
                                    {
                                        if (c_ValidarEntrada.ValidarDefeito(txt_Defeito.Text).Equals(false))
                                        {

                                        }
                                        else
                                        {
                                            // ENVIA OS DADOS DE CADASTRO PARA O BANCO DE DADOS
                                            
                                        }
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
    }
}
