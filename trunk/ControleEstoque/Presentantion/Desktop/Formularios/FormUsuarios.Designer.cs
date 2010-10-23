namespace Desktop.Formularios
{
    partial class FormUsuarios
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
            this.btnSalvar = new Desktop.Button();
            this.btnInserir = new Desktop.Button();
            this.txtNome = new Desktop.TextBox();
            this.lblNome = new Desktop.Label();
            this.chkAtivo = new Desktop.CheckBox();
            this.txtCodigo = new Desktop.TextBox();
            this.lblCodigo = new Desktop.Label();
            this.btnConsultar = new Desktop.Button();
            this.btnExcluir = new Desktop.Button();
            this.btnAlterarSenha = new Desktop.Button();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.EstadosExibicaoPossiveis = null;
            this.btnSalvar.Font = new System.Drawing.Font("Verdana", 9F);
            this.btnSalvar.Location = new System.Drawing.Point(135, 102);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(117, 23);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.EstadosExibicaoPossiveis = null;
            this.btnInserir.Font = new System.Drawing.Font("Verdana", 9F);
            this.btnInserir.Location = new System.Drawing.Point(12, 102);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(117, 23);
            this.btnInserir.TabIndex = 4;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // txtNome
            // 
            this.txtNome.EstadosExibicaoPossiveis = null;
            this.txtNome.Font = new System.Drawing.Font("Verdana", 9F);
            this.txtNome.Location = new System.Drawing.Point(12, 74);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(363, 22);
            this.txtNome.TabIndex = 3;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.EstadosExibicaoPossiveis = null;
            this.lblNome.Font = new System.Drawing.Font("Verdana", 9F);
            this.lblNome.Location = new System.Drawing.Point(12, 56);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(43, 14);
            this.lblNome.TabIndex = 10;
            this.lblNome.Text = "Nome";
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.EstadosExibicaoPossiveis = null;
            this.chkAtivo.Font = new System.Drawing.Font("Verdana", 9F);
            this.chkAtivo.Location = new System.Drawing.Point(200, 31);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(57, 18);
            this.chkAtivo.TabIndex = 2;
            this.chkAtivo.Text = "Ativo";
            this.chkAtivo.UseVisualStyleBackColor = true;
            // 
            // txtCodigo
            // 
            this.txtCodigo.EstadosExibicaoPossiveis = null;
            this.txtCodigo.Font = new System.Drawing.Font("Verdana", 9F);
            this.txtCodigo.Location = new System.Drawing.Point(12, 27);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(182, 22);
            this.txtCodigo.TabIndex = 1;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.EstadosExibicaoPossiveis = null;
            this.lblCodigo.Font = new System.Drawing.Font("Verdana", 9F);
            this.lblCodigo.Location = new System.Drawing.Point(12, 9);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(51, 14);
            this.lblCodigo.TabIndex = 7;
            this.lblCodigo.Text = "Código";
            // 
            // btnConsultar
            // 
            this.btnConsultar.EstadosExibicaoPossiveis = new EstadoExibicao[0];
            this.btnConsultar.Font = new System.Drawing.Font("Verdana", 9F);
            this.btnConsultar.Location = new System.Drawing.Point(12, 131);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(117, 23);
            this.btnConsultar.TabIndex = 7;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.EstadosExibicaoPossiveis = new EstadoExibicao[0];
            this.btnExcluir.Font = new System.Drawing.Font("Verdana", 9F);
            this.btnExcluir.Location = new System.Drawing.Point(258, 102);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(117, 23);
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterarSenha
            // 
            this.btnAlterarSenha.EstadosExibicaoPossiveis = new EstadoExibicao[0];
            this.btnAlterarSenha.Font = new System.Drawing.Font("Verdana", 9F);
            this.btnAlterarSenha.Location = new System.Drawing.Point(135, 131);
            this.btnAlterarSenha.Name = "btnAlterarSenha";
            this.btnAlterarSenha.Size = new System.Drawing.Size(117, 23);
            this.btnAlterarSenha.TabIndex = 11;
            this.btnAlterarSenha.Text = "Alterar Senha";
            this.btnAlterarSenha.UseVisualStyleBackColor = true;
            this.btnAlterarSenha.Click += new System.EventHandler(this.btnAlterarSenha_Click);
            // 
            // FormUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(391, 166);
            this.Controls.Add(this.btnAlterarSenha);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.chkAtivo);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Name = "FormUsuarios";
            this.Text = "Usuários";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSalvar;
        private Button btnInserir;
        private TextBox txtNome;
        private Label lblNome;
        private CheckBox chkAtivo;
        private TextBox txtCodigo;
        private Label lblCodigo;
        private Button btnConsultar;
        private Button btnExcluir;
        private Button btnAlterarSenha;
    }
}
