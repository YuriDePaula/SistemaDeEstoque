namespace SistemaDeEstoque
{
    partial class frmCadastrarProduto
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigoBarras = new System.Windows.Forms.TextBox();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mkbDataValidade = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtQuantidadeEstoque = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdentificacaoPrateleiraEstoque = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdentificacaoCorredorEstoque = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ResourcesInformations = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtQuantidadeMercado = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIdentificacaoPrateleiraMercado = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIdentificacaoMercado = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.cbxListaMarcas = new System.Windows.Forms.ComboBox();
            this.txtResponsavelSetor = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label1.Location = new System.Drawing.Point(15, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código de Barras :";
            // 
            // txtCodigoBarras
            // 
            this.txtCodigoBarras.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtCodigoBarras.Location = new System.Drawing.Point(170, 17);
            this.txtCodigoBarras.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoBarras.Name = "txtCodigoBarras";
            this.txtCodigoBarras.Size = new System.Drawing.Size(224, 26);
            this.txtCodigoBarras.TabIndex = 1;
            this.txtCodigoBarras.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCodigoBarras.TextChanged += new System.EventHandler(this.txtCodigoBarras_TextChanged);
            this.txtCodigoBarras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoBarras_KeyPress);
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtNomeProduto.Location = new System.Drawing.Point(572, 17);
            this.txtNomeProduto.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(224, 26);
            this.txtNomeProduto.TabIndex = 3;
            this.txtNomeProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label2.Location = new System.Drawing.Point(417, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome do Produto :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label3.Location = new System.Drawing.Point(15, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data de Validade :";
            // 
            // mkbDataValidade
            // 
            this.mkbDataValidade.Location = new System.Drawing.Point(170, 50);
            this.mkbDataValidade.Mask = "00/00/0000";
            this.mkbDataValidade.Name = "mkbDataValidade";
            this.mkbDataValidade.Size = new System.Drawing.Size(224, 26);
            this.mkbDataValidade.TabIndex = 6;
            this.mkbDataValidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mkbDataValidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mkbDataValidade_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtQuantidadeEstoque);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtIdentificacaoPrateleiraEstoque);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtIdentificacaoCorredorEstoque);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(19, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 130);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações  dos Produtos em Estoque";
            this.ResourcesInformations.SetToolTip(this.groupBox1, "Localização dos produtos em estoque.");
            // 
            // txtQuantidadeEstoque
            // 
            this.txtQuantidadeEstoque.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtQuantidadeEstoque.Location = new System.Drawing.Point(175, 94);
            this.txtQuantidadeEstoque.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantidadeEstoque.Name = "txtQuantidadeEstoque";
            this.txtQuantidadeEstoque.Size = new System.Drawing.Size(188, 26);
            this.txtQuantidadeEstoque.TabIndex = 9;
            this.txtQuantidadeEstoque.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQuantidadeEstoque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidadeEstoque_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label6.Location = new System.Drawing.Point(20, 97);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "Quantidade :";
            // 
            // txtIdentificacaoPrateleiraEstoque
            // 
            this.txtIdentificacaoPrateleiraEstoque.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtIdentificacaoPrateleiraEstoque.Location = new System.Drawing.Point(175, 60);
            this.txtIdentificacaoPrateleiraEstoque.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdentificacaoPrateleiraEstoque.Name = "txtIdentificacaoPrateleiraEstoque";
            this.txtIdentificacaoPrateleiraEstoque.Size = new System.Drawing.Size(188, 26);
            this.txtIdentificacaoPrateleiraEstoque.TabIndex = 7;
            this.txtIdentificacaoPrateleiraEstoque.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIdentificacaoPrateleiraEstoque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdentificacaoPrateleiraEstoque_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label5.Location = new System.Drawing.Point(20, 63);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Prateleira :";
            // 
            // txtIdentificacaoCorredorEstoque
            // 
            this.txtIdentificacaoCorredorEstoque.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtIdentificacaoCorredorEstoque.Location = new System.Drawing.Point(175, 26);
            this.txtIdentificacaoCorredorEstoque.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdentificacaoCorredorEstoque.Name = "txtIdentificacaoCorredorEstoque";
            this.txtIdentificacaoCorredorEstoque.Size = new System.Drawing.Size(188, 26);
            this.txtIdentificacaoCorredorEstoque.TabIndex = 5;
            this.txtIdentificacaoCorredorEstoque.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIdentificacaoCorredorEstoque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdentificacaoCorredorEstoque_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label4.Location = new System.Drawing.Point(20, 29);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Corredor :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtQuantidadeMercado);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtIdentificacaoPrateleiraMercado);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtIdentificacaoMercado);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(421, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(375, 130);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informações  dos Produtos no Mercado";
            this.ResourcesInformations.SetToolTip(this.groupBox2, "Localização dos produtos em estoque.");
            // 
            // txtQuantidadeMercado
            // 
            this.txtQuantidadeMercado.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtQuantidadeMercado.Location = new System.Drawing.Point(175, 94);
            this.txtQuantidadeMercado.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantidadeMercado.Name = "txtQuantidadeMercado";
            this.txtQuantidadeMercado.Size = new System.Drawing.Size(188, 26);
            this.txtQuantidadeMercado.TabIndex = 9;
            this.txtQuantidadeMercado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQuantidadeMercado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidadeMercado_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label7.Location = new System.Drawing.Point(20, 97);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "Quantidade :";
            // 
            // txtIdentificacaoPrateleiraMercado
            // 
            this.txtIdentificacaoPrateleiraMercado.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtIdentificacaoPrateleiraMercado.Location = new System.Drawing.Point(175, 60);
            this.txtIdentificacaoPrateleiraMercado.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdentificacaoPrateleiraMercado.Name = "txtIdentificacaoPrateleiraMercado";
            this.txtIdentificacaoPrateleiraMercado.Size = new System.Drawing.Size(188, 26);
            this.txtIdentificacaoPrateleiraMercado.TabIndex = 7;
            this.txtIdentificacaoPrateleiraMercado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIdentificacaoPrateleiraMercado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdentificacaoPrateleiraMercado_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label8.Location = new System.Drawing.Point(20, 63);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 19);
            this.label8.TabIndex = 6;
            this.label8.Text = "Prateleira :";
            // 
            // txtIdentificacaoMercado
            // 
            this.txtIdentificacaoMercado.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtIdentificacaoMercado.Location = new System.Drawing.Point(175, 26);
            this.txtIdentificacaoMercado.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdentificacaoMercado.Name = "txtIdentificacaoMercado";
            this.txtIdentificacaoMercado.Size = new System.Drawing.Size(188, 26);
            this.txtIdentificacaoMercado.TabIndex = 5;
            this.txtIdentificacaoMercado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIdentificacaoMercado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdentificacaoMercado_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label9.Location = new System.Drawing.Point(20, 29);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 19);
            this.label9.TabIndex = 4;
            this.label9.Text = "Corredor :";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(19, 286);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(93, 36);
            this.btnAdicionar.TabIndex = 13;
            this.btnAdicionar.Text = "Adicionar";
            this.ResourcesInformations.SetToolTip(this.btnAdicionar, "Adiciona novos produtos.");
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(538, 286);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(93, 36);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Limpar";
            this.ResourcesInformations.SetToolTip(this.btnClear, "Permite limpar os campos.");
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(703, 286);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 36);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancelar";
            this.ResourcesInformations.SetToolTip(this.btnCancel, "Cancela uma inclusão de dados.");
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(194, 286);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(93, 36);
            this.btnChange.TabIndex = 16;
            this.btnChange.Text = "Alterar";
            this.ResourcesInformations.SetToolTip(this.btnChange, "Adiciona novos produtos.");
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(366, 286);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(93, 36);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Deletar";
            this.ResourcesInformations.SetToolTip(this.btnDelete, "Adiciona novos produtos.");
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label10.Location = new System.Drawing.Point(417, 56);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 19);
            this.label10.TabIndex = 11;
            this.label10.Text = "Marca do Produto :";
            // 
            // cbxListaMarcas
            // 
            this.cbxListaMarcas.FormattingEnabled = true;
            this.cbxListaMarcas.Location = new System.Drawing.Point(572, 50);
            this.cbxListaMarcas.Name = "cbxListaMarcas";
            this.cbxListaMarcas.Size = new System.Drawing.Size(224, 27);
            this.cbxListaMarcas.TabIndex = 12;
            // 
            // txtResponsavelSetor
            // 
            this.txtResponsavelSetor.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtResponsavelSetor.Location = new System.Drawing.Point(345, 93);
            this.txtResponsavelSetor.Margin = new System.Windows.Forms.Padding(4);
            this.txtResponsavelSetor.Name = "txtResponsavelSetor";
            this.txtResponsavelSetor.Size = new System.Drawing.Size(268, 26);
            this.txtResponsavelSetor.TabIndex = 19;
            this.txtResponsavelSetor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label11.Location = new System.Drawing.Point(166, 96);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(159, 19);
            this.label11.TabIndex = 18;
            this.label11.Text = "Responsável pelo Setor :";
            // 
            // frmCadastrarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 340);
            this.Controls.Add(this.txtResponsavelSetor);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.cbxListaMarcas);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mkbDataValidade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNomeProduto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodigoBarras);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadastrarProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro / Alteração / Exclusão de Produtos em Estoque";
            this.Load += new System.EventHandler(this.CadastrarProduto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigoBarras;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mkbDataValidade;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtQuantidadeEstoque;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdentificacaoPrateleiraEstoque;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIdentificacaoCorredorEstoque;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolTip ResourcesInformations;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtQuantidadeMercado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIdentificacaoPrateleiraMercado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIdentificacaoMercado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbxListaMarcas;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtResponsavelSetor;
        private System.Windows.Forms.Label label11;
    }
}