namespace Forumario3ByPau
{
    public partial class Form1 : Form
    {
        Label lblNombreElemento, lblNumeroInventario, lblAnoCreacion;
        TextBox txtNombreElemento, txtNumeroInventario, txtAnoCreacion, txtImagenElemento, txtDescripcionElemento;
        Button btnAtras, btnSiguiente;

        public Form1()
        {
            // Configuraci�n b�sica del formulario
            this.Text = "Formulario de Elemento";
            this.Size = new System.Drawing.Size(400, 300);

            // Nombre del elemento
            lblNombreElemento = new Label();
            lblNombreElemento.Text = "Nombre del elemento";
            lblNombreElemento.Location = new System.Drawing.Point(10, 10);
            this.Controls.Add(lblNombreElemento);

            txtNombreElemento = new TextBox();
            txtNombreElemento.Location = new System.Drawing.Point(150, 10);
            this.Controls.Add(txtNombreElemento);

            // N�mero de inventario
            lblNumeroInventario = new Label();
            lblNumeroInventario.Text = "N�mero de inventario";
            lblNumeroInventario.Location = new System.Drawing.Point(10, 40);
            this.Controls.Add(lblNumeroInventario);

            txtNumeroInventario = new TextBox();
            txtNumeroInventario.Location = new System.Drawing.Point(150, 40);
            this.Controls.Add(txtNumeroInventario);

            // A�o de creaci�n
            lblAnoCreacion = new Label();
            lblAnoCreacion.Text = "A�o de creaci�n";
            lblAnoCreacion.Location = new System.Drawing.Point(10, 70);
            this.Controls.Add(lblAnoCreacion);

            txtAnoCreacion = new TextBox();
            txtAnoCreacion.Location = new System.Drawing.Point(150, 70);
            this.Controls.Add(txtAnoCreacion);

            // Imagen del elemento
            txtImagenElemento = new TextBox();
            txtImagenElemento.Location = new System.Drawing.Point(10, 100);
            txtImagenElemento.Size = new System.Drawing.Size(360, 30);
            this.Controls.Add(txtImagenElemento);

            // Descripci�n del elemento
            txtDescripcionElemento = new TextBox();
            txtDescripcionElemento.Location = new System.Drawing.Point(10, 140);
            txtDescripcionElemento.Size = new System.Drawing.Size(360, 30);
            this.Controls.Add(txtDescripcionElemento);

            // Botones
            btnAtras = new Button();
            btnAtras.Text = "Atr�s";
            btnAtras.Location = new System.Drawing.Point(100, 200);
            this.Controls.Add(btnAtras);

            btnSiguiente = new Button();
            btnSiguiente.Text = "Siguiente";
            btnSiguiente.Location = new System.Drawing.Point(200, 200);
            this.Controls.Add(btnSiguiente);
        }

        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new Form1());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}