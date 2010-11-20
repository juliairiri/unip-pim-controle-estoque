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
    public partial class FormUnidades : Desktop.Controles.FormularioBase
    {
        #region Campos e Propriedades

        private Unidade _entidade;
        public Unidade Entidade
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

        public FormUnidades()
        {
            InitializeComponent();

            this.EstadoExibicaoAtual = EstadoExibicao.Visualizando;
            this.Entidade = null;
        }

        private void PreencherEntidade()
        {
            if (this.Entidade == null || this.EstadoExibicaoAtual == EstadoExibicao.Incluindo)
                this.Entidade = new Unidade();

            this.Entidade.Codigo = txtCodigo.Text;
            this.Entidade.Inativo = chkInativo.Checked;
            this.Entidade.Descricao = txtDescricao.Text;
        }

        private void PreencherFormulario()
        {
            this.txtCodigo.Text = this.Entidade.Codigo;
            this.chkInativo.Checked = this.Entidade.Inativo;
            this.txtDescricao.Text = this.Entidade.Descricao;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.EstadoExibicaoAtual = EstadoExibicao.Incluindo;

            this.LimparFormulario();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ServicoClient client = new ServicoClient();
            Unidade unidade;

            this.PreencherEntidade();

            try
            {
                unidade = this.Entidade;

                if (this.EstadoExibicaoAtual == EstadoExibicao.Incluindo)
                    client.InserirUnidade(ref unidade);
                else
                    client.AlterarUnidade(ref unidade);

                this.EstadoExibicaoAtual = EstadoExibicao.Visualizando;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Unidade de Medida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
