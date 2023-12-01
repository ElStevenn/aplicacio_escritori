﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEscritori
{
    public partial class Menu : Form
    {
        private readonly Login login;
        private readonly GestionarParteMuseo.Gestor_museo gestorMuseo;

        public Menu()
        {
            InitializeComponent();
            GestionarParteMuseo gestionarParte = new GestionarParteMuseo();
            gestorMuseo = gestionarParte.gestorMuseo; // Si esto es un campo público
        }

        public Menu(Login login) : this()
        {
            this.login = login;
        }

        private void buttonCrearElemento_Click(object sender, EventArgs e)
        {
            CampsMain campsMain = new CampsMain(gestorMuseo);
            campsMain.Show();
            this.Hide();
        }

        private void cambiarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            this.login.Show();
        }

        private void buttonConfJuego_Click(object sender, EventArgs e)
        {
            ConfJuego ConfJuego = new ConfJuego(this);
            ConfJuego.Show();
            this.Hide();
        }

        private void buttonEliminarElemento_Click(object sender, EventArgs e)
        {
            EliminarElemento eliminarElemento = new EliminarElemento(this);
            eliminarElemento.Show();
            this.Hide();
        }

        private void buttonModElemento_Click(object sender, EventArgs e)
        {
            // redireccionar a modigicar_elemento
            ModificarElemento menu = new ModificarElemento();
            menu.Show();
            this.Hide();

        }

        private void labelHolaUsuari_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManejarIdioma menu = new ManejarIdioma();
            menu.Show();
            this.Hide();
        }
    }
}
