using System.Drawing;

namespace Desktop
{
    public class DataGridView : System.Windows.Forms.DataGridView
    {
        private EstadoExibicao[] _estadosExibicaoPossiveis;
        public EstadoExibicao[] EstadosExibicaoPossiveis
        {
            get { return _estadosExibicaoPossiveis; }
            set { _estadosExibicaoPossiveis = value; }
        }

        public DataGridView()
        {
            this.Font = new Font("Verdana", 9);
            //this.EstadosExibicaoPossiveis = new EstadoExibicao[] { };
        }
    }
}
