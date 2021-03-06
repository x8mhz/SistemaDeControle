﻿using System;
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
            // CARRREGA A GRID DE PRODUTO
            this.tb_ProdutoTableAdapter.Fill(this.bD_SistemaGerenciamentoDataSet.tb_Produto);
            // CARREGA A GRID DE CLIENTE
            this.tb_ClienteTableAdapter.Fill(this.bD_SistemaGerenciamentoDataSet.tb_Cliente);
            // CARREGA A GRID DE ENTRADA
            this.tb_EntradaTableAdapter.Fill(this.bD_SistemaGerenciamentoDataSet.tb_Entrada);


            // HORA ATUAL DA DATA DE ENTRADA E RODAPÉ
            txt_DataEntrada.Text = lbl_DataHoraAtual.Text = Convert.ToString(DateTime.Now);
            // CONTADOR DE USUÁRIOS
            txt_Codigo.Text =  Convert.ToString(c_ContadorBanco.ContadorEntrada());                                     
        }


        // VERIFICA E SALVA AS ENTRADAS CADASTRADAS NO BANCO DE DADOS
        private void btn_Salvar_Click(object sender, EventArgs e)
        {        
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
                                txt_Valor.Text = "0";

                                lbl_AvisoValor.Visible = false;

                                if (!check_PagoNao.Checked && !check_PagoSim.Checked)
                                {
                                    lbl_AvisoPago.Visible = true;                               
                                }
                                else
                                {                      
                                    if (!c_ValidarEntrada.ValidarDefeito(txt_Defeito.Text).Equals(true))
                                    {

                                    }
                                    else
                                    {
                                        try
                                        {
                                            string check_Pago = null;
                                            if (check_PagoSim.Checked) check_Pago = "SIM";
                                            
                                            if (check_PagoNao.Checked) check_Pago = "NÃO";
                                            

                                            // ENVIA OS DADOS DE CADASTRO PARA O BANCO DE 
                                            c_EnviarEntradaBanco Enviar = new c_EnviarEntradaBanco(c_ContadorBanco.ContadorEntrada(), txt_Produto.Text, txt_Cliente.Text, txt_DataEntrada.Text, txt_DataSaida.Text, Convert.ToDecimal(txt_Valor.Text), check_Pago, txt_Defeito.Text);
                                            Enviar.EnviarEntradaBanco();

                                            MessageBox.Show("Salvo com sucesso!", "Entrada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                            // ATUALIZA A GRID DE ENTRAD
                                            this.tb_EntradaTableAdapter.Fill(this.bD_SistemaGerenciamentoDataSet.tb_Entrada);

                                            //JOGAR OS ATUAIS CLIENTE E PRODUTO DENTRO DO COMBOBOX
                                            txt_Cliente.Items.Add(txt_Cliente.Text);
                                            txt_Produto.Items.Add(txt_Produto.Text);
                                        }
                                        catch (Exception ex)
                                        {
                                            MessageBox.Show("Erro: " + ex);
                                        }
                                    }
                                }
                            }
                        }
                     }
                 }
             }        
        }
        //-------------------------------------------------------------



        // TORNA VISÍVEIS AS FORMS ADICIONAR CLIENTE E ADICIONAR PRODUTO
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
        //--------------------------------------------------------------



        // ADICIONA NOS CAMPOS DE CLIENTE E PRODUTO A GRID COM O CLICK REFERENTE
        private void grid_Cliente_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_Cliente.Text = grid_Cliente.CurrentRow.Cells[0].Value.ToString() + " - " + grid_Cliente.CurrentRow.Cells[1].Value.ToString();
        }

        private void grid_Produto_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_Produto.Text = grid_Produto.CurrentRow.Cells[0].Value.ToString() + " - " + grid_Produto.CurrentRow.Cells[1].Value.ToString();
        }
        //-------------------------------------------------------------------------



        // ATUALIZA AS GRID CLIENTE E PRODUTO QUANDO ABRE ABA CORRESPONDENTE
        private void tab_Controle_MouseClick(object sender, MouseEventArgs e)
        {           
            if (tab_Controle.SelectedTab.Equals(tabEntrada))
            {
                this.tb_ClienteTableAdapter.Fill(this.bD_SistemaGerenciamentoDataSet.tb_Cliente);
            }

            if (tab_Controle.SelectedTab.Equals(tabEntrada))
            {
                this.tb_ProdutoTableAdapter.Fill(this.bD_SistemaGerenciamentoDataSet.tb_Produto);
            }

            if (tab_Controle.SelectedTab.Equals(tabEntrada))
            {
                this.tb_EntradaTableAdapter.Fill(this.bD_SistemaGerenciamentoDataSet.tb_Entrada);
            }
        }

        private void btn_Novo_Click(object sender, EventArgs e)
        {
            txt_Cliente.Text = "";
            txt_Produto.Text = "";
            txt_DataEntrada.Text = Convert.ToString(DateTime.Now);
            txt_DataSaida.Clear();
            txt_Valor.Clear();
            check_PagoNao.Checked = true;
            check_PagoSim.Checked = false;
            txt_Defeito.Clear();
        }

        private void check_PagoNao_MouseClick(object sender, MouseEventArgs e)
        {
            check_PagoSim.Checked = false;
        }

        private void check_PagoSim_MouseClick(object sender, MouseEventArgs e)
        {
            check_PagoNao.Checked = false;
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        string pesquisa = null;
        //CONFIGURAÇÃO DO TEXTEBOX DE PESQUISA.
        private void txt_Pesquisar_MouseClick(object sender, MouseEventArgs e)
        {
            txt_Pesquisar.Text = null;
        }

        private void txt_Pesquisar_Leave(object sender, EventArgs e)
        {
            pesquisa = txt_Pesquisar.Text;
            txt_Pesquisar.Text = " Digite Código ou o Nome do Cliente...";            
        }



        // CONFIGURAÇÃO DO BOTÃO DE PESQUISA
        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            c_PesquisaBanco pesquisa = new c_PesquisaBanco();
            c_Conexao con = new c_Conexao();
           
            grid_Entrada.DataSource = pesquisa.Pesquisar(txt_Pesquisar.Text);
           
        }
    }
}
