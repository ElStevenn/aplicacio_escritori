using System;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            if (textBoxNombre.Text == "admin" && textBoxContra.Text == "12345")
            {
                Menu menu = new Menu(this);
                menu.Show();
                this.Hide();
                textBoxNombre.Text = "";
                textBoxContra.Text = "";
                labelWarning.Visible = false;
            }
            else
            {
                labelWarning.Visible = true;
                labelWarning.Text = "El usuari o contrasenya està mal introduït";
            }
        }

        private void Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada es Enter
            if (e.KeyChar == (char)Keys.Enter)
            {
                button_login_Click(sender, e);
            }
        }
    }
}
