namespace Desktop.Formularios
{
    partial class FormLocaisEstoque
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
            this.textBox1 = new Desktop.TextBox();
            this.chkInativo = new Desktop.CheckBox();
            this.btnConsultar = new Desktop.Button();
            this.btnSalvar = new Desktop.Button();
            this.btnInserir = new Desktop.Button();
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
            this.txtCodigo.EstadosExibicaoPossiveis = null;
            this.txtCodigo.Font = new System.Drawing.Font("Verdana", 9F);
            this.txtCodigo.Location = new System.Drawing.Point(15, 26);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(205, 22);
            this.txtCodigo.TabIndex = 3;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.EstadosExibicaoPossiveis = new EstadoExibicao[0];
            this.lblDescricao.Font = new System.Drawing.Font("Verdana", 9F);
            this.lblDescricao.Location = new System.Drawing.Point(12, 51);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(67, 14);
            this.lblDescricao.TabIndex = 4;
            this.lblDescricao.Text = "Descrição";
            // 
            // textBox1
            // 
            this.textBox1.EstadosExibicaoPossiveis = null;
            this.textBox1.Font = new System.Drawing.Font("Verdana", 9F);
            this.textBox1.Location = new System.Drawing.Point(15, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(402, 22);
            this.textBox1.TabIndex = 5;
            // 
            // chkInativo
            // 
            this.chkInativo.AutoSize = true;
            this.chkInativo.EstadosExibicaoPossiveis = new EstadoExibicao[0];
            this.chkInativo.Font = new System.Drawing.Font("Verdana", 9F);
            this.chkInativo.Location = new System.Drawing.Point(227, 29);
            this.chkInativo.Name = "chkInativo";
            this.chkInativo.Size = new System.Drawing.Size(70, 18);
            this.chkInativo.TabIndex = 6;
            this.chkInativo.Text = "Inativo";
            this.chkInativo.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.EstadosExibicaoPossiveis = new EstadoExibicao[0];
            this.btnConsultar.Font = new System.Drawing.Font("Verdana", 9F);
            this.btnConsultar.Location = new System.Drawing.Point(229, 96);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(101, 23);
            this.btnConsultar.TabIndex = 11;
            this.btnConsultar.Text = "&Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.EstadosExibicaoPossiveis = new EstadoExibicao[0];
            this.btnSalvar.Font = new System.Drawing.Font("Verdana", 9F);
            this.btnSalvar.Location = new System.Drawing.Point(122, 96);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(101, 23);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnInserir
            // 
            this.btnInserir.EstadosExibicaoPossiveis = new EstadoExibicao[0];
            this.btnInserir.Font = new System.Drawing.Font("Verdana", 9F);
            this.btnInserir.Location = new System.Drawing.Point(15, 96);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(101, 23);
            this.btnInserir.TabIndex = 9;
            this.btnInserir.Text = "&Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            // 
            // FormLocaisEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(429, 133);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.chkInativo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLocaisEstoque";
            this.ShowIcon = false;
            this.Text = "Locais de Estoque";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCodigo;
        private TextBox txtCodigo;
        private Label lblDescricao;
        private TextBox textBox1;
        private CheckBox chkInativo;
        private Button btnConsultar;
        private Button btnSalvar;
        private Button btnInserir;
    }
}
