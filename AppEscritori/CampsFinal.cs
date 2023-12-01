using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AppEscritori.GestionarParteMuseo;

namespace AppEscritori
{
    public partial class CampsFinal : Form
    {
        public CampsFinal()
        {
            InitializeComponent();
        }

        private void button_generar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Elemento guardado con éxito.");
            Menu menu = new Menu();
            menu.Show();
            this.Hide();

        }

        private void button_atras_Click(object sender, EventArgs e)
        {
            // Para volver atràs
            Camps camp = new Camps();
            camp.Show();
            this.Hide();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
