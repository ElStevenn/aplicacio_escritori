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
    public partial class campos_casteng : Form
    {
        public GestionarParteMuseo.Gestor_museo gestionadorMuseo;
        public campos_casteng()
        {
            InitializeComponent();
        }
        public campos_casteng(Gestor_museo gestor_Museo)
        {
            InitializeComponent();
            this.gestionadorMuseo = gestor_Museo;
            ponerCampos();
        }

        public void ponerCampos()
        {
            if (gestionadorMuseo != null)
            {
                descrp_eng.Text = gestionadorMuseo.eng_descripcionEelemento;
                nombre_eng.Text = gestionadorMuseo.eng_nombreElemento;
                nombre_esp.Text = gestionadorMuseo.es_nombreElemento;
                descrp_esp.Text = gestionadorMuseo.es_descripcionElemento;
            }
        }


        private void buttonAtras_Click(object sender, EventArgs e)
        {
            // Manejar en caso de que el usuario haya puesto campos
            string nombre_elemento_espanol = nombre_esp.Text;
            string descrpipcion_esp = descrp_esp.Text;
            string nombre_elemento_eng = nombre_eng.Text;
            string descripcion_eng = descrp_eng.Text;
            gestionadorMuseo.actualizar_campos_espeng(nombre_elemento_espanol, descrpipcion_esp, nombre_elemento_eng, descripcion_eng);

            // Volver a campos main
            CampsMain campsMain = new CampsMain(gestionadorMuseo);
            campsMain.Show();
            this.Hide();
        }

        private void buttonSiguiente_Click(object sender, EventArgs e)
        {
            // Boton para apuntar todos los campos
            string nombre_elemento_espanol = nombre_esp.Text;
            string descrpipcion_esp = descrp_esp.Text;
            string nombre_elemento_eng = nombre_eng.Text;
            string descripcion_eng = descrp_eng.Text;

            if (string.IsNullOrEmpty(nombre_elemento_espanol) || string.IsNullOrEmpty(descrpipcion_esp) || string.IsNullOrEmpty(nombre_elemento_eng) || string.IsNullOrEmpty(descripcion_eng))
            {
                // En caso de que no introduzca los campos correctamente
                MessageBox.Show("Debes de rellenar todos los campos con valores correctos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Poner los campos en la classe
                gestionadorMuseo.actualizar_campos_espeng(nombre_elemento_espanol, descrpipcion_esp, nombre_elemento_eng, descripcion_eng);

                // Ir a Campos generales
                Camps campsFinals = new Camps(gestionadorMuseo);
                campsFinals.Show();
                this.Hide();
            }

        }
    }
}
