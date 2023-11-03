namespace AppEscritori
{
    partial class ConfJuego
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
            button1ConfigPreg = new Button();
            button2ConfImagPunt = new Button();
            SuspendLayout();
            // 
            // button1ConfigPreg
            // 
            button1ConfigPreg.Location = new Point(14, 14);
            button1ConfigPreg.Margin = new Padding(4, 3, 4, 3);
            button1ConfigPreg.Name = "button1ConfigPreg";
            button1ConfigPreg.Size = new Size(226, 27);
            button1ConfigPreg.TabIndex = 0;
            button1ConfigPreg.Text = "Configurar preguntes";
            button1ConfigPreg.UseVisualStyleBackColor = true;
            // 
            // button2ConfImagPunt
            // 
            button2ConfImagPunt.Location = new Point(14, 48);
            button2ConfImagPunt.Margin = new Padding(4, 3, 4, 3);
            button2ConfImagPunt.Name = "button2ConfImagPunt";
            button2ConfImagPunt.Size = new Size(226, 27);
            button2ConfImagPunt.TabIndex = 1;
            button2ConfImagPunt.Text = "Configurar imatges / puntuació";
            button2ConfImagPunt.UseVisualStyleBackColor = true;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(254, 87);
            Controls.Add(button2ConfImagPunt);
            Controls.Add(button1ConfigPreg);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form8";
            Text = "Formulari_08";
            ResumeLayout(false);
        }

        #endregion

        private Button button1ConfigPreg;
        private Button button2ConfImagPunt;
    }
}