using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Desktop.Servico;
using Entidades;

namespace Desktop.Formularios
{
    public partial class FormAutenticacao : Desktop.Controles.FormularioBase
    {
        private bool _autenticado;
        public bool Autenticado
        {
            get { return _autenticado; }
            set { _autenticado = value; }
        }

        private Entidades.Usuario _usuarioAutenticado;
        public Entidades.Usuario UsuarioAutenticado
        {
            get { return _usuarioAutenticado; }
            set { _usuarioAutenticado = value; }
        }

        public FormAutenticacao()
        {
            InitializeComponent();

            this.ConfigurarControles();
            this.EstadoExibicaoAtual = EstadoExibicao.Visualizando;
        }

        public override void ConfigurarControles()
        {
            this.txtUsuario.EstadosExibicaoPossiveis = new EstadoExibicao[] { EstadoExibicao.Visualizando, EstadoExibicao.Alterando, EstadoExibicao.Incluindo };
            this.txtSenha.EstadosExibicaoPossiveis = new EstadoExibicao[] { EstadoExibicao.Visualizando, EstadoExibicao.Alterando, EstadoExibicao.Incluindo };
            this.btnOk.EstadosExibicaoPossiveis = new EstadoExibicao[] { EstadoExibicao.Visualizando, EstadoExibicao.Alterando, EstadoExibicao.Incluindo };
            this.btnCancelar.EstadosExibicaoPossiveis = new EstadoExibicao[] { EstadoExibicao.Visualizando, EstadoExibicao.Alterando, EstadoExibicao.Incluindo };
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            ServicoClient client = new ServicoClient();

            try
            {
                Entidades.Usuario usuario = client.Autenticar(txtUsuario.Text, txtSenha.Text);

                if (usuario != null)
                {
                    this.Autenticado = true;
                    this.UsuarioAutenticado = usuario;
                }
            }
            catch (Exception ex)
            {
                this.Autenticado = false;
                this.UsuarioAutenticado = null;

                MessageBox.Show(ex.Message, "Autenticação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
