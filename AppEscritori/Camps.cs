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
            InitializeComponent();
            this.gestionadorMuseo = gestor_Museo;
            ponerCampos();
        }

        public void ponerCampos()
        {
            if (gestionadorMuseo != null)
            {
                Autonomia.Text = gestionadorMuseo.autonomia;
                capacitatDiposit.Text = gestionadorMuseo.capacitat_diposit;
                cicle_cam.Text = gestionadorMuseo.cicle;
                Cilindrada_c.Text = gestionadorMuseo.cilidrada;
                Element.Text = gestionadorMuseo.elemento;
                Envergadura_c.Text = gestionadorMuseo.envergadura;
                Potencia_c.Text = gestionadorMuseo.potencia;
                quilometres_fets.Text = gestionadorMuseo.quilometros_h;
                pes.Text = gestionadorMuseo.peso;
                velocitat.Text = gestionadorMuseo.velocidad;
                velocitat_maxima.Text = gestionadorMuseo.velocidad_maxima;
                font_energia.Text = gestionadorMuseo.fuente_energia;
                font_ingres.Text = gestionadorMuseo.fuente_ingreso;
                forma_ingres.Text = gestionadorMuseo.forma_ingreso;
                lloc_fabricacio.Text = gestionadorMuseo.lugar_fabricacion;
                longitud_c.Text = gestionadorMuseo.longitud;
            }

        }


        private void button2Siguiente_Click(object sender, EventArgs e)
        {
            // Obtener cada uno de los valores
            string autonomia = Autonomia.Text;
            string capacitat_diposit = capacitatDiposit.Text;
            string clicle = cicle_cam.Text;
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

            
            CampsFinal campsFinal = new CampsFinal(gestionadorMuseo);
            campsFinal.Show();
            this.Hide();
            
        }

        private void button1Enrere_Click(object sender, EventArgs e)
        {
            // Volver atrás
            campos_casteng campsenges = new campos_casteng(gestionadorMuseo);
            campsenges.Show();
            this.Hide();
        }
    }
}
