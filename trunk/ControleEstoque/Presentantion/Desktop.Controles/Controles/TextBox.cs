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
            FormularioBase formulario = this.ObterFormularioBase();

            if (formulario.EstadoExibicaoAtual == EstadoExibicao.Visualizando)
                formulario.EstadoExibicaoAtual = EstadoExibicao.Alterando;

            base.OnTextChanged(e);
        }

        private FormularioBase ObterFormularioBase()
        {
            System.Windows.Forms.Control controle = this.Parent as System.Windows.Forms.Control;
            FormularioBase formulario = null;

            while (controle != null)
            {
                if (controle is FormularioBase)
                {
                    formulario = controle as FormularioBase;
                    break;
                }

                controle = controle.Parent as System.Windows.Forms.Control;
            }

            return formulario;
        }

    }
}
