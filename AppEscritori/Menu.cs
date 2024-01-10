using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AppEscritori.GestionarParteMuseo;

namespace AppEscritori
{
    public partial class Menu : Form
    {
        private readonly Login login;
        public GestionarParteMuseo.Gestor_museo gestorMuseo;
        string rutaActual = AppDomain.CurrentDomain.BaseDirectory + "JSON";

        public Menu()
        {
            InitializeComponent();
            textBox1JsonUbicacio.Text = rutaActual;
        }

        public Menu(Login login) : this()
        {
            this.login = login;
            textBox1JsonUbicacio.Text = rutaActual;
        }

        private void buttonCrearElemento_Click(object sender, EventArgs e)
        {
            Gestor_museo gestorMuseo = new Gestor_museo();
            gestorMuseo.modo_gestor = "crear"; // Muy importante esto
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
            EliminarElemento eliminarElemento = new EliminarElemento();
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

        private void button1_Click(object sender, EventArgs e)
        {
            ManejarIdioma menu = new ManejarIdioma();
            menu.Show();
            this.Hide();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult result = MessageBox.Show("Estàs segur que vols tancar?", "Confirmació", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.login.Show();

            }
            else if (result == DialogResult.No)
            {
                e.Cancel = true;
            }

        }

        private void textBox1JsonUbicacio_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1JsonUbicacio_Click(object sender, EventArgs e)
        {
            string rutaActual = AppDomain.CurrentDomain.BaseDirectory + "JSON";

            // Abre el Explorador de Archivos en la ruta actual
            Process.Start("explorer.exe", rutaActual);
        }
    }
}
