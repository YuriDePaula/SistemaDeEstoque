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
            this.ClientestoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagarContaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VendastoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.supermercadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caixaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoquistasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.financeiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeDate = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ControlPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ControlPanel
            // 
            this.ControlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlPanel.BackColor = System.Drawing.Color.LightGray;
            this.ControlPanel.Controls.Add(this.statusStrip1);
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
            this.lblDate.Location = new System.Drawing.Point(484, 250);
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
            this.lblHour.Location = new System.Drawing.Point(531, 116);
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
            this.supermercadoToolStripMenuItem,
            this.financeiroToolStripMenuItem,
            this.agendaToolStripMenuItem});
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
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.consultarToolStripMenuItem.Text = "Consultar";
            this.consultarToolStripMenuItem.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            this.cadastrarToolStripMenuItem.Click += new System.EventHandler(this.cadastrarToolStripMenuItem_Click);
            // 
            // ClientestoolStripMenuItem1
            // 
            this.ClientestoolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem2,
            this.relatórioToolStripMenuItem,
            this.pagarContaToolStripMenuItem});
            this.ClientestoolStripMenuItem1.Name = "ClientestoolStripMenuItem1";
            this.ClientestoolStripMenuItem1.Size = new System.Drawing.Size(84, 20);
            this.ClientestoolStripMenuItem1.Text = "Clientes";
            // 
            // cadastrarToolStripMenuItem2
            // 
            this.cadastrarToolStripMenuItem2.Name = "cadastrarToolStripMenuItem2";
            this.cadastrarToolStripMenuItem2.Size = new System.Drawing.Size(164, 22);
            this.cadastrarToolStripMenuItem2.Text = "Cadastrar";
            // 
            // relatórioToolStripMenuItem
            // 
            this.relatórioToolStripMenuItem.Name = "relatórioToolStripMenuItem";
            this.relatórioToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.relatórioToolStripMenuItem.Text = "Relatório";
            // 
            // pagarContaToolStripMenuItem
            // 
            this.pagarContaToolStripMenuItem.Name = "pagarContaToolStripMenuItem";
            this.pagarContaToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.pagarContaToolStripMenuItem.Text = "Pagar Conta";
            // 
            // VendastoolStripMenuItem1
            // 
            this.VendastoolStripMenuItem1.Name = "VendastoolStripMenuItem1";
            this.VendastoolStripMenuItem1.Size = new System.Drawing.Size(68, 20);
            this.VendastoolStripMenuItem1.Text = "Vendas";
            // 
            // fornecedoresToolStripMenuItem
            // 
            this.fornecedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarToolStripMenuItem1,
            this.cadastrarToolStripMenuItem1});
            this.fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            this.fornecedoresToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.fornecedoresToolStripMenuItem.Text = "Fornecedores";
            // 
            // consultarToolStripMenuItem1
            // 
            this.consultarToolStripMenuItem1.Name = "consultarToolStripMenuItem1";
            this.consultarToolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.consultarToolStripMenuItem1.Text = "Consultar";
            // 
            // cadastrarToolStripMenuItem1
            // 
            this.cadastrarToolStripMenuItem1.Name = "cadastrarToolStripMenuItem1";
            this.cadastrarToolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.cadastrarToolStripMenuItem1.Text = "Cadastrar";
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
            // financeiroToolStripMenuItem
            // 
            this.financeiroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pedidosToolStripMenuItem});
            this.financeiroToolStripMenuItem.Name = "financeiroToolStripMenuItem";
            this.financeiroToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.financeiroToolStripMenuItem.Text = "Financeiro";
            // 
            // pedidosToolStripMenuItem
            // 
            this.pedidosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarToolStripMenuItem2,
            this.alterarDadosToolStripMenuItem});
            this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            this.pedidosToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.pedidosToolStripMenuItem.Text = "Pedidos";
            // 
            // consultarToolStripMenuItem2
            // 
            this.consultarToolStripMenuItem2.Name = "consultarToolStripMenuItem2";
            this.consultarToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.consultarToolStripMenuItem2.Text = "Consultar";
            // 
            // alterarDadosToolStripMenuItem
            // 
            this.alterarDadosToolStripMenuItem.Name = "alterarDadosToolStripMenuItem";
            this.alterarDadosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.alterarDadosToolStripMenuItem.Text = "Alterar dados";
            // 
            // agendaToolStripMenuItem
            // 
            this.agendaToolStripMenuItem.Name = "agendaToolStripMenuItem";
            this.agendaToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.agendaToolStripMenuItem.Text = "Agenda";
            // 
            // timeDate
            // 
            this.timeDate.Tick += new System.EventHandler(this.timeDate_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 404);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
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
            this.Text = "Controle de Automação De Estoque";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ControlPanel.ResumeLayout(false);
            this.ControlPanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem relatórioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagarContaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem financeiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem alterarDadosToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
    }
}

