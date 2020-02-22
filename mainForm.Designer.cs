namespace SistemaDeEstoque
{
    partial class mainForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblHour = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gdfdfghgghjvjToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supermercadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeDate = new System.Windows.Forms.Timer(this.components);
            this.caixaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoquistasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VendastoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ClientestoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ControlPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ControlPanel
            // 
            this.ControlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlPanel.BackColor = System.Drawing.Color.LightGray;
            this.ControlPanel.Controls.Add(this.lblDate);
            this.ControlPanel.Controls.Add(this.lblHour);
            this.ControlPanel.Location = new System.Drawing.Point(0, 24);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(800, 426);
            this.ControlPanel.TabIndex = 0;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.LightGray;
            this.lblDate.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(468, 405);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(69, 20);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "label1";
            this.lblDate.Visible = false;
            // 
            // lblHour
            // 
            this.lblHour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHour.AutoSize = true;
            this.lblHour.BackColor = System.Drawing.Color.LightGray;
            this.lblHour.Font = new System.Drawing.Font("Fira Code", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHour.Location = new System.Drawing.Point(548, 373);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(117, 33);
            this.lblHour.TabIndex = 0;
            this.lblHour.Text = "label1";
            this.lblHour.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.Font = new System.Drawing.Font("Fira Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gdfdfghgghjvjToolStripMenuItem,
            this.ClientestoolStripMenuItem1,
            this.VendastoolStripMenuItem1,
            this.fornecedoresToolStripMenuItem,
            this.supermercadoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gdfdfghgghjvjToolStripMenuItem
            // 
            this.gdfdfghgghjvjToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarToolStripMenuItem,
            this.cadastrarToolStripMenuItem});
            this.gdfdfghgghjvjToolStripMenuItem.Name = "gdfdfghgghjvjToolStripMenuItem";
            this.gdfdfghgghjvjToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.gdfdfghgghjvjToolStripMenuItem.Text = "Produtos";
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultarToolStripMenuItem.Text = "Consultar";
            this.consultarToolStripMenuItem.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // fornecedoresToolStripMenuItem
            // 
            this.fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            this.fornecedoresToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.fornecedoresToolStripMenuItem.Text = "Fornecedores";
            // 
            // supermercadoToolStripMenuItem
            // 
            this.supermercadoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.caixaToolStripMenuItem,
            this.consultarProdutosToolStripMenuItem,
            this.estoquistasToolStripMenuItem});
            this.supermercadoToolStripMenuItem.Name = "supermercadoToolStripMenuItem";
            this.supermercadoToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.supermercadoToolStripMenuItem.Text = "Supermercado";
            // 
            // timeDate
            // 
            this.timeDate.Tick += new System.EventHandler(this.timeDate_Tick);
            // 
            // caixaToolStripMenuItem
            // 
            this.caixaToolStripMenuItem.Name = "caixaToolStripMenuItem";
            this.caixaToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.caixaToolStripMenuItem.Text = "Caixa";
            // 
            // consultarProdutosToolStripMenuItem
            // 
            this.consultarProdutosToolStripMenuItem.Name = "consultarProdutosToolStripMenuItem";
            this.consultarProdutosToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.consultarProdutosToolStripMenuItem.Text = "Consultar Produtos";
            // 
            // estoquistasToolStripMenuItem
            // 
            this.estoquistasToolStripMenuItem.Name = "estoquistasToolStripMenuItem";
            this.estoquistasToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.estoquistasToolStripMenuItem.Text = "Estoquistas";
            // 
            // VendastoolStripMenuItem1
            // 
            this.VendastoolStripMenuItem1.Name = "VendastoolStripMenuItem1";
            this.VendastoolStripMenuItem1.Size = new System.Drawing.Size(68, 20);
            this.VendastoolStripMenuItem1.Text = "Vendas";
            // 
            // ClientestoolStripMenuItem1
            // 
            this.ClientestoolStripMenuItem1.Name = "ClientestoolStripMenuItem1";
            this.ClientestoolStripMenuItem1.Size = new System.Drawing.Size(84, 20);
            this.ClientestoolStripMenuItem1.Text = "Clientes";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ControlPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle Automação De Estoque";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ControlPanel.ResumeLayout(false);
            this.ControlPanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gdfdfghgghjvjToolStripMenuItem;
        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.Timer timeDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supermercadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caixaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estoquistasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClientestoolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem VendastoolStripMenuItem1;
    }
}

