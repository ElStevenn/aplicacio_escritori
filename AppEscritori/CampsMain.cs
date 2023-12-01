using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppEscritori;
using static AppEscritori.GestionarParteMuseo;

namespace AppEscritori
{
    public partial class CampsMain : Form
    {
        Menu menu;
        Gestor_museo Gestor_museo;


        public CampsMain()
        {
            // Esto si lo quito me da error!
  

        }

        public CampsMain(Menu menu)
        {
            InitializeComponent();
            this.menu = menu;
        }
        public void ponerCampos()
        {
            descripcio_element.Text = "hola hola hola";
        }


        private void buttonSiguiente_Click(object sender, EventArgs e)
        {
            string nombreElemento = Nom_element.Text;
            string numeroInventario = Numero_inventari.Text;
            string anoCreacion = any_creacio.Text;
            string descripcion_elemento = descripcio_element.Text;




            // Validación de campos vacíos
            if (string.IsNullOrEmpty(nombreElemento) || string.IsNullOrEmpty(numeroInventario) || string.IsNullOrEmpty(anoCreacion) || string.IsNullOrEmpty(descripcion_elemento))
            {
                MessageBox.Show("Debes de rellenar todos los campos con valores correctos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                // Actualizo los campos y los almazeno en la classe
                Gestor_museo.actualizar_campos_main(nombreElemento, numeroInventario, anoCreacion, descripcion_elemento);

                // Passar a la pantalla de Main
                Camps camps = new Camps();
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
    }
}
