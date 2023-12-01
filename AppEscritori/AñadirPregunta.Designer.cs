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
            respuestaA = new TextBox();
            buttonAnadir = new Button();
            textBoxPregunta = new TextBox();
            buttonAtras = new Button();
            respuestaD = new TextBox();
            respuestaC = new TextBox();
            respuestaB = new TextBox();
            Preguntas = new Label();
            NumPreguntes = new Label();
            Respuestas = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            RespuestaCorrectaA = new RadioButton();
            RespuestaCorrectaB = new RadioButton();
            RespuestaCorrectaC = new RadioButton();
            RespuestaCorrecta = new Label();
            RespuestaCorrectaD = new RadioButton();
            SuspendLayout();
            // 
            // respuestaA
            // 
            respuestaA.Location = new Point(30, 92);
            respuestaA.Margin = new Padding(4, 3, 4, 3);
            respuestaA.Name = "respuestaA";
            respuestaA.Size = new Size(512, 23);
            respuestaA.TabIndex = 12;
            respuestaA.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonAnadir
            // 
            buttonAnadir.Location = new Point(428, 241);
            buttonAnadir.Margin = new Padding(4, 3, 4, 3);
            buttonAnadir.Name = "buttonAnadir";
            buttonAnadir.Size = new Size(114, 27);
            buttonAnadir.TabIndex = 18;
            buttonAnadir.Text = "Añadir";
            buttonAnadir.UseVisualStyleBackColor = true;
            buttonAnadir.Click += buttonAnadir_Click;
            // 
            // textBoxPregunta
            // 
            textBoxPregunta.Location = new Point(83, 33);
            textBoxPregunta.Margin = new Padding(4, 3, 4, 3);
            textBoxPregunta.Name = "textBoxPregunta";
            textBoxPregunta.Size = new Size(459, 23);
            textBoxPregunta.TabIndex = 11;
            textBoxPregunta.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonAtras
            // 
            buttonAtras.Location = new Point(13, 241);
            buttonAtras.Margin = new Padding(4, 3, 4, 3);
            buttonAtras.Name = "buttonAtras";
            buttonAtras.Size = new Size(114, 27);
            buttonAtras.TabIndex = 17;
            buttonAtras.Text = "Atrás";
            buttonAtras.UseVisualStyleBackColor = true;
            buttonAtras.Click += buttonAtras_Click;
            // 
            // respuestaD
            // 
            respuestaD.Location = new Point(31, 179);
            respuestaD.Margin = new Padding(4, 3, 4, 3);
            respuestaD.Name = "respuestaD";
            respuestaD.Size = new Size(511, 23);
            respuestaD.TabIndex = 16;
            respuestaD.TextAlign = HorizontalAlignment.Center;
            // 
            // respuestaC
            // 
            respuestaC.Location = new Point(31, 150);
            respuestaC.Margin = new Padding(4, 3, 4, 3);
            respuestaC.Name = "respuestaC";
            respuestaC.Size = new Size(511, 23);
            respuestaC.TabIndex = 15;
            respuestaC.TextAlign = HorizontalAlignment.Center;
            // 
            // respuestaB
            // 
            respuestaB.Location = new Point(30, 121);
            respuestaB.Margin = new Padding(4, 3, 4, 3);
            respuestaB.Name = "respuestaB";
            respuestaB.Size = new Size(512, 23);
            respuestaB.TabIndex = 14;
            respuestaB.TextAlign = HorizontalAlignment.Center;
            // 
            // Preguntas
            // 
            Preguntas.AutoSize = true;
            Preguntas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Preguntas.Location = new Point(3, 33);
            Preguntas.Name = "Preguntas";
            Preguntas.Size = new Size(73, 21);
            Preguntas.TabIndex = 19;
            Preguntas.Text = "Pregunta";
            // 
            // NumPreguntes
            // 
            NumPreguntes.AutoSize = true;
            NumPreguntes.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            NumPreguntes.ForeColor = Color.Firebrick;
            NumPreguntes.Location = new Point(193, 9);
            NumPreguntes.Name = "NumPreguntes";
            NumPreguntes.Size = new Size(149, 21);
            NumPreguntes.TabIndex = 20;
            NumPreguntes.Text = "Hi ha X preguntes ";
            // 
            // Respuestas
            // 
            Respuestas.AutoSize = true;
            Respuestas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Respuestas.Location = new Point(3, 68);
            Respuestas.Name = "Respuestas";
            Respuestas.Size = new Size(88, 21);
            Respuestas.TabIndex = 21;
            Respuestas.Text = "Respuestas";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(3, 94);
            label4.Name = "label4";
            label4.Size = new Size(20, 21);
            label4.TabIndex = 22;
            label4.Text = "A";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(4, 123);
            label5.Name = "label5";
            label5.Size = new Size(19, 21);
            label5.TabIndex = 23;
            label5.Text = "B";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(4, 152);
            label6.Name = "label6";
            label6.Size = new Size(20, 21);
            label6.TabIndex = 24;
            label6.Text = "C";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(3, 181);
            label7.Name = "label7";
            label7.Size = new Size(21, 21);
            label7.TabIndex = 25;
            label7.Text = "D";
            // 
            // RespuestaCorrectaA
            // 
            RespuestaCorrectaA.AutoSize = true;
            RespuestaCorrectaA.Location = new Point(151, 211);
            RespuestaCorrectaA.Name = "RespuestaCorrectaA";
            RespuestaCorrectaA.Size = new Size(33, 19);
            RespuestaCorrectaA.TabIndex = 26;
            RespuestaCorrectaA.TabStop = true;
            RespuestaCorrectaA.Text = "A";
            RespuestaCorrectaA.UseVisualStyleBackColor = true;
            // 
            // RespuestaCorrectaB
            // 
            RespuestaCorrectaB.AutoSize = true;
            RespuestaCorrectaB.Location = new Point(193, 211);
            RespuestaCorrectaB.Name = "RespuestaCorrectaB";
            RespuestaCorrectaB.Size = new Size(32, 19);
            RespuestaCorrectaB.TabIndex = 27;
            RespuestaCorrectaB.TabStop = true;
            RespuestaCorrectaB.Text = "B";
            RespuestaCorrectaB.UseVisualStyleBackColor = true;
            // 
            // RespuestaCorrectaC
            // 
            RespuestaCorrectaC.AutoSize = true;
            RespuestaCorrectaC.Location = new Point(231, 211);
            RespuestaCorrectaC.Name = "RespuestaCorrectaC";
            RespuestaCorrectaC.Size = new Size(33, 19);
            RespuestaCorrectaC.TabIndex = 28;
            RespuestaCorrectaC.TabStop = true;
            RespuestaCorrectaC.Text = "C";
            RespuestaCorrectaC.UseVisualStyleBackColor = true;
            // 
            // RespuestaCorrecta
            // 
            RespuestaCorrecta.AutoSize = true;
            RespuestaCorrecta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RespuestaCorrecta.Location = new Point(4, 208);
            RespuestaCorrecta.Name = "RespuestaCorrecta";
            RespuestaCorrecta.Size = new Size(141, 21);
            RespuestaCorrecta.TabIndex = 30;
            RespuestaCorrecta.Text = "Respuesta correcta";
            // 
            // RespuestaCorrectaD
            // 
            RespuestaCorrectaD.AutoSize = true;
            RespuestaCorrectaD.Location = new Point(270, 211);
            RespuestaCorrectaD.Name = "RespuestaCorrectaD";
            RespuestaCorrectaD.Size = new Size(33, 19);
            RespuestaCorrectaD.TabIndex = 29;
            RespuestaCorrectaD.TabStop = true;
            RespuestaCorrectaD.Text = "D";
            RespuestaCorrectaD.UseVisualStyleBackColor = true;
            // 
            // AñadirPregunta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 280);
            Controls.Add(RespuestaCorrecta);
            Controls.Add(RespuestaCorrectaD);
            Controls.Add(RespuestaCorrectaC);
            Controls.Add(RespuestaCorrectaB);
            Controls.Add(RespuestaCorrectaA);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(Respuestas);
            Controls.Add(NumPreguntes);
            Controls.Add(Preguntas);
            Controls.Add(respuestaA);
            Controls.Add(buttonAnadir);
            Controls.Add(textBoxPregunta);
            Controls.Add(buttonAtras);
            Controls.Add(respuestaD);
            Controls.Add(respuestaC);
            Controls.Add(respuestaB);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            Name = "AñadirPregunta";
            Text = "Agregar preguntes";
            Load += AñadirPregunta_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox respuestaA;
        private Button buttonAnadir;
        private TextBox textBoxPregunta;
        private Button buttonAtras;
        private TextBox respuestaD;
        private TextBox respuestaC;
        private TextBox respuestaB;
        private Label Preguntas;
        private Label NumPreguntes;
        private Label Respuestas;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private RadioButton RespuestaCorrectaA;
        private RadioButton RespuestaCorrectaB;
        private RadioButton RespuestaCorrectaC;
        private Label RespuestaCorrecta;
        private RadioButton RespuestaCorrectaD;
    }
}

