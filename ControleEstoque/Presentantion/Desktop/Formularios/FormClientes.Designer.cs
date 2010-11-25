namespace Desktop.Formularios
{
    partial class FormClientes
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
            this.lblTipo = new Desktop.Label();
            this.cbTipo = new Desktop.ComboBox();
            this.chkInativo = new Desktop.CheckBox();
            this.grupoDados = new Desktop.GroupBox();
            this.txtCodigoFornecedor = new Desktop.TextBox();
            this.lblCodigoFornecedor = new Desktop.Label();
            this.label1 = new Desktop.Label();
            this.txtNome = new Desktop.TextBox();
            this.textBox2 = new Desktop.TextBox();
            this.txtRazaoSocial = new Desktop.Label();
            this.groupBox1 = new Desktop.GroupBox();
            this.grupoDados.SuspendLayout();
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
            this.txtCodigo.Size = new System.Drawing.Size(151, 22);
            this.txtCodigo.TabIndex = 3;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.EstadosExibicaoPossiveis = new EstadoExibicao[0];
            this.lblTipo.Font = new System.Drawing.Font("Verdana", 9F);
            this.lblTipo.Location = new System.Drawing.Point(6, 20);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(33, 14);
            this.lblTipo.TabIndex = 4;
            this.lblTipo.Text = "Tipo";
            // 
            // cbTipo
            // 
            this.cbTipo.EstadosExibicaoPossiveis = null;
            this.cbTipo.Font = new System.Drawing.Font("Verdana", 9F);
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Location = new System.Drawing.Point(9, 37);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(192, 22);
            this.cbTipo.TabIndex = 5;
            // 
            // chkInativo
            // 
            this.chkInativo.AutoSize = true;
            this.chkInativo.EstadosExibicaoPossiveis = null;
            this.chkInativo.Font = new System.Drawing.Font("Verdana", 9F);
            this.chkInativo.Location = new System.Drawing.Point(329, 28);
            this.chkInativo.Name = "chkInativo";
            this.chkInativo.Size = new System.Drawing.Size(70, 18);
            this.chkInativo.TabIndex = 6;
            this.chkInativo.Text = "Inativo";
            this.chkInativo.UseVisualStyleBackColor = true;
            // 
            // grupoDados
            // 
            this.grupoDados.Controls.Add(this.txtRazaoSocial);
            this.grupoDados.Controls.Add(this.textBox2);
            this.grupoDados.Controls.Add(this.txtNome);
            this.grupoDados.Controls.Add(this.label1);
            this.grupoDados.Controls.Add(this.lblTipo);
            this.grupoDados.Controls.Add(this.cbTipo);
            this.grupoDados.Font = new System.Drawing.Font("Verdana", 9F);
            this.grupoDados.Location = new System.Drawing.Point(15, 54);
            this.grupoDados.Name = "grupoDados";
            this.grupoDados.Size = new System.Drawing.Size(634, 158);
            this.grupoDados.TabIndex = 7;
            this.grupoDados.TabStop = false;
            this.grupoDados.Text = "Dados";
            // 
            // txtCodigoFornecedor
            // 
            this.txtCodigoFornecedor.EstadosExibicaoPossiveis = new EstadoExibicao[] {
        EstadoExibicao.Incluindo};
            this.txtCodigoFornecedor.Font = new System.Drawing.Font("Verdana", 9F);
            this.txtCodigoFornecedor.Location = new System.Drawing.Point(172, 26);
            this.txtCodigoFornecedor.Name = "txtCodigoFornecedor";
            this.txtCodigoFornecedor.Size = new System.Drawing.Size(151, 22);
            this.txtCodigoFornecedor.TabIndex = 8;
            // 
            // lblCodigoFornecedor
            // 
            this.lblCodigoFornecedor.AutoSize = true;
            this.lblCodigoFornecedor.EstadosExibicaoPossiveis = new EstadoExibicao[0];
            this.lblCodigoFornecedor.Font = new System.Drawing.Font("Verdana", 9F);
            this.lblCodigoFornecedor.Location = new System.Drawing.Point(169, 9);
            this.lblCodigoFornecedor.Name = "lblCodigoFornecedor";
            this.lblCodigoFornecedor.Size = new System.Drawing.Size(126, 14);
            this.lblCodigoFornecedor.TabIndex = 9;
            this.lblCodigoFornecedor.Text = "Código Fornecedor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.EstadosExibicaoPossiveis = new EstadoExibicao[0];
            this.label1.Font = new System.Drawing.Font("Verdana", 9F);
            this.label1.Location = new System.Drawing.Point(6, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 14);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.EstadosExibicaoPossiveis = new EstadoExibicao[] {
        EstadoExibicao.Incluindo};
            this.txtNome.Font = new System.Drawing.Font("Verdana", 9F);
            this.txtNome.Location = new System.Drawing.Point(9, 79);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(619, 22);
            this.txtNome.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.EstadosExibicaoPossiveis = new EstadoExibicao[] {
        EstadoExibicao.Incluindo};
            this.textBox2.Font = new System.Drawing.Font("Verdana", 9F);
            this.textBox2.Location = new System.Drawing.Point(9, 121);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(619, 22);
            this.textBox2.TabIndex = 11;
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.AutoSize = true;
            this.txtRazaoSocial.EstadosExibicaoPossiveis = new EstadoExibicao[0];
            this.txtRazaoSocial.Font = new System.Drawing.Font("Verdana", 9F);
            this.txtRazaoSocial.Location = new System.Drawing.Point(6, 104);
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(86, 14);
            this.txtRazaoSocial.TabIndex = 12;
            this.txtRazaoSocial.Text = "Razão Social";
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 9F);
            this.groupBox1.Location = new System.Drawing.Point(15, 218);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(634, 100);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(663, 439);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblCodigoFornecedor);
            this.Controls.Add(this.txtCodigoFornecedor);
            this.Controls.Add(this.grupoDados);
            this.Controls.Add(this.chkInativo);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormClientes";
            this.Text = "Clientes";
            this.grupoDados.ResumeLayout(false);
            this.grupoDados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCodigo;
        private TextBox txtCodigo;
        private Label lblTipo;
        private ComboBox cbTipo;
        private CheckBox chkInativo;
        private GroupBox grupoDados;
        private Label txtRazaoSocial;
        private TextBox textBox2;
        private TextBox txtNome;
        private Label label1;
        private TextBox txtCodigoFornecedor;
        private Label lblCodigoFornecedor;
        private GroupBox groupBox1;
    }
}
