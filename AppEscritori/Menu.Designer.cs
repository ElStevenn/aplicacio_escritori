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
            menuStrip1 = new MenuStrip();
            cambiarUsuarioToolStripMenuItem = new ToolStripMenuItem();
            labelHolaUsuari = new Label();
            menuStrip1.SuspendLayout();
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
            buttonConfJuego.Text = "Configuración Juego 2D";
            buttonConfJuego.UseVisualStyleBackColor = true;
            buttonConfJuego.Click += buttonConfJuego_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cambiarUsuarioToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(467, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // cambiarUsuarioToolStripMenuItem
            // 
            cambiarUsuarioToolStripMenuItem.Name = "cambiarUsuarioToolStripMenuItem";
            cambiarUsuarioToolStripMenuItem.Size = new Size(106, 20);
            cambiarUsuarioToolStripMenuItem.Text = "Cambiar usuario";
            cambiarUsuarioToolStripMenuItem.Click += cambiarUsuarioToolStripMenuItem_Click;
            // 
            // labelHolaUsuari
            // 
            labelHolaUsuari.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelHolaUsuari.Location = new Point(161, 17);
            labelHolaUsuari.Margin = new Padding(4, 0, 4, 0);
            labelHolaUsuari.Name = "labelHolaUsuari";
            labelHolaUsuari.Size = new Size(130, 42);
            labelHolaUsuari.TabIndex = 5;
            labelHolaUsuari.Text = "Hola (usuari)";
            labelHolaUsuari.TextAlign = ContentAlignment.MiddleCenter;
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
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            HelpButton = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "Menu";
            Text = "Menu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCrearElemento;
        private Button buttonModElemento;
        private Button buttonEliminarElemento;
        private Button buttonConfJuego;
        private MenuStrip menuStrip1;
        private Label labelHolaUsuari;
        private ToolStripMenuItem cambiarUsuarioToolStripMenuItem;
    }
}