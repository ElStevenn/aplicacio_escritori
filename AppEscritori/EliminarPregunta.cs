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
    public partial class EliminarPregunta : Form
    {
        ConfigurarPreguntas confpreguntas;
        public EliminarPregunta()
        {
            InitializeComponent();
        }
        public EliminarPregunta(ConfigurarPreguntas confpreguntas)
        {
            InitializeComponent();
            this.confpreguntas = confpreguntas;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1Enrere_Click(object sender, EventArgs e)
        {
            this.Close();
            this.confpreguntas.Show();
        }

        private void EliminarPregunta_Load(object sender, EventArgs e)
        {

        }
    }
}
