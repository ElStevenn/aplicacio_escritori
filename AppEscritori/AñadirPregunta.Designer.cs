namespace AppEscritori
{
    partial class AñadirPregunta
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
            textBoxCorrecta = new TextBox();
            buttonAnadir = new Button();
            textBoxPregunta = new TextBox();
            buttonAtras = new Button();
            textBoxIncorr3 = new TextBox();
            textBoxIncorr2 = new TextBox();
            labelIncorrecta = new Label();
            textBoxIncorr1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // textBoxCorrecta
            // 
            textBoxCorrecta.Location = new Point(161, 42);
            textBoxCorrecta.Margin = new Padding(4, 3, 4, 3);
            textBoxCorrecta.Name = "textBoxCorrecta";
            textBoxCorrecta.Size = new Size(354, 23);
            textBoxCorrecta.TabIndex = 12;
            textBoxCorrecta.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonAnadir
            // 
            buttonAnadir.Location = new Point(430, 196);
            buttonAnadir.Margin = new Padding(4, 3, 4, 3);
            buttonAnadir.Name = "buttonAnadir";
            buttonAnadir.Size = new Size(114, 27);
            buttonAnadir.TabIndex = 18;
            buttonAnadir.Text = "Añadir";
            buttonAnadir.UseVisualStyleBackColor = true;
            // 
            // textBoxPregunta
            // 
            textBoxPregunta.Location = new Point(161, 15);
            textBoxPregunta.Margin = new Padding(4, 3, 4, 3);
            textBoxPregunta.Name = "textBoxPregunta";
            textBoxPregunta.Size = new Size(354, 23);
            textBoxPregunta.TabIndex = 11;
            textBoxPregunta.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonAtras
            // 
            buttonAtras.Location = new Point(13, 196);
            buttonAtras.Margin = new Padding(4, 3, 4, 3);
            buttonAtras.Name = "buttonAtras";
            buttonAtras.Size = new Size(114, 27);
            buttonAtras.TabIndex = 17;
            buttonAtras.Text = "Atrás";
            buttonAtras.UseVisualStyleBackColor = true;
            buttonAtras.Click += buttonAtras_Click;
            // 
            // textBoxIncorr3
            // 
            textBoxIncorr3.Location = new Point(13, 167);
            textBoxIncorr3.Margin = new Padding(4, 3, 4, 3);
            textBoxIncorr3.Name = "textBoxIncorr3";
            textBoxIncorr3.Size = new Size(502, 23);
            textBoxIncorr3.TabIndex = 16;
            textBoxIncorr3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxIncorr2
            // 
            textBoxIncorr2.Location = new Point(13, 137);
            textBoxIncorr2.Margin = new Padding(4, 3, 4, 3);
            textBoxIncorr2.Name = "textBoxIncorr2";
            textBoxIncorr2.Size = new Size(502, 23);
            textBoxIncorr2.TabIndex = 15;
            textBoxIncorr2.TextAlign = HorizontalAlignment.Center;
            // 
            // labelIncorrecta
            // 
            labelIncorrecta.AutoSize = true;
            labelIncorrecta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelIncorrecta.Location = new Point(13, 83);
            labelIncorrecta.Margin = new Padding(4, 0, 4, 0);
            labelIncorrecta.Name = "labelIncorrecta";
            labelIncorrecta.Size = new Size(168, 21);
            labelIncorrecta.TabIndex = 13;
            labelIncorrecta.Text = "Respuestas incorrectas";
            // 
            // textBoxIncorr1
            // 
            textBoxIncorr1.Location = new Point(13, 107);
            textBoxIncorr1.Margin = new Padding(4, 3, 4, 3);
            textBoxIncorr1.Name = "textBoxIncorr1";
            textBoxIncorr1.Size = new Size(502, 23);
            textBoxIncorr1.TabIndex = 14;
            textBoxIncorr1.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(13, 15);
            label1.Name = "label1";
            label1.Size = new Size(73, 21);
            label1.TabIndex = 19;
            label1.Text = "Pregunta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(13, 44);
            label2.Name = "label2";
            label2.Size = new Size(141, 21);
            label2.TabIndex = 19;
            label2.Text = "Respuesta correcta";
            // 
            // AñadirPregunta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(557, 233);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxCorrecta);
            Controls.Add(buttonAnadir);
            Controls.Add(textBoxPregunta);
            Controls.Add(buttonAtras);
            Controls.Add(textBoxIncorr3);
            Controls.Add(textBoxIncorr2);
            Controls.Add(labelIncorrecta);
            Controls.Add(textBoxIncorr1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            Name = "AñadirPregunta";
            Text = "Form10";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxCorrecta;
        private Button buttonAnadir;
        private TextBox textBoxPregunta;
        private Button buttonAtras;
        private TextBox textBoxIncorr3;
        private TextBox textBoxIncorr2;
        private Label labelIncorrecta;
        private TextBox textBoxIncorr1;
        private Label label1;
        private Label label2;
    }
}

