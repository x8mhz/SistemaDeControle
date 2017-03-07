namespace SistemaDeGerenciamento
{
    partial class f_CadastroCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_CadastroCliente));
            this.pn_MenuCadastroCliente = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_SalvarCliente = new System.Windows.Forms.Button();
            this.pn_CadastroCliente = new System.Windows.Forms.Panel();
            this.txt_CelularCliente = new System.Windows.Forms.MaskedTextBox();
            this.txt_TelefoneCliente = new System.Windows.Forms.MaskedTextBox();
            this.txt_EnderecoCliente = new System.Windows.Forms.TextBox();
            this.txt_NomeCliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_AvisoNome = new System.Windows.Forms.Label();
            this.lbl_AvisoTelefone = new System.Windows.Forms.Label();
            this.lbl_AvisoCelular = new System.Windows.Forms.Label();
            this.pn_MenuCadastroCliente.SuspendLayout();
            this.pn_CadastroCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_MenuCadastroCliente
            // 
            this.pn_MenuCadastroCliente.BackColor = System.Drawing.Color.White;
            this.pn_MenuCadastroCliente.Controls.Add(this.label1);
            this.pn_MenuCadastroCliente.Controls.Add(this.btn_SalvarCliente);
            this.pn_MenuCadastroCliente.Location = new System.Drawing.Point(-1, 0);
            this.pn_MenuCadastroCliente.Name = "pn_MenuCadastroCliente";
            this.pn_MenuCadastroCliente.Size = new System.Drawing.Size(672, 111);
            this.pn_MenuCadastroCliente.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(265, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Adicionar Cliente ";
            // 
            // btn_SalvarCliente
            // 
            this.btn_SalvarCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_SalvarCliente.BackgroundImage")));
            this.btn_SalvarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_SalvarCliente.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_SalvarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btn_SalvarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_SalvarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SalvarCliente.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SalvarCliente.ForeColor = System.Drawing.Color.Gray;
            this.btn_SalvarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btn_SalvarCliente.Image")));
            this.btn_SalvarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SalvarCliente.Location = new System.Drawing.Point(270, 22);
            this.btn_SalvarCliente.Name = "btn_SalvarCliente";
            this.btn_SalvarCliente.Size = new System.Drawing.Size(133, 66);
            this.btn_SalvarCliente.TabIndex = 2;
            this.btn_SalvarCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_SalvarCliente.UseVisualStyleBackColor = true;
            this.btn_SalvarCliente.Click += new System.EventHandler(this.btn_SalvarCliente_Click);
            // 
            // pn_CadastroCliente
            // 
            this.pn_CadastroCliente.BackColor = System.Drawing.Color.White;
            this.pn_CadastroCliente.Controls.Add(this.lbl_AvisoCelular);
            this.pn_CadastroCliente.Controls.Add(this.lbl_AvisoTelefone);
            this.pn_CadastroCliente.Controls.Add(this.lbl_AvisoNome);
            this.pn_CadastroCliente.Controls.Add(this.txt_CelularCliente);
            this.pn_CadastroCliente.Controls.Add(this.txt_TelefoneCliente);
            this.pn_CadastroCliente.Controls.Add(this.txt_EnderecoCliente);
            this.pn_CadastroCliente.Controls.Add(this.txt_NomeCliente);
            this.pn_CadastroCliente.Controls.Add(this.label5);
            this.pn_CadastroCliente.Controls.Add(this.label4);
            this.pn_CadastroCliente.Controls.Add(this.label3);
            this.pn_CadastroCliente.Controls.Add(this.label2);
            this.pn_CadastroCliente.Location = new System.Drawing.Point(-1, 117);
            this.pn_CadastroCliente.Name = "pn_CadastroCliente";
            this.pn_CadastroCliente.Size = new System.Drawing.Size(672, 273);
            this.pn_CadastroCliente.TabIndex = 1;
            // 
            // txt_CelularCliente
            // 
            this.txt_CelularCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CelularCliente.Location = new System.Drawing.Point(113, 194);
            this.txt_CelularCliente.Mask = "(999) 000-0000";
            this.txt_CelularCliente.Name = "txt_CelularCliente";
            this.txt_CelularCliente.Size = new System.Drawing.Size(153, 26);
            this.txt_CelularCliente.TabIndex = 7;
            // 
            // txt_TelefoneCliente
            // 
            this.txt_TelefoneCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TelefoneCliente.Location = new System.Drawing.Point(113, 142);
            this.txt_TelefoneCliente.Mask = "(999) 000-0000";
            this.txt_TelefoneCliente.Name = "txt_TelefoneCliente";
            this.txt_TelefoneCliente.Size = new System.Drawing.Size(153, 26);
            this.txt_TelefoneCliente.TabIndex = 6;
            // 
            // txt_EnderecoCliente
            // 
            this.txt_EnderecoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_EnderecoCliente.Location = new System.Drawing.Point(113, 85);
            this.txt_EnderecoCliente.Name = "txt_EnderecoCliente";
            this.txt_EnderecoCliente.Size = new System.Drawing.Size(544, 26);
            this.txt_EnderecoCliente.TabIndex = 5;
            // 
            // txt_NomeCliente
            // 
            this.txt_NomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NomeCliente.Location = new System.Drawing.Point(113, 34);
            this.txt_NomeCliente.Name = "txt_NomeCliente";
            this.txt_NomeCliente.Size = new System.Drawing.Size(359, 26);
            this.txt_NomeCliente.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(13, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Celular:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(13, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Telefone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(13, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Endereço:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(13, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome:";
            // 
            // lbl_AvisoNome
            // 
            this.lbl_AvisoNome.AutoSize = true;
            this.lbl_AvisoNome.ForeColor = System.Drawing.Color.IndianRed;
            this.lbl_AvisoNome.Location = new System.Drawing.Point(110, 63);
            this.lbl_AvisoNome.Name = "lbl_AvisoNome";
            this.lbl_AvisoNome.Size = new System.Drawing.Size(91, 13);
            this.lbl_AvisoNome.TabIndex = 26;
            this.lbl_AvisoNome.Text = " Campo inválido...";
            this.lbl_AvisoNome.Visible = false;
            // 
            // lbl_AvisoTelefone
            // 
            this.lbl_AvisoTelefone.AutoSize = true;
            this.lbl_AvisoTelefone.ForeColor = System.Drawing.Color.IndianRed;
            this.lbl_AvisoTelefone.Location = new System.Drawing.Point(110, 171);
            this.lbl_AvisoTelefone.Name = "lbl_AvisoTelefone";
            this.lbl_AvisoTelefone.Size = new System.Drawing.Size(91, 13);
            this.lbl_AvisoTelefone.TabIndex = 27;
            this.lbl_AvisoTelefone.Text = " Campo inválido...";
            this.lbl_AvisoTelefone.Visible = false;
            // 
            // lbl_AvisoCelular
            // 
            this.lbl_AvisoCelular.AutoSize = true;
            this.lbl_AvisoCelular.ForeColor = System.Drawing.Color.IndianRed;
            this.lbl_AvisoCelular.Location = new System.Drawing.Point(110, 223);
            this.lbl_AvisoCelular.Name = "lbl_AvisoCelular";
            this.lbl_AvisoCelular.Size = new System.Drawing.Size(91, 13);
            this.lbl_AvisoCelular.TabIndex = 28;
            this.lbl_AvisoCelular.Text = " Campo inválido...";
            this.lbl_AvisoCelular.Visible = false;
            // 
            // f_CadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(668, 392);
            this.Controls.Add(this.pn_CadastroCliente);
            this.Controls.Add(this.pn_MenuCadastroCliente);
            this.Name = "f_CadastroCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.f_CadastroCliente_Load);
            this.pn_MenuCadastroCliente.ResumeLayout(false);
            this.pn_MenuCadastroCliente.PerformLayout();
            this.pn_CadastroCliente.ResumeLayout(false);
            this.pn_CadastroCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_MenuCadastroCliente;
        private System.Windows.Forms.Panel pn_CadastroCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_SalvarCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txt_CelularCliente;
        private System.Windows.Forms.MaskedTextBox txt_TelefoneCliente;
        private System.Windows.Forms.TextBox txt_EnderecoCliente;
        private System.Windows.Forms.TextBox txt_NomeCliente;
        private System.Windows.Forms.Label lbl_AvisoCelular;
        private System.Windows.Forms.Label lbl_AvisoTelefone;
        private System.Windows.Forms.Label lbl_AvisoNome;
    }
}