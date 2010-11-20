using System.Drawing;

using Desktop.Controles;

namespace Desktop
{
    public class ComboBox : System.Windows.Forms.ComboBox
    {
        private EstadoExibicao[] _estadosExibicaoPossiveis;
        public EstadoExibicao[] EstadosExibicaoPossiveis
        {
            get { return _estadosExibicaoPossiveis; }
            set { _estadosExibicaoPossiveis = value; }
        }

        public ComboBox()
        {
            this.Font = new Font("Verdana", 9);
            //this.EstadosExibicaoPossiveis = new EstadoExibicao[] { };
        }

        protected override void OnSelectedIndexChanged(System.EventArgs e)
        {
            FormularioBase formulario = this.ObterFormularioBase();

            if (formulario != null)
                if (formulario.EstadoExibicaoAtual == EstadoExibicao.Visualizando)
                    formulario.EstadoExibicaoAtual = EstadoExibicao.Alterando;

            base.OnSelectedIndexChanged(e);
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
