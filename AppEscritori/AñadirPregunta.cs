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

        private void labelIncorrecta_Click(object sender, EventArgs e)
        {

        }


        private void AñadirPregunta_Load(object sender, EventArgs e)
        {

        }

        private void textBoxPregunta_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAnadir_Click(object sender, EventArgs e)
        {

        }

        private void textBoxIncorr1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
