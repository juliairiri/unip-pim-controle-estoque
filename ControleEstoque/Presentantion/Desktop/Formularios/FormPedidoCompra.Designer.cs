namespace Desktop.Formularios
{
    partial class FormPedidoCompra
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
            this.label1 = new Desktop.Label();
            this.txtCodigo = new Desktop.TextBox();
            this.textBox1 = new Desktop.TextBox();
            this.label2 = new Desktop.Label();
            this.comboBox1 = new Desktop.ComboBox();
            this.label3 = new Desktop.Label();
            this.dataGridView1 = new Desktop.DataGridView();
            this.groupBox1 = new Desktop.GroupBox();
            this.btnInserirItem = new Desktop.Button();
            this.btnEditarItem = new Desktop.Button();
            this.btnExcluirItem = new Desktop.Button();
            this.btnInserir = new Desktop.Button();
            this.btnExcluir = new Desktop.Button();
            this.btnLiberar = new Desktop.Button();
            this.btnReceber = new Desktop.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.EstadosExibicaoPossiveis = new EstadoExibicao[0];
            this.label1.Font = new System.Drawing.Font("Verdana", 9F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.EstadosExibicaoPossiveis = new EstadoExibicao[0];
            this.txtCodigo.Font = new System.Drawing.Font("Verdana", 9F);
            this.txtCodigo.Location = new System.Drawing.Point(15, 26);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(151, 22);
            this.txtCodigo.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.EstadosExibicaoPossiveis = new EstadoExibicao[0];
            this.textBox1.Font = new System.Drawing.Font("Verdana", 9F);
            this.textBox1.Location = new System.Drawing.Point(172, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(118, 22);
            this.textBox1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.EstadosExibicaoPossiveis = new EstadoExibicao[0];
            this.label2.Font = new System.Drawing.Font("Verdana", 9F);
            this.label2.Location = new System.Drawing.Point(169, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 14);
            this.label2.TabIndex = 6;
            this.label2.Text = "Data";
            // 
            // comboBox1
            // 
            this.comboBox1.EstadosExibicaoPossiveis = null;
            this.comboBox1.Font = new System.Drawing.Font("Verdana", 9F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(296, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(550, 22);
            this.comboBox1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.EstadosExibicaoPossiveis = new EstadoExibicao[0];
            this.label3.Font = new System.Drawing.Font("Verdana", 9F);
            this.label3.Location = new System.Drawing.Point(293, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 14);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fornecedor";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EstadosExibicaoPossiveis = null;
            this.dataGridView1.Font = new System.Drawing.Font("Verdana", 9F);
            this.dataGridView1.Location = new System.Drawing.Point(6, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(819, 234);
            this.dataGridView1.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExcluirItem);
            this.groupBox1.Controls.Add(this.btnEditarItem);
            this.groupBox1.Controls.Add(this.btnInserirItem);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 9F);
            this.groupBox1.Location = new System.Drawing.Point(15, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(831, 290);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Itens";
            // 
            // btnInserirItem
            // 
            this.btnInserirItem.EstadosExibicaoPossiveis = new EstadoExibicao[0];
            this.btnInserirItem.Font = new System.Drawing.Font("Verdana", 9F);
            this.btnInserirItem.Location = new System.Drawing.Point(507, 261);
            this.btnInserirItem.Name = "btnInserirItem";
            this.btnInserirItem.Size = new System.Drawing.Size(102, 23);
            this.btnInserirItem.TabIndex = 10;
            this.btnInserirItem.Text = "Inserir";
            this.btnInserirItem.UseVisualStyleBackColor = true;
            // 
            // btnEditarItem
            // 
            this.btnEditarItem.EstadosExibicaoPossiveis = new EstadoExibicao[0];
            this.btnEditarItem.Font = new System.Drawing.Font("Verdana", 9F);
            this.btnEditarItem.Location = new System.Drawing.Point(615, 261);
            this.btnEditarItem.Name = "btnEditarItem";
            this.btnEditarItem.Size = new System.Drawing.Size(102, 23);
            this.btnEditarItem.TabIndex = 11;
            this.btnEditarItem.Text = "Editar";
            this.btnEditarItem.UseVisualStyleBackColor = true;
            // 
            // btnExcluirItem
            // 
            this.btnExcluirItem.EstadosExibicaoPossiveis = new EstadoExibicao[0];
            this.btnExcluirItem.Font = new System.Drawing.Font("Verdana", 9F);
            this.btnExcluirItem.Location = new System.Drawing.Point(723, 261);
            this.btnExcluirItem.Name = "btnExcluirItem";
            this.btnExcluirItem.Size = new System.Drawing.Size(102, 23);
            this.btnExcluirItem.TabIndex = 12;
            this.btnExcluirItem.Text = "Excluir";
            this.btnExcluirItem.UseVisualStyleBackColor = true;
            // 
            // btnInserir
            // 
            this.btnInserir.EstadosExibicaoPossiveis = new EstadoExibicao[0];
            this.btnInserir.Font = new System.Drawing.Font("Verdana", 9F);
            this.btnInserir.Location = new System.Drawing.Point(15, 350);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(102, 23);
            this.btnInserir.TabIndex = 13;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.EstadosExibicaoPossiveis = new EstadoExibicao[0];
            this.btnExcluir.Font = new System.Drawing.Font("Verdana", 9F);
            this.btnExcluir.Location = new System.Drawing.Point(123, 350);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(102, 23);
            this.btnExcluir.TabIndex = 14;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnLiberar
            // 
            this.btnLiberar.EstadosExibicaoPossiveis = new EstadoExibicao[0];
            this.btnLiberar.Font = new System.Drawing.Font("Verdana", 9F);
            this.btnLiberar.Location = new System.Drawing.Point(231, 350);
            this.btnLiberar.Name = "btnLiberar";
            this.btnLiberar.Size = new System.Drawing.Size(102, 23);
            this.btnLiberar.TabIndex = 15;
            this.btnLiberar.Text = "Liberar";
            this.btnLiberar.UseVisualStyleBackColor = true;
            // 
            // btnReceber
            // 
            this.btnReceber.EstadosExibicaoPossiveis = new EstadoExibicao[0];
            this.btnReceber.Font = new System.Drawing.Font("Verdana", 9F);
            this.btnReceber.Location = new System.Drawing.Point(339, 350);
            this.btnReceber.Name = "btnReceber";
            this.btnReceber.Size = new System.Drawing.Size(102, 23);
            this.btnReceber.TabIndex = 16;
            this.btnReceber.Text = "Receber";
            this.btnReceber.UseVisualStyleBackColor = true;
            // 
            // FormPedidoCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(858, 387);
            this.Controls.Add(this.btnReceber);
            this.Controls.Add(this.btnLiberar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPedidoCompra";
            this.Text = "Pedido de Compra";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtCodigo;
        private TextBox textBox1;
        private Label label2;
        private ComboBox comboBox1;
        private Label label3;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Button btnExcluirItem;
        private Button btnEditarItem;
        private Button btnInserirItem;
        private Button btnInserir;
        private Button btnExcluir;
        private Button btnLiberar;
        private Button btnReceber;
    }
}
