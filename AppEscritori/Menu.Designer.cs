namespace AppEscritori
{
    partial class Menu
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            buttonCrearElemento = new Button();
            buttonModElemento = new Button();
            buttonEliminarElemento = new Button();
            buttonConfJuego = new Button();
            labelHolaUsuari = new Label();
            groupBox1JsonUbicacio = new GroupBox();
            label1JsonExplicacio = new Label();
            textBox1JsonUbicacio = new TextBox();
            button1JsonUbicacio = new Button();
            groupBox1JsonUbicacio.SuspendLayout();
            SuspendLayout();
            // 
            // buttonCrearElemento
            // 
            buttonCrearElemento.Location = new Point(107, 66);
            buttonCrearElemento.Margin = new Padding(4, 3, 4, 3);
            buttonCrearElemento.Name = "buttonCrearElemento";
            buttonCrearElemento.Size = new Size(244, 35);
            buttonCrearElemento.TabIndex = 0;
            buttonCrearElemento.Text = "Crear Element";
            buttonCrearElemento.UseVisualStyleBackColor = true;
            buttonCrearElemento.Click += buttonCrearElemento_Click;
            // 
            // buttonModElemento
            // 
            buttonModElemento.Location = new Point(107, 108);
            buttonModElemento.Margin = new Padding(4, 3, 4, 3);
            buttonModElemento.Name = "buttonModElemento";
            buttonModElemento.Size = new Size(244, 35);
            buttonModElemento.TabIndex = 1;
            buttonModElemento.Text = "Modificar Element";
            buttonModElemento.UseVisualStyleBackColor = true;
            buttonModElemento.Click += buttonModElemento_Click;
            // 
            // buttonEliminarElemento
            // 
            buttonEliminarElemento.Location = new Point(107, 151);
            buttonEliminarElemento.Margin = new Padding(4, 3, 4, 3);
            buttonEliminarElemento.Name = "buttonEliminarElemento";
            buttonEliminarElemento.Size = new Size(244, 35);
            buttonEliminarElemento.TabIndex = 2;
            buttonEliminarElemento.Text = "Eliminar Element";
            buttonEliminarElemento.UseVisualStyleBackColor = true;
            buttonEliminarElemento.Click += buttonEliminarElemento_Click;
            // 
            // buttonConfJuego
            // 
            buttonConfJuego.Location = new Point(107, 194);
            buttonConfJuego.Margin = new Padding(4, 3, 4, 3);
            buttonConfJuego.Name = "buttonConfJuego";
            buttonConfJuego.Size = new Size(244, 35);
            buttonConfJuego.TabIndex = 3;
            buttonConfJuego.Text = "Configuració Joc 2D";
            buttonConfJuego.UseVisualStyleBackColor = true;
            buttonConfJuego.Click += buttonConfJuego_Click;
            // 
            // labelHolaUsuari
            // 
            labelHolaUsuari.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            labelHolaUsuari.ForeColor = Color.Red;
            labelHolaUsuari.Location = new Point(113, 16);
            labelHolaUsuari.Margin = new Padding(4, 0, 4, 0);
            labelHolaUsuari.Name = "labelHolaUsuari";
            labelHolaUsuari.Size = new Size(228, 41);
            labelHolaUsuari.TabIndex = 5;
            labelHolaUsuari.Text = "Panell Administratiu";
            labelHolaUsuari.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1JsonUbicacio
            // 
            groupBox1JsonUbicacio.Controls.Add(button1JsonUbicacio);
            groupBox1JsonUbicacio.Controls.Add(textBox1JsonUbicacio);
            groupBox1JsonUbicacio.Controls.Add(label1JsonExplicacio);
            groupBox1JsonUbicacio.Location = new Point(107, 235);
            groupBox1JsonUbicacio.Name = "groupBox1JsonUbicacio";
            groupBox1JsonUbicacio.Size = new Size(244, 99);
            groupBox1JsonUbicacio.TabIndex = 6;
            groupBox1JsonUbicacio.TabStop = false;
            groupBox1JsonUbicacio.Text = "Ubicació dels arxius";
            // 
            // label1JsonExplicacio
            // 
            label1JsonExplicacio.AutoSize = true;
            label1JsonExplicacio.Location = new Point(6, 19);
            label1JsonExplicacio.MaximumSize = new Size(240, 0);
            label1JsonExplicacio.Name = "label1JsonExplicacio";
            label1JsonExplicacio.Size = new Size(235, 45);
            label1JsonExplicacio.TabIndex = 0;
            label1JsonExplicacio.Text = "La ubicació de la carpeta on ubicar els arxius JSON (en cas de voler modificar-los) és:";
            // 
            // textBox1JsonUbicacio
            // 
            textBox1JsonUbicacio.Location = new Point(6, 67);
            textBox1JsonUbicacio.Name = "textBox1JsonUbicacio";
            textBox1JsonUbicacio.ReadOnly = true;
            textBox1JsonUbicacio.Size = new Size(128, 23);
            textBox1JsonUbicacio.TabIndex = 1;
            textBox1JsonUbicacio.TextChanged += textBox1JsonUbicacio_TextChanged;
            // 
            // button1JsonUbicacio
            // 
            button1JsonUbicacio.Location = new Point(140, 67);
            button1JsonUbicacio.Name = "button1JsonUbicacio";
            button1JsonUbicacio.Size = new Size(101, 23);
            button1JsonUbicacio.TabIndex = 2;
            button1JsonUbicacio.Text = "Obrir Ubicació";
            button1JsonUbicacio.UseVisualStyleBackColor = true;
            button1JsonUbicacio.Click += button1JsonUbicacio_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 346);
            Controls.Add(groupBox1JsonUbicacio);
            Controls.Add(labelHolaUsuari);
            Controls.Add(buttonConfJuego);
            Controls.Add(buttonEliminarElemento);
            Controls.Add(buttonModElemento);
            Controls.Add(buttonCrearElemento);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            HelpButton = true;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Panell administratiu";
            FormClosing += Menu_FormClosing;
            groupBox1JsonUbicacio.ResumeLayout(false);
            groupBox1JsonUbicacio.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonCrearElemento;
        private Button buttonModElemento;
        private Button buttonEliminarElemento;
        private Button buttonConfJuego;
        private Label labelHolaUsuari;
        private GroupBox groupBox1JsonUbicacio;
        private Label label1JsonExplicacio;
        private Button button1JsonUbicacio;
        private TextBox textBox1JsonUbicacio;
    }
}