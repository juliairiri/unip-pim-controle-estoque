namespace Desktop
{
    partial class FormPrincipal
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
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnCadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.mnUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnCadastrosProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnMedidas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnEstoque = new System.Windows.Forms.ToolStripMenuItem();
            this.mnLocaisEstoque = new System.Windows.Forms.ToolStripMenuItem();
            this.mnClientesFornecedores = new System.Windows.Forms.ToolStripMenuItem();
            this.mnClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnModulos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSair = new System.Windows.Forms.ToolStripMenuItem();
            this.mnPedidoCompra = new System.Windows.Forms.ToolStripMenuItem();
            this.mnPedidoVenda = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnCadastros,
            this.mnModulos,
            this.mnSair});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(1159, 24);
            this.menuPrincipal.TabIndex = 1;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // mnCadastros
            // 
            this.mnCadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnUsuarios,
            this.mnCadastrosProdutos,
            this.mnEstoque,
            this.mnClientesFornecedores});
            this.mnCadastros.Name = "mnCadastros";
            this.mnCadastros.Size = new System.Drawing.Size(77, 20);
            this.mnCadastros.Text = "Cadastros";
            // 
            // mnUsuarios
            // 
            this.mnUsuarios.Name = "mnUsuarios";
            this.mnUsuarios.Size = new System.Drawing.Size(212, 22);
            this.mnUsuarios.Text = "Usuários";
            this.mnUsuarios.Click += new System.EventHandler(this.mnUsuarios_Click);
            // 
            // mnCadastrosProdutos
            // 
            this.mnCadastrosProdutos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnProdutos,
            this.mnMedidas});
            this.mnCadastrosProdutos.Name = "mnCadastrosProdutos";
            this.mnCadastrosProdutos.Size = new System.Drawing.Size(212, 22);
            this.mnCadastrosProdutos.Text = "Produtos";
            // 
            // mnProdutos
            // 
            this.mnProdutos.Name = "mnProdutos";
            this.mnProdutos.Size = new System.Drawing.Size(242, 22);
            this.mnProdutos.Text = "Produtos";
            this.mnProdutos.Click += new System.EventHandler(this.mnProdutos_Click);
            // 
            // mnMedidas
            // 
            this.mnMedidas.Name = "mnMedidas";
            this.mnMedidas.Size = new System.Drawing.Size(242, 22);
            this.mnMedidas.Text = "Unidades de Pesos e Medidas";
            this.mnMedidas.Click += new System.EventHandler(this.mnMedidas_Click);
            // 
            // mnEstoque
            // 
            this.mnEstoque.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnLocaisEstoque});
            this.mnEstoque.Name = "mnEstoque";
            this.mnEstoque.Size = new System.Drawing.Size(212, 22);
            this.mnEstoque.Text = "Estoque";
            // 
            // mnLocaisEstoque
            // 
            this.mnLocaisEstoque.Name = "mnLocaisEstoque";
            this.mnLocaisEstoque.Size = new System.Drawing.Size(176, 22);
            this.mnLocaisEstoque.Text = "Locais de Estoque";
            this.mnLocaisEstoque.Click += new System.EventHandler(this.mnLocaisEstoque_Click);
            // 
            // mnClientesFornecedores
            // 
            this.mnClientesFornecedores.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnClientes,
            this.fornecedoresToolStripMenuItem});
            this.mnClientesFornecedores.Name = "mnClientesFornecedores";
            this.mnClientesFornecedores.Size = new System.Drawing.Size(212, 22);
            this.mnClientesFornecedores.Text = "Clientes e Fornecedores";
            // 
            // mnClientes
            // 
            this.mnClientes.Name = "mnClientes";
            this.mnClientes.Size = new System.Drawing.Size(151, 22);
            this.mnClientes.Text = "Clientes";
            this.mnClientes.Click += new System.EventHandler(this.mnClientes_Click);
            // 
            // fornecedoresToolStripMenuItem
            // 
            this.fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            this.fornecedoresToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.fornecedoresToolStripMenuItem.Text = "Fornecedores";
            this.fornecedoresToolStripMenuItem.Click += new System.EventHandler(this.fornecedoresToolStripMenuItem_Click);
            // 
            // mnModulos
            // 
            this.mnModulos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnPedidoCompra,
            this.mnPedidoVenda});
            this.mnModulos.Name = "mnModulos";
            this.mnModulos.Size = new System.Drawing.Size(65, 20);
            this.mnModulos.Text = "Módulos";
            // 
            // mnSair
            // 
            this.mnSair.Name = "mnSair";
            this.mnSair.Size = new System.Drawing.Size(42, 20);
            this.mnSair.Text = "Sair";
            this.mnSair.Click += new System.EventHandler(this.mnSair_Click);
            // 
            // mnPedidoCompra
            // 
            this.mnPedidoCompra.Name = "mnPedidoCompra";
            this.mnPedidoCompra.Size = new System.Drawing.Size(180, 22);
            this.mnPedidoCompra.Text = "Pedido de Compra";
            // 
            // mnPedidoVenda
            // 
            this.mnPedidoVenda.Name = "mnPedidoVenda";
            this.mnPedidoVenda.Size = new System.Drawing.Size(180, 22);
            this.mnPedidoVenda.Text = "Pedido de Venda";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 727);
            this.Controls.Add(this.menuPrincipal);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuPrincipal;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.ShowIcon = false;
            this.Text = "Controle de Estoque";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.FormPrincipal_Shown);
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnCadastros;
        private System.Windows.Forms.ToolStripMenuItem mnModulos;
        private System.Windows.Forms.ToolStripMenuItem mnSair;
        private System.Windows.Forms.ToolStripMenuItem mnUsuarios;
        private System.Windows.Forms.ToolStripMenuItem mnCadastrosProdutos;
        private System.Windows.Forms.ToolStripMenuItem mnProdutos;
        private System.Windows.Forms.ToolStripMenuItem mnMedidas;
        private System.Windows.Forms.ToolStripMenuItem mnEstoque;
        private System.Windows.Forms.ToolStripMenuItem mnLocaisEstoque;
        private System.Windows.Forms.ToolStripMenuItem mnClientesFornecedores;
        private System.Windows.Forms.ToolStripMenuItem mnClientes;
        private System.Windows.Forms.ToolStripMenuItem fornecedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnPedidoCompra;
        private System.Windows.Forms.ToolStripMenuItem mnPedidoVenda;

    }
}

