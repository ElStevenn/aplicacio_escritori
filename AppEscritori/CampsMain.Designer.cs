namespace AppEscritori
{
    partial class CampsMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Nom_element = new TextBox();
            Numero_inventari = new TextBox();
            any_creacio = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            imageList1 = new ImageList(components);
            imagen_elemento = new PictureBox();
            descripcio_element = new TextBox();
            label4 = new Label();
            buttonAtras = new Button();
            buttonSiguiente = new Button();
            abrir_archivo = new OpenFileDialog();
            button1 = new Button();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)imagen_elemento).BeginInit();
            SuspendLayout();
            // 
            // Nom_element
            // 
            Nom_element.Location = new Point(12, 28);
            Nom_element.Name = "Nom_element";
            Nom_element.Size = new Size(177, 23);
            Nom_element.TabIndex = 3;
            // 
            // Numero_inventari
            // 
            Numero_inventari.Location = new Point(195, 28);
            Numero_inventari.Name = "Numero_inventari";
            Numero_inventari.Size = new Size(186, 23);
            Numero_inventari.TabIndex = 4;
            // 
            // any_creacio
            // 
            any_creacio.Location = new Point(387, 28);
            any_creacio.Name = "any_creacio";
            any_creacio.Size = new Size(177, 23);
            any_creacio.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 9);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 6;
            label1.Text = "Nombre elemento";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(225, 9);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 7;
            label2.Text = "Numero inventario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(431, 9);
            label3.Name = "label3";
            label3.Size = new Size(93, 15);
            label3.TabIndex = 8;
            label3.Text = "Año de creación";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // imagen_elemento
            // 
            imagen_elemento.Location = new Point(12, 57);
            imagen_elemento.Name = "imagen_elemento";
            imagen_elemento.Size = new Size(191, 125);
            imagen_elemento.TabIndex = 9;
            imagen_elemento.TabStop = false;
            // 
            // descripcio_element
            // 
            descripcio_element.Location = new Point(12, 206);
            descripcio_element.Multiline = true;
            descripcio_element.Name = "descripcio_element";
            descripcio_element.Size = new Size(552, 100);
            descripcio_element.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 188);
            label4.Name = "label4";
            label4.Size = new Size(122, 15);
            label4.TabIndex = 11;
            label4.Text = "Descripción elemento";
            // 
            // buttonAtras
            // 
            buttonAtras.Location = new Point(12, 312);
            buttonAtras.Name = "buttonAtras";
            buttonAtras.Size = new Size(133, 23);
            buttonAtras.TabIndex = 12;
            buttonAtras.Text = "Atrás";
            buttonAtras.UseVisualStyleBackColor = true;
            buttonAtras.Click += buttonAtras_Click;
            // 
            // buttonSiguiente
            // 
            buttonSiguiente.Location = new Point(431, 312);
            buttonSiguiente.Name = "buttonSiguiente";
            buttonSiguiente.Size = new Size(133, 23);
            buttonSiguiente.TabIndex = 13;
            buttonSiguiente.Text = "Siguiente";
            buttonSiguiente.UseVisualStyleBackColor = true;
            buttonSiguiente.Click += buttonSiguiente_Click;
            // 
            // abrir_archivo
            // 
            abrir_archivo.FileName = "openFileDialog1";
            abrir_archivo.InitialDirectory = "c:\\\\";
            // 
            // button1
            // 
            button1.Location = new Point(209, 76);
            button1.Name = "button1";
            button1.Size = new Size(147, 23);
            button1.TabIndex = 14;
            button1.Text = "Seleccionar Imagen";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(225, 105);
            label5.Name = "label5";
            label5.Size = new Size(113, 30);
            label5.TabIndex = 15;
            label5.Text = "Añadir una imagen\r\n grande si es posible";
            // 
            // CampsMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 345);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(buttonSiguiente);
            Controls.Add(buttonAtras);
            Controls.Add(label4);
            Controls.Add(descripcio_element);
            Controls.Add(imagen_elemento);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(any_creacio);
            Controls.Add(Numero_inventari);
            Controls.Add(Nom_element);
            Name = "CampsMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Campos Principales";
            ((System.ComponentModel.ISupportInitialize)imagen_elemento).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Nom_element;
        private TextBox Numero_inventari;
        private TextBox any_creacio;
        private Label label1;
        private Label label2;
        private Label label3;
        private ImageList imageList1;
        private PictureBox imagen_elemento;
        private TextBox descripcio_element;
        private Label label4;
        private Button buttonAtras;
        private Button buttonSiguiente;
        private OpenFileDialog abrir_archivo;
        private Button button1;
        private Label label5;
    }
}