namespace Desktop.Formularios
{
    partial class FormUnidades
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
            this.txtCodigo = new Desktop.TextBox();
            this.lblCodigo = new Desktop.Label();
            this.lblDescricao = new Desktop.Label();
            this.txtDescricao = new Desktop.TextBox();
            this.btnInserir = new Desktop.Button();
            this.btnSalvar = new Desktop.Button();
            this.btnConsultar = new Desktop.Button();
            this.chkInativo = new Desktop.CheckBox();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.EstadosExibicaoPossiveis = new EstadoExibicao[] {
        EstadoExibicao.Incluindo};
            this.txtCodigo.Font = new System.Drawing.Font("Verdana", 9F);
            this.txtCodigo.Location = new System.Drawing.Point(15, 26);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(205, 22);
            this.txtCodigo.TabIndex = 2;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.EstadosExibicaoPossiveis = new EstadoExibicao[0];
            this.lblCodigo.Font = new System.Drawing.Font("Verdana", 9F);
            this.lblCodigo.Location = new System.Drawing.Point(12, 9);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(51, 14);
            this.lblCodigo.TabIndex = 3;
            this.lblCodigo.Text = "Código";
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
            // txtDescricao
            // 
            this.txtDescricao.EstadosExibicaoPossiveis = new EstadoExibicao[] {
        EstadoExibicao.Visualizando,
        EstadoExibicao.Incluindo,
        EstadoExibicao.Alterando};
            this.txtDescricao.Font = new System.Drawing.Font("Verdana", 9F);
            this.txtDescricao.Location = new System.Drawing.Point(15, 68);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(375, 22);
            this.txtDescricao.TabIndex = 5;
            // 
            // btnInserir
            // 
            this.btnInserir.EstadosExibicaoPossiveis = new EstadoExibicao[] {
        EstadoExibicao.Visualizando};
            this.btnInserir.Font = new System.Drawing.Font("Verdana", 9F);
            this.btnInserir.Location = new System.Drawing.Point(15, 96);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(101, 23);
            this.btnInserir.TabIndex = 6;
            this.btnInserir.Text = "&Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.EstadosExibicaoPossiveis = new EstadoExibicao[] {
        EstadoExibicao.Incluindo,
        EstadoExibicao.Alterando};
            this.btnSalvar.Font = new System.Drawing.Font("Verdana", 9F);
            this.btnSalvar.Location = new System.Drawing.Point(122, 96);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(101, 23);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.EstadosExibicaoPossiveis = new EstadoExibicao[] {
        EstadoExibicao.Visualizando};
            this.btnConsultar.Font = new System.Drawing.Font("Verdana", 9F);
            this.btnConsultar.Location = new System.Drawing.Point(229, 96);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(101, 23);
            this.btnConsultar.TabIndex = 8;
            this.btnConsultar.Text = "&Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // chkInativo
            // 
            this.chkInativo.AutoSize = true;
            this.chkInativo.EstadosExibicaoPossiveis = new EstadoExibicao[] {
        EstadoExibicao.Visualizando,
        EstadoExibicao.Incluindo,
        EstadoExibicao.Alterando};
            this.chkInativo.Font = new System.Drawing.Font("Verdana", 9F);
            this.chkInativo.Location = new System.Drawing.Point(229, 28);
            this.chkInativo.Name = "chkInativo";
            this.chkInativo.Size = new System.Drawing.Size(70, 18);
            this.chkInativo.TabIndex = 9;
            this.chkInativo.Text = "Inativo";
            this.chkInativo.UseVisualStyleBackColor = true;
            // 
            // FormUnidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(402, 135);
            this.Controls.Add(this.chkInativo);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormUnidades";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Unidades de Pesos e Medidas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtCodigo;
        private Label lblCodigo;
        private Label lblDescricao;
        private TextBox txtDescricao;
        private Button btnInserir;
        private Button btnSalvar;
        private Button btnConsultar;
        private CheckBox chkInativo;
    }
}
