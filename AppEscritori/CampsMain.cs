﻿using System;
using System.Windows.Forms;
using AppEscritori;
using static AppEscritori.GestionarParteMuseo;

namespace AppEscritori
{
    public partial class CampsMain : Form
    {
        public GestionarParteMuseo.Gestor_museo gestionadorMuseo;
        public CampsMain()
        {
            InitializeComponent();
            // this.gestionadorMuseo = GestionarParteMuseo.Gestor_museo.Instance;
            // Aquí gestionadorMuseo ya es accesible y puedes usarlo para manipular tus datos.
        }

        public CampsMain(Gestor_museo gestor_Museo)
        {
            InitializeComponent();
            this.gestionadorMuseo = gestor_Museo;
            ponerCampos();
        }


        private void ponerCampos()
        {
            // Le pongo los nombres a los campos (si es que existen)
            if (gestionadorMuseo != null)
            {
                descripcio_element.Text = gestionadorMuseo.descripcion_elemento ?? "";
                Nom_element.Text = gestionadorMuseo.nombreElemento ?? "";
                any_creacio.Text = gestionadorMuseo.anoCreacion ?? "";
                Numero_inventari.Text = gestionadorMuseo.numeroInventario ?? "";
            }

        }

        private void buttonSiguiente_Click(object sender, EventArgs e)
        {
            // Obtengo los valores de los TextBoxes.
            string nombreElemento = Nom_element.Text;
            string numeroInventario = Numero_inventari.Text;
            string anoCreacion = any_creacio.Text;
            string descripcion_elemento = descripcio_element.Text;

            // Validación de campos vacíos.
            if (string.IsNullOrEmpty(nombreElemento) || string.IsNullOrEmpty(numeroInventario) ||
                string.IsNullOrEmpty(anoCreacion) || string.IsNullOrEmpty(descripcion_elemento))
            {
                MessageBox.Show("Debes de rellenar todos los campos con valores correctos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {


                // Actualiza los campos y los almacena en la clase gestionadorMuseo.
                gestionadorMuseo.actualizar_campos_main(nombreElemento, numeroInventario, anoCreacion, descripcion_elemento);

                // Pasar a la pantalla de Camps.
                Camps camps = new Camps(gestionadorMuseo); // Asegúrate de que Camps tenga un constructor que acepte Gestor_museo.
                camps.Show();
                this.Hide();
            }
        }


        private void buttonAtras_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Boton para que se le salga un OpenFileDialog al clickar el botón y configuro filtros, indices y directorios
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Imágenes|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            ofd.FilterIndex = 1;
            ofd.RestoreDirectory = true;

            // Muesto el openFileDialog
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Selecciono la ruta y lo enlazo al picter view
                string rutaDelFicheroSeleccionada = ofd.FileName;
                imagen_elemento.Image = Image.FromFile(rutaDelFicheroSeleccionada);

                // Ajusto el Picture box para que se muestre con las dimensiones que se desea
                imagen_elemento.SizeMode = PictureBoxSizeMode.StretchImage;

            }


        }
    }
}
