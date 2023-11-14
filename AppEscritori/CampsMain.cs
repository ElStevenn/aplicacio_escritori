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
    public partial class CampsMain : Form
    {
        Menu menu;
        public CampsMain()
        {
            InitializeComponent();
        }
        public CampsMain(Menu menu)
        {
            InitializeComponent();
            this.menu = menu;
        }


        private void buttonSiguiente_Click(object sender, EventArgs e)
        {
            Camps camps = new ();
            camps.Show();
            this.Hide();
        }

        private void buttonAtras_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();

        }
    }
}
