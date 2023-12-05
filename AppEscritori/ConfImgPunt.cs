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
        ConfJuego confJuego;
        int dificulty;
        string range;
        string extension = "";
        public ConfImgPunt()
        {
            InitializeComponent();
        }
        public ConfImgPunt(ConfJuego confJuego)
        {
            InitializeComponent();
            this.confJuego = confJuego;
        }

        private void button2Enrere_Click(object sender, EventArgs e)
        {

            this.Close();
            this.confJuego.Show();
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
                extension = Path.GetExtension(filePath);
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

        private void comboBoxDifs_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dictionary<string, int> dificultades = new Dictionary<string, int>
                {
                    { "Fácil", 1 },
                    { "Normal", 2 },
                    { "Difícil", 3 }
                };

            if (comboBoxDifs.SelectedItem != null && dificultades.TryGetValue(comboBoxDifs.SelectedItem.ToString(), out int result))
            {
                dificulty = result;
            }

        }
        private void GuardarImagenEnNuevaRuta(string rutaOriginal, string nuevoNombre)
        {
            try
            {
                // Cargar la imagen desde la ruta original
                Image imagen = pictureBox1.Image;

                // Construir la ruta completa para la nueva imagen
                string rutaCompletaNuevaImagen = Path.Combine(rutaOriginal, nuevoNombre);

                // Guardar la imagen en la nueva ruta con el nuevo nombre
                imagen.Save(rutaCompletaNuevaImagen);

                // Puedes mostrar un mensaje o realizar otras acciones después de guardar la imagen
                MessageBox.Show("Imagen guardada con éxito en: " + rutaCompletaNuevaImagen);


            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir al intentar guardar la imagen
                MessageBox.Show("Error al guardar la imagen: " + ex.Message);
            }
        }

        private void button3ConfirmarCanvis_Click(object sender, EventArgs e)
        {

            if (pictureBox1.Image != null && extension != "")
            {
                // Asegúrate de que se haya seleccionado una ruta y un nombre antes de intentar guardar
                if (!string.IsNullOrEmpty(textBoxRuta.Text))
                {
                    if (dificulty == 1 || dificulty == 2 || dificulty == 3)
                    {
                        string rutaOriginal = textBoxRuta.Text; // Puedes obtener la ruta original de donde seleccionaste la imagen
                        string nuevoNombre = changeImgName(); // Agrega la extensión deseada

                        // Llama al método para guardar la imagen en la nueva ruta con el nuevo nombre
                        GuardarImagenEnNuevaRuta(rutaOriginal, nuevoNombre);
                    }
                    else
                    {
                      MessageBox.Show("Selecciona una dificultad.");
                    }

                }
                else
                {
                    MessageBox.Show("Selecciona una ruta");
                }
            }
            else
            {
                MessageBox.Show("No hay ninguna imagen para guardar.");
            }
        }

        private string changeImgName()
        {
            string imgName= "";
            range = GetSelectedRadioButtonText();

            switch(range) 
            {
                case "0-4":
                    imgName = "assignedVehicle04";
                    break;
                case "5-8":
                    imgName = "assignedVehicle58";
                    break;
                case "9-12":
                    imgName = "assignedVehicle912";
                    break;
                case "13-16":
                    imgName = "assignedVehicle1316";
                    break;
                case "17-20":
                    imgName = "assignedVehicle1728";
                    break;

            }

            switch (dificulty)
            {
                case 1:
                    imgName = imgName + "EASY" + extension;
                    break;
                case 2:
                    imgName = imgName + "NORMAL" + extension;
                    break;
                case 3:
                    imgName = imgName + "HARD" + extension;
                    break;
            }
            return imgName;
        }

        private string GetSelectedRadioButtonText()
        {
            foreach (Control control in groupBoxResultat.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    // Retorna el texto del RadioButton seleccionado
                    return radioButton.Text;
                }
            }
            // Retorna una cadena vacía si no se encuentra ningún RadioButton seleccionado
            return string.Empty;
        }


    }
}
