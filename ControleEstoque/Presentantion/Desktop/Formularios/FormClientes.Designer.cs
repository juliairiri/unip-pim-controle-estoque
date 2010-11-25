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
            this.lblRazaoSocial = new Desktop.Label();
            this.txtRazaoSocial = new Desktop.TextBox();
            this.txtNome = new Desktop.TextBox();
            this.label1 = new Desktop.Label();
            this.txtCodigoFornecedor = new Desktop.TextBox();
            this.lblCodigoFornecedor = new Desktop.Label();
            this.groupDocumentos = new Desktop.GroupBox();
            this.lblCnpj = new Desktop.Label();
            this.txtCnpj = new Desktop.TextBox();
            this.txtCpf = new Desktop.TextBox();
            this.lblCpf = new Desktop.Label();
            this.groupEndereço = new Desktop.GroupBox();
            this.lblCep = new Desktop.Label();
            this.txtCep = new Desktop.TextBox();
            this.lblCidade = new Desktop.Label();
            this.lblEstado = new Desktop.Label();
            this.txtEstado = new Desktop.TextBox();
            this.txtCidade = new Desktop.TextBox();
            this.txtBairro = new Desktop.TextBox();
            this.lblBairro = new Desktop.Label();
            this.lblComplemento = new Desktop.Label();
            this.lblNumero = new Desktop.Label();
            this.txtNumero = new Desktop.TextBox();
            this.txtComplemento = new Desktop.TextBox();
            this.txtLogradouro = new Desktop.TextBox();
            this.lblLogradouro = new Desktop.Label();
            this.btnConsultar = new Desktop.Button();
            this.btnSalvar = new Desktop.Button();
            this.btnInserir = new Desktop.Button();
            this.grupoDados.SuspendLayout();
            this.groupDocumentos.SuspendLayout();
            this.groupEndereço.SuspendLayout();
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
            this.txtCodigo.Enabled = false;
            this.txtCodigo.EstadosExibicaoPossiveis = new EstadoExibicao[0];
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
            this.cbTipo.EstadosExibicaoPossiveis = new EstadoExibicao[] {
        EstadoExibicao.Visualizando,
        EstadoExibicao.Incluindo,
        EstadoExibicao.Alterando};
            this.cbTipo.Font = new System.Drawing.Font("Verdana", 9F);
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Location = new System.Drawing.Point(9, 37);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(192, 22);
            this.cbTipo.TabIndex = 5;
            this.cbTipo.SelectedIndexChanged += new System.EventHandler(this.cbTipo_SelectedIndexChanged);
            // 
            // chkInativo
            // 
            this.chkInativo.AutoSize = true;
            this.chkInativo.EstadosExibicaoPossiveis = new EstadoExibicao[] {
        EstadoExibicao.Visualizando,
        EstadoExibicao.Incluindo,
        EstadoExibicao.Alterando};
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
            this.grupoDados.Controls.Add(this.lblRazaoSocial);
            this.grupoDados.Controls.Add(this.txtRazaoSocial);
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
            // lblRazaoSocial
            // 
            this.lblRazaoSocial.AutoSize = true;
            this.lblRazaoSocial.EstadosExibicaoPossiveis = new EstadoExibicao[0];
            this.lblRazaoSocial.Font = new System.Drawing.Font("Verdana", 9F);
            this.lblRazaoSocial.Location = new System.Drawing.Point(6, 104);
            this.lblRazaoSocial.Name = "lblRazaoSocial";
            this.lblRazaoSocial.Size = new System.Drawing.Size(86, 14);
            this.lblRazaoSocial.TabIndex = 12;
            this.lblRazaoSocial.Text = "Razão Social";
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.EstadosExibicaoPossiveis = new EstadoExibicao[] {
        EstadoExibicao.Visualizando,
        EstadoExibicao.Incluindo,
        EstadoExibicao.Alterando};
            this.txtRazaoSocial.Font = new System.Drawing.Font("Verdana", 9F);
            this.txtRazaoSocial.Location = new System.Drawing.Point(9, 121);
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(619, 22);
            this.txtRazaoSocial.TabIndex = 11;
            // 
            // txtNome
            // 
            this.txtNome.EstadosExibicaoPossiveis = new EstadoExibicao[] {
        EstadoExibicao.Visualizando,
        EstadoExibicao.Incluindo,
        EstadoExibicao.Alterando};
            this.txtNome.Font = new System.Drawing.Font("Verdana", 9F);
            this.txtNome.Location = new System.Drawing.Point(9, 79);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(619, 22);
            this.txtNome.TabIndex = 10;
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
            // txtCodigoFornecedor
            // 
            this.txtCodigoFornecedor.EstadosExibicaoPossiveis = new EstadoExibicao[] {
        EstadoExibicao.Visualizando,
        EstadoExibicao.Incluindo,
        EstadoExibicao.Alterando};
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
            // groupDocumentos
            // 
            this.groupDocumentos.Controls.Add(this.lblCnpj);
            this.groupDocumentos.Controls.Add(this.txtCnpj);
            this.groupDocumentos.Controls.Add(this.txtCpf);
            this.groupDocumentos.Controls.Add(this.lblCpf);
            this.groupDocumentos.Font = new System.Drawing.Font("Verdana", 9F);
            this.groupDocumentos.Location = new System.Drawing.Point(15, 218);
            this.groupDocumentos.Name = "groupDocumentos";
            this.groupDocumentos.Size = new System.Drawing.Size(634, 75);
            this.groupDocumentos.TabIndex = 10;
            this.groupDocumentos.TabStop = false;
            this.groupDocumentos.Text = "Documentos";
            // 
            // lblCnpj
            // 
            this.lblCnpj.AutoSize = true;
            this.lblCnpj.EstadosExibicaoPossiveis = new EstadoExibicao[0];
            this.lblCnpj.Font = new System.Drawing.Font("Verdana", 9F);
            this.lblCnpj.Location = new System.Drawing.Point(166, 22);
            this.lblCnpj.Name = "lblCnpj";
            this.lblCnpj.Size = new System.Drawing.Size(38, 14);
            this.lblCnpj.TabIndex = 13;
            this.lblCnpj.Text = "CNPJ";
            // 
            // txtCnpj
            // 
            this.txtCnpj.EstadosExibicaoPossiveis = new EstadoExibicao[] {
        EstadoExibicao.Visualizando,
        EstadoExibicao.Incluindo,
        EstadoExibicao.Alterando};
            this.txtCnpj.Font = new System.Drawing.Font("Verdana", 9F);
            this.txtCnpj.Location = new System.Drawing.Point(166, 39);
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(151, 22);
            this.txtCnpj.TabIndex = 12;
            // 
            // txtCpf
            // 
            this.txtCpf.EstadosExibicaoPossiveis = new EstadoExibicao[] {
        EstadoExibicao.Visualizando,
        EstadoExibicao.Incluindo,
        EstadoExibicao.Alterando};
            this.txtCpf.Font = new System.Drawing.Font("Verdana", 9F);
            this.txtCpf.Location = new System.Drawing.Point(9, 39);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(151, 22);
            this.txtCpf.TabIndex = 11;
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.EstadosExibicaoPossiveis = new EstadoExibicao[0];
            this.lblCpf.Font = new System.Drawing.Font("Verdana", 9F);
            this.lblCpf.Location = new System.Drawing.Point(6, 22);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(31, 14);
            this.lblCpf.TabIndex = 0;
            this.lblCpf.Text = "CPF";
            // 
            // groupEndereço
            // 
            this.groupEndereço.Controls.Add(this.lblCep);
            this.groupEndereço.Controls.Add(this.txtCep);
            this.groupEndereço.Controls.Add(this.lblCidade);
            this.groupEndereço.Controls.Add(this.lblEstado);
            this.groupEndereço.Controls.Add(this.txtEstado);
            this.groupEndereço.Controls.Add(this.txtCidade);
            this.groupEndereço.Controls.Add(this.txtBairro);
            this.groupEndereço.Controls.Add(this.lblBairro);
            this.groupEndereço.Controls.Add(this.lblComplemento);
            this.groupEndereço.Controls.Add(this.lblNumero);
            this.groupEndereço.Controls.Add(this.txtNumero);
            this.groupEndereço.Controls.Add(this.txtComplemento);
            this.groupEndereço.Controls.Add(this.txtLogradouro);
            this.groupEndereço.Controls.Add(this.lblLogradouro);
            this.groupEndereço.Font = new System.Drawing.Font("Verdana", 9F);
            this.groupEndereço.Location = new System.Drawing.Point(15, 299);
            this.groupEndereço.Name = "groupEndereço";
            this.groupEndereço.Size = new System.Drawing.Size(634, 164);
            this.groupEndereço.TabIndex = 11;
            this.groupEndereço.TabStop = false;
            this.groupEndereço.Text = "Endereço";
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.EstadosExibicaoPossiveis = new EstadoExibicao[0];
            this.lblCep.Font = new System.Drawing.Font("Verdana", 9F);
            this.lblCep.Location = new System.Drawing.Point(6, 106);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(32, 14);
            this.lblCep.TabIndex = 26;
            this.lblCep.Text = "CEP";
            // 
            // txtCep
            // 
            this.txtCep.EstadosExibicaoPossiveis = new EstadoExibicao[] {
        EstadoExibicao.Visualizando,
        EstadoExibicao.Incluindo,
        EstadoExibicao.Alterando};
            this.txtCep.Font = new System.Drawing.Font("Verdana", 9F);
            this.txtCep.Location = new System.Drawing.Point(9, 123);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(83, 22);
            this.txtCep.TabIndex = 25;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.EstadosExibicaoPossiveis = new EstadoExibicao[0];
            this.lblCidade.Font = new System.Drawing.Font("Verdana", 9F);
            this.lblCidade.Location = new System.Drawing.Point(317, 64);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(51, 14);
            this.lblCidade.TabIndex = 24;
            this.lblCidade.Text = "Cidade";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.EstadosExibicaoPossiveis = new EstadoExibicao[0];
            this.lblEstado.Font = new System.Drawing.Font("Verdana", 9F);
            this.lblEstado.Location = new System.Drawing.Point(569, 64);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(51, 14);
            this.lblEstado.TabIndex = 23;
            this.lblEstado.Text = "Estado";
            // 
            // txtEstado
            // 
            this.txtEstado.EstadosExibicaoPossiveis = new EstadoExibicao[] {
        EstadoExibicao.Visualizando,
        EstadoExibicao.Incluindo,
        EstadoExibicao.Alterando};
            this.txtEstado.Font = new System.Drawing.Font("Verdana", 9F);
            this.txtEstado.Location = new System.Drawing.Point(572, 81);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(56, 22);
            this.txtEstado.TabIndex = 22;
            // 
            // txtCidade
            // 
            this.txtCidade.EstadosExibicaoPossiveis = new EstadoExibicao[] {
        EstadoExibicao.Visualizando,
        EstadoExibicao.Incluindo,
        EstadoExibicao.Alterando};
            this.txtCidade.Font = new System.Drawing.Font("Verdana", 9F);
            this.txtCidade.Location = new System.Drawing.Point(320, 81);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(246, 22);
            this.txtCidade.TabIndex = 21;
            // 
            // txtBairro
            // 
            this.txtBairro.EstadosExibicaoPossiveis = new EstadoExibicao[] {
        EstadoExibicao.Visualizando,
        EstadoExibicao.Incluindo,
        EstadoExibicao.Alterando};
            this.txtBairro.Font = new System.Drawing.Font("Verdana", 9F);
            this.txtBairro.Location = new System.Drawing.Point(9, 81);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(305, 22);
            this.txtBairro.TabIndex = 19;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.EstadosExibicaoPossiveis = new EstadoExibicao[0];
            this.lblBairro.Font = new System.Drawing.Font("Verdana", 9F);
            this.lblBairro.Location = new System.Drawing.Point(6, 64);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(44, 14);
            this.lblBairro.TabIndex = 20;
            this.lblBairro.Text = "Bairro";
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.EstadosExibicaoPossiveis = new EstadoExibicao[0];
            this.lblComplemento.Font = new System.Drawing.Font("Verdana", 9F);
            this.lblComplemento.Location = new System.Drawing.Point(474, 22);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(94, 14);
            this.lblComplemento.TabIndex = 18;
            this.lblComplemento.Text = "Complemento";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.EstadosExibicaoPossiveis = new EstadoExibicao[0];
            this.lblNumero.Font = new System.Drawing.Font("Verdana", 9F);
            this.lblNumero.Location = new System.Drawing.Point(317, 22);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(56, 14);
            this.lblNumero.TabIndex = 17;
            this.lblNumero.Text = "Número";
            // 
            // txtNumero
            // 
            this.txtNumero.EstadosExibicaoPossiveis = new EstadoExibicao[] {
        EstadoExibicao.Visualizando,
        EstadoExibicao.Incluindo,
        EstadoExibicao.Alterando};
            this.txtNumero.Font = new System.Drawing.Font("Verdana", 9F);
            this.txtNumero.Location = new System.Drawing.Point(320, 39);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(151, 22);
            this.txtNumero.TabIndex = 16;
            // 
            // txtComplemento
            // 
            this.txtComplemento.EstadosExibicaoPossiveis = new EstadoExibicao[] {
        EstadoExibicao.Visualizando,
        EstadoExibicao.Incluindo,
        EstadoExibicao.Alterando};
            this.txtComplemento.Font = new System.Drawing.Font("Verdana", 9F);
            this.txtComplemento.Location = new System.Drawing.Point(477, 39);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(151, 22);
            this.txtComplemento.TabIndex = 15;
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.EstadosExibicaoPossiveis = new EstadoExibicao[] {
        EstadoExibicao.Visualizando,
        EstadoExibicao.Incluindo,
        EstadoExibicao.Alterando};
            this.txtLogradouro.Font = new System.Drawing.Font("Verdana", 9F);
            this.txtLogradouro.Location = new System.Drawing.Point(9, 39);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(305, 22);
            this.txtLogradouro.TabIndex = 12;
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.EstadosExibicaoPossiveis = new EstadoExibicao[0];
            this.lblLogradouro.Font = new System.Drawing.Font("Verdana", 9F);
            this.lblLogradouro.Location = new System.Drawing.Point(6, 22);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(80, 14);
            this.lblLogradouro.TabIndex = 14;
            this.lblLogradouro.Text = "Logradouro";
            // 
            // btnConsultar
            // 
            this.btnConsultar.EstadosExibicaoPossiveis = new EstadoExibicao[] {
        EstadoExibicao.Visualizando};
            this.btnConsultar.Font = new System.Drawing.Font("Verdana", 9F);
            this.btnConsultar.Location = new System.Drawing.Point(229, 469);
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
            this.btnSalvar.Location = new System.Drawing.Point(122, 469);
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
            this.btnInserir.Location = new System.Drawing.Point(15, 469);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(101, 23);
            this.btnInserir.TabIndex = 12;
            this.btnInserir.Text = "&Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(663, 505);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.groupEndereço);
            this.Controls.Add(this.groupDocumentos);
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
            this.groupDocumentos.ResumeLayout(false);
            this.groupDocumentos.PerformLayout();
            this.groupEndereço.ResumeLayout(false);
            this.groupEndereço.PerformLayout();
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
        private Label lblRazaoSocial;
        private TextBox txtRazaoSocial;
        private TextBox txtNome;
        private Label label1;
        private TextBox txtCodigoFornecedor;
        private Label lblCodigoFornecedor;
        private GroupBox groupDocumentos;
        private Label lblCnpj;
        private TextBox txtCnpj;
        private TextBox txtCpf;
        private Label lblCpf;
        private GroupBox groupEndereço;
        private Label lblLogradouro;
        private Label lblEstado;
        private TextBox txtEstado;
        private TextBox txtCidade;
        private TextBox txtBairro;
        private Label lblBairro;
        private Label lblComplemento;
        private Label lblNumero;
        private TextBox txtNumero;
        private TextBox txtComplemento;
        private TextBox txtLogradouro;
        private Label lblCidade;
        private Label lblCep;
        private TextBox txtCep;
        private Button btnConsultar;
        private Button btnSalvar;
        private Button btnInserir;
    }
}
