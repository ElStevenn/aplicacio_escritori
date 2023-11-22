namespace AppEscritori
{
    partial class ModificarPregunta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBoxPreguntas = new ComboBox();
            textBoxRespCorrecta = new TextBox();
            labelModRespIncorrecta = new Label();
            textBoxRespInc1 = new TextBox();
            textBoxRespInc2 = new TextBox();
            textBoxRespInc3 = new TextBox();
            buttonAtras = new Button();
            buttonModificar = new Button();
            labelRespCorrecta = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // comboBoxPreguntas
            // 
            comboBoxPreguntas.FormattingEnabled = true;
            comboBoxPreguntas.Items.AddRange(new object[] { "Pregunta 1", "Pregunta 2", "Pregunta 3", "Pregunta 4", "Pregunta 5", "Pregunta 6", "Pregunta 7", "Pregunta 8", "Pregunta 9", "Pregunta 10" });
            comboBoxPreguntas.Location = new Point(14, 27);
            comboBoxPreguntas.Margin = new Padding(4, 3, 4, 3);
            comboBoxPreguntas.Name = "comboBoxPreguntas";
            comboBoxPreguntas.Size = new Size(461, 23);
            comboBoxPreguntas.TabIndex = 0;
            comboBoxPreguntas.Text = "(Pregunta)";
            // 
            // textBoxRespCorrecta
            // 
            textBoxRespCorrecta.Location = new Point(14, 80);
            textBoxRespCorrecta.Margin = new Padding(4, 3, 4, 3);
            textBoxRespCorrecta.Name = "textBoxRespCorrecta";
            textBoxRespCorrecta.Size = new Size(339, 23);
            textBoxRespCorrecta.TabIndex = 1;
            textBoxRespCorrecta.Text = "Respuesta Correcta";
            // 
            // labelModRespIncorrecta
            // 
            labelModRespIncorrecta.AutoSize = true;
            labelModRespIncorrecta.Location = new Point(14, 120);
            labelModRespIncorrecta.Margin = new Padding(4, 0, 4, 0);
            labelModRespIncorrecta.Name = "labelModRespIncorrecta";
            labelModRespIncorrecta.Size = new Size(190, 15);
            labelModRespIncorrecta.TabIndex = 2;
            labelModRespIncorrecta.Text = "Modifica las respuestas incorrectas";
            labelModRespIncorrecta.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxRespInc1
            // 
            textBoxRespInc1.Location = new Point(14, 138);
            textBoxRespInc1.Margin = new Padding(4, 3, 4, 3);
            textBoxRespInc1.Name = "textBoxRespInc1";
            textBoxRespInc1.Size = new Size(339, 23);
            textBoxRespInc1.TabIndex = 3;
            textBoxRespInc1.Text = "Respuesta Incorrecta";
            // 
            // textBoxRespInc2
            // 
            textBoxRespInc2.Location = new Point(14, 168);
            textBoxRespInc2.Margin = new Padding(4, 3, 4, 3);
            textBoxRespInc2.Name = "textBoxRespInc2";
            textBoxRespInc2.Size = new Size(339, 23);
            textBoxRespInc2.TabIndex = 4;
            textBoxRespInc2.Text = "Respuesta Incorrecta";
            // 
            // textBoxRespInc3
            // 
            textBoxRespInc3.Location = new Point(14, 197);
            textBoxRespInc3.Margin = new Padding(4, 3, 4, 3);
            textBoxRespInc3.Name = "textBoxRespInc3";
            textBoxRespInc3.Size = new Size(339, 23);
            textBoxRespInc3.TabIndex = 5;
            textBoxRespInc3.Text = "Respuesta Incorrecta";
            // 
            // buttonAtras
            // 
            buttonAtras.Location = new Point(14, 246);
            buttonAtras.Margin = new Padding(4, 3, 4, 3);
            buttonAtras.Name = "buttonAtras";
            buttonAtras.Size = new Size(88, 27);
            buttonAtras.TabIndex = 6;
            buttonAtras.Text = "Atrás";
            buttonAtras.UseVisualStyleBackColor = true;
            buttonAtras.Click += buttonAtras_Click;
            // 
            // buttonModificar
            // 
            buttonModificar.Location = new Point(401, 246);
            buttonModificar.Margin = new Padding(4, 3, 4, 3);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Size = new Size(88, 27);
            buttonModificar.TabIndex = 7;
            buttonModificar.Text = "Modificar";
            buttonModificar.UseVisualStyleBackColor = true;
            // 
            // labelRespCorrecta
            // 
            labelRespCorrecta.AutoSize = true;
            labelRespCorrecta.Location = new Point(10, 61);
            labelRespCorrecta.Margin = new Padding(4, 0, 4, 0);
            labelRespCorrecta.Name = "labelRespCorrecta";
            labelRespCorrecta.Size = new Size(169, 15);
            labelRespCorrecta.TabIndex = 8;
            labelRespCorrecta.Text = "Introduce la respuesta correcta";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 9;
            label1.Text = "Pregunta";
            // 
            // ModificarPregunta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 286);
            Controls.Add(label1);
            Controls.Add(labelRespCorrecta);
            Controls.Add(buttonModificar);
            Controls.Add(buttonAtras);
            Controls.Add(textBoxRespInc3);
            Controls.Add(textBoxRespInc2);
            Controls.Add(textBoxRespInc1);
            Controls.Add(labelModRespIncorrecta);
            Controls.Add(textBoxRespCorrecta);
            Controls.Add(comboBoxPreguntas);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "ModificarPregunta";
            Text = "Modificar Pregunta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxPreguntas;
        private TextBox textBoxRespCorrecta;
        private Label labelModRespIncorrecta;
        private TextBox textBoxRespInc1;
        private TextBox textBoxRespInc2;
        private TextBox textBoxRespInc3;
        private Button buttonAtras;
        private Button buttonModificar;
        private Label labelRespCorrecta;
        private Label label1;
    }
}