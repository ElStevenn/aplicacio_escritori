using System;
using System.Windows.Forms;
using AppEscritori;
using static AppEscritori.GestionarParteMuseo;

namespace AppEscritori
{
    public partial class CampsMain : Form
    {
        private readonly Gestor_museo gestionadorMuseo;

        public CampsMain(Gestor_museo gestorMuseo)
        {
            InitializeComponent();
            this.gestionadorMuseo = gestorMuseo;
            ponerCampos();
        }

        private void ponerCampos()
        {
            descripcio_element.Text = "hola hola hola"; // Asigna el texto al TextBox
        }

        private void buttonSiguiente_Click(object sender, EventArgs e)
        {
            string nombreElemento = Nom_element.Text;
            string numeroInventario = Numero_inventari.Text;
            string anoCreacion = any_creacio.Text;
            string descripcion_elemento = descripcio_element.Text;

            // Validación de campos vacíos
            if (string.IsNullOrEmpty(nombreElemento) || string.IsNullOrEmpty(numeroInventario) ||
                string.IsNullOrEmpty(anoCreacion) || string.IsNullOrEmpty(descripcion_elemento))
            {
                MessageBox.Show("Debes de rellenar todos los campos con valores correctos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Actualiza los campos y los almacena en la clase
                gestionadorMuseo.actualizar_campos_main(nombreElemento, numeroInventario, anoCreacion, descripcion_elemento);

                // Pasar a la pantalla de Main
                Camps camps = new Camps(gestionadorMuseo); // Asumiendo que Camps espera un Gestor_museo como parámetro
                camps.Show();
                this.Hide();
            }
        }

        private void buttonAtras_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu(); // Asumiendo que tienes un formulario llamado Menu
            menu.Show();
            this.Hide();
        }
    }
}
