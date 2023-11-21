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
    public partial class Camps : Form
    {
        public Camps()
        {
            InitializeComponent();
        }

        private void button2Siguiente_Click(object sender, EventArgs e)
        {
            CampsFinal campsFinal = new CampsFinal();
            campsFinal.Show();
            this.Hide();
        }

        private void button1Enrere_Click(object sender, EventArgs e)
        {
            CampsMain campsMain = new CampsMain();
            campsMain.Show();
            this.Hide();
        }

        private void textBox1Autonomia_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
