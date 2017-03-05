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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pn_Menu = new System.Windows.Forms.Panel();
            this.pn_Entrada = new System.Windows.Forms.Panel();
            this.btn_Novo = new System.Windows.Forms.Button();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.pn_TabControle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Codigo = new System.Windows.Forms.TextBox();
            this.txt_Valor = new System.Windows.Forms.TextBox();
            this.pn_PagoOuNao = new System.Windows.Forms.Panel();
            this.txt_Defeito = new System.Windows.Forms.TextBox();
            this.txt_DataSaida = new System.Windows.Forms.MaskedTextBox();
            this.txt_Produto = new System.Windows.Forms.ComboBox();
            this.txt_Cliente = new System.Windows.Forms.ComboBox();
            this.btn_AddProduto = new System.Windows.Forms.Button();
            this.btn_AddCliente = new System.Windows.Forms.Button();
            this.toolStrip_Rodape = new System.Windows.Forms.ToolStrip();
            this.check_PagoNao = new System.Windows.Forms.CheckBox();
            this.check_PagoSim = new System.Windows.Forms.CheckBox();
            this.tab_Controle = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txt_Pesquisar = new System.Windows.Forms.TextBox();
            this.btn_Pesquisar = new System.Windows.Forms.Button();
            this.btn_Email = new System.Windows.Forms.Button();
            this.lbl_PesquisaNaoEncontrada = new System.Windows.Forms.Label();
            this.txt_DataEntrada = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pn_Menu.SuspendLayout();
            this.pn_Entrada.SuspendLayout();
            this.pn_TabControle.SuspendLayout();
            this.pn_PagoOuNao.SuspendLayout();
            this.tab_Controle.SuspendLayout();
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
            // pn_Entrada
            // 
            this.pn_Entrada.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pn_Entrada.BackColor = System.Drawing.Color.White;
            this.pn_Entrada.Controls.Add(this.txt_DataEntrada);
            this.pn_Entrada.Controls.Add(this.label8);
            this.pn_Entrada.Controls.Add(this.pn_PagoOuNao);
            this.pn_Entrada.Controls.Add(this.btn_AddCliente);
            this.pn_Entrada.Controls.Add(this.btn_AddProduto);
            this.pn_Entrada.Controls.Add(this.label1);
            this.pn_Entrada.Controls.Add(this.txt_Cliente);
            this.pn_Entrada.Controls.Add(this.label5);
            this.pn_Entrada.Controls.Add(this.label2);
            this.pn_Entrada.Controls.Add(this.label6);
            this.pn_Entrada.Controls.Add(this.label9);
            this.pn_Entrada.Controls.Add(this.txt_Codigo);
            this.pn_Entrada.Controls.Add(this.txt_Produto);
            this.pn_Entrada.Controls.Add(this.label3);
            this.pn_Entrada.Controls.Add(this.txt_Valor);
            this.pn_Entrada.Controls.Add(this.label7);
            this.pn_Entrada.Controls.Add(this.txt_Defeito);
            this.pn_Entrada.Controls.Add(this.txt_DataSaida);
            this.pn_Entrada.Location = new System.Drawing.Point(-8, 117);
            this.pn_Entrada.Name = "pn_Entrada";
            this.pn_Entrada.Size = new System.Drawing.Size(486, 534);
            this.pn_Entrada.TabIndex = 1;
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
            // pn_TabControle
            // 
            this.pn_TabControle.BackColor = System.Drawing.Color.White;
            this.pn_TabControle.Controls.Add(this.tab_Controle);
            this.pn_TabControle.Location = new System.Drawing.Point(475, 117);
            this.pn_TabControle.Name = "pn_TabControle";
            this.pn_TabControle.Size = new System.Drawing.Size(788, 534);
            this.pn_TabControle.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(20, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(20, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Produto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(20, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cliente:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(20, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Entrada:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(20, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Saída";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(20, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Valor:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(20, 338);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Pago:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(20, 392);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Defeito:";
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Codigo.Location = new System.Drawing.Point(105, 28);
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.Size = new System.Drawing.Size(100, 26);
            this.txt_Codigo.TabIndex = 9;
            // 
            // txt_Valor
            // 
            this.txt_Valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Valor.Location = new System.Drawing.Point(105, 278);
            this.txt_Valor.Name = "txt_Valor";
            this.txt_Valor.Size = new System.Drawing.Size(109, 26);
            this.txt_Valor.TabIndex = 12;
            // 
            // pn_PagoOuNao
            // 
            this.pn_PagoOuNao.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pn_PagoOuNao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_PagoOuNao.Controls.Add(this.check_PagoSim);
            this.pn_PagoOuNao.Controls.Add(this.check_PagoNao);
            this.pn_PagoOuNao.Location = new System.Drawing.Point(105, 329);
            this.pn_PagoOuNao.Name = "pn_PagoOuNao";
            this.pn_PagoOuNao.Size = new System.Drawing.Size(359, 44);
            this.pn_PagoOuNao.TabIndex = 13;
            // 
            // txt_Defeito
            // 
            this.txt_Defeito.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_Defeito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Defeito.Location = new System.Drawing.Point(105, 392);
            this.txt_Defeito.Multiline = true;
            this.txt_Defeito.Name = "txt_Defeito";
            this.txt_Defeito.Size = new System.Drawing.Size(359, 113);
            this.txt_Defeito.TabIndex = 14;
            // 
            // txt_DataSaida
            // 
            this.txt_DataSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DataSaida.Location = new System.Drawing.Point(105, 228);
            this.txt_DataSaida.Mask = "00/00/0000";
            this.txt_DataSaida.Name = "txt_DataSaida";
            this.txt_DataSaida.Size = new System.Drawing.Size(109, 26);
            this.txt_DataSaida.TabIndex = 15;
            this.txt_DataSaida.ValidatingType = typeof(System.DateTime);
            // 
            // txt_Produto
            // 
            this.txt_Produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Produto.FormattingEnabled = true;
            this.txt_Produto.Location = new System.Drawing.Point(105, 78);
            this.txt_Produto.Name = "txt_Produto";
            this.txt_Produto.Size = new System.Drawing.Size(293, 28);
            this.txt_Produto.TabIndex = 17;
            // 
            // txt_Cliente
            // 
            this.txt_Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cliente.FormattingEnabled = true;
            this.txt_Cliente.Location = new System.Drawing.Point(105, 128);
            this.txt_Cliente.Name = "txt_Cliente";
            this.txt_Cliente.Size = new System.Drawing.Size(293, 28);
            this.txt_Cliente.TabIndex = 18;
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
            this.btn_AddProduto.Location = new System.Drawing.Point(419, 78);
            this.btn_AddProduto.Name = "btn_AddProduto";
            this.btn_AddProduto.Size = new System.Drawing.Size(45, 28);
            this.btn_AddProduto.TabIndex = 19;
            this.btn_AddProduto.UseVisualStyleBackColor = false;
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
            this.btn_AddCliente.Location = new System.Drawing.Point(419, 128);
            this.btn_AddCliente.Name = "btn_AddCliente";
            this.btn_AddCliente.Size = new System.Drawing.Size(45, 28);
            this.btn_AddCliente.TabIndex = 20;
            this.btn_AddCliente.UseVisualStyleBackColor = false;
            // 
            // toolStrip_Rodape
            // 
            this.toolStrip_Rodape.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip_Rodape.Location = new System.Drawing.Point(0, 654);
            this.toolStrip_Rodape.Name = "toolStrip_Rodape";
            this.toolStrip_Rodape.Size = new System.Drawing.Size(1257, 25);
            this.toolStrip_Rodape.TabIndex = 3;
            this.toolStrip_Rodape.Text = "toolStrip1";
            // 
            // check_PagoNao
            // 
            this.check_PagoNao.AutoSize = true;
            this.check_PagoNao.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_PagoNao.ForeColor = System.Drawing.Color.IndianRed;
            this.check_PagoNao.Location = new System.Drawing.Point(37, 9);
            this.check_PagoNao.Name = "check_PagoNao";
            this.check_PagoNao.Size = new System.Drawing.Size(58, 24);
            this.check_PagoNao.TabIndex = 0;
            this.check_PagoNao.Text = "Não";
            this.check_PagoNao.UseVisualStyleBackColor = true;
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
            // tab_Controle
            // 
            this.tab_Controle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab_Controle.Controls.Add(this.tabPage2);
            this.tab_Controle.Controls.Add(this.tabPage1);
            this.tab_Controle.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_Controle.Location = new System.Drawing.Point(3, 3);
            this.tab_Controle.Name = "tab_Controle";
            this.tab_Controle.SelectedIndex = 0;
            this.tab_Controle.Size = new System.Drawing.Size(779, 513);
            this.tab_Controle.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ForeColor = System.Drawing.Color.Gray;
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(771, 480);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Entrada";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.ForeColor = System.Drawing.Color.Gray;
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(776, 469);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cliente";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txt_Pesquisar
            // 
            this.txt_Pesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Pesquisar.ForeColor = System.Drawing.Color.Gray;
            this.txt_Pesquisar.Location = new System.Drawing.Point(520, 52);
            this.txt_Pesquisar.Name = "txt_Pesquisar";
            this.txt_Pesquisar.Size = new System.Drawing.Size(337, 26);
            this.txt_Pesquisar.TabIndex = 4;
            this.txt_Pesquisar.Text = "Digite Código ou o Nome do Cliente...";
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
            this.btn_Email.Location = new System.Drawing.Point(1164, 27);
            this.btn_Email.Name = "btn_Email";
            this.btn_Email.Size = new System.Drawing.Size(80, 84);
            this.btn_Email.TabIndex = 6;
            this.btn_Email.Text = "E-Mail";
            this.btn_Email.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Email.UseVisualStyleBackColor = true;
            // 
            // lbl_PesquisaNaoEncontrada
            // 
            this.lbl_PesquisaNaoEncontrada.AutoSize = true;
            this.lbl_PesquisaNaoEncontrada.ForeColor = System.Drawing.Color.IndianRed;
            this.lbl_PesquisaNaoEncontrada.Location = new System.Drawing.Point(517, 81);
            this.lbl_PesquisaNaoEncontrada.Name = "lbl_PesquisaNaoEncontrada";
            this.lbl_PesquisaNaoEncontrada.Size = new System.Drawing.Size(137, 13);
            this.lbl_PesquisaNaoEncontrada.TabIndex = 7;
            this.lbl_PesquisaNaoEncontrada.Text = "Pesquisa não encontrada...";
            this.lbl_PesquisaNaoEncontrada.Visible = false;
            // 
            // txt_DataEntrada
            // 
            this.txt_DataEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DataEntrada.Location = new System.Drawing.Point(105, 178);
            this.txt_DataEntrada.Mask = "00/00/0000";
            this.txt_DataEntrada.Name = "txt_DataEntrada";
            this.txt_DataEntrada.Size = new System.Drawing.Size(109, 26);
            this.txt_DataEntrada.TabIndex = 21;
            this.txt_DataEntrada.ValidatingType = typeof(System.DateTime);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1257, 679);
            this.panel1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1257, 679);
            this.Controls.Add(this.toolStrip_Rodape);
            this.Controls.Add(this.pn_Entrada);
            this.Controls.Add(this.pn_Menu);
            this.Controls.Add(this.pn_TabControle);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Sistema de Controle";
            this.pn_Menu.ResumeLayout(false);
            this.pn_Menu.PerformLayout();
            this.pn_Entrada.ResumeLayout(false);
            this.pn_Entrada.PerformLayout();
            this.pn_TabControle.ResumeLayout(false);
            this.pn_PagoOuNao.ResumeLayout(false);
            this.pn_PagoOuNao.PerformLayout();
            this.tab_Controle.ResumeLayout(false);
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
        private System.Windows.Forms.ComboBox txt_Cliente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Codigo;
        private System.Windows.Forms.TextBox txt_Valor;
        private System.Windows.Forms.Panel pn_PagoOuNao;
        private System.Windows.Forms.TextBox txt_Defeito;
        private System.Windows.Forms.MaskedTextBox txt_DataSaida;
        private System.Windows.Forms.ComboBox txt_Produto;
        private System.Windows.Forms.Button btn_AddCliente;
        private System.Windows.Forms.Button btn_AddProduto;
        private System.Windows.Forms.ToolStrip toolStrip_Rodape;
        private System.Windows.Forms.CheckBox check_PagoSim;
        private System.Windows.Forms.CheckBox check_PagoNao;
        private System.Windows.Forms.TabControl tab_Controle;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_Email;
        private System.Windows.Forms.Button btn_Pesquisar;
        private System.Windows.Forms.TextBox txt_Pesquisar;
        private System.Windows.Forms.Label lbl_PesquisaNaoEncontrada;
        private System.Windows.Forms.MaskedTextBox txt_DataEntrada;
        private System.Windows.Forms.Panel panel1;
    }
}

