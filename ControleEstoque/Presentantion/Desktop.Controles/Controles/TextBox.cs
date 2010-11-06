using System.Drawing;

using Desktop.Controles;

namespace Desktop
{
    public class TextBox : System.Windows.Forms.TextBox
    {
        private EstadoExibicao[] _estadosExibicaoPossiveis;
        public EstadoExibicao[] EstadosExibicaoPossiveis
        {
            get { return _estadosExibicaoPossiveis; }
            set { _estadosExibicaoPossiveis = value; }
        }

        public TextBox()
        {
            this.Font = new Font("Verdana", 9);
            //this.EstadosExibicaoPossiveis = new EstadoExibicao[] { };
        }

        protected override void OnTextChanged(System.EventArgs e)
        {
            FormularioBase formulario = this.Parent as FormularioBase;

            if (formulario.EstadoExibicaoAtual == EstadoExibicao.Visualizando)
                formulario.EstadoExibicaoAtual = EstadoExibicao.Alterando;

            base.OnTextChanged(e);
        }
    }
}
