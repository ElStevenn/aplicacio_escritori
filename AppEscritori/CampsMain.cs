using System;
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
            poner_imagen();
        }

        private void poner_imagen()
        {
            if (gestionadorMuseo.ruta_imagen != null)
            {
                imagen_elemento.Image = Image.FromFile(gestionadorMuseo.ruta_imagen);
                imagen_elemento.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void ponerCampos()
        {
            // Le pongo los nombres a los campos (si es que existen)
            if (gestionadorMuseo != null)
            {
                descripcio_element.Text = gestionadorMuseo.descripcion_elemento;
                Nom_element.Text = gestionadorMuseo.nombreElemento;
                any_creacio.Text = gestionadorMuseo.anoCreacion;
                Numero_inventari.Text = gestionadorMuseo.numeroInventario;
            }

        }

        private void buttonSiguiente_Click(object sender, EventArgs e)
        {
            // Obtengo los valores de los TextBoxes.
            string nombreElemento = Nom_element.Text.Trim();
            string numeroInventario = Numero_inventari.Text.Trim();
            string anoCreacion = any_creacio.Text.Trim();
            string descripcion_elemento = descripcio_element.Text.Trim();

            string mensajeError = "";

            // Verificar si los campos están vacíos y acumular los mensajes de error.
            if (string.IsNullOrEmpty(nombreElemento))
            {
                mensajeError += "El campo 'nombre elemento' está vacío.\n";
            }
            if (string.IsNullOrEmpty(numeroInventario))
            {
                mensajeError += "El campo 'número inventario' está vacío.\n";
            }
            if (string.IsNullOrEmpty(anoCreacion))
            {
                mensajeError += "El campo 'año de creación' está vacío.\n";
            }
            if (string.IsNullOrEmpty(descripcion_elemento))
            {
                mensajeError += "El campo 'descripción elemento' está vacío.\n";
            }

            // Verificar si hay algún mensaje de error.
            if (!string.IsNullOrEmpty(mensajeError))
            {
                MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verificar la carga de la imagen.
            if (string.IsNullOrEmpty(gestionadorMuseo.ruta_imagen))
            {
                MessageBox.Show("Debes subir una imagen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string mensajeErrorNumerico = "";

            if (!int.TryParse(anoCreacion, out int anoCreacionNumero))
            {
                mensajeErrorNumerico += "El campo 'Año creación' debe ser numérico.\n";
            }
            if (!int.TryParse(numeroInventario, out int numeroInventarioNumero))
            {
                mensajeErrorNumerico += "El campo 'Número inventario' debe ser numérico.\n";
            }

            // Verificar si hay algún mensaje de error.
            if (!string.IsNullOrEmpty(mensajeErrorNumerico))
            {
                MessageBox.Show(mensajeErrorNumerico, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Continuar con la lógica de negocio si todo está correcto.
            gestionadorMuseo.actualizar_campos_main(nombreElemento, numeroInventario, anoCreacion, descripcion_elemento);

            // Pasar a la pantalla de campos para ponerlo en catalán y en español.
            campos_casteng campsengesp = new campos_casteng(gestionadorMuseo);
            campsengesp.Show();
            this.Hide();
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
                gestionadorMuseo.actualizar_ruta_imagen(rutaDelFicheroSeleccionada);
            }


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
