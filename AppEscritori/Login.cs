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
            }
            else
            {
                labelWarning.Visible = true;
                labelWarning.Text = "El usuari o contrasenya està mal introduït";
            }
        }

    }
}
