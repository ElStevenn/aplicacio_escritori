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
    public partial class ConfImgPunt : Form
    {
        ConfigurarDiff configurarDiff;
        public ConfImgPunt()
        {
            InitializeComponent();
        }
        public ConfImgPunt(ConfigurarDiff configurarDiff)
        {
            InitializeComponent();
            this.configurarDiff = configurarDiff;
        }

        private void button2Enrere_Click(object sender, EventArgs e)
        {

            this.Close();
            this.configurarDiff.Show();
        }
    }
}
