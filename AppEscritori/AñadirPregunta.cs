using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEscritori
{
    public partial class AñadirPregunta : Form
    {
        ConfigurarPreguntas confpreguntas;
        public AñadirPregunta()
        {
            InitializeComponent();

        }
        public AñadirPregunta(ConfigurarPreguntas confpreguntas)
        {
            InitializeComponent();
            this.confpreguntas = confpreguntas;
        }

        private void buttonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
            this.confpreguntas.Show();
        }
    }
}
