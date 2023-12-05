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

        private void button1SeleccionarImatge_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif;*.bmp|Todos los archivos|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Obtiene la ruta del archivo seleccionado
                string filePath = openFileDialog.FileName;

                // Carga la imagen en el PictureBox
                pictureBox1.Image = Image.FromFile(filePath);
            }
        }

        private void buttonBuscarRuta_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            DialogResult result = folder.ShowDialog();
            if (result.Equals(DialogResult.OK))
            {
                textBoxRuta.Text = folder.SelectedPath;
            }
        }
    }
}
