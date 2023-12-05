using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AppEscritori.GestionarParteMuseo;

namespace AppEscritori
{
    public partial class CampsFinal : Form
    {
        public GestionarParteMuseo.Gestor_museo gestionadorMuseo;
        public CampsFinal()
        {
            InitializeComponent();
        }
        public CampsFinal(Gestor_museo gestor_Museo)
        {
            InitializeComponent();
            this.gestionadorMuseo = gestor_Museo;
            cargar_campos();
        }

        public void cargar_campos()
        {
            if (gestionadorMuseo != null)
            {
                // Cargo la imagen y hago para que se muestren en las dimensiones correctas
                string ruta_imagen = gestionadorMuseo.ruta_imagen;
                imagen_elemento.Image = Image.FromFile(ruta_imagen);

                imagen_elemento.SizeMode = PictureBoxSizeMode.StretchImage;
            }
;
        }

        private void button_generar_Click(object sender, EventArgs e)
        {

            // PARTE CARGAR EL JSON Y IMAGEN


            MessageBox.Show("Elemento guardado con éxito.");
            Menu menu = new Menu();
            menu.Show();
            this.Hide();

        }

        private void button_atras_Click(object sender, EventArgs e)
        {
            // Para volver atrás
            Camps camp = new Camps(gestionadorMuseo);
            camp.Show();
            this.Hide();

        }

    }
}
