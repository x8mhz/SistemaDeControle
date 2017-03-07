using System;
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
                                        string check_Pago = null;
                                        if (check_PagoSim.Checked) check_Pago = "SIM";                                      
                                        if (check_PagoNao.Checked) check_Pago = "NÃO";
                                        
                                        // ENVIA OS DADOS DE CADASTRO PARA O BANCO DE 
                                        c_EnviarEntradaBanco Enviar = new c_EnviarEntradaBanco(c_ContadorBanco.ContadorEntrada(),txt_Produto.Text, txt_Cliente.Text, txt_DataEntrada.Text, txt_DataSaida.Text, Convert.ToDecimal(txt_Valor.Text), check_Pago, txt_Defeito.Text);
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
            txt_Cliente.Items.Add(grid_Cliente.CurrentRow.Cells[0].Value.ToString() + " - " + grid_Cliente.CurrentRow.Cells[1].Value.ToString());
        }

        private void grid_Produto_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_Produto.Items.Add(grid_Produto.CurrentRow.Cells[0].Value.ToString() + " - " + grid_Produto.CurrentRow.Cells[1].Value.ToString());
        }
        //-------------------------------------------------------------------------



        // ATUALIZA AS GRID CLIENTE E PRODUTO QUANDO ABRE ABA CORRESPONDENTE
        private void tab_Controle_MouseClick(object sender, MouseEventArgs e)
        {
            if (tab_Controle.SelectedTab == tabEntrada)
            {
                this.tb_EntradaTableAdapter.Fill(this.bD_SistemaGerenciamentoDataSet.tb_Entrada);
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
        //-------------------------------------------------------------------------


    }
}
