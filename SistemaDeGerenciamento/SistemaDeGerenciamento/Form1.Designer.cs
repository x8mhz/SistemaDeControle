namespace SistemaDeGerenciamento
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pn_Menu = new System.Windows.Forms.Panel();
            this.lbl_PesquisaNaoEncontrada = new System.Windows.Forms.Label();
            this.btn_Email = new System.Windows.Forms.Button();
            this.btn_Pesquisar = new System.Windows.Forms.Button();
            this.txt_Pesquisar = new System.Windows.Forms.TextBox();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.btn_Novo = new System.Windows.Forms.Button();
            this.pn_Entrada = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.lbl_AvisoPago = new System.Windows.Forms.Label();
            this.lbl_AvisoValor = new System.Windows.Forms.Label();
            this.lbl_AvisoSaida = new System.Windows.Forms.Label();
            this.lbl_AvisoEntrada = new System.Windows.Forms.Label();
            this.lbl_AvisoProduto = new System.Windows.Forms.Label();
            this.lbl_AvisoCliente = new System.Windows.Forms.Label();
            this.txt_DataEntrada = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Cliente = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_AddCliente = new System.Windows.Forms.Button();
            this.pn_PagoOuNao = new System.Windows.Forms.Panel();
            this.check_PagoSim = new System.Windows.Forms.CheckBox();
            this.check_PagoNao = new System.Windows.Forms.CheckBox();
            this.btn_AddProduto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Codigo = new System.Windows.Forms.TextBox();
            this.txt_Produto = new System.Windows.Forms.ComboBox();
            this.txt_Valor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Defeito = new System.Windows.Forms.TextBox();
            this.txt_DataSaida = new System.Windows.Forms.MaskedTextBox();
            this.pn_TabControle = new System.Windows.Forms.Panel();
            this.tab_Controle = new System.Windows.Forms.TabControl();
            this.tabProduto = new System.Windows.Forms.TabPage();
            this.grid_Entrada = new System.Windows.Forms.DataGridView();
            this.codEntradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.defeitoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbEntradaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD_SistemaGerenciamentoDataSet = new SistemaDeGerenciamento.BD_SistemaGerenciamentoDataSet();
            this.tabCliente = new System.Windows.Forms.TabPage();
            this.grid_Cliente = new System.Windows.Forms.DataGridView();
            this.codClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celularDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabEntrada = new System.Windows.Forms.TabPage();
            this.grid_Produto = new System.Windows.Forms.DataGridView();
            this.codProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip_Rodape = new System.Windows.Forms.ToolStrip();
            this.lbl_DataHoraAtual = new System.Windows.Forms.ToolStripLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_EntradaTableAdapter = new SistemaDeGerenciamento.BD_SistemaGerenciamentoDataSetTableAdapters.tb_EntradaTableAdapter();
            this.tb_ClienteTableAdapter = new SistemaDeGerenciamento.BD_SistemaGerenciamentoDataSetTableAdapters.tb_ClienteTableAdapter();
            this.tb_ProdutoTableAdapter = new SistemaDeGerenciamento.BD_SistemaGerenciamentoDataSetTableAdapters.tb_ProdutoTableAdapter();
            this.pn_Menu.SuspendLayout();
            this.pn_Entrada.SuspendLayout();
            this.pn_PagoOuNao.SuspendLayout();
            this.pn_TabControle.SuspendLayout();
            this.tab_Controle.SuspendLayout();
            this.tabProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Entrada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEntradaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_SistemaGerenciamentoDataSet)).BeginInit();
            this.tabCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Cliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClienteBindingSource)).BeginInit();
            this.tabEntrada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Produto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProdutoBindingSource)).BeginInit();
            this.toolStrip_Rodape.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_Menu
            // 
            this.pn_Menu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pn_Menu.BackColor = System.Drawing.Color.White;
            this.pn_Menu.Controls.Add(this.lbl_PesquisaNaoEncontrada);
            this.pn_Menu.Controls.Add(this.btn_Email);
            this.pn_Menu.Controls.Add(this.btn_Pesquisar);
            this.pn_Menu.Controls.Add(this.txt_Pesquisar);
            this.pn_Menu.Controls.Add(this.btn_Sair);
            this.pn_Menu.Controls.Add(this.btn_Excluir);
            this.pn_Menu.Controls.Add(this.btn_Salvar);
            this.pn_Menu.Controls.Add(this.btn_Novo);
            this.pn_Menu.Location = new System.Drawing.Point(-8, 0);
            this.pn_Menu.Name = "pn_Menu";
            this.pn_Menu.Size = new System.Drawing.Size(1271, 111);
            this.pn_Menu.TabIndex = 0;
            // 
            // lbl_PesquisaNaoEncontrada
            // 
            this.lbl_PesquisaNaoEncontrada.AutoSize = true;
            this.lbl_PesquisaNaoEncontrada.ForeColor = System.Drawing.Color.IndianRed;
            this.lbl_PesquisaNaoEncontrada.Location = new System.Drawing.Point(517, 81);
            this.lbl_PesquisaNaoEncontrada.Name = "lbl_PesquisaNaoEncontrada";
            this.lbl_PesquisaNaoEncontrada.Size = new System.Drawing.Size(143, 13);
            this.lbl_PesquisaNaoEncontrada.TabIndex = 7;
            this.lbl_PesquisaNaoEncontrada.Text = "  Pesquisa não encontrada...";
            this.lbl_PesquisaNaoEncontrada.Visible = false;
            // 
            // btn_Email
            // 
            this.btn_Email.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Email.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btn_Email.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Email.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Email.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Email.ForeColor = System.Drawing.Color.Gray;
            this.btn_Email.Image = ((System.Drawing.Image)(resources.GetObject("btn_Email.Image")));
            this.btn_Email.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Email.Location = new System.Drawing.Point(1164, 24);
            this.btn_Email.Name = "btn_Email";
            this.btn_Email.Size = new System.Drawing.Size(80, 84);
            this.btn_Email.TabIndex = 6;
            this.btn_Email.Text = "E-Mail";
            this.btn_Email.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Email.UseVisualStyleBackColor = true;
            // 
            // btn_Pesquisar
            // 
            this.btn_Pesquisar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Pesquisar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btn_Pesquisar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Pesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Pesquisar.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pesquisar.ForeColor = System.Drawing.Color.Gray;
            this.btn_Pesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Pesquisar.Image")));
            this.btn_Pesquisar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Pesquisar.Location = new System.Drawing.Point(863, 12);
            this.btn_Pesquisar.Name = "btn_Pesquisar";
            this.btn_Pesquisar.Size = new System.Drawing.Size(91, 96);
            this.btn_Pesquisar.TabIndex = 5;
            this.btn_Pesquisar.Text = "Pesquisar";
            this.btn_Pesquisar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Pesquisar.UseVisualStyleBackColor = true;
            // 
            // txt_Pesquisar
            // 
            this.txt_Pesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Pesquisar.ForeColor = System.Drawing.Color.Gray;
            this.txt_Pesquisar.Location = new System.Drawing.Point(520, 52);
            this.txt_Pesquisar.Name = "txt_Pesquisar";
            this.txt_Pesquisar.Size = new System.Drawing.Size(337, 26);
            this.txt_Pesquisar.TabIndex = 4;
            this.txt_Pesquisar.Text = " Digite Código ou o Nome do Cliente...";
            // 
            // btn_Sair
            // 
            this.btn_Sair.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Sair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btn_Sair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sair.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sair.ForeColor = System.Drawing.Color.Gray;
            this.btn_Sair.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sair.Image")));
            this.btn_Sair.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Sair.Location = new System.Drawing.Point(351, 12);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(80, 96);
            this.btn_Sair.TabIndex = 3;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Sair.UseVisualStyleBackColor = true;
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Excluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btn_Excluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Excluir.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Excluir.ForeColor = System.Drawing.Color.Gray;
            this.btn_Excluir.Image = ((System.Drawing.Image)(resources.GetObject("btn_Excluir.Image")));
            this.btn_Excluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Excluir.Location = new System.Drawing.Point(241, 12);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(80, 96);
            this.btn_Excluir.TabIndex = 2;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Excluir.UseVisualStyleBackColor = true;
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Salvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btn_Salvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salvar.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salvar.ForeColor = System.Drawing.Color.Gray;
            this.btn_Salvar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Salvar.Image")));
            this.btn_Salvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Salvar.Location = new System.Drawing.Point(132, 12);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(80, 96);
            this.btn_Salvar.TabIndex = 1;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // btn_Novo
            // 
            this.btn_Novo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Novo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btn_Novo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Novo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Novo.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Novo.ForeColor = System.Drawing.Color.Gray;
            this.btn_Novo.Image = ((System.Drawing.Image)(resources.GetObject("btn_Novo.Image")));
            this.btn_Novo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Novo.Location = new System.Drawing.Point(24, 12);
            this.btn_Novo.Name = "btn_Novo";
            this.btn_Novo.Size = new System.Drawing.Size(80, 96);
            this.btn_Novo.TabIndex = 0;
            this.btn_Novo.Text = "Novo";
            this.btn_Novo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Novo.UseVisualStyleBackColor = true;
            this.btn_Novo.Click += new System.EventHandler(this.btn_Novo_Click);
            // 
            // pn_Entrada
            // 
            this.pn_Entrada.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pn_Entrada.BackColor = System.Drawing.Color.White;
            this.pn_Entrada.Controls.Add(this.label16);
            this.pn_Entrada.Controls.Add(this.lbl_AvisoPago);
            this.pn_Entrada.Controls.Add(this.lbl_AvisoValor);
            this.pn_Entrada.Controls.Add(this.lbl_AvisoSaida);
            this.pn_Entrada.Controls.Add(this.lbl_AvisoEntrada);
            this.pn_Entrada.Controls.Add(this.lbl_AvisoProduto);
            this.pn_Entrada.Controls.Add(this.lbl_AvisoCliente);
            this.pn_Entrada.Controls.Add(this.txt_DataEntrada);
            this.pn_Entrada.Controls.Add(this.label3);
            this.pn_Entrada.Controls.Add(this.txt_Cliente);
            this.pn_Entrada.Controls.Add(this.label8);
            this.pn_Entrada.Controls.Add(this.btn_AddCliente);
            this.pn_Entrada.Controls.Add(this.pn_PagoOuNao);
            this.pn_Entrada.Controls.Add(this.btn_AddProduto);
            this.pn_Entrada.Controls.Add(this.label1);
            this.pn_Entrada.Controls.Add(this.label5);
            this.pn_Entrada.Controls.Add(this.label2);
            this.pn_Entrada.Controls.Add(this.label6);
            this.pn_Entrada.Controls.Add(this.label9);
            this.pn_Entrada.Controls.Add(this.txt_Codigo);
            this.pn_Entrada.Controls.Add(this.txt_Produto);
            this.pn_Entrada.Controls.Add(this.txt_Valor);
            this.pn_Entrada.Controls.Add(this.label7);
            this.pn_Entrada.Controls.Add(this.txt_Defeito);
            this.pn_Entrada.Controls.Add(this.txt_DataSaida);
            this.pn_Entrada.Location = new System.Drawing.Point(-8, 117);
            this.pn_Entrada.Name = "pn_Entrada";
            this.pn_Entrada.Size = new System.Drawing.Size(486, 545);
            this.pn_Entrada.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.IndianRed;
            this.label16.Location = new System.Drawing.Point(101, 521);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(0, 13);
            this.label16.TabIndex = 29;
            this.label16.Visible = false;
            // 
            // lbl_AvisoPago
            // 
            this.lbl_AvisoPago.AutoSize = true;
            this.lbl_AvisoPago.ForeColor = System.Drawing.Color.IndianRed;
            this.lbl_AvisoPago.Location = new System.Drawing.Point(102, 380);
            this.lbl_AvisoPago.Name = "lbl_AvisoPago";
            this.lbl_AvisoPago.Size = new System.Drawing.Size(109, 13);
            this.lbl_AvisoPago.TabIndex = 28;
            this.lbl_AvisoPago.Text = " Escolha obrigatória...";
            this.lbl_AvisoPago.Visible = false;
            // 
            // lbl_AvisoValor
            // 
            this.lbl_AvisoValor.AutoSize = true;
            this.lbl_AvisoValor.ForeColor = System.Drawing.Color.IndianRed;
            this.lbl_AvisoValor.Location = new System.Drawing.Point(102, 314);
            this.lbl_AvisoValor.Name = "lbl_AvisoValor";
            this.lbl_AvisoValor.Size = new System.Drawing.Size(91, 13);
            this.lbl_AvisoValor.TabIndex = 27;
            this.lbl_AvisoValor.Text = " Campo inválido...";
            this.lbl_AvisoValor.Visible = false;
            // 
            // lbl_AvisoSaida
            // 
            this.lbl_AvisoSaida.AutoSize = true;
            this.lbl_AvisoSaida.ForeColor = System.Drawing.Color.IndianRed;
            this.lbl_AvisoSaida.Location = new System.Drawing.Point(102, 266);
            this.lbl_AvisoSaida.Name = "lbl_AvisoSaida";
            this.lbl_AvisoSaida.Size = new System.Drawing.Size(91, 13);
            this.lbl_AvisoSaida.TabIndex = 26;
            this.lbl_AvisoSaida.Text = " Campo inválido...";
            this.lbl_AvisoSaida.Visible = false;
            // 
            // lbl_AvisoEntrada
            // 
            this.lbl_AvisoEntrada.AutoSize = true;
            this.lbl_AvisoEntrada.ForeColor = System.Drawing.Color.IndianRed;
            this.lbl_AvisoEntrada.Location = new System.Drawing.Point(102, 215);
            this.lbl_AvisoEntrada.Name = "lbl_AvisoEntrada";
            this.lbl_AvisoEntrada.Size = new System.Drawing.Size(91, 13);
            this.lbl_AvisoEntrada.TabIndex = 25;
            this.lbl_AvisoEntrada.Text = " Campo inválido...";
            this.lbl_AvisoEntrada.Visible = false;
            // 
            // lbl_AvisoProduto
            // 
            this.lbl_AvisoProduto.AutoSize = true;
            this.lbl_AvisoProduto.ForeColor = System.Drawing.Color.IndianRed;
            this.lbl_AvisoProduto.Location = new System.Drawing.Point(101, 166);
            this.lbl_AvisoProduto.Name = "lbl_AvisoProduto";
            this.lbl_AvisoProduto.Size = new System.Drawing.Size(104, 13);
            this.lbl_AvisoProduto.TabIndex = 24;
            this.lbl_AvisoProduto.Text = " Campo obrigatório...";
            this.lbl_AvisoProduto.Visible = false;
            // 
            // lbl_AvisoCliente
            // 
            this.lbl_AvisoCliente.AutoSize = true;
            this.lbl_AvisoCliente.ForeColor = System.Drawing.Color.IndianRed;
            this.lbl_AvisoCliente.Location = new System.Drawing.Point(101, 113);
            this.lbl_AvisoCliente.Name = "lbl_AvisoCliente";
            this.lbl_AvisoCliente.Size = new System.Drawing.Size(104, 13);
            this.lbl_AvisoCliente.TabIndex = 23;
            this.lbl_AvisoCliente.Text = " Campo obrigatório...";
            this.lbl_AvisoCliente.Visible = false;
            // 
            // txt_DataEntrada
            // 
            this.txt_DataEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DataEntrada.Location = new System.Drawing.Point(105, 186);
            this.txt_DataEntrada.Mask = "00/00/0000";
            this.txt_DataEntrada.Name = "txt_DataEntrada";
            this.txt_DataEntrada.Size = new System.Drawing.Size(109, 26);
            this.txt_DataEntrada.TabIndex = 21;
            this.txt_DataEntrada.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(20, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cliente:";
            // 
            // txt_Cliente
            // 
            this.txt_Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cliente.FormattingEnabled = true;
            this.txt_Cliente.Location = new System.Drawing.Point(105, 82);
            this.txt_Cliente.Name = "txt_Cliente";
            this.txt_Cliente.Size = new System.Drawing.Size(293, 28);
            this.txt_Cliente.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(20, 342);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Pago:";
            // 
            // btn_AddCliente
            // 
            this.btn_AddCliente.BackColor = System.Drawing.Color.White;
            this.btn_AddCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_AddCliente.BackgroundImage")));
            this.btn_AddCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_AddCliente.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_AddCliente.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_AddCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btn_AddCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_AddCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddCliente.Location = new System.Drawing.Point(423, 82);
            this.btn_AddCliente.Name = "btn_AddCliente";
            this.btn_AddCliente.Size = new System.Drawing.Size(45, 28);
            this.btn_AddCliente.TabIndex = 20;
            this.btn_AddCliente.UseVisualStyleBackColor = false;
            this.btn_AddCliente.Click += new System.EventHandler(this.btn_AddCliente_Click);
            // 
            // pn_PagoOuNao
            // 
            this.pn_PagoOuNao.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pn_PagoOuNao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_PagoOuNao.Controls.Add(this.check_PagoSim);
            this.pn_PagoOuNao.Controls.Add(this.check_PagoNao);
            this.pn_PagoOuNao.Location = new System.Drawing.Point(105, 333);
            this.pn_PagoOuNao.Name = "pn_PagoOuNao";
            this.pn_PagoOuNao.Size = new System.Drawing.Size(363, 44);
            this.pn_PagoOuNao.TabIndex = 13;
            // 
            // check_PagoSim
            // 
            this.check_PagoSim.AutoSize = true;
            this.check_PagoSim.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_PagoSim.ForeColor = System.Drawing.Color.DarkCyan;
            this.check_PagoSim.Location = new System.Drawing.Point(171, 8);
            this.check_PagoSim.Name = "check_PagoSim";
            this.check_PagoSim.Size = new System.Drawing.Size(55, 24);
            this.check_PagoSim.TabIndex = 1;
            this.check_PagoSim.Text = "Sim";
            this.check_PagoSim.UseVisualStyleBackColor = true;
            // 
            // check_PagoNao
            // 
            this.check_PagoNao.AutoSize = true;
            this.check_PagoNao.Checked = true;
            this.check_PagoNao.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_PagoNao.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_PagoNao.ForeColor = System.Drawing.Color.IndianRed;
            this.check_PagoNao.Location = new System.Drawing.Point(37, 9);
            this.check_PagoNao.Name = "check_PagoNao";
            this.check_PagoNao.Size = new System.Drawing.Size(58, 24);
            this.check_PagoNao.TabIndex = 0;
            this.check_PagoNao.Text = "Não";
            this.check_PagoNao.UseVisualStyleBackColor = true;
            // 
            // btn_AddProduto
            // 
            this.btn_AddProduto.BackColor = System.Drawing.Color.White;
            this.btn_AddProduto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_AddProduto.BackgroundImage")));
            this.btn_AddProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_AddProduto.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_AddProduto.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_AddProduto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btn_AddProduto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_AddProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddProduto.Location = new System.Drawing.Point(423, 135);
            this.btn_AddProduto.Name = "btn_AddProduto";
            this.btn_AddProduto.Size = new System.Drawing.Size(45, 28);
            this.btn_AddProduto.TabIndex = 19;
            this.btn_AddProduto.UseVisualStyleBackColor = false;
            this.btn_AddProduto.Click += new System.EventHandler(this.btn_AddProduto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(20, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(20, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Entrada:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(19, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Produto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(20, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Saída";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(20, 401);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Defeito:";
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.Enabled = false;
            this.txt_Codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Codigo.Location = new System.Drawing.Point(105, 32);
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.Size = new System.Drawing.Size(100, 26);
            this.txt_Codigo.TabIndex = 9;
            // 
            // txt_Produto
            // 
            this.txt_Produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Produto.FormattingEnabled = true;
            this.txt_Produto.Items.AddRange(new object[] {
            "COMPUTADOR",
            "NOTEBOOK",
            "MONITOR",
            "TABLET",
            "GPS"});
            this.txt_Produto.Location = new System.Drawing.Point(104, 135);
            this.txt_Produto.Name = "txt_Produto";
            this.txt_Produto.Size = new System.Drawing.Size(293, 28);
            this.txt_Produto.TabIndex = 17;
            // 
            // txt_Valor
            // 
            this.txt_Valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Valor.Location = new System.Drawing.Point(105, 285);
            this.txt_Valor.Name = "txt_Valor";
            this.txt_Valor.Size = new System.Drawing.Size(109, 26);
            this.txt_Valor.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(20, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Valor:";
            // 
            // txt_Defeito
            // 
            this.txt_Defeito.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_Defeito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Defeito.Location = new System.Drawing.Point(105, 401);
            this.txt_Defeito.Multiline = true;
            this.txt_Defeito.Name = "txt_Defeito";
            this.txt_Defeito.Size = new System.Drawing.Size(363, 116);
            this.txt_Defeito.TabIndex = 14;
            // 
            // txt_DataSaida
            // 
            this.txt_DataSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DataSaida.Location = new System.Drawing.Point(105, 237);
            this.txt_DataSaida.Mask = "00/00/0000";
            this.txt_DataSaida.Name = "txt_DataSaida";
            this.txt_DataSaida.Size = new System.Drawing.Size(109, 26);
            this.txt_DataSaida.TabIndex = 15;
            this.txt_DataSaida.ValidatingType = typeof(System.DateTime);
            // 
            // pn_TabControle
            // 
            this.pn_TabControle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pn_TabControle.BackColor = System.Drawing.Color.White;
            this.pn_TabControle.Controls.Add(this.tab_Controle);
            this.pn_TabControle.Location = new System.Drawing.Point(475, 117);
            this.pn_TabControle.Name = "pn_TabControle";
            this.pn_TabControle.Size = new System.Drawing.Size(788, 545);
            this.pn_TabControle.TabIndex = 2;
            // 
            // tab_Controle
            // 
            this.tab_Controle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab_Controle.Controls.Add(this.tabProduto);
            this.tab_Controle.Controls.Add(this.tabCliente);
            this.tab_Controle.Controls.Add(this.tabEntrada);
            this.tab_Controle.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tab_Controle.Location = new System.Drawing.Point(3, 3);
            this.tab_Controle.Name = "tab_Controle";
            this.tab_Controle.Padding = new System.Drawing.Point(50, 5);
            this.tab_Controle.SelectedIndex = 0;
            this.tab_Controle.Size = new System.Drawing.Size(779, 518);
            this.tab_Controle.TabIndex = 0;
            this.tab_Controle.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tab_Controle_MouseClick);
            // 
            // tabProduto
            // 
            this.tabProduto.AccessibleName = "tabProduto";
            this.tabProduto.Controls.Add(this.grid_Entrada);
            this.tabProduto.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabProduto.ForeColor = System.Drawing.Color.Gray;
            this.tabProduto.Location = new System.Drawing.Point(4, 33);
            this.tabProduto.Name = "tabProduto";
            this.tabProduto.Padding = new System.Windows.Forms.Padding(3);
            this.tabProduto.Size = new System.Drawing.Size(771, 481);
            this.tabProduto.TabIndex = 1;
            this.tabProduto.Text = "      Entrada";
            this.tabProduto.UseVisualStyleBackColor = true;
            // 
            // grid_Entrada
            // 
            this.grid_Entrada.AllowUserToAddRows = false;
            this.grid_Entrada.AllowUserToDeleteRows = false;
            this.grid_Entrada.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_Entrada.AutoGenerateColumns = false;
            this.grid_Entrada.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.grid_Entrada.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_Entrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Entrada.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codEntradaDataGridViewTextBoxColumn,
            this.produtoDataGridViewTextBoxColumn,
            this.clienteDataGridViewTextBoxColumn,
            this.entradaDataGridViewTextBoxColumn,
            this.saidaDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn,
            this.pagoDataGridViewTextBoxColumn,
            this.defeitoDataGridViewTextBoxColumn});
            this.grid_Entrada.DataSource = this.tbEntradaBindingSource;
            this.grid_Entrada.Location = new System.Drawing.Point(3, 3);
            this.grid_Entrada.Name = "grid_Entrada";
            this.grid_Entrada.Size = new System.Drawing.Size(765, 475);
            this.grid_Entrada.TabIndex = 0;
            // 
            // codEntradaDataGridViewTextBoxColumn
            // 
            this.codEntradaDataGridViewTextBoxColumn.DataPropertyName = "codEntrada";
            this.codEntradaDataGridViewTextBoxColumn.HeaderText = "codEntrada";
            this.codEntradaDataGridViewTextBoxColumn.Name = "codEntradaDataGridViewTextBoxColumn";
            // 
            // produtoDataGridViewTextBoxColumn
            // 
            this.produtoDataGridViewTextBoxColumn.DataPropertyName = "produto";
            this.produtoDataGridViewTextBoxColumn.HeaderText = "produto";
            this.produtoDataGridViewTextBoxColumn.Name = "produtoDataGridViewTextBoxColumn";
            // 
            // clienteDataGridViewTextBoxColumn
            // 
            this.clienteDataGridViewTextBoxColumn.DataPropertyName = "cliente";
            this.clienteDataGridViewTextBoxColumn.HeaderText = "cliente";
            this.clienteDataGridViewTextBoxColumn.Name = "clienteDataGridViewTextBoxColumn";
            // 
            // entradaDataGridViewTextBoxColumn
            // 
            this.entradaDataGridViewTextBoxColumn.DataPropertyName = "entrada";
            this.entradaDataGridViewTextBoxColumn.HeaderText = "entrada";
            this.entradaDataGridViewTextBoxColumn.Name = "entradaDataGridViewTextBoxColumn";
            // 
            // saidaDataGridViewTextBoxColumn
            // 
            this.saidaDataGridViewTextBoxColumn.DataPropertyName = "saida";
            this.saidaDataGridViewTextBoxColumn.HeaderText = "saida";
            this.saidaDataGridViewTextBoxColumn.Name = "saidaDataGridViewTextBoxColumn";
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "valor";
            this.valorDataGridViewTextBoxColumn.HeaderText = "valor";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            // 
            // pagoDataGridViewTextBoxColumn
            // 
            this.pagoDataGridViewTextBoxColumn.DataPropertyName = "pago";
            this.pagoDataGridViewTextBoxColumn.HeaderText = "pago";
            this.pagoDataGridViewTextBoxColumn.Name = "pagoDataGridViewTextBoxColumn";
            // 
            // defeitoDataGridViewTextBoxColumn
            // 
            this.defeitoDataGridViewTextBoxColumn.DataPropertyName = "defeito";
            this.defeitoDataGridViewTextBoxColumn.HeaderText = "defeito";
            this.defeitoDataGridViewTextBoxColumn.Name = "defeitoDataGridViewTextBoxColumn";
            // 
            // tbEntradaBindingSource
            // 
            this.tbEntradaBindingSource.DataMember = "tb_Entrada";
            this.tbEntradaBindingSource.DataSource = this.bD_SistemaGerenciamentoDataSet;
            // 
            // bD_SistemaGerenciamentoDataSet
            // 
            this.bD_SistemaGerenciamentoDataSet.DataSetName = "BD_SistemaGerenciamentoDataSet";
            this.bD_SistemaGerenciamentoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabCliente
            // 
            this.tabCliente.Controls.Add(this.grid_Cliente);
            this.tabCliente.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCliente.ForeColor = System.Drawing.Color.Gray;
            this.tabCliente.Location = new System.Drawing.Point(4, 33);
            this.tabCliente.Name = "tabCliente";
            this.tabCliente.Padding = new System.Windows.Forms.Padding(3);
            this.tabCliente.Size = new System.Drawing.Size(771, 313);
            this.tabCliente.TabIndex = 0;
            this.tabCliente.Text = "      Cliente";
            this.tabCliente.UseVisualStyleBackColor = true;
            // 
            // grid_Cliente
            // 
            this.grid_Cliente.AllowUserToAddRows = false;
            this.grid_Cliente.AllowUserToDeleteRows = false;
            this.grid_Cliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_Cliente.AutoGenerateColumns = false;
            this.grid_Cliente.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.grid_Cliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_Cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Cliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codClienteDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.enderecoDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.celularDataGridViewTextBoxColumn});
            this.grid_Cliente.DataSource = this.tbClienteBindingSource;
            this.grid_Cliente.Location = new System.Drawing.Point(3, 3);
            this.grid_Cliente.Name = "grid_Cliente";
            this.grid_Cliente.Size = new System.Drawing.Size(765, 471);
            this.grid_Cliente.TabIndex = 0;
            this.grid_Cliente.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grid_Cliente_RowHeaderMouseClick);
            // 
            // codClienteDataGridViewTextBoxColumn
            // 
            this.codClienteDataGridViewTextBoxColumn.DataPropertyName = "codCliente";
            this.codClienteDataGridViewTextBoxColumn.HeaderText = "codCliente";
            this.codClienteDataGridViewTextBoxColumn.Name = "codClienteDataGridViewTextBoxColumn";
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // enderecoDataGridViewTextBoxColumn
            // 
            this.enderecoDataGridViewTextBoxColumn.DataPropertyName = "endereco";
            this.enderecoDataGridViewTextBoxColumn.HeaderText = "endereco";
            this.enderecoDataGridViewTextBoxColumn.Name = "enderecoDataGridViewTextBoxColumn";
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            // 
            // celularDataGridViewTextBoxColumn
            // 
            this.celularDataGridViewTextBoxColumn.DataPropertyName = "celular";
            this.celularDataGridViewTextBoxColumn.HeaderText = "celular";
            this.celularDataGridViewTextBoxColumn.Name = "celularDataGridViewTextBoxColumn";
            // 
            // tbClienteBindingSource
            // 
            this.tbClienteBindingSource.DataMember = "tb_Cliente";
            this.tbClienteBindingSource.DataSource = this.bD_SistemaGerenciamentoDataSet;
            // 
            // tabEntrada
            // 
            this.tabEntrada.Controls.Add(this.grid_Produto);
            this.tabEntrada.ForeColor = System.Drawing.Color.Gray;
            this.tabEntrada.Location = new System.Drawing.Point(4, 33);
            this.tabEntrada.Name = "tabEntrada";
            this.tabEntrada.Padding = new System.Windows.Forms.Padding(3);
            this.tabEntrada.Size = new System.Drawing.Size(771, 313);
            this.tabEntrada.TabIndex = 2;
            this.tabEntrada.Text = "Produto";
            this.tabEntrada.UseVisualStyleBackColor = true;
            // 
            // grid_Produto
            // 
            this.grid_Produto.AllowUserToAddRows = false;
            this.grid_Produto.AllowUserToDeleteRows = false;
            this.grid_Produto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_Produto.AutoGenerateColumns = false;
            this.grid_Produto.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.grid_Produto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Produto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codProdutoDataGridViewTextBoxColumn,
            this.produtoDataGridViewTextBoxColumn1,
            this.marcaDataGridViewTextBoxColumn,
            this.modeloDataGridViewTextBoxColumn});
            this.grid_Produto.DataSource = this.tbProdutoBindingSource;
            this.grid_Produto.Location = new System.Drawing.Point(3, 3);
            this.grid_Produto.Name = "grid_Produto";
            this.grid_Produto.Size = new System.Drawing.Size(765, 471);
            this.grid_Produto.TabIndex = 0;
            this.grid_Produto.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grid_Produto_RowHeaderMouseClick);
            // 
            // codProdutoDataGridViewTextBoxColumn
            // 
            this.codProdutoDataGridViewTextBoxColumn.DataPropertyName = "codProduto";
            this.codProdutoDataGridViewTextBoxColumn.HeaderText = "codProduto";
            this.codProdutoDataGridViewTextBoxColumn.Name = "codProdutoDataGridViewTextBoxColumn";
            // 
            // produtoDataGridViewTextBoxColumn1
            // 
            this.produtoDataGridViewTextBoxColumn1.DataPropertyName = "produto";
            this.produtoDataGridViewTextBoxColumn1.HeaderText = "produto";
            this.produtoDataGridViewTextBoxColumn1.Name = "produtoDataGridViewTextBoxColumn1";
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            this.marcaDataGridViewTextBoxColumn.DataPropertyName = "marca";
            this.marcaDataGridViewTextBoxColumn.HeaderText = "marca";
            this.marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            // 
            // modeloDataGridViewTextBoxColumn
            // 
            this.modeloDataGridViewTextBoxColumn.DataPropertyName = "modelo";
            this.modeloDataGridViewTextBoxColumn.HeaderText = "modelo";
            this.modeloDataGridViewTextBoxColumn.Name = "modeloDataGridViewTextBoxColumn";
            // 
            // tbProdutoBindingSource
            // 
            this.tbProdutoBindingSource.DataMember = "tb_Produto";
            this.tbProdutoBindingSource.DataSource = this.bD_SistemaGerenciamentoDataSet;
            // 
            // toolStrip_Rodape
            // 
            this.toolStrip_Rodape.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip_Rodape.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_DataHoraAtual});
            this.toolStrip_Rodape.Location = new System.Drawing.Point(0, 665);
            this.toolStrip_Rodape.Name = "toolStrip_Rodape";
            this.toolStrip_Rodape.Size = new System.Drawing.Size(1257, 25);
            this.toolStrip_Rodape.TabIndex = 3;
            this.toolStrip_Rodape.Text = "toolStrip1";
            // 
            // lbl_DataHoraAtual
            // 
            this.lbl_DataHoraAtual.Name = "lbl_DataHoraAtual";
            this.lbl_DataHoraAtual.Size = new System.Drawing.Size(0, 22);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1257, 690);
            this.panel1.TabIndex = 5;
            // 
            // tb_EntradaTableAdapter
            // 
            this.tb_EntradaTableAdapter.ClearBeforeFill = true;
            // 
            // tb_ClienteTableAdapter
            // 
            this.tb_ClienteTableAdapter.ClearBeforeFill = true;
            // 
            // tb_ProdutoTableAdapter
            // 
            this.tb_ProdutoTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1257, 690);
            this.Controls.Add(this.toolStrip_Rodape);
            this.Controls.Add(this.pn_Entrada);
            this.Controls.Add(this.pn_Menu);
            this.Controls.Add(this.pn_TabControle);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Controle";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pn_Menu.ResumeLayout(false);
            this.pn_Menu.PerformLayout();
            this.pn_Entrada.ResumeLayout(false);
            this.pn_Entrada.PerformLayout();
            this.pn_PagoOuNao.ResumeLayout(false);
            this.pn_PagoOuNao.PerformLayout();
            this.pn_TabControle.ResumeLayout(false);
            this.tab_Controle.ResumeLayout(false);
            this.tabProduto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Entrada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEntradaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_SistemaGerenciamentoDataSet)).EndInit();
            this.tabCliente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Cliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClienteBindingSource)).EndInit();
            this.tabEntrada.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Produto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProdutoBindingSource)).EndInit();
            this.toolStrip_Rodape.ResumeLayout(false);
            this.toolStrip_Rodape.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pn_Menu;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Button btn_Novo;
        private System.Windows.Forms.Panel pn_Entrada;
        private System.Windows.Forms.Panel pn_TabControle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Codigo;
        private System.Windows.Forms.TextBox txt_Valor;
        private System.Windows.Forms.Panel pn_PagoOuNao;
        private System.Windows.Forms.TextBox txt_Defeito;
        private System.Windows.Forms.MaskedTextBox txt_DataSaida;
        private System.Windows.Forms.ComboBox txt_Produto;
        private System.Windows.Forms.Button btn_AddProduto;
        private System.Windows.Forms.ToolStrip toolStrip_Rodape;
        private System.Windows.Forms.CheckBox check_PagoSim;
        private System.Windows.Forms.CheckBox check_PagoNao;
        private System.Windows.Forms.TabControl tab_Controle;
        private System.Windows.Forms.TabPage tabCliente;
        private System.Windows.Forms.TabPage tabProduto;
        private System.Windows.Forms.Button btn_Email;
        private System.Windows.Forms.Button btn_Pesquisar;
        private System.Windows.Forms.TextBox txt_Pesquisar;
        private System.Windows.Forms.Label lbl_PesquisaNaoEncontrada;
        private System.Windows.Forms.MaskedTextBox txt_DataEntrada;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripLabel lbl_DataHoraAtual;
        private System.Windows.Forms.DataGridView grid_Entrada;
        private System.Windows.Forms.DataGridView grid_Cliente;
        private BD_SistemaGerenciamentoDataSet bD_SistemaGerenciamentoDataSet;
        private System.Windows.Forms.BindingSource tbEntradaBindingSource;
        private BD_SistemaGerenciamentoDataSetTableAdapters.tb_EntradaTableAdapter tb_EntradaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codEntradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn produtoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn defeitoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tbClienteBindingSource;
        private BD_SistemaGerenciamentoDataSetTableAdapters.tb_ClienteTableAdapter tb_ClienteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn celularDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tabEntrada;
        private System.Windows.Forms.DataGridView grid_Produto;
        private System.Windows.Forms.BindingSource tbProdutoBindingSource;
        private BD_SistemaGerenciamentoDataSetTableAdapters.tb_ProdutoTableAdapter tb_ProdutoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn produtoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox txt_Cliente;
        private System.Windows.Forms.Button btn_AddCliente;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lbl_AvisoPago;
        private System.Windows.Forms.Label lbl_AvisoValor;
        private System.Windows.Forms.Label lbl_AvisoSaida;
        private System.Windows.Forms.Label lbl_AvisoEntrada;
        private System.Windows.Forms.Label lbl_AvisoProduto;
        private System.Windows.Forms.Label lbl_AvisoCliente;
    }
}

