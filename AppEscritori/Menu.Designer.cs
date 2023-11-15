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
            SuspendLayout();
            // 
            // buttonCrearElemento
            // 
            buttonCrearElemento.Location = new Point(107, 71);
            buttonCrearElemento.Margin = new Padding(4, 3, 4, 3);
            buttonCrearElemento.Name = "buttonCrearElemento";
            buttonCrearElemento.Size = new Size(244, 36);
            buttonCrearElemento.TabIndex = 0;
            buttonCrearElemento.Text = "Crear Elemento";
            buttonCrearElemento.UseVisualStyleBackColor = true;
            buttonCrearElemento.Click += buttonCrearElemento_Click;
            // 
            // buttonModElemento
            // 
            buttonModElemento.Location = new Point(107, 113);
            buttonModElemento.Margin = new Padding(4, 3, 4, 3);
            buttonModElemento.Name = "buttonModElemento";
            buttonModElemento.Size = new Size(244, 36);
            buttonModElemento.TabIndex = 1;
            buttonModElemento.Text = "Modificar Elemento";
            buttonModElemento.UseVisualStyleBackColor = true;
            buttonModElemento.Click += buttonModElemento_Click;
            // 
            // buttonEliminarElemento
            // 
            buttonEliminarElemento.Location = new Point(107, 156);
            buttonEliminarElemento.Margin = new Padding(4, 3, 4, 3);
            buttonEliminarElemento.Name = "buttonEliminarElemento";
            buttonEliminarElemento.Size = new Size(244, 36);
            buttonEliminarElemento.TabIndex = 2;
            buttonEliminarElemento.Text = "Eliminar Elemento";
            buttonEliminarElemento.UseVisualStyleBackColor = true;
            buttonEliminarElemento.Click += buttonEliminarElemento_Click;
            // 
            // buttonConfJuego
            // 
            buttonConfJuego.Location = new Point(107, 199);
            buttonConfJuego.Margin = new Padding(4, 3, 4, 3);
            buttonConfJuego.Name = "buttonConfJuego";
            buttonConfJuego.Size = new Size(244, 36);
            buttonConfJuego.TabIndex = 3;
            buttonConfJuego.Text = "Configuracion Juego 2D";
            buttonConfJuego.UseVisualStyleBackColor = true;
            buttonConfJuego.Click += buttonConfJuego_Click;
            // 
            // labelHolaUsuari
            // 
            labelHolaUsuari.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelHolaUsuari.Location = new Point(107, 24);
            labelHolaUsuari.Margin = new Padding(4, 0, 4, 0);
            labelHolaUsuari.Name = "labelHolaUsuari";
            labelHolaUsuari.Size = new Size(228, 42);
            labelHolaUsuari.TabIndex = 5;
            labelHolaUsuari.Text = "Panell Administratiu";
            labelHolaUsuari.TextAlign = ContentAlignment.MiddleCenter;
            labelHolaUsuari.Click += labelHolaUsuari_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 251);
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
            Text = "Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonCrearElemento;
        private Button buttonModElemento;
        private Button buttonEliminarElemento;
        private Button buttonConfJuego;
        private Label labelHolaUsuari;
    }
}