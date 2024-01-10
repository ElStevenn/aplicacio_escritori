﻿using System;
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
                sostre_maxim.Text = gestionadorMuseo.techoMaximo;
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
            string ambito = ambit.Text.Trim();

            // Compruevo que el usuario haya introducido bien el formato de los campos
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
            if (!string.IsNullOrEmpty(autonomia) && !EsNumericoGrande(autonomia))
            {
                MessageBox.Show("El camp autonomia ha de ser numèric!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("El camp capacitat dipòsit ha de ser numèric!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("El camp cilindrada ha de ser numèric!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("El camp envergadura ha de ser numèric!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("El camp potència ha de ser numèrics!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("El camp quilòmetres fets ha de ser numèric!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("El camp sostre màxim de vol ha de ser numèric!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("El camp pes ha de ser numèric!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("El camp velocitat ha de ser numèric!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("El camp velocitat màxima ha de ser numèric!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("El camp longitud ha de ser numèric!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Los campos autonomia, capacitat deposit, cilindrada, elemento, longitud, velocidad, velocidad máxima, quilometros hechos y peso deben de ser númericos! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

    }
}
