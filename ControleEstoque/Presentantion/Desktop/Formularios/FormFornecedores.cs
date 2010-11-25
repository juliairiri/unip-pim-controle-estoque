using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Entidades;
using Desktop.Servico;

namespace Desktop.Formularios
{
    public partial class FormFornecedores : Desktop.Controles.FormularioBase
    {
        #region Campos e Propriedades

        private Fornecedor _entidade;
        public Fornecedor Entidade
        {
            get { return _entidade; }
            set
            {
                _entidade = value;
                if (value == null)
                    this.EstadoExibicaoAtual = EstadoExibicao.Desabilitado;
            }
        }

        #endregion

        public FormFornecedores()
        {
            InitializeComponent();

            this.EstadoExibicaoAtual = EstadoExibicao.Visualizando;
            this.Entidade = null;

            this.PreencherCombos();
        }

        private void PreencherCombos()
        {
            cbTipo.DataSource = Enum.GetValues(typeof(TipoPessoa));
            cbTipo.SelectedIndex = -1;
        }

        private void PreencherEntidade()
        {
            if (this.Entidade == null || this.EstadoExibicaoAtual == EstadoExibicao.Incluindo)
                this.Entidade = new Fornecedor();

            long codigo;
            long codigoFornecedor;

            if (!long.TryParse(txtCodigo.Text, out codigo))
                codigo = 0;

            if (!long.TryParse(txtCodigoFornecedor.Text, out codigoFornecedor))
                codigoFornecedor = 0;

            this.Entidade.Codigo = codigo;
            this.Entidade.CodigoCliente = codigoFornecedor;
            this.Entidade.Tipo = (TipoPessoa)cbTipo.SelectedValue;
            this.Entidade.Nome = txtNome.Text;
            this.Entidade.RazaoSocial = lblRazaoSocial.Text;
            this.Entidade.Cpf = txtCpf.Text;
            this.Entidade.Cnpj = txtCnpj.Text;
            this.Entidade.Logradouro = txtLogradouro.Text;
            this.Entidade.Numero = txtNumero.Text;
            this.Entidade.Complemento = txtComplemento.Text;
            this.Entidade.Bairro = txtBairro.Text;
            this.Entidade.Cidade = txtCidade.Text;
            this.Entidade.Estado = txtEstado.Text;
            this.Entidade.Cep = txtCep.Text;
            this.Entidade.Inativo = chkInativo.Checked;
        }

        private void PreencherFormulario()
        {
            this.txtCodigo.Text = this.Entidade.Codigo.ToString();
            txtCodigoFornecedor.Text = this.Entidade.CodigoCliente.ToString();
            cbTipo.SelectedItem = this.Entidade.Tipo;
            txtNome.Text = this.Entidade.Nome;
            lblRazaoSocial.Text = this.Entidade.RazaoSocial;
            txtCpf.Text = this.Entidade.Cpf;
            txtCnpj.Text = this.Entidade.Cnpj;
            txtLogradouro.Text = this.Entidade.Logradouro;
            txtNumero.Text = this.Entidade.Numero;
            txtComplemento.Text = this.Entidade.Complemento;
            txtBairro.Text = this.Entidade.Bairro;
            txtCidade.Text = this.Entidade.Cidade;
            txtEstado.Text = this.Entidade.Estado;
            txtCep.Text = this.Entidade.Cep;
            this.chkInativo.Checked = this.Entidade.Inativo;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.EstadoExibicaoAtual = EstadoExibicao.Incluindo;

            this.LimparFormulario();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ServicoClient client = new ServicoClient();
            Fornecedor fornecedor;

            this.PreencherEntidade();

            try
            {
                fornecedor = this.Entidade;

                if (this.EstadoExibicaoAtual == EstadoExibicao.Incluindo)
                    client.InserirFornecedor(ref fornecedor);
                else
                    client.AlterarFornecedor(ref fornecedor);

                this.Entidade = fornecedor;

                this.PreencherFormulario();

                this.EstadoExibicaoAtual = EstadoExibicao.Visualizando;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fornecedor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipo.SelectedValue != null)
            {
                TipoPessoa tipo = (TipoPessoa)cbTipo.SelectedValue;

                if (tipo == TipoPessoa.Fisica)
                {
                    txtRazaoSocial.Enabled = false;
                    txtCnpj.Enabled = false;
                    txtCpf.Enabled = true;
                }
                else if (tipo == TipoPessoa.Juridica)
                {
                    txtRazaoSocial.Enabled = true;
                    txtCnpj.Enabled = true;
                    txtCpf.Enabled = false;
                }

            }
        }
    }
}
