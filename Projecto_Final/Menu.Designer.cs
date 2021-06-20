
namespace ProjectoFinal
{
    partial class Menu
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
            this.button_GerirCliente = new System.Windows.Forms.Button();
            this.buttonManageProducts = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerirClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarClienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarClienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.removerClienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.GerirProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removerProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConsultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_GerirCliente
            // 
            this.button_GerirCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_GerirCliente.Location = new System.Drawing.Point(52, 45);
            this.button_GerirCliente.Name = "button_GerirCliente";
            this.button_GerirCliente.Size = new System.Drawing.Size(219, 45);
            this.button_GerirCliente.TabIndex = 0;
            this.button_GerirCliente.Text = "Gerir Clientes";
            this.button_GerirCliente.UseVisualStyleBackColor = true;
            this.button_GerirCliente.Click += new System.EventHandler(this.button_GerirCliente_Click);
            // 
            // buttonManageProducts
            // 
            this.buttonManageProducts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonManageProducts.Location = new System.Drawing.Point(52, 112);
            this.buttonManageProducts.Name = "buttonManageProducts";
            this.buttonManageProducts.Size = new System.Drawing.Size(219, 45);
            this.buttonManageProducts.TabIndex = 1;
            this.buttonManageProducts.Text = "Gerir Produtos";
            this.buttonManageProducts.UseVisualStyleBackColor = true;
            this.buttonManageProducts.Click += new System.EventHandler(this.buttonManageProducts_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.Location = new System.Drawing.Point(52, 182);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(219, 45);
            this.button3.TabIndex = 2;
            this.button3.Text = "Mostrar Biblotecas";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.Location = new System.Drawing.Point(52, 251);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(219, 45);
            this.button4.TabIndex = 3;
            this.button4.Text = "Sair";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Sair_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(319, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerirClienteToolStripMenuItem,
            this.GerirProdutosToolStripMenuItem,
            this.ConsultarToolStripMenuItem,
            this.SairToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // gerirClienteToolStripMenuItem
            // 
            this.gerirClienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criarClienteToolStripMenuItem1,
            this.modificarClienteToolStripMenuItem1,
            this.removerClienteToolStripMenuItem1});
            this.gerirClienteToolStripMenuItem.Name = "gerirClienteToolStripMenuItem";
            this.gerirClienteToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.gerirClienteToolStripMenuItem.Text = "Gerir Cliente";
            this.gerirClienteToolStripMenuItem.Click += new System.EventHandler(this.gerirClienteToolStripMenuItem_Click);
            // 
            // criarClienteToolStripMenuItem1
            // 
            this.criarClienteToolStripMenuItem1.Name = "criarClienteToolStripMenuItem1";
            this.criarClienteToolStripMenuItem1.Size = new System.Drawing.Size(165, 22);
            this.criarClienteToolStripMenuItem1.Text = "Criar Cliente";
            this.criarClienteToolStripMenuItem1.Click += new System.EventHandler(this.criarClienteToolStripMenuItem1_Click);
            // 
            // modificarClienteToolStripMenuItem1
            // 
            this.modificarClienteToolStripMenuItem1.Name = "modificarClienteToolStripMenuItem1";
            this.modificarClienteToolStripMenuItem1.Size = new System.Drawing.Size(165, 22);
            this.modificarClienteToolStripMenuItem1.Text = "Modificar Cliente";
            this.modificarClienteToolStripMenuItem1.Click += new System.EventHandler(this.modificarClienteToolStripMenuItem1_Click);
            // 
            // removerClienteToolStripMenuItem1
            // 
            this.removerClienteToolStripMenuItem1.Name = "removerClienteToolStripMenuItem1";
            this.removerClienteToolStripMenuItem1.Size = new System.Drawing.Size(165, 22);
            this.removerClienteToolStripMenuItem1.Text = "Remover Cliente";
            this.removerClienteToolStripMenuItem1.Click += new System.EventHandler(this.removerClienteToolStripMenuItem1_Click);
            // 
            // GerirProdutosToolStripMenuItem
            // 
            this.GerirProdutosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criarProdutoToolStripMenuItem,
            this.modificarProdutoToolStripMenuItem,
            this.removerProdutoToolStripMenuItem});
            this.GerirProdutosToolStripMenuItem.Name = "GerirProdutosToolStripMenuItem";
            this.GerirProdutosToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.GerirProdutosToolStripMenuItem.Text = "Gerir Produtos";
            this.GerirProdutosToolStripMenuItem.Click += new System.EventHandler(this.gerirProdutoToolStripMenuItem_Click);
            // 
            // criarProdutoToolStripMenuItem
            // 
            this.criarProdutoToolStripMenuItem.Name = "criarProdutoToolStripMenuItem";
            this.criarProdutoToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.criarProdutoToolStripMenuItem.Text = "Criar Produto";
            this.criarProdutoToolStripMenuItem.Click += new System.EventHandler(this.criarProdutoToolStripMenuItem_Click);
            // 
            // modificarProdutoToolStripMenuItem
            // 
            this.modificarProdutoToolStripMenuItem.Name = "modificarProdutoToolStripMenuItem";
            this.modificarProdutoToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.modificarProdutoToolStripMenuItem.Text = "Modificar Produto";
            this.modificarProdutoToolStripMenuItem.Click += new System.EventHandler(this.modificarProdutoToolStripMenuItem_Click);
            // 
            // removerProdutoToolStripMenuItem
            // 
            this.removerProdutoToolStripMenuItem.Name = "removerProdutoToolStripMenuItem";
            this.removerProdutoToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.removerProdutoToolStripMenuItem.Text = "Remover Produto";
            this.removerProdutoToolStripMenuItem.Click += new System.EventHandler(this.removerProdutoToolStripMenuItem_Click);
            // 
            // ConsultarToolStripMenuItem
            // 
            this.ConsultarToolStripMenuItem.Name = "ConsultarToolStripMenuItem";
            this.ConsultarToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.ConsultarToolStripMenuItem.Text = "Consultar Biblotecas";
            this.ConsultarToolStripMenuItem.Click += new System.EventHandler(this.ShowToolStripMenuItem_Click);
            // 
            // SairToolStripMenuItem
            // 
            this.SairToolStripMenuItem.Name = "SairToolStripMenuItem";
            this.SairToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.SairToolStripMenuItem.Text = "Sair";
            this.SairToolStripMenuItem.Click += new System.EventHandler(this.SairToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 330);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(319, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 352);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonManageProducts);
            this.Controls.Add(this.button_GerirCliente);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_GerirCliente;
        private System.Windows.Forms.Button buttonManageProducts;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerirClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GerirProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ConsultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criarClienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modificarClienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem removerClienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem criarProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removerProdutoToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer timer1;
    }
}