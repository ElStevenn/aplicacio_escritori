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
            buttonAtrasConfPreg = new Button();
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
            button1ConfigPreg.Click += button1ConfigPreg_Click;
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
            button2ConfImagPunt.Click += button2ConfImagPunt_Click;
            // 
            // buttonAtrasConfPreg
            // 
            buttonAtrasConfPreg.Location = new Point(84, 81);
            buttonAtrasConfPreg.Margin = new Padding(4, 3, 4, 3);
            buttonAtrasConfPreg.Name = "buttonAtrasConfPreg";
            buttonAtrasConfPreg.Size = new Size(80, 29);
            buttonAtrasConfPreg.TabIndex = 4;
            buttonAtrasConfPreg.Text = "Enrere";
            buttonAtrasConfPreg.UseVisualStyleBackColor = true;
            buttonAtrasConfPreg.Click += buttonAtrasConfPreg_Click;
            // 
            // ConfJuego
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(254, 118);
            Controls.Add(buttonAtrasConfPreg);
            Controls.Add(button2ConfImagPunt);
            Controls.Add(button1ConfigPreg);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            Name = "ConfJuego";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Configuració Joc";
            FormClosing += ConfJuego_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Button button1ConfigPreg;
        private Button button2ConfImagPunt;
        private Button buttonAtrasConfPreg;
    }
}