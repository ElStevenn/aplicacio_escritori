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

        public CampsMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSiguiente_Click(object sender, EventArgs e)
        {
            Camps camps = new Camps();
            camps.Show();
            this.Hide();
        }

    }
}
