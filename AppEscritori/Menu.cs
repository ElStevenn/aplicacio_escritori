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
    public partial class Menu : Form
    {
        Login login;
        public Menu()
        {
            InitializeComponent();
        }
        public Menu(Login login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void buttonCrearElemento_Click(object sender, EventArgs e)
        {
            CampsMain campsMain = new CampsMain(this);
            campsMain.Show();
            this.Hide();

        }

        private void cambiarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            this.login.Show();
        }
    }
}
