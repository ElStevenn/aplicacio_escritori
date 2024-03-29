﻿using System;
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
        public string rutaArchivoJson_cat;
        public string rutaArchivoJson_esp;
        public string rutaArchivoJson_eng;
        public string rutaImagenes;


        public EliminarElemento()
        {
            InitializeComponent();
            ConfigurarRutas();
            ConfigurarComboBox();
        }
        private void ConfigurarRutas()
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            rutaArchivoJson_cat = Path.Combine(baseDirectory, "JSON", "elements_cat.json");
            rutaArchivoJson_esp = Path.Combine(baseDirectory, "JSON", "elements_esp.json");
            rutaArchivoJson_eng = Path.Combine(baseDirectory, "JSON", "elements_eng.json");
            rutaImagenes = Path.Combine(baseDirectory, "JSON", "imgelements"); 
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
            if (selecElemento.SelectedItem is ElementoInventario elementoSeleccionado)
            {
                // Cargar las listas actuales de elementos desde los archivos JSON
                List<ElementoInventario> elementos_cat = CargarDatosDesdeJson(rutaArchivoJson_cat);
                List<ElementoInventario> elementos_esp = CargarDatosDesdeJson(rutaArchivoJson_esp);
                List<ElementoInventario> elementos_eng = CargarDatosDesdeJson(rutaArchivoJson_eng);

                // Función para eliminar un elemento por numInventario
                void EliminarElementoPorNumInventario(List<ElementoInventario> lista)
                {
                    var elementoAEliminar = lista.FirstOrDefault(e => e.numInventory == elementoSeleccionado.numInventory);
                    if (elementoAEliminar != null)
                    {
                        lista.Remove(elementoAEliminar);
                        if (fotoElemento.Image != null)
                        {
                            fotoElemento.Image.Dispose();
                            fotoElemento.Image = null;
                        }

                        // Eliminar la imagen del sistema de archivos
                        string ruta_imagen_eliminar = Path.Combine(rutaImagenes, elementoSeleccionado.image);
                        try
                        {
                            if (File.Exists(ruta_imagen_eliminar))
                            {
                                File.Delete(ruta_imagen_eliminar);
                                MessageBox.Show("Imagen eliminada con éxito");
                            }
                        }
                        catch (IOException ioEx)
                        {
                            MessageBox.Show("No se pudo eliminar la imagen: " + ioEx.Message);
                            return;
                        }
                        catch (UnauthorizedAccessException unAuthEx)
                        {
                            MessageBox.Show("Acceso denegado: " + unAuthEx.Message);
                            return;
                        }
                    }
                }

                // Eliminar el elemento seleccionado de las listas
                EliminarElementoPorNumInventario(elementos_cat);
                EliminarElementoPorNumInventario(elementos_esp);
                EliminarElementoPorNumInventario(elementos_eng);

                // Convertir las listas actualizadas a formato JSON
                string jsonActualizado_cat = JsonConvert.SerializeObject(elementos_cat, Formatting.Indented);
                string jsonActualizado_esp = JsonConvert.SerializeObject(elementos_esp, Formatting.Indented);
                string jsonActualizado_eng = JsonConvert.SerializeObject(elementos_eng, Formatting.Indented);

                // Sobrescribir los archivos JSON con los datos actualizados (en todos los idiomas)
                File.WriteAllText(rutaArchivoJson_cat, jsonActualizado_cat);
                File.WriteAllText(rutaArchivoJson_esp, jsonActualizado_esp);
                File.WriteAllText(rutaArchivoJson_eng, jsonActualizado_eng);



                // Actualizar el ComboBox y otros controles si es necesario
                ConfigurarComboBox();

            }
            else
            {
                MessageBox.Show("Por favor, seleccione un elemento para eliminar.");
            }

        }

        private void selecElemento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selecElemento.SelectedItem is ElementoInventario elementoSeleccionado)
            {
                string ruta_imagen = Path.Combine(rutaImagenes, elementoSeleccionado.image);
                nombreElemento.Text = elementoSeleccionado.nameElement;
                numInventario.Text = elementoSeleccionado.numInventory.ToString();
                fotoElemento.Image = Image.FromFile(ruta_imagen);
                fotoElemento.SizeMode = PictureBoxSizeMode.StretchImage;
                // Si quisieramos, podríamos añadir mas partes de nuestro elemento
            }
        }
    }
}
