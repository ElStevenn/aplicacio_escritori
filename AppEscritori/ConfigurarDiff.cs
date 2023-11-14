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
    public partial class ConfigurarDiff : Form
    {
        ConfJuego confjuego;
        public ConfigurarDiff()
        {
            InitializeComponent();
        }
        public ConfigurarDiff(ConfJuego confjuego)
        {
            InitializeComponent();
            this.confjuego = confjuego;
        }

        private void button_atras13_Click(object sender, EventArgs e)
        {
            this.Close();
            this.confjuego.Show();
        }
    }
}
