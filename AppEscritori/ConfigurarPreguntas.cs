using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AppEscritori
{
    public partial class ConfigurarPreguntas : Form
    {
        ConfJuego confjuego;
        public ConfigurarPreguntas()
        {
            InitializeComponent();
        }
        public ConfigurarPreguntas(ConfJuego configpreguntes)
        {
            InitializeComponent();
            this.confjuego = confjuego;
        }

        private void buttonAnadir_Click(object sender, EventArgs e)
        {
            AñadirPregunta añadirPreg = new AñadirPregunta(this);
            añadirPreg.Show();
            this.Hide();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            ModificarPregunta modificarPreg = new ModificarPregunta(this);
            modificarPreg.Show();
            this.Hide();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            EliminarPregunta eliminarPreg = new EliminarPregunta(this);
            eliminarPreg.Show();
            this.Hide();
        }
    }
}
