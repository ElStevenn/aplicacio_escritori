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
    public partial class ModificarElemento : Form
    {
        public ModificarElemento()
        {
            InitializeComponent();
        }

        private void buttonAtras_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            Gestor_museo gestorMuseo = GestionarParteMuseo.Gestor_museo.Instance; ;
            CampsMain menu = new CampsMain(gestorMuseo);
            menu.Show();
            this.Hide();
        }
    }
}
