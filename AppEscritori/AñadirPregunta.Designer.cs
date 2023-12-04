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
            labelXPreguntas = new Label();
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
            comboBoxIdiomas = new ComboBox();
            Idioma = new Label();
            groupBoxButtonsCO = new GroupBox();
            groupBoxButtonsCO.SuspendLayout();
            SuspendLayout();
            // 
            // respuestaA
            // 
            respuestaA.Location = new Point(34, 104);
            respuestaA.Margin = new Padding(4, 3, 4, 3);
            respuestaA.Name = "respuestaA";
            respuestaA.Size = new Size(512, 23);
            respuestaA.TabIndex = 12;
            respuestaA.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonAnadir
            // 
            buttonAnadir.Location = new Point(428, 244);
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
            textBoxPregunta.Location = new Point(87, 45);
            textBoxPregunta.Margin = new Padding(4, 3, 4, 3);
            textBoxPregunta.Name = "textBoxPregunta";
            textBoxPregunta.Size = new Size(459, 23);
            textBoxPregunta.TabIndex = 11;
            textBoxPregunta.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonAtras
            // 
            buttonAtras.Location = new Point(13, 244);
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
            respuestaD.Location = new Point(35, 191);
            respuestaD.Margin = new Padding(4, 3, 4, 3);
            respuestaD.Name = "respuestaD";
            respuestaD.Size = new Size(511, 23);
            respuestaD.TabIndex = 16;
            respuestaD.TextAlign = HorizontalAlignment.Center;
            // 
            // respuestaC
            // 
            respuestaC.Location = new Point(35, 162);
            respuestaC.Margin = new Padding(4, 3, 4, 3);
            respuestaC.Name = "respuestaC";
            respuestaC.Size = new Size(511, 23);
            respuestaC.TabIndex = 15;
            respuestaC.TextAlign = HorizontalAlignment.Center;
            // 
            // respuestaB
            // 
            respuestaB.Location = new Point(34, 133);
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
            Preguntas.Location = new Point(7, 45);
            Preguntas.Name = "Preguntas";
            Preguntas.Size = new Size(73, 21);
            Preguntas.TabIndex = 19;
            Preguntas.Text = "Pregunta";
            // 
            // labelXPreguntas
            // 
            labelXPreguntas.AutoSize = true;
            labelXPreguntas.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelXPreguntas.ForeColor = Color.Firebrick;
            labelXPreguntas.Location = new Point(397, 220);
            labelXPreguntas.Name = "labelXPreguntas";
            labelXPreguntas.Size = new Size(135, 21);
            labelXPreguntas.TabIndex = 20;
            labelXPreguntas.Text = "Hay X preguntas";
            // 
            // Respuestas
            // 
            Respuestas.AutoSize = true;
            Respuestas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Respuestas.Location = new Point(7, 80);
            Respuestas.Name = "Respuestas";
            Respuestas.Size = new Size(88, 21);
            Respuestas.TabIndex = 21;
            Respuestas.Text = "Respuestas";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(7, 106);
            label4.Name = "label4";
            label4.Size = new Size(20, 21);
            label4.TabIndex = 22;
            label4.Text = "A";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(8, 135);
            label5.Name = "label5";
            label5.Size = new Size(19, 21);
            label5.TabIndex = 23;
            label5.Text = "B";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(8, 164);
            label6.Name = "label6";
            label6.Size = new Size(20, 21);
            label6.TabIndex = 24;
            label6.Text = "C";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(7, 193);
            label7.Name = "label7";
            label7.Size = new Size(21, 21);
            label7.TabIndex = 25;
            label7.Text = "D";
            // 
            // RespuestaCorrectaA
            // 
            RespuestaCorrectaA.AutoSize = true;
            RespuestaCorrectaA.Location = new Point(0, 5);
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
            RespuestaCorrectaB.Location = new Point(42, 5);
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
            RespuestaCorrectaC.Location = new Point(80, 5);
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
            RespuestaCorrecta.Location = new Point(8, 220);
            RespuestaCorrecta.Name = "RespuestaCorrecta";
            RespuestaCorrecta.Size = new Size(141, 21);
            RespuestaCorrecta.TabIndex = 30;
            RespuestaCorrecta.Text = "Respuesta correcta";
            // 
            // RespuestaCorrectaD
            // 
            RespuestaCorrectaD.AutoSize = true;
            RespuestaCorrectaD.Location = new Point(119, 5);
            RespuestaCorrectaD.Name = "RespuestaCorrectaD";
            RespuestaCorrectaD.Size = new Size(33, 19);
            RespuestaCorrectaD.TabIndex = 29;
            RespuestaCorrectaD.TabStop = true;
            RespuestaCorrectaD.Text = "D";
            RespuestaCorrectaD.UseVisualStyleBackColor = true;
            // 
            // comboBoxIdiomas
            // 
            comboBoxIdiomas.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxIdiomas.FormattingEnabled = true;
            comboBoxIdiomas.Items.AddRange(new object[] { "Castellano", "Catalán", "Inglés" });
            comboBoxIdiomas.Location = new Point(87, 16);
            comboBoxIdiomas.Name = "comboBoxIdiomas";
            comboBoxIdiomas.Size = new Size(121, 23);
            comboBoxIdiomas.TabIndex = 31;
            comboBoxIdiomas.SelectedIndexChanged += comboBoxIdiomas_SelectedIndexChanged;
            // 
            // Idioma
            // 
            Idioma.AutoSize = true;
            Idioma.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Idioma.Location = new Point(8, 18);
            Idioma.Name = "Idioma";
            Idioma.Size = new Size(58, 21);
            Idioma.TabIndex = 32;
            Idioma.Text = "Idioma";
            // 
            // groupBoxButtonsCO
            // 
            groupBoxButtonsCO.Controls.Add(RespuestaCorrectaC);
            groupBoxButtonsCO.Controls.Add(RespuestaCorrectaA);
            groupBoxButtonsCO.Controls.Add(RespuestaCorrectaB);
            groupBoxButtonsCO.Controls.Add(RespuestaCorrectaD);
            groupBoxButtonsCO.Location = new Point(155, 220);
            groupBoxButtonsCO.Name = "groupBoxButtonsCO";
            groupBoxButtonsCO.Size = new Size(154, 30);
            groupBoxButtonsCO.TabIndex = 33;
            groupBoxButtonsCO.TabStop = false;
            // 
            // AñadirPregunta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 283);
            Controls.Add(groupBoxButtonsCO);
            Controls.Add(Idioma);
            Controls.Add(comboBoxIdiomas);
            Controls.Add(RespuestaCorrecta);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(Respuestas);
            Controls.Add(labelXPreguntas);
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
            groupBoxButtonsCO.ResumeLayout(false);
            groupBoxButtonsCO.PerformLayout();
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
        private Label labelXPreguntas;
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
        private ComboBox comboBoxIdiomas;
        private Label Idioma;
        private GroupBox groupBoxButtonsCO;
    }
}

