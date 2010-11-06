using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Desktop.Formularios
{
    public partial class FormProdutos : Desktop.Controles.FormularioBase
    {
        public FormProdutos()
        {
            InitializeComponent();
        }

        private void btnConversoes_Click(object sender, EventArgs e)
        {
            FormProdutosConversoes conversoes = new FormProdutosConversoes();
            conversoes.ShowDialog();
        }
    }
}
