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

    public partial class ConfJuego : Form
    {
        Menu menu;
        public ConfJuego()
        {
            InitializeComponent();
        }
        public ConfJuego(Menu menu)
        {
            InitializeComponent();
            this.menu = menu;
        }

        private void button1ConfigPreg_Click(object sender, EventArgs e)
        {
            ConfPregunta configpreguntas = new ConfPregunta(this);
            configpreguntas.Show();
            this.Hide();
        }

        private void buttonAtrasConfPreg_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2ConfImagPunt_Click(object sender, EventArgs e)
        {
            ConfImgPunt confImgPunt = new ConfImgPunt(this);
            confImgPunt.Show();
            this.Hide();
        }

        private void ConfJuego_FormClosing(object sender, FormClosingEventArgs e)
        {
                this.menu.Show();
        }
    }
}
