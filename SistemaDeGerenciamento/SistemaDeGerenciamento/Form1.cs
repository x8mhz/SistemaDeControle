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
            // TODO: This line of code loads data into the 'bD_SistemaGerenciamentoDataSet.tb_Produto' table. You can move, or remove it, as needed.
            this.tb_ProdutoTableAdapter.Fill(this.bD_SistemaGerenciamentoDataSet.tb_Produto);
            // TODO: This line of code loads data into the 'bD_SistemaGerenciamentoDataSet.tb_Cliente' table. You can move, or remove it, as needed.
            this.tb_ClienteTableAdapter.Fill(this.bD_SistemaGerenciamentoDataSet.tb_Cliente);
            // TODO: This line of code loads data into the 'bD_SistemaGerenciamentoDataSet.tb_Entrada' table. You can move, or remove it, as needed.
            this.tb_EntradaTableAdapter.Fill(this.bD_SistemaGerenciamentoDataSet.tb_Entrada);


            // HORA ATUAL DA DATA DE ENTRADA E RODAPÉ
            txt_DataEntrada.Text = lbl_DataHoraAtual.Text = Convert.ToString(DateTime.Now);
            // CONTADOR DE USUÁRIOS
            txt_Codigo.Text =  Convert.ToString(c_ContadorBanco.ContadorEntrada());                                     
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            string checa_Pago;
          
            if (!c_ValidarEntrada.ValidarProduto(txt_Cliente.Text).Equals(true))
            {
                lbl_AvisoCliente.Visible = true;
            }
            else
            {
                lbl_AvisoCliente.Visible = false;

                if (!c_ValidarEntrada.ValidarCliente(txt_Produto.Text).Equals(true))
                {
                    lbl_AvisoProduto.Visible = true;
                }
                else
                {
                    lbl_AvisoProduto.Visible = false;

                    if (!c_ValidarEntrada.ValidarEntrada(txt_DataEntrada.Text).Equals(true))
                    {
                        lbl_AvisoEntrada.Visible = true;
                    }
                    else
                    {
                        lbl_AvisoEntrada.Visible = false;

                        if (!c_ValidarEntrada.ValidarSaida(txt_DataSaida.Text).Equals(true))
                        {
                            lbl_AvisoSaida.Visible = true;
                        }
                        else
                        {
                            lbl_AvisoSaida.Visible = false;

                            if (!c_ValidarEntrada.ValidarValor(txt_Valor.Text).Equals(true))
                            {
                                lbl_AvisoValor.Visible = true;
                            }
                            else
                            {
                                lbl_AvisoValor.Visible = false;

                                if (check_PagoNao.Equals(false) && check_PagoSim.Equals(false))
                                {
                                    lbl_AvisoPago.Visible = true;
                                    
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
 
                                    }
                                    else
                                    {
                                        // ENVIA OS DADOS DE CADASTRO PARA O BANCO DE 
                                        c_EnviarEntradaBanco Enviar = new c_EnviarEntradaBanco(c_ContadorBanco.ContadorEntrada(),txt_Produto.Text, txt_Cliente.Text, txt_DataEntrada.Text, txt_DataSaida.Text, Convert.ToDecimal(txt_Valor.Text), checa_Pago, txt_Defeito.Text);
                                        Enviar.EnviarEntradaBanco();
                                        MessageBox.Show("Salvo com sucesso!", "Entrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        this.tb_EntradaTableAdapter.Fill(this.bD_SistemaGerenciamentoDataSet.tb_Entrada);
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

        private void grid_Cliente_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txt_Cliente.Items.Add(grid_Cliente.CurrentRow.Cells[0].Value.ToString() + " - " + grid_Cliente.CurrentRow.Cells[1].Value.ToString());
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txt_Produto.Items.Add(grid_Produto.CurrentRow.Cells[0].Value.ToString() + " - " + grid_Produto.CurrentRow.Cells[1].Value.ToString());
        }

        private void tab_Controle_MouseClick(object sender, MouseEventArgs e)
        {
            if (tab_Controle.SelectedTab == tabEntrada)
            {
                this.tb_ClienteTableAdapter.Fill(this.bD_SistemaGerenciamentoDataSet.tb_Cliente);
            }

            if (tab_Controle.SelectedTab == tabCliente)
            {
                this.tb_ClienteTableAdapter.Fill(this.bD_SistemaGerenciamentoDataSet.tb_Cliente);
            }

            if (tab_Controle.SelectedTab == tabProduto)
            {
                this.tb_ProdutoTableAdapter.Fill(this.bD_SistemaGerenciamentoDataSet.tb_Produto);
            }
             
  
     
        }

    }
}
