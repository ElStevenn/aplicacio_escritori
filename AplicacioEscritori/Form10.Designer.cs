namespace AplicacioEscritori
{
    partial class Form10
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
            this.textBoxPregunta = new System.Windows.Forms.TextBox();
            this.textBoxCorrecta = new System.Windows.Forms.TextBox();
            this.labelIncorrecta = new System.Windows.Forms.Label();
            this.textBoxIncorr1 = new System.Windows.Forms.TextBox();
            this.textBoxIncorr2 = new System.Windows.Forms.TextBox();
            this.textBoxIncorr3 = new System.Windows.Forms.TextBox();
            this.buttonAtras = new System.Windows.Forms.Button();
            this.buttonAnadir = new System.Windows.Forms.Button();
            this.groupBoxFrom = new System.Windows.Forms.GroupBox();
            this.labelCreando = new System.Windows.Forms.Label();
            this.groupBoxFrom.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxPregunta
            // 
            this.textBoxPregunta.Location = new System.Drawing.Point(6, 17);
            this.textBoxPregunta.Name = "textBoxPregunta";
            this.textBoxPregunta.Size = new System.Drawing.Size(170, 20);
            this.textBoxPregunta.TabIndex = 0;
            this.textBoxPregunta.Text = "Pregunta";
            this.textBoxPregunta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxCorrecta
            // 
            this.textBoxCorrecta.Location = new System.Drawing.Point(6, 43);
            this.textBoxCorrecta.Name = "textBoxCorrecta";
            this.textBoxCorrecta.Size = new System.Drawing.Size(170, 20);
            this.textBoxCorrecta.TabIndex = 1;
            this.textBoxCorrecta.Text = "Respuesta correcta";
            this.textBoxCorrecta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelIncorrecta
            // 
            this.labelIncorrecta.AutoSize = true;
            this.labelIncorrecta.Location = new System.Drawing.Point(3, 75);
            this.labelIncorrecta.Name = "labelIncorrecta";
            this.labelIncorrecta.Size = new System.Drawing.Size(146, 13);
            this.labelIncorrecta.TabIndex = 4;
            this.labelIncorrecta.Text = "Añadir respuestas incorrectas";
       
            // 
            // textBoxIncorr1
            // 
            this.textBoxIncorr1.Location = new System.Drawing.Point(6, 100);
            this.textBoxIncorr1.Name = "textBoxIncorr1";
            this.textBoxIncorr1.Size = new System.Drawing.Size(170, 20);
            this.textBoxIncorr1.TabIndex = 5;
            this.textBoxIncorr1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxIncorr2
            // 
            this.textBoxIncorr2.Location = new System.Drawing.Point(6, 126);
            this.textBoxIncorr2.Name = "textBoxIncorr2";
            this.textBoxIncorr2.Size = new System.Drawing.Size(170, 20);
            this.textBoxIncorr2.TabIndex = 6;
            this.textBoxIncorr2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxIncorr3
            // 
            this.textBoxIncorr3.Location = new System.Drawing.Point(6, 152);
            this.textBoxIncorr3.Name = "textBoxIncorr3";
            this.textBoxIncorr3.Size = new System.Drawing.Size(170, 20);
            this.textBoxIncorr3.TabIndex = 7;
            this.textBoxIncorr3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonAtras
            // 
            this.buttonAtras.Location = new System.Drawing.Point(6, 188);
            this.buttonAtras.Name = "buttonAtras";
            this.buttonAtras.Size = new System.Drawing.Size(98, 23);
            this.buttonAtras.TabIndex = 8;
            this.buttonAtras.Text = "Atrás";
            this.buttonAtras.UseVisualStyleBackColor = true;
            // 
            // buttonAnadir
            // 
            this.buttonAnadir.Location = new System.Drawing.Point(182, 188);
            this.buttonAnadir.Name = "buttonAnadir";
            this.buttonAnadir.Size = new System.Drawing.Size(98, 23);
            this.buttonAnadir.TabIndex = 9;
            this.buttonAnadir.Text = "Añadir";
            this.buttonAnadir.UseVisualStyleBackColor = true;
            // 
            // groupBoxFrom
            // 
            this.groupBoxFrom.Controls.Add(this.labelCreando);
            this.groupBoxFrom.Controls.Add(this.textBoxCorrecta);
            this.groupBoxFrom.Controls.Add(this.buttonAnadir);
            this.groupBoxFrom.Controls.Add(this.textBoxPregunta);
            this.groupBoxFrom.Controls.Add(this.buttonAtras);
            this.groupBoxFrom.Controls.Add(this.textBoxIncorr3);
            this.groupBoxFrom.Controls.Add(this.textBoxIncorr2);
            this.groupBoxFrom.Controls.Add(this.labelIncorrecta);
            this.groupBoxFrom.Controls.Add(this.textBoxIncorr1);
            this.groupBoxFrom.Location = new System.Drawing.Point(12, 12);
            this.groupBoxFrom.Name = "groupBoxFrom";
            this.groupBoxFrom.Size = new System.Drawing.Size(286, 219);
            this.groupBoxFrom.TabIndex = 10;
            this.groupBoxFrom.TabStop = false;
            this.groupBoxFrom.Text = "FormPreguntas";
            // 
            // labelCreando
            // 
            this.labelCreando.AutoSize = true;
            this.labelCreando.Location = new System.Drawing.Point(181, 33);
            this.labelCreando.Name = "labelCreando";
            this.labelCreando.Size = new System.Drawing.Size(99, 13);
            this.labelCreando.TabIndex = 10;
            this.labelCreando.Text = "Creado x preguntas";
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 244);
            this.Controls.Add(this.groupBoxFrom);
            this.Name = "Form10";
            this.Text = "Form10";
          
            this.groupBoxFrom.ResumeLayout(false);
            this.groupBoxFrom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPregunta;
        private System.Windows.Forms.TextBox textBoxCorrecta;
        private System.Windows.Forms.Label labelIncorrecta;
        private System.Windows.Forms.TextBox textBoxIncorr1;
        private System.Windows.Forms.TextBox textBoxIncorr2;
        private System.Windows.Forms.TextBox textBoxIncorr3;
        private System.Windows.Forms.Button buttonAtras;
        private System.Windows.Forms.Button buttonAnadir;
        private System.Windows.Forms.GroupBox groupBoxFrom;
        private System.Windows.Forms.Label labelCreando;
    }
}

