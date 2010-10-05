using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Desktop.Controles
{
    public partial class FormularioBase : Form
    {
        private EstadoExibicao _estadoExibicaoAtual;
        public EstadoExibicao EstadoExibicaoAtual
        {
            get { return _estadoExibicaoAtual; }
            set 
            { 
                _estadoExibicaoAtual = value; 
                this.OnEstadoExibicaoChange(); 
            }
        }

        public FormularioBase()
        {
            InitializeComponent();

            this.EstadoExibicaoAtual = EstadoExibicao.Visualizando;
        }

        private void OnEstadoExibicaoChange()
        {
            foreach (Control controle in this.Controls)
            {
                if (controle is Desktop.Button)
                {
                    Desktop.Button botao = controle as Desktop.Button;
                    if (botao.EstadosExibicaoPossiveis != null)
                    {
                        if (botao.EstadosExibicaoPossiveis.Contains(EstadoExibicaoAtual))
                            botao.Enabled = true;
                        else
                            botao.Enabled = false;
                    }
                }
                else if (controle is Desktop.CheckBox)
                {
                    Desktop.CheckBox checkbox = controle as Desktop.CheckBox;
                    if (checkbox.EstadosExibicaoPossiveis != null)
                    {
                        if (checkbox.EstadosExibicaoPossiveis.Contains(EstadoExibicaoAtual))
                            checkbox.Enabled = true;
                        else
                            checkbox.Enabled = false;
                    }
                }
                else if (controle is Desktop.ComboBox)
                {
                    Desktop.ComboBox combobox = controle as Desktop.ComboBox;
                    if (combobox.EstadosExibicaoPossiveis != null)
                    {
                        if (combobox.EstadosExibicaoPossiveis.Contains(EstadoExibicaoAtual))
                            combobox.Enabled = true;
                        else
                            combobox.Enabled = false;
                    }
                }
                else if (controle is Desktop.DataGridView)
                {
                    Desktop.DataGridView datagrid = controle as Desktop.DataGridView;
                    if (datagrid.EstadosExibicaoPossiveis != null)
                    {
                        if (datagrid.EstadosExibicaoPossiveis.Contains(EstadoExibicaoAtual))
                            datagrid.Enabled = true;
                        else
                            datagrid.Enabled = false;
                    }
                }
                else if (controle is Desktop.Label)
                {
                    Desktop.Label label = controle as Desktop.Label;
                    if (label.EstadosExibicaoPossiveis != null)
                    {
                        if (label.EstadosExibicaoPossiveis.Contains(EstadoExibicaoAtual))
                            label.Enabled = true;
                        else
                            label.Enabled = false;
                    }
                }
                else if (controle is Desktop.TextBox)
                {
                    Desktop.TextBox textbox = controle as Desktop.TextBox;
                    if (textbox.EstadosExibicaoPossiveis != null)
                    {
                        if (textbox.EstadosExibicaoPossiveis.Contains(EstadoExibicaoAtual))
                            textbox.Enabled = true;
                        else
                            textbox.Enabled = false;
                    }
                }
            }
        }

        public virtual void ConfigurarControles() { }
    }
}
