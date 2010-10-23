namespace Desktop.Formularios
{
    partial class FormAutenticacao
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
            this.lblUsuario = new Desktop.Label();
            this.txtUsuario = new Desktop.TextBox();
            this.lblSenha = new Desktop.Label();
            this.txtSenha = new Desktop.TextBox();
            this.btnOk = new Desktop.Button();
            this.btnCancelar = new Desktop.Button();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.EstadosExibicaoPossiveis = new EstadoExibicao[0];
            this.lblUsuario.Font = new System.Drawing.Font("Verdana", 9F);
            this.lblUsuario.Location = new System.Drawing.Point(12, 26);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(55, 14);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuário";
            // 
            // txtUsuario
            // 
            this.txtUsuario.EstadosExibicaoPossiveis = null;
            this.txtUsuario.Font = new System.Drawing.Font("Verdana", 9F);
            this.txtUsuario.Location = new System.Drawing.Point(73, 23);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(243, 22);
            this.txtUsuario.TabIndex = 2;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.EstadosExibicaoPossiveis = new EstadoExibicao[0];
            this.lblSenha.Font = new System.Drawing.Font("Verdana", 9F);
            this.lblSenha.Location = new System.Drawing.Point(20, 70);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(47, 14);
            this.lblSenha.TabIndex = 3;
            this.lblSenha.Text = "Senha";
            // 
            // txtSenha
            // 
            this.txtSenha.EstadosExibicaoPossiveis = null;
            this.txtSenha.Font = new System.Drawing.Font("Verdana", 9F);
            this.txtSenha.Location = new System.Drawing.Point(73, 67);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(243, 22);
            this.txtSenha.TabIndex = 4;
            // 
            // btnOk
            // 
            this.btnOk.EstadosExibicaoPossiveis = new EstadoExibicao[0];
            this.btnOk.Font = new System.Drawing.Font("Verdana", 9F);
            this.btnOk.Location = new System.Drawing.Point(15, 128);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "&Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.EstadosExibicaoPossiveis = new EstadoExibicao[0];
            this.btnCancelar.Font = new System.Drawing.Font("Verdana", 9F);
            this.btnCancelar.Location = new System.Drawing.Point(241, 128);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FormAutenticacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(337, 172);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormAutenticacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autenticação";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblUsuario;
        private TextBox txtUsuario;
        private Label lblSenha;
        private TextBox txtSenha;
        private Button btnOk;
        private Button btnCancelar;
    }
}
