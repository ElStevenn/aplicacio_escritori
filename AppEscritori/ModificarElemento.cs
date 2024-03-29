﻿using Newtonsoft.Json;
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
        // public string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

        // Estas rutas se establecerán correctamente en tiempo de ejecución
        public string rutaArchivoJson_cat;
        public string rutaArchivoJson_esp;
        public string rutaArchivoJson_eng;
        public string rutaImagenes;

        public ModificarElemento()
        {
            InitializeComponent();
            ConfigurarRutas();
            cconfigurarTextos();
            ConfigurarComboBox();
        }


        public ModificarElemento(Gestor_museo gestor_Museo)
        {
            InitializeComponent();
            this.gestionadorMuseo = gestor_Museo;
            ConfigurarRutas();
            ConfigurarComboBox();
            cconfigurarTextos();
        }

        private void ConfigurarRutas()
        {
            // Obtener la ruta del directorio donde se ejecuta el proyecto (normalmente la raíz del proyecto en desarrollo)
            string projectRoot = AppDomain.CurrentDomain.BaseDirectory;
            rutaArchivoJson_cat = Path.Combine(projectRoot, "JSON", "elements_cat.json");
            rutaArchivoJson_esp = Path.Combine(projectRoot, "JSON", "elements_esp.json");
            rutaArchivoJson_eng = Path.Combine(projectRoot, "JSON", "elements_eng.json");
            rutaImagenes = Path.Combine(projectRoot, "JSON", "imgelements");
        }


        public List<ElementoInventario> CargarDatosDesdeJson(string ruta)
        {
            if (string.IsNullOrEmpty(ruta))
            {
                throw new ArgumentException("La ruta del archivo no puede ser nula o vacía.", nameof(ruta));
            }

            string json = File.ReadAllText(ruta);
            return JsonConvert.DeserializeObject<List<ElementoInventario>>(json);
        }

        public void cconfigurarTextos()
        {
            if (this.gestionadorMuseo != null)
            {
                labnumInventario.Text = this.gestionadorMuseo.numeroInventario.ToString();
                ano_creacion.Text = this.gestionadorMuseo.anoCreacion.ToString();
            }
            else
            {
                labnumInventario.Text = "";
                ano_creacion.Text = "";
            }

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
                string ruta_imagen = Path.Combine(rutaImagenes, elementoSeleccionado.image);
                Console.WriteLine("Ruta de imagen intentada: " + ruta_imagen);

                if (File.Exists(ruta_imagen))
                {
                    foto_elemento.Image = Image.FromFile(ruta_imagen);
                    foto_elemento.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    MessageBox.Show("El archivo de imagen no se encontró en la ruta: " + ruta_imagen, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
                string rutaElemento = Path.Combine(rutaImagenes, elementoSeleccionado.image);
                gestorMuseo.actualizar_ruta_imagen(rutaElemento);


                CampsMain menu = new CampsMain(gestorMuseo);
                menu.Show();
                this.Hide();
            }

        }

    }
}
