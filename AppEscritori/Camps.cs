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
    public partial class Camps : Form

    {
        public GestionarParteMuseo.Gestor_museo gestionadorMuseo;
        public Camps()
        {
            InitializeComponent();
         
        }
        public Camps(Gestor_museo gestor_Museo)
        {
            InitializeComponent()
;           this.gestionadorMuseo = GestionarParteMuseo.Gestor_museo.Instance;

        }


        private void button2Siguiente_Click(object sender, EventArgs e)
        {
            // Obtener cada uno de los valores
            string autonomia = Autonomia.Text;
            string capacitat_diposit = capacitatDiposit.Text;
            string clicle = clicle_cam.Text;
            string cilidrada = Cilindrada_c.Text;
            string elemento = Element.Text;
            string potencia = Potencia_c.Text;
            string quilometros_hechos = quilometres_fets.Text;
            string techo_maximo = sostre_maxim.Text;
            string peso = pes.Text;
            string velocidad = velocitat.Text;
            string velocidad_maxima = velocitat_maxima.Text;
            string fuente_energia = font_energia.Text;
            string fuente_ingreso = font_ingres.Text;
            string forma_ingreso = forma_ingres.Text;
            string lugar_fabricacion = lloc_fabricacio.Text;
            string longitud = longitud_c.Text;

            if (string.IsNullOrEmpty(autonomia) || string.IsNullOrEmpty(capacitat_diposit) || string.IsNullOrEmpty(clicle) || string.IsNullOrEmpty(cilidrada) ||
                string.IsNullOrEmpty(elemento) || string.IsNullOrEmpty(potencia) || string.IsNullOrEmpty(quilometros_hechos) || string.IsNullOrEmpty(techo_maximo) ||
                string.IsNullOrEmpty(peso) || string.IsNullOrEmpty(velocidad) || string.IsNullOrEmpty(velocidad_maxima) || string.IsNullOrEmpty(fuente_energia) ||
                string.IsNullOrEmpty(fuente_ingreso) || string.IsNullOrEmpty(forma_ingreso) || string.IsNullOrEmpty(lugar_fabricacion) || string.IsNullOrEmpty(longitud))
            {
                MessageBox.Show("Todos los campos deben estar completos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // No continuar con la ejecución si hay campos vacíos
            }
            else
            {
                CampsFinal campsFinal = new CampsFinal();
                campsFinal.Show();
                this.Hide();
            }
        }

        private void button1Enrere_Click(object sender, EventArgs e)
        {
            CampsMain campsMain = new CampsMain(gestionadorMuseo);
            campsMain.Show();
            this.Hide();
        }

        private void textBox1Autonomia_TextChanged(object sender, EventArgs e)
        {

        }
    }
}