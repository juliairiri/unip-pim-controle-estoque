namespace Desktop.Formularios
{
    partial class FormUsuariosAlterarSenha
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
            this.lblSenha = new Desktop.Label();
            this.txtSenha = new Desktop.TextBox();
            this.lblConfirmacao = new Desktop.Label();
            this.txtConfirmacao = new Desktop.TextBox();
            this.btnConfirmar = new Desktop.Button();
            this.btnCancelar = new Desktop.Button();
            this.SuspendLayout();
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.EstadosExibicaoPossiveis = new EstadoExibicao[0];
            this.lblSenha.Font = new System.Drawing.Font("Verdana", 9F);
            this.lblSenha.Location = new System.Drawing.Point(12, 9);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(99, 14);
            this.lblSenha.TabIndex = 0;
            this.lblSenha.Text = "Digite a Senha";
            // 
            // txtSenha
            // 
            this.txtSenha.EstadosExibicaoPossiveis = null;
            this.txtSenha.Font = new System.Drawing.Font("Verdana", 9F);
            this.txtSenha.Location = new System.Drawing.Point(15, 26);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(243, 22);
            this.txtSenha.TabIndex = 2;
            // 
            // lblConfirmacao
            // 
            this.lblConfirmacao.AutoSize = true;
            this.lblConfirmacao.EstadosExibicaoPossiveis = new EstadoExibicao[0];
            this.lblConfirmacao.Font = new System.Drawing.Font("Verdana", 9F);
            this.lblConfirmacao.Location = new System.Drawing.Point(12, 51);
            this.lblConfirmacao.Name = "lblConfirmacao";
            this.lblConfirmacao.Size = new System.Drawing.Size(119, 14);
            this.lblConfirmacao.TabIndex = 3;
            this.lblConfirmacao.Text = "Confirme a Senha";
            // 
            // txtConfirmacao
            // 
            this.txtConfirmacao.EstadosExibicaoPossiveis = null;
            this.txtConfirmacao.Font = new System.Drawing.Font("Verdana", 9F);
            this.txtConfirmacao.Location = new System.Drawing.Point(15, 68);
            this.txtConfirmacao.Name = "txtConfirmacao";
            this.txtConfirmacao.PasswordChar = '*';
            this.txtConfirmacao.Size = new System.Drawing.Size(243, 22);
            this.txtConfirmacao.TabIndex = 4;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.EstadosExibicaoPossiveis = new EstadoExibicao[0];
            this.btnConfirmar.Font = new System.Drawing.Font("Verdana", 9F);
            this.btnConfirmar.Location = new System.Drawing.Point(15, 115);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(86, 23);
            this.btnConfirmar.TabIndex = 5;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.EstadosExibicaoPossiveis = new EstadoExibicao[0];
            this.btnCancelar.Font = new System.Drawing.Font("Verdana", 9F);
            this.btnCancelar.Location = new System.Drawing.Point(172, 115);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(86, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FormAlterarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(278, 162);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.txtConfirmacao);
            this.Controls.Add(this.lblConfirmacao);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblSenha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormAlterarSenha";
            this.Text = "Alterar Senha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblSenha;
        private TextBox txtSenha;
        private Label lblConfirmacao;
        private TextBox txtConfirmacao;
        private Button btnConfirmar;
        private Button btnCancelar;
    }
}
