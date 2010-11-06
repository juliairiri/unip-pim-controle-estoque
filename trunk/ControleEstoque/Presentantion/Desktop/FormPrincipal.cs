using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Desktop.Formularios;

namespace Desktop
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void mnUsuarios_Click(object sender, EventArgs e)
        {
            FormUsuarios usuarios = new FormUsuarios();
            usuarios.MdiParent = this;
            usuarios.Show();
        }

        private void FormPrincipal_Shown(object sender, EventArgs e)
        {
            bool autenticado = false;
            
            FormAutenticacao autenticacao = new FormAutenticacao();

            if (autenticacao.ShowDialog() == DialogResult.OK)
            {
                if (autenticacao.Autenticado)
                {
                    autenticado = true;
                    Contexto.Usuario = autenticacao.UsuarioAutenticado;
                }
            }

            if (!autenticado)
            {
                this.Close();
            }
        }

        private void mnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnProdutos_Click(object sender, EventArgs e)
        {
            FormProdutos produtos = new FormProdutos();
            produtos.MdiParent = this;
            produtos.Show();
        }

        private void mnMedidas_Click(object sender, EventArgs e)
        {
            FormUnidades unidades = new FormUnidades();
            unidades.MdiParent = this;
            unidades.Show();
        }

        private void mnLocaisEstoque_Click(object sender, EventArgs e)
        {
            FormLocaisEstoque locais = new FormLocaisEstoque();
            locais.MdiParent = this;
            locais.Show();
        }
    }
}
