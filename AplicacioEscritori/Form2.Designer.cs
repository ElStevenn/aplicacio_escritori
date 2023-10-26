using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AplicacioEscritori
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.buttonCrearElemento = new System.Windows.Forms.Button();
            this.buttonModElemento = new System.Windows.Forms.Button();
            this.buttonEliminarElemento = new System.Windows.Forms.Button();
            this.buttonConfJuego = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelUsuari = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCrearElemento
            // 
            this.buttonCrearElemento.Location = new System.Drawing.Point(92, 75);
            this.buttonCrearElemento.Name = "buttonCrearElemento";
            this.buttonCrearElemento.Size = new System.Drawing.Size(209, 31);
            this.buttonCrearElemento.TabIndex = 0;
            this.buttonCrearElemento.Text = "Crear Elemento";
            this.buttonCrearElemento.UseVisualStyleBackColor = true;
            // 
            // buttonModElemento
            // 
            this.buttonModElemento.Location = new System.Drawing.Point(92, 112);
            this.buttonModElemento.Name = "buttonModElemento";
            this.buttonModElemento.Size = new System.Drawing.Size(209, 31);
            this.buttonModElemento.TabIndex = 1;
            this.buttonModElemento.Text = "Modificar Elemento";
            this.buttonModElemento.UseVisualStyleBackColor = true;
            // 
            // buttonEliminarElemento
            // 
            this.buttonEliminarElemento.Location = new System.Drawing.Point(92, 149);
            this.buttonEliminarElemento.Name = "buttonEliminarElemento";
            this.buttonEliminarElemento.Size = new System.Drawing.Size(209, 31);
            this.buttonEliminarElemento.TabIndex = 2;
            this.buttonEliminarElemento.Text = "Eliminar Elemento";
            this.buttonEliminarElemento.UseVisualStyleBackColor = true;
            // 
            // buttonConfJuego
            // 
            this.buttonConfJuego.Location = new System.Drawing.Point(92, 186);
            this.buttonConfJuego.Name = "buttonConfJuego";
            this.buttonConfJuego.Size = new System.Drawing.Size(209, 31);
            this.buttonConfJuego.TabIndex = 3;
            this.buttonConfJuego.Text = "Configuración Juego 2D";
            this.buttonConfJuego.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(399, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.salirToolStripMenuItem.Text = "Cambiar usuario";
            // 
            // labelUsuari
            // 
            this.labelUsuari.AutoSize = true;
            this.labelUsuari.Location = new System.Drawing.Point(160, 41);
            this.labelUsuari.Name = "labelUsuari";
            this.labelUsuari.Size = new System.Drawing.Size(66, 13);
            this.labelUsuari.TabIndex = 5;
            this.labelUsuari.Text = "Hola (usuari)";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 246);
            this.Controls.Add(this.labelUsuari);
            this.Controls.Add(this.buttonConfJuego);
            this.Controls.Add(this.buttonEliminarElemento);
            this.Controls.Add(this.buttonModElemento);
            this.Controls.Add(this.buttonCrearElemento);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCrearElemento;
        private System.Windows.Forms.Button buttonModElemento;
        private System.Windows.Forms.Button buttonEliminarElemento;
        private System.Windows.Forms.Button buttonConfJuego;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label labelUsuari;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}