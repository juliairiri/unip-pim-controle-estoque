using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Desktop.Servico;

namespace Desktop.Formularios
{
    public partial class FormUsuariosAlterarSenha : Desktop.Controles.FormularioBase
    {
        public FormUsuariosAlterarSenha()
        {
            InitializeComponent();

            this.ConfigurarControles();
            this.EstadoExibicaoAtual = EstadoExibicao.Visualizando;
        }

        public override void ConfigurarControles()
        {
            this.txtSenha.EstadosExibicaoPossiveis = new EstadoExibicao[] { EstadoExibicao.Alterando, EstadoExibicao.Incluindo, EstadoExibicao.Visualizando };
            this.txtConfirmacao.EstadosExibicaoPossiveis = new EstadoExibicao[] { EstadoExibicao.Alterando, EstadoExibicao.Incluindo, EstadoExibicao.Visualizando };
            this.btnConfirmar.EstadosExibicaoPossiveis = new EstadoExibicao[] { EstadoExibicao.Alterando, EstadoExibicao.Incluindo, EstadoExibicao.Visualizando };
            this.btnCancelar.EstadosExibicaoPossiveis = new EstadoExibicao[] { EstadoExibicao.Alterando, EstadoExibicao.Incluindo, EstadoExibicao.Visualizando };
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (this.txtSenha.Text.Trim() == this.txtConfirmacao.Text.Trim())
            {
                if (!string.IsNullOrEmpty(this.txtSenha.Text))
                {
                    ServicoClient client = new ServicoClient();
                    Entidades.Usuario usuario = Contexto.Usuario;

                    try
                    {
                        client.AlterarSenha(ref usuario, this.txtSenha.Text);
                        Contexto.Usuario = usuario;

                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Alterar Senha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Informe a nova Senha", "Alterar Senha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Senha não confere", "Alterar Senha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
