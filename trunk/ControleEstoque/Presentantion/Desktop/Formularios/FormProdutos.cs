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
    public partial class FormProdutos : Desktop.Controles.FormularioBase
    {
        #region Campos e Propriedades

        private Produto _entidade;
        public Produto Entidade
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
        
        public FormProdutos()
        {
            InitializeComponent();

            this.PreencherCombos();

            this.EstadoExibicaoAtual = EstadoExibicao.Visualizando;
            this.Entidade = null;
        }

        private void btnConversoes_Click(object sender, EventArgs e)
        {
            FormProdutosConversoes conversoes = new FormProdutosConversoes();
            conversoes.ShowDialog();
        }

        private void PreencherEntidade()
        {
            if (this.Entidade == null || this.EstadoExibicaoAtual == EstadoExibicao.Incluindo)
                this.Entidade = new Produto();

            this.Entidade.Codigo = txtCodigo.Text;
            this.Entidade.Inativo = chkInativo.Checked;
            this.Entidade.Descricao = txtDescricao.Text;
            this.Entidade.UnidadeEstoque = cbUnidadeEstoque.SelectedValue.ToString();
            this.Entidade.UnidadeCompra = cbUnidadeCompra.SelectedValue.ToString();
            this.Entidade.UnidadeVenda = cbUnidadeVenda.SelectedValue.ToString();
        }

        private void PreencherFormulario()
        {
            this.txtCodigo.Text = this.Entidade.Codigo;
            this.chkInativo.Checked = this.Entidade.Inativo;
            this.txtDescricao.Text = this.Entidade.Descricao;
            this.cbUnidadeEstoque.SelectedValue = this.Entidade.UnidadeEstoque;
            this.cbUnidadeCompra.SelectedValue = this.Entidade.UnidadeCompra;
            this.cbUnidadeVenda.SelectedValue = this.Entidade.UnidadeVenda;
            this.txtUsuarioInclusao.Text = this.Entidade.UsuarioInclusao;
            this.txtDataInclusao.Text = this.Entidade.DataInclusao.ToString();
            this.txtUsuarioAlteracao.Text = this.Entidade.UsuarioAlteracao;
            this.txtDataAlteracao.Text = this.Entidade.DataAlteracao.ToString();
        }

        private void PreencherCombos()
        {
            ServicoClient client = new ServicoClient();

            try
            {
                Unidade[] unidadesEstoque = client.ObterListaUnidades();
                Unidade[] unidadesCompra = (Unidade[])unidadesEstoque.Clone();
                Unidade[] unidadesVenda = (Unidade[])unidadesEstoque.Clone();

                this.cbUnidadeEstoque.DataSource = unidadesEstoque;
                this.cbUnidadeEstoque.DisplayMember = "Descricao";
                this.cbUnidadeEstoque.ValueMember = "Codigo";
                this.cbUnidadeEstoque.SelectedIndex = -1;

                this.cbUnidadeCompra.DataSource = unidadesCompra;
                this.cbUnidadeCompra.DisplayMember = "Descricao";
                this.cbUnidadeCompra.ValueMember = "Codigo";
                this.cbUnidadeCompra.SelectedIndex = -1;

                this.cbUnidadeVenda.DataSource = unidadesVenda;
                this.cbUnidadeVenda.DisplayMember = "Descricao";
                this.cbUnidadeVenda.ValueMember = "Codigo";
                this.cbUnidadeVenda.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Produto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.EstadoExibicaoAtual = EstadoExibicao.Incluindo;

            this.LimparFormulario();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ServicoClient client = new ServicoClient();
            Produto produto;

            this.PreencherEntidade();

            try
            {
                produto = this.Entidade;

                if (this.EstadoExibicaoAtual == EstadoExibicao.Incluindo)
                    client.InserirProduto(ref produto);
                else
                    client.AlterarProduto(ref produto);

                this.Entidade = produto;
                this.PreencherFormulario();

                this.EstadoExibicaoAtual = EstadoExibicao.Visualizando;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Produto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }
    }
}
