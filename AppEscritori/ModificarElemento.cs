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
            Camps menu = new ();
            menu.Show();
            this.Hide();
        }
    }
}
