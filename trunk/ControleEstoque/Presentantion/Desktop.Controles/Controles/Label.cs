using System.Drawing;

namespace Desktop
{
    public class Label : System.Windows.Forms.Label
    {
        private EstadoExibicao[] _estadosExibicaoPossiveis;
        public EstadoExibicao[] EstadosExibicaoPossiveis
        {
            get { return _estadosExibicaoPossiveis; }
            set { _estadosExibicaoPossiveis = value; }
        }

        public Label()
        {
            this.Font = new Font("Verdana", 9);
            this.EstadosExibicaoPossiveis = new EstadoExibicao[] { };
        }
    }
}
