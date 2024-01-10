using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
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
            comboBox1Ambit.SelectedIndex = 0;
            this.gestionadorMuseo = gestor_Museo;
            ponerCampos();
        }

        public void ponerCampos()
        {
            if (gestionadorMuseo != null)
            {
                if (gestionadorMuseo.autonomia != "0" && gestionadorMuseo.autonomia != "-1")
                {
                    Autonomia.Text = gestionadorMuseo.autonomia;
                }
                else { Autonomia.Text = ""; }
                if (gestionadorMuseo.capacitat_diposit != "0" && gestionadorMuseo.capacitat_diposit != "-1")
                {
                    capacitatDiposit.Text = gestionadorMuseo.capacitat_diposit;
                }
                else { capacitatDiposit.Text = ""; }
                if (gestionadorMuseo.cicle != "0" && gestionadorMuseo.cicle != "-1")
                {
                    cicle_cam.Text = gestionadorMuseo.cicle;
                }
                else { cicle_cam.Text = ""; }
                if (gestionadorMuseo.cilidrada != "0" && gestionadorMuseo.cilidrada != "-1")
                {
                    Cilindrada_c.Text = gestionadorMuseo.cilidrada;
                }
                else { Cilindrada_c.Text = ""; }
                if (gestionadorMuseo.elemento != "0" && gestionadorMuseo.elemento != "-1")
                {
                    Element.Text = gestionadorMuseo.elemento;
                }
                else { Element.Text = ""; }
                if (gestionadorMuseo.envergadura != "0" && gestionadorMuseo.envergadura != "-1")
                {
                    Envergadura_c.Text = gestionadorMuseo.envergadura;
                }
                else { Envergadura_c.Text = ""; }
                if (gestionadorMuseo.potencia != "0" && gestionadorMuseo.potencia != "-1")
                {
                    Potencia_c.Text = gestionadorMuseo.potencia;
                }
                else { Potencia_c.Text = ""; }
                if (gestionadorMuseo.quilometros_h != "0" && gestionadorMuseo.quilometros_h != "-1")
                {
                    quilometres_fets.Text = gestionadorMuseo.quilometros_h;
                }
                else { quilometres_fets.Text = ""; }
                if (gestionadorMuseo.peso != "0" && gestionadorMuseo.peso != "-1")
                {
                    pes.Text = gestionadorMuseo.peso;
                }
                else { pes.Text = ""; }
                if (gestionadorMuseo.velocidad != "0" && gestionadorMuseo.velocidad != "-1")
                {
                    velocitat.Text = gestionadorMuseo.velocidad;
                }
                else { velocitat.Text = ""; }
                if (gestionadorMuseo.velocidad_maxima != "0" && gestionadorMuseo.velocidad_maxima != "-1")
                {
                    velocitat_maxima.Text = gestionadorMuseo.velocidad_maxima;
                }
                else { velocitat_maxima.Text = ""; }

                font_energia.Text = gestionadorMuseo.fuente_energia;
                font_ingres.Text = gestionadorMuseo.fuente_ingreso;
                forma_ingres.Text = gestionadorMuseo.forma_ingreso;
                lloc_fabricacio.Text = gestionadorMuseo.lugar_fabricacion;

                if (gestionadorMuseo.longitud != "0" && gestionadorMuseo.longitud != "-1")
                {
                    longitud_c.Text = gestionadorMuseo.longitud;
                }
                else { longitud_c.Text = ""; }
                if (gestionadorMuseo.techoMaximo != "0" && gestionadorMuseo.techoMaximo != "-1")
                {
                    sostre_maxim.Text = gestionadorMuseo.techoMaximo;
                }
                else { sostre_maxim.Text = ""; }

                //comboBox1Ambit.SelectedIndex = 1;
                switch (gestionadorMuseo.ambito)
                {
                    case "1":
                        comboBox1Ambit.SelectedIndex = 1;
                        break;
                    case "2":
                        comboBox1Ambit.SelectedIndex = 2;
                        break;
                    case "3":
                        comboBox1Ambit.SelectedIndex = 3;
                        break;
                    case "4":
                        comboBox1Ambit.SelectedIndex = 4;
                        break;
                    case "5":
                        comboBox1Ambit.SelectedIndex = 5;
                        break;
                    case "6":
                        comboBox1Ambit.SelectedIndex = 6;
                        break;
                    default:
                        comboBox1Ambit.SelectedIndex = 0;
                        break;
                }

            }

        }
        bool EsNumericoGrande(string str)
        {
            return BigInteger.TryParse(str, out _);
        }

        private void button2Siguiente_Click(object sender, EventArgs e)
        {
            // Obtener cada uno de los valores
            string autonomia = Autonomia.Text.Trim();
            string capacitat_diposit = capacitatDiposit.Text.Trim();
            string clicle = cicle_cam.Text.Trim();
            string cilidrada = Cilindrada_c.Text.Trim();
            //string elemento = Element.Text.Trim();
            string elemento = "";
            string envergadura = Envergadura_c.Text.Trim();
            string potencia = Potencia_c.Text.Trim();
            string quilometros_hechos = quilometres_fets.Text.Trim();
            string techo_maximo = sostre_maxim.Text.Trim();
            string peso = pes.Text.Trim();
            string velocidad = velocitat.Text.Trim();
            string velocidad_maxima = velocitat_maxima.Text.Trim();
            string fuente_energia = font_energia.Text.Trim();
            string fuente_ingreso = font_ingres.Text.Trim();
            string forma_ingreso = forma_ingres.Text.Trim();
            string lugar_fabricacion = lloc_fabricacio.Text.Trim();
            string longitud = longitud_c.Text.Trim();
            //string ambito = ambit.Text.Trim();
            string ambito = "";
            if (comboBox1Ambit.SelectedIndex != 0)
            {
                ambito = comboBox1Ambit.SelectedIndex.ToString();
            }

            // Compruevo que el usuario haya introducido bien el formato de los campos TODO A LA VEZ
            /*
            if ((!string.IsNullOrEmpty(autonomia) && !EsNumericoGrande(autonomia)) ||
                (!string.IsNullOrEmpty(capacitat_diposit) && !EsNumericoGrande(capacitat_diposit)) ||
                (!string.IsNullOrEmpty(cilidrada) && !EsNumericoGrande(cilidrada)) ||
                (!string.IsNullOrEmpty(envergadura) && !EsNumericoGrande(envergadura)) ||
                (!string.IsNullOrEmpty(potencia) && !EsNumericoGrande(potencia)) ||
                (!string.IsNullOrEmpty(quilometros_hechos) && !EsNumericoGrande(quilometros_hechos)) ||
                (!string.IsNullOrEmpty(techo_maximo) && !EsNumericoGrande(techo_maximo)) ||
                (!string.IsNullOrEmpty(peso) && !EsNumericoGrande(peso)) ||
                (!string.IsNullOrEmpty(velocidad) && !EsNumericoGrande(velocidad)) ||
                (!string.IsNullOrEmpty(velocidad_maxima) && !EsNumericoGrande(velocidad_maxima)) ||
                (!string.IsNullOrEmpty(longitud) && !EsNumericoGrande(longitud))
            )
            */
            //missatge d'error per cada camp que falli
            Boolean dadesNoValides = false;
            List<string> campsErronis = new List<string>();

            if (!string.IsNullOrEmpty(autonomia) && !EsNumericoGrande(autonomia))
            {
                campsErronis.Add(" Autonomia");
                //MessageBox.Show("El camp autonomia ha de ser numèric!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dadesNoValides = true;
                Autonomia.ForeColor = Color.Red;
            }
            else
            {
                //dadesNoValides = false;
                Autonomia.ForeColor = Color.Black;
            }
            if (!string.IsNullOrEmpty(capacitat_diposit) && !EsNumericoGrande(capacitat_diposit))
            {
                campsErronis.Add(" Capacitat dipòsit");
                //MessageBox.Show("El camp capacitat dipòsit ha de ser numèric!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dadesNoValides = true;
                capacitatDiposit.ForeColor = Color.Red;
            }
            else
            {
                //dadesNoValides = false;
                capacitatDiposit.ForeColor = Color.Black;
            }
            if (!string.IsNullOrEmpty(cilidrada) && !EsNumericoGrande(cilidrada))
            {
                campsErronis.Add(" Cilindrada");
                //MessageBox.Show("El camp cilindrada ha de ser numèric!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dadesNoValides = true;
                Cilindrada_c.ForeColor = Color.Red;
            }
            else
            {
                //dadesNoValides = false;
                Cilindrada_c.ForeColor = Color.Black;
            }
            if (!string.IsNullOrEmpty(envergadura) && !EsNumericoGrande(envergadura))
            {
                campsErronis.Add(" Envergadura");
                //MessageBox.Show("El camp envergadura ha de ser numèric!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dadesNoValides = true;
                Envergadura_c.ForeColor = Color.Red;
            }
            else
            {
                //dadesNoValides = false;
                Envergadura_c.ForeColor = Color.Black;
            }
            if (!string.IsNullOrEmpty(potencia) && !EsNumericoGrande(potencia))
            {
                campsErronis.Add(" Potència");
                //MessageBox.Show("El camp potència ha de ser numèrics!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dadesNoValides = true;
                Potencia_c.ForeColor = Color.Red;
            }
            else
            {
                //dadesNoValides = false;
                Potencia_c.ForeColor = Color.Black;
            }
            if (!string.IsNullOrEmpty(quilometros_hechos) && !EsNumericoGrande(quilometros_hechos))
            {
                campsErronis.Add(" Quilometratge");
                //MessageBox.Show("El camp quilòmetratge ha de ser numèric!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dadesNoValides = true;
                quilometres_fets.ForeColor = Color.Red;
            }
            else
            {
                //dadesNoValides = false;
                quilometres_fets.ForeColor = Color.Black;
            }
            if (!string.IsNullOrEmpty(techo_maximo) && !EsNumericoGrande(techo_maximo))
            {
                campsErronis.Add(" Sostre màxim de vol");
                //MessageBox.Show("El camp sostre màxim de vol ha de ser numèric!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dadesNoValides = true;
                sostre_maxim.ForeColor = Color.Red;
            }
            else
            {
                //dadesNoValides = false;
                sostre_maxim.ForeColor = Color.Black;
            }
            if (!string.IsNullOrEmpty(peso) && !EsNumericoGrande(peso))
            {
                campsErronis.Add(" Pes");
                //MessageBox.Show("El camp pes ha de ser numèric!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dadesNoValides = true;
                pes.ForeColor = Color.Red;
            }
            else
            {
                //dadesNoValides = false;
                pes.ForeColor = Color.Black;
            }
            if (!string.IsNullOrEmpty(velocidad) && !EsNumericoGrande(velocidad))
            {
                campsErronis.Add(" Velocitat");
                //MessageBox.Show("El camp velocitat ha de ser numèric!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dadesNoValides = true;
                velocitat.ForeColor = Color.Red;
            }
            else
            {
                //dadesNoValides = false;
                velocitat.ForeColor = Color.Black;
            }
            if (!string.IsNullOrEmpty(velocidad_maxima) && !EsNumericoGrande(velocidad_maxima))
            {
                campsErronis.Add(" Velocitat màxima");
                //MessageBox.Show("El camp velocitat màxima ha de ser numèric!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dadesNoValides = true;
                velocitat_maxima.ForeColor = Color.Red;
            }
            else
            {
                //dadesNoValides = false;
                velocitat_maxima.ForeColor = Color.Black;
            }
            if (!string.IsNullOrEmpty(longitud) && !EsNumericoGrande(longitud))
            {
                campsErronis.Add(" Longitud");
                //MessageBox.Show("El camp longitud ha de ser numèric!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dadesNoValides = true;
                longitud_c.ForeColor = Color.Red;
            }
            else
            {
                //dadesNoValides = false;
                longitud_c.ForeColor = Color.Black;
            }
            //validació per canviar al següent formulari
            if (dadesNoValides == true)
            {
                String errorsJunts = "";
                foreach (string item in campsErronis)
                {
                    errorsJunts += item;
                }
                MessageBox.Show("Els camps" + errorsJunts + " han de ser numèrics!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MessageBox.Show("Els camps " + campsErronis.ToString + " han de ser numèrics!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                // Pongo los campos a la classe
                gestionadorMuseo.actualizar_caracteristicas(autonomia, capacitat_diposit, clicle, cilidrada, elemento, envergadura, potencia,
                    quilometros_hechos, techo_maximo, peso, velocidad, velocidad_maxima, fuente_energia, fuente_ingreso, forma_ingreso, lugar_fabricacion, longitud, ambito);


                CampsFinal campsFinal = new CampsFinal(gestionadorMuseo);
                campsFinal.Show();
                this.Hide();
            }
        }

        private void button1Enrere_Click(object sender, EventArgs e)
        {
            // Volver atrás
            campos_casteng campsenges = new campos_casteng(gestionadorMuseo);
            campsenges.Show();
            this.Hide();
        }

        private void comboBox1Ambit_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("Degug...", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
