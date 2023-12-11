using System;
using Newtonsoft.Json;
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
    public partial class EliminarElemento : Form
    {

        public GestionarParteMuseo.Gestor_museo gestionadorMuseo;
        public string rutaArchivoJson_cat = @"..\..\..\JSON\elements_cat.json";
        public string rutaArchivoJson_esp = @"..\..\..\JSON\elements_esp.json";
        public string rutaArchivoJson_eng = @"..\..\..\JSON\elements_eng.json";

        public EliminarElemento()
        {
            InitializeComponent();
            ConfigurarComboBox();
        }


        public List<ElementoInventario> CargarDatosDesdeJson(string ruta)
        {
            string json = File.ReadAllText(ruta);
            return JsonConvert.DeserializeObject<List<ElementoInventario>>(json);
        }

        public void ConfigurarComboBox()
        {
            List<ElementoInventario> elementos = CargarDatosDesdeJson(rutaArchivoJson_cat);
            selecElemento.DataSource = elementos;
            selecElemento.DisplayMember = "nameElement";
        }



        private void buttonAtras_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }


        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            // Botón de eliminar el elemento

            // Comprovar si el elemento es correcto y eliminarlo

        }

        private void selecElemento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selecElemento.SelectedItem is ElementoInventario elementoSeleccionado)
            {
                string ruta_imagen = @"..\..\..\JSON\museu_images\" + elementoSeleccionado.image;
                nombreElemento.Text = elementoSeleccionado.nameElement;
                numInventario.Text = elementoSeleccionado.numInventory.ToString();
                fotoElemento.Image = Image.FromFile(ruta_imagen);
                fotoElemento.SizeMode = PictureBoxSizeMode.StretchImage;
                // Si quisieramos, podríamos añadir mas partes de nuestro elemento
            }
        }
    }
}
