namespace Desktop.Formularios
{
    partial class FormUsuariosConsultar
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
            this.chkPorCodigo = new Desktop.CheckBox();
            this.chkPorNome = new Desktop.CheckBox();
            this.lblTexto = new Desktop.Label();
            this.txtTexto = new Desktop.TextBox();
            this.btnPesquisar = new Desktop.Button();
            this.lblResultados = new Desktop.Label();
            this.gridResultados = new Desktop.DataGridView();
            this.btnSelecionar = new Desktop.Button();
            this.colunaCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaAtivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // chkPorCodigo
            // 
            this.chkPorCodigo.AutoSize = true;
            this.chkPorCodigo.EstadosExibicaoPossiveis = new EstadoExibicao[0];
            this.chkPorCodigo.Font = new System.Drawing.Font("Verdana", 9F);
            this.chkPorCodigo.Location = new System.Drawing.Point(12, 12);
            this.chkPorCodigo.Name = "chkPorCodigo";
            this.chkPorCodigo.Size = new System.Drawing.Size(95, 18);
            this.chkPorCodigo.TabIndex = 0;
            this.chkPorCodigo.Text = "Por Código";
            this.chkPorCodigo.UseVisualStyleBackColor = true;
            // 
            // chkPorNome
            // 
            this.chkPorNome.AutoSize = true;
            this.chkPorNome.EstadosExibicaoPossiveis = new EstadoExibicao[0];
            this.chkPorNome.Font = new System.Drawing.Font("Verdana", 9F);
            this.chkPorNome.Location = new System.Drawing.Point(113, 12);
            this.chkPorNome.Name = "chkPorNome";
            this.chkPorNome.Size = new System.Drawing.Size(87, 18);
            this.chkPorNome.TabIndex = 1;
            this.chkPorNome.Text = "Por Nome";
            this.chkPorNome.UseVisualStyleBackColor = true;
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.EstadosExibicaoPossiveis = new EstadoExibicao[0];
            this.lblTexto.Font = new System.Drawing.Font("Verdana", 9F);
            this.lblTexto.Location = new System.Drawing.Point(12, 33);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(42, 14);
            this.lblTexto.TabIndex = 2;
            this.lblTexto.Text = "Texto";
            // 
            // txtTexto
            // 
            this.txtTexto.EstadosExibicaoPossiveis = null;
            this.txtTexto.Font = new System.Drawing.Font("Verdana", 9F);
            this.txtTexto.Location = new System.Drawing.Point(15, 50);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.PasswordChar = '*';
            this.txtTexto.Size = new System.Drawing.Size(451, 22);
            this.txtTexto.TabIndex = 3;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.EstadosExibicaoPossiveis = new EstadoExibicao[0];
            this.btnPesquisar.Font = new System.Drawing.Font("Verdana", 9F);
            this.btnPesquisar.Location = new System.Drawing.Point(472, 49);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(82, 23);
            this.btnPesquisar.TabIndex = 4;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // lblResultados
            // 
            this.lblResultados.AutoSize = true;
            this.lblResultados.EstadosExibicaoPossiveis = new EstadoExibicao[0];
            this.lblResultados.Font = new System.Drawing.Font("Verdana", 9F);
            this.lblResultados.Location = new System.Drawing.Point(12, 75);
            this.lblResultados.Name = "lblResultados";
            this.lblResultados.Size = new System.Drawing.Size(77, 14);
            this.lblResultados.TabIndex = 5;
            this.lblResultados.Text = "Resultados";
            // 
            // gridResultados
            // 
            this.gridResultados.AllowUserToAddRows = false;
            this.gridResultados.AllowUserToDeleteRows = false;
            this.gridResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridResultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colunaCodigo,
            this.colunaNome,
            this.colunaAtivo});
            this.gridResultados.EstadosExibicaoPossiveis = new EstadoExibicao[0];
            this.gridResultados.Font = new System.Drawing.Font("Verdana", 9F);
            this.gridResultados.Location = new System.Drawing.Point(15, 92);
            this.gridResultados.Name = "gridResultados";
            this.gridResultados.ReadOnly = true;
            this.gridResultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridResultados.Size = new System.Drawing.Size(538, 298);
            this.gridResultados.TabIndex = 6;
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.EstadosExibicaoPossiveis = new EstadoExibicao[0];
            this.btnSelecionar.Font = new System.Drawing.Font("Verdana", 9F);
            this.btnSelecionar.Location = new System.Drawing.Point(15, 396);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(81, 23);
            this.btnSelecionar.TabIndex = 7;
            this.btnSelecionar.Text = "&Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            // 
            // colunaCodigo
            // 
            this.colunaCodigo.HeaderText = "Código";
            this.colunaCodigo.Name = "colunaCodigo";
            this.colunaCodigo.ReadOnly = true;
            // 
            // colunaNome
            // 
            this.colunaNome.HeaderText = "Nome";
            this.colunaNome.Name = "colunaNome";
            this.colunaNome.ReadOnly = true;
            this.colunaNome.Width = 350;
            // 
            // colunaAtivo
            // 
            this.colunaAtivo.HeaderText = "Ativo";
            this.colunaAtivo.Name = "colunaAtivo";
            this.colunaAtivo.ReadOnly = true;
            this.colunaAtivo.Width = 50;
            // 
            // FormUsuariosConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(565, 431);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.gridResultados);
            this.Controls.Add(this.lblResultados);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.chkPorNome);
            this.Controls.Add(this.chkPorCodigo);
            this.Name = "FormUsuariosConsultar";
            ((System.ComponentModel.ISupportInitialize)(this.gridResultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox chkPorCodigo;
        private CheckBox chkPorNome;
        private Label lblTexto;
        private TextBox txtTexto;
        private Button btnPesquisar;
        private Label lblResultados;
        private DataGridView gridResultados;
        private Button btnSelecionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaNome;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colunaAtivo;
    }
}
