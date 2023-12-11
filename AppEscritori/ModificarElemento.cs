using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static AppEscritori.GestionarParteMuseo;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AppEscritori
{
    public partial class ModificarElemento : Form
    {
        public GestionarParteMuseo.Gestor_museo gestionadorMuseo;
        public string rutaArchivoJson_cat = @"..\..\..\JSON\elements_cat.json";
        public string rutaArchivoJson_esp = @"..\..\..\JSON\elements_esp.json";
        public string rutaArchivoJson_eng = @"..\..\..\JSON\elements_eng.json";

        public ModificarElemento()
        {
            InitializeComponent();
            ConfigurarComboBox();
        }

        public ModificarElemento(Gestor_museo gestor_Museo)
        {
            InitializeComponent();
            this.gestionadorMuseo = gestor_Museo;
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

        private void selecElemento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selecElemento.SelectedItem is ElementoInventario elementoSeleccionado)
            {
                string ruta_imagen = @"..\..\..\JSON\imgelements\" + elementoSeleccionado.image;
                labelNombreElemento.Text = elementoSeleccionado.nameElement;
                labnumInventario.Text = elementoSeleccionado.numInventory.ToString();
                foto_elemento.Image = Image.FromFile(ruta_imagen);
                foto_elemento.SizeMode = PictureBoxSizeMode.StretchImage;
                // Se podrían cargar mas elementos como se necesite
            }
        }

        public List<string> CargarCamposEngEsp(int numero_inventario)
        {
            // Función que se encarga de cargar los elementos en español y en inglés
            var elementosEsp = CargarDatosDesdeJson(rutaArchivoJson_esp);
            var elementosEng = CargarDatosDesdeJson(rutaArchivoJson_eng);


            var elementoBuscado_esp = elementosEsp.FirstOrDefault(e => e.numInventory == numero_inventario);
            var elementoBuscado_eng = elementosEng.FirstOrDefault(e => e.numInventory == numero_inventario);

            List<string> resultado = new List<string>();

            if (elementoBuscado_esp != null)
            {
                resultado.Add(elementoBuscado_esp.nameElement);
                resultado.Add(elementoBuscado_esp.description);
            }

            if (elementoBuscado_eng != null)
            {
                resultado.Add(elementoBuscado_eng.nameElement);
                resultado.Add(elementoBuscado_eng.description);
            }
            // return - (nombre_esp, desrp_esp, nombre_eng, descrp_eng)
            return resultado;
        }



        private void buttonAtras_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {


            if (selecElemento.SelectedItem is ElementoInventario elementoSeleccionado)
            {
                // aquí se le ponen todos los elementos a la classe
                Gestor_museo gestorMuseo = new Gestor_museo();
                gestorMuseo.modo_gestor = "editar"; // Pongo la referencia que está en modo editar


                gestorMuseo.actualizar_campos_main(elementoSeleccionado.nameElement, elementoSeleccionado.numInventory.ToString(), elementoSeleccionado.year.ToString(), elementoSeleccionado.description);
                gestorMuseo.actualizar_caracteristicas(elementoSeleccionado.autonomy.ToString(), elementoSeleccionado.disposalCapacity.ToString(), elementoSeleccionado.cicle, elementoSeleccionado.cilindrada.ToString(),
                    elementoSeleccionado.nameElement, elementoSeleccionado.wingspan.ToString(), elementoSeleccionado.potency.ToString(), elementoSeleccionado.kmsDone.ToString(), elementoSeleccionado.sostreMaximDeVol.ToString(),
                    elementoSeleccionado.weight.ToString(), elementoSeleccionado.speed.ToString(), elementoSeleccionado.maxSpeed.ToString(), elementoSeleccionado.energyfont, elementoSeleccionado.sourceIncome, elementoSeleccionado.fromIncome,
                    elementoSeleccionado.manufacturingPlace, elementoSeleccionado.lenght.ToString(), elementoSeleccionado.field.ToString());

                List<String> elelementos_eng_esp = CargarCamposEngEsp(elementoSeleccionado.numInventory);

                gestorMuseo.actualizar_campos_espeng(elelementos_eng_esp[0], elelementos_eng_esp[1], elelementos_eng_esp[2], elelementos_eng_esp[3]);
                // Añadir la ruta de la imagen -> 
                string ruta_elemento = @"..\..\..\JSON\imgelements\" + Path.GetFileName(elementoSeleccionado.image);
                gestorMuseo.actualizar_ruta_imagen(ruta_elemento);


                CampsMain menu = new CampsMain(gestorMuseo);
                menu.Show();
                this.Hide();
            }

        }

    }
}
