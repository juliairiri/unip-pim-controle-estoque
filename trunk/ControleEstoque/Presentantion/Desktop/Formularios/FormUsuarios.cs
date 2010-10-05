using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.ServiceModel;

using Desktop.Servico;
using Entidades;

namespace Desktop.Formularios
{
    public partial class FormUsuarios : Desktop.Controles.FormularioBase
    {
        #region Campos e Propriedades

        private Usuario _entidade;
        public Usuario Entidade
        {
            get { return _entidade; }
            set { _entidade = value; }
        }

        #endregion

        #region Construtor

        public FormUsuarios()
        {
            InitializeComponent();

            this.ConfigurarControles();
            this.EstadoExibicaoAtual = EstadoExibicao.Visualizando;
        }

        #endregion

        #region Métodos Diversos

        public override void ConfigurarControles()
        {
            this.txtCodigo.EstadosExibicaoPossiveis = new EstadoExibicao[] { EstadoExibicao.Incluindo };
            this.txtNome.EstadosExibicaoPossiveis = new EstadoExibicao[] { EstadoExibicao.Visualizando, EstadoExibicao.Incluindo, EstadoExibicao.Alterando };
            this.chkAtivo.EstadosExibicaoPossiveis = new EstadoExibicao[] { EstadoExibicao.Visualizando, EstadoExibicao.Incluindo, EstadoExibicao.Alterando };
            this.btnInserir.EstadosExibicaoPossiveis = new EstadoExibicao[] { EstadoExibicao.Visualizando };
            this.btnSalvar.EstadosExibicaoPossiveis = new EstadoExibicao[] { EstadoExibicao.Incluindo, EstadoExibicao.Alterando };
            this.btnExcluir.EstadosExibicaoPossiveis = new EstadoExibicao[] { EstadoExibicao.Visualizando };
            this.btnConsultar.EstadosExibicaoPossiveis = new EstadoExibicao[] { EstadoExibicao.Visualizando };
        }

        private void PreencherEntidade()
        {
            if (this.Entidade == null)
                this.Entidade = new Usuario();

            this.Entidade.Codigo = txtCodigo.Text;
            this.Entidade.Ativo = chkAtivo.Checked;
            this.Entidade.Nome = txtNome.Text;
        }

        #endregion

        #region Eventos

        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.EstadoExibicaoAtual = EstadoExibicao.Incluindo;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ServicoClient client = new ServicoClient();
            Usuario usuario;

            this.PreencherEntidade();

            try
            {
                usuario = this.Entidade;

                if (this.EstadoExibicaoAtual == EstadoExibicao.Incluindo)
                    client.InserirUsuario(ref usuario);
                else
                    client.AlterarUsuario(ref usuario);

                this.EstadoExibicaoAtual = EstadoExibicao.Visualizando;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Usuários", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ServicoClient client = new ServicoClient();

            try
            {
                client.DeletarUsuario(this.Entidade);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Usuários", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ServicoClient client = new ServicoClient();

            this.Entidade = client.ObterUsuarioPorCodigo("dsilva");

            if (this.Entidade != null)
            {
                txtCodigo.Text = this.Entidade.Codigo;
                chkAtivo.Checked = this.Entidade.Ativo;
                txtNome.Text = this.Entidade.Nome;

                this.EstadoExibicaoAtual = EstadoExibicao.Visualizando;
            }
        }

        #endregion
    }
}