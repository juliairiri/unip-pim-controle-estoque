namespace Desktop.Formularios
{
    partial class FormProdutos
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
            this.lblCodigo = new Desktop.Label();
            this.txtCodigo = new Desktop.TextBox();
            this.lblDescricao = new Desktop.Label();
            this.txtDescricao = new Desktop.TextBox();
            this.chkInativo = new Desktop.CheckBox();
            this.grpUnidades = new Desktop.GroupBox();
            this.cbUnidadeVenda = new Desktop.ComboBox();
            this.lblUnidadeVenda = new Desktop.Label();
            this.cbUnidadeCompra = new Desktop.ComboBox();
            this.lblUnidadeCompra = new Desktop.Label();
            this.cbUnidadeEstoque = new Desktop.ComboBox();
            this.lblUnidadeEstoque = new Desktop.Label();
            this.grpAlteracoes = new Desktop.GroupBox();
            this.lblDataAlteracao = new Desktop.Label();
            this.txtDataAlteracao = new Desktop.TextBox();
            this.txtUsuarioAlteracao = new Desktop.TextBox();
            this.lblUsuarioAlteracao = new Desktop.Label();
            this.lblDataInclusao = new Desktop.Label();
            this.txtDataInclusao = new Desktop.TextBox();
            this.txtUsuarioInclusao = new Desktop.TextBox();
            this.lblUsuarioInclusao = new Desktop.Label();
            this.btnConsultar = new Desktop.Button();
            this.btnSalvar = new Desktop.Button();
            this.btnInserir = new Desktop.Button();
            this.btnConversoes = new Desktop.Button();
            this.grpUnidades.SuspendLayout();
            this.grpAlteracoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.EstadosExibicaoPossiveis = new EstadoExibicao[0];
            this.lblCodigo.Font = new System.Drawing.Font("Verdana", 9F);
            this.lblCodigo.Location = new System.Drawing.Point(12, 9);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(51, 14);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.EstadosExibicaoPossiveis = new EstadoExibicao[] {
        EstadoExibicao.Incluindo};
            this.txtCodigo.Font = new System.Drawing.Font("Verdana", 9F);
            this.txtCodigo.Location = new System.Drawing.Point(15, 26);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(332, 22);
            this.txtCodigo.TabIndex = 4;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.EstadosExibicaoPossiveis = new EstadoExibicao[0];
            this.lblDescricao.Font = new System.Drawing.Font("Verdana", 9F);
            this.lblDescricao.Location = new System.Drawing.Point(12, 51);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(67, 14);
            this.lblDescricao.TabIndex = 5;
            this.lblDescricao.Text = "Descrição";
            // 
            // txtDescricao
            // 
            this.txtDescricao.EstadosExibicaoPossiveis = new EstadoExibicao[] {
        EstadoExibicao.Visualizando,
        EstadoExibicao.Incluindo,
        EstadoExibicao.Alterando};
            this.txtDescricao.Font = new System.Drawing.Font("Verdana", 9F);
            this.txtDescricao.Location = new System.Drawing.Point(15, 68);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(426, 22);
            this.txtDescricao.TabIndex = 6;
            // 
            // chkInativo
            // 
            this.chkInativo.AutoSize = true;
            this.chkInativo.EstadosExibicaoPossiveis = new EstadoExibicao[] {
        EstadoExibicao.Visualizando,
        EstadoExibicao.Incluindo,
        EstadoExibicao.Alterando};
            this.chkInativo.Font = new System.Drawing.Font("Verdana", 9F);
            this.chkInativo.Location = new System.Drawing.Point(353, 30);
            this.chkInativo.Name = "chkInativo";
            this.chkInativo.Size = new System.Drawing.Size(70, 18);
            this.chkInativo.TabIndex = 7;
            this.chkInativo.Text = "Inativo";
            this.chkInativo.UseVisualStyleBackColor = true;
            // 
            // grpUnidades
            // 
            this.grpUnidades.Controls.Add(this.cbUnidadeVenda);
            this.grpUnidades.Controls.Add(this.lblUnidadeVenda);
            this.grpUnidades.Controls.Add(this.cbUnidadeCompra);
            this.grpUnidades.Controls.Add(this.lblUnidadeCompra);
            this.grpUnidades.Controls.Add(this.cbUnidadeEstoque);
            this.grpUnidades.Controls.Add(this.lblUnidadeEstoque);
            this.grpUnidades.Font = new System.Drawing.Font("Verdana", 9F);
            this.grpUnidades.Location = new System.Drawing.Point(15, 96);
            this.grpUnidades.Name = "grpUnidades";
            this.grpUnidades.Size = new System.Drawing.Size(426, 164);
            this.grpUnidades.TabIndex = 8;
            this.grpUnidades.TabStop = false;
            this.grpUnidades.Text = "Unidades";
            // 
            // cbUnidadeVenda
            // 
            this.cbUnidadeVenda.EstadosExibicaoPossiveis = new EstadoExibicao[] {
        EstadoExibicao.Visualizando,
        EstadoExibicao.Incluindo,
        EstadoExibicao.Alterando};
            this.cbUnidadeVenda.Font = new System.Drawing.Font("Verdana", 9F);
            this.cbUnidadeVenda.FormattingEnabled = true;
            this.cbUnidadeVenda.Location = new System.Drawing.Point(9, 127);
            this.cbUnidadeVenda.Name = "cbUnidadeVenda";
            this.cbUnidadeVenda.Size = new System.Drawing.Size(411, 22);
            this.cbUnidadeVenda.TabIndex = 5;
            // 
            // lblUnidadeVenda
            // 
            this.lblUnidadeVenda.AutoSize = true;
            this.lblUnidadeVenda.EstadosExibicaoPossiveis = new EstadoExibicao[0];
            this.lblUnidadeVenda.Font = new System.Drawing.Font("Verdana", 9F);
            this.lblUnidadeVenda.Location = new System.Drawing.Point(6, 110);
            this.lblUnidadeVenda.Name = "lblUnidadeVenda";
            this.lblUnidadeVenda.Size = new System.Drawing.Size(123, 14);
            this.lblUnidadeVenda.TabIndex = 4;
            this.lblUnidadeVenda.Text = "Unidade de Venda";
            // 
            // cbUnidadeCompra
            // 
            this.cbUnidadeCompra.EstadosExibicaoPossiveis = new EstadoExibicao[] {
        EstadoExibicao.Visualizando,
        EstadoExibicao.Incluindo,
        EstadoExibicao.Alterando};
            this.cbUnidadeCompra.Font = new System.Drawing.Font("Verdana", 9F);
            this.cbUnidadeCompra.FormattingEnabled = true;
            this.cbUnidadeCompra.Location = new System.Drawing.Point(9, 85);
            this.cbUnidadeCompra.Name = "cbUnidadeCompra";
            this.cbUnidadeCompra.Size = new System.Drawing.Size(411, 22);
            this.cbUnidadeCompra.TabIndex = 3;
            // 
            // lblUnidadeCompra
            // 
            this.lblUnidadeCompra.AutoSize = true;
            this.lblUnidadeCompra.EstadosExibicaoPossiveis = new EstadoExibicao[0];
            this.lblUnidadeCompra.Font = new System.Drawing.Font("Verdana", 9F);
            this.lblUnidadeCompra.Location = new System.Drawing.Point(6, 68);
            this.lblUnidadeCompra.Name = "lblUnidadeCompra";
            this.lblUnidadeCompra.Size = new System.Drawing.Size(132, 14);
            this.lblUnidadeCompra.TabIndex = 2;
            this.lblUnidadeCompra.Text = "Unidade de Compra";
            // 
            // cbUnidadeEstoque
            // 
            this.cbUnidadeEstoque.EstadosExibicaoPossiveis = new EstadoExibicao[] {
        EstadoExibicao.Visualizando,
        EstadoExibicao.Incluindo,
        EstadoExibicao.Alterando};
            this.cbUnidadeEstoque.Font = new System.Drawing.Font("Verdana", 9F);
            this.cbUnidadeEstoque.FormattingEnabled = true;
            this.cbUnidadeEstoque.Location = new System.Drawing.Point(9, 43);
            this.cbUnidadeEstoque.Name = "cbUnidadeEstoque";
            this.cbUnidadeEstoque.Size = new System.Drawing.Size(411, 22);
            this.cbUnidadeEstoque.TabIndex = 1;
            // 
            // lblUnidadeEstoque
            // 
            this.lblUnidadeEstoque.AutoSize = true;
            this.lblUnidadeEstoque.EstadosExibicaoPossiveis = new EstadoExibicao[0];
            this.lblUnidadeEstoque.Font = new System.Drawing.Font("Verdana", 9F);
            this.lblUnidadeEstoque.Location = new System.Drawing.Point(6, 26);
            this.lblUnidadeEstoque.Name = "lblUnidadeEstoque";
            this.lblUnidadeEstoque.Size = new System.Drawing.Size(135, 14);
            this.lblUnidadeEstoque.TabIndex = 0;
            this.lblUnidadeEstoque.Text = "Unidade de Estoque";
            // 
            // grpAlteracoes
            // 
            this.grpAlteracoes.Controls.Add(this.lblDataAlteracao);
            this.grpAlteracoes.Controls.Add(this.txtDataAlteracao);
            this.grpAlteracoes.Controls.Add(this.txtUsuarioAlteracao);
            this.grpAlteracoes.Controls.Add(this.lblUsuarioAlteracao);
            this.grpAlteracoes.Controls.Add(this.lblDataInclusao);
            this.grpAlteracoes.Controls.Add(this.txtDataInclusao);
            this.grpAlteracoes.Controls.Add(this.txtUsuarioInclusao);
            this.grpAlteracoes.Controls.Add(this.lblUsuarioInclusao);
            this.grpAlteracoes.Font = new System.Drawing.Font("Verdana", 9F);
            this.grpAlteracoes.Location = new System.Drawing.Point(15, 266);
            this.grpAlteracoes.Name = "grpAlteracoes";
            this.grpAlteracoes.Size = new System.Drawing.Size(426, 124);
            this.grpAlteracoes.TabIndex = 9;
            this.grpAlteracoes.TabStop = false;
            this.grpAlteracoes.Text = "Alterações";
            // 
            // lblDataAlteracao
            // 
            this.lblDataAlteracao.AutoSize = true;
            this.lblDataAlteracao.EstadosExibicaoPossiveis = new EstadoExibicao[0];
            this.lblDataAlteracao.Font = new System.Drawing.Font("Verdana", 9F);
            this.lblDataAlteracao.Location = new System.Drawing.Point(235, 68);
            this.lblDataAlteracao.Name = "lblDataAlteracao";
            this.lblDataAlteracao.Size = new System.Drawing.Size(120, 14);
            this.lblDataAlteracao.TabIndex = 16;
            this.lblDataAlteracao.Text = "Data de Alteração";
            // 
            // txtDataAlteracao
            // 
            this.txtDataAlteracao.Enabled = false;
            this.txtDataAlteracao.EstadosExibicaoPossiveis = null;
            this.txtDataAlteracao.Font = new System.Drawing.Font("Verdana", 9F);
            this.txtDataAlteracao.Location = new System.Drawing.Point(235, 86);
            this.txtDataAlteracao.Name = "txtDataAlteracao";
            this.txtDataAlteracao.Size = new System.Drawing.Size(185, 22);
            this.txtDataAlteracao.TabIndex = 15;
            // 
            // txtUsuarioAlteracao
            // 
            this.txtUsuarioAlteracao.Enabled = false;
            this.txtUsuarioAlteracao.EstadosExibicaoPossiveis = null;
            this.txtUsuarioAlteracao.Font = new System.Drawing.Font("Verdana", 9F);
            this.txtUsuarioAlteracao.Location = new System.Drawing.Point(9, 86);
            this.txtUsuarioAlteracao.Name = "txtUsuarioAlteracao";
            this.txtUsuarioAlteracao.Size = new System.Drawing.Size(185, 22);
            this.txtUsuarioAlteracao.TabIndex = 14;
            // 
            // lblUsuarioAlteracao
            // 
            this.lblUsuarioAlteracao.AutoSize = true;
            this.lblUsuarioAlteracao.EstadosExibicaoPossiveis = new EstadoExibicao[0];
            this.lblUsuarioAlteracao.Font = new System.Drawing.Font("Verdana", 9F);
            this.lblUsuarioAlteracao.Location = new System.Drawing.Point(6, 69);
            this.lblUsuarioAlteracao.Name = "lblUsuarioAlteracao";
            this.lblUsuarioAlteracao.Size = new System.Drawing.Size(138, 14);
            this.lblUsuarioAlteracao.TabIndex = 13;
            this.lblUsuarioAlteracao.Text = "Usuário de Alteração";
            // 
            // lblDataInclusao
            // 
            this.lblDataInclusao.AutoSize = true;
            this.lblDataInclusao.EstadosExibicaoPossiveis = new EstadoExibicao[0];
            this.lblDataInclusao.Font = new System.Drawing.Font("Verdana", 9F);
            this.lblDataInclusao.Location = new System.Drawing.Point(235, 26);
            this.lblDataInclusao.Name = "lblDataInclusao";
            this.lblDataInclusao.Size = new System.Drawing.Size(114, 14);
            this.lblDataInclusao.TabIndex = 12;
            this.lblDataInclusao.Text = "Data de Inclusão";
            // 
            // txtDataInclusao
            // 
            this.txtDataInclusao.Enabled = false;
            this.txtDataInclusao.EstadosExibicaoPossiveis = null;
            this.txtDataInclusao.Font = new System.Drawing.Font("Verdana", 9F);
            this.txtDataInclusao.Location = new System.Drawing.Point(235, 44);
            this.txtDataInclusao.Name = "txtDataInclusao";
            this.txtDataInclusao.Size = new System.Drawing.Size(185, 22);
            this.txtDataInclusao.TabIndex = 11;
            // 
            // txtUsuarioInclusao
            // 
            this.txtUsuarioInclusao.Enabled = false;
            this.txtUsuarioInclusao.EstadosExibicaoPossiveis = null;
            this.txtUsuarioInclusao.Font = new System.Drawing.Font("Verdana", 9F);
            this.txtUsuarioInclusao.Location = new System.Drawing.Point(9, 44);
            this.txtUsuarioInclusao.Name = "txtUsuarioInclusao";
            this.txtUsuarioInclusao.Size = new System.Drawing.Size(185, 22);
            this.txtUsuarioInclusao.TabIndex = 10;
            // 
            // lblUsuarioInclusao
            // 
            this.lblUsuarioInclusao.AutoSize = true;
            this.lblUsuarioInclusao.EstadosExibicaoPossiveis = new EstadoExibicao[0];
            this.lblUsuarioInclusao.Font = new System.Drawing.Font("Verdana", 9F);
            this.lblUsuarioInclusao.Location = new System.Drawing.Point(6, 27);
            this.lblUsuarioInclusao.Name = "lblUsuarioInclusao";
            this.lblUsuarioInclusao.Size = new System.Drawing.Size(132, 14);
            this.lblUsuarioInclusao.TabIndex = 0;
            this.lblUsuarioInclusao.Text = "Usuário de Inclusão";
            // 
            // btnConsultar
            // 
            this.btnConsultar.EstadosExibicaoPossiveis = new EstadoExibicao[] {
        EstadoExibicao.Visualizando};
            this.btnConsultar.Font = new System.Drawing.Font("Verdana", 9F);
            this.btnConsultar.Location = new System.Drawing.Point(229, 396);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(101, 23);
            this.btnConsultar.TabIndex = 14;
            this.btnConsultar.Text = "&Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.EstadosExibicaoPossiveis = new EstadoExibicao[] {
        EstadoExibicao.Incluindo,
        EstadoExibicao.Alterando};
            this.btnSalvar.Font = new System.Drawing.Font("Verdana", 9F);
            this.btnSalvar.Location = new System.Drawing.Point(122, 396);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(101, 23);
            this.btnSalvar.TabIndex = 13;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.EstadosExibicaoPossiveis = new EstadoExibicao[] {
        EstadoExibicao.Visualizando};
            this.btnInserir.Font = new System.Drawing.Font("Verdana", 9F);
            this.btnInserir.Location = new System.Drawing.Point(15, 396);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(101, 23);
            this.btnInserir.TabIndex = 12;
            this.btnInserir.Text = "&Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnConversoes
            // 
            this.btnConversoes.EstadosExibicaoPossiveis = new EstadoExibicao[] {
        EstadoExibicao.Visualizando};
            this.btnConversoes.Font = new System.Drawing.Font("Verdana", 9F);
            this.btnConversoes.Location = new System.Drawing.Point(334, 396);
            this.btnConversoes.Name = "btnConversoes";
            this.btnConversoes.Size = new System.Drawing.Size(101, 23);
            this.btnConversoes.TabIndex = 15;
            this.btnConversoes.Text = "C&onversões";
            this.btnConversoes.UseVisualStyleBackColor = true;
            this.btnConversoes.Click += new System.EventHandler(this.btnConversoes_Click);
            // 
            // FormProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(457, 436);
            this.Controls.Add(this.btnConversoes);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.grpAlteracoes);
            this.Controls.Add(this.grpUnidades);
            this.Controls.Add(this.chkInativo);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormProdutos";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Produtos";
            this.grpUnidades.ResumeLayout(false);
            this.grpUnidades.PerformLayout();
            this.grpAlteracoes.ResumeLayout(false);
            this.grpAlteracoes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCodigo;
        private TextBox txtCodigo;
        private Label lblDescricao;
        private TextBox txtDescricao;
        private CheckBox chkInativo;
        private GroupBox grpUnidades;
        private ComboBox cbUnidadeVenda;
        private Label lblUnidadeVenda;
        private ComboBox cbUnidadeCompra;
        private Label lblUnidadeCompra;
        private ComboBox cbUnidadeEstoque;
        private Label lblUnidadeEstoque;
        private GroupBox grpAlteracoes;
        private Label lblDataInclusao;
        private TextBox txtDataInclusao;
        private TextBox txtUsuarioInclusao;
        private Label lblUsuarioInclusao;
        private Label lblDataAlteracao;
        private TextBox txtDataAlteracao;
        private TextBox txtUsuarioAlteracao;
        private Label lblUsuarioAlteracao;
        private Button btnConsultar;
        private Button btnSalvar;
        private Button btnInserir;
        private Button btnConversoes;
    }
}
