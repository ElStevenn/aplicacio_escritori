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
            buttonCrearElemento.Location = new Point(107, 66);
            buttonCrearElemento.Margin = new Padding(4, 3, 4, 3);
            buttonCrearElemento.Name = "buttonCrearElemento";
            buttonCrearElemento.Size = new Size(244, 35);
            buttonCrearElemento.TabIndex = 0;
            buttonCrearElemento.Text = "Crear Elemento";
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
            buttonModElemento.Text = "Modificar Elemento";
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
            buttonEliminarElemento.Text = "Eliminar Elemento";
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
            buttonConfJuego.Text = "Configuracion Juego 2D";
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
            labelHolaUsuari.Text = "Panel Administrativo";
            labelHolaUsuari.TextAlign = ContentAlignment.MiddleCenter;
            labelHolaUsuari.Click += labelHolaUsuari_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 248);
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
            Text = "Panel administrativo";
            Load += Menu_Load;
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