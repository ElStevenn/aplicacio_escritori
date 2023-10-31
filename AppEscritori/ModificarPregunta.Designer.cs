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
            this.comboBoxPreguntas = new System.Windows.Forms.ComboBox();
            this.textBoxRespCorrecta = new System.Windows.Forms.TextBox();
            this.labelModRespIncorrecta = new System.Windows.Forms.Label();
            this.textBoxRespInc1 = new System.Windows.Forms.TextBox();
            this.textBoxRespInc2 = new System.Windows.Forms.TextBox();
            this.textBoxRespInc3 = new System.Windows.Forms.TextBox();
            this.buttonAtras = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.labelRespCorrecta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxPreguntas
            // 
            this.comboBoxPreguntas.FormattingEnabled = true;
            this.comboBoxPreguntas.Items.AddRange(new object[] {
            "Pregunta 1",
            "Pregunta 2",
            "Pregunta 3",
            "Pregunta 4",
            "Pregunta 5",
            "Pregunta 6",
            "Pregunta 7",
            "Pregunta 8",
            "Pregunta 9",
            "Pregunta 10"});
            this.comboBoxPreguntas.Location = new System.Drawing.Point(12, 12);
            this.comboBoxPreguntas.Name = "comboBoxPreguntas";
            this.comboBoxPreguntas.Size = new System.Drawing.Size(396, 21);
            this.comboBoxPreguntas.TabIndex = 0;
            this.comboBoxPreguntas.Text = "(Pregunta)";
            // 
            // textBoxRespCorrecta
            // 
            this.textBoxRespCorrecta.Location = new System.Drawing.Point(12, 58);
            this.textBoxRespCorrecta.Name = "textBoxRespCorrecta";
            this.textBoxRespCorrecta.Size = new System.Drawing.Size(291, 20);
            this.textBoxRespCorrecta.TabIndex = 1;
            this.textBoxRespCorrecta.Text = "Respuesta Correcta";
            // 
            // labelModRespIncorrecta
            // 
            this.labelModRespIncorrecta.AutoSize = true;
            this.labelModRespIncorrecta.Location = new System.Drawing.Point(9, 92);
            this.labelModRespIncorrecta.Name = "labelModRespIncorrecta";
            this.labelModRespIncorrecta.Size = new System.Drawing.Size(172, 13);
            this.labelModRespIncorrecta.TabIndex = 2;
            this.labelModRespIncorrecta.Text = "Modifica las respuestas incorrectas";
            this.labelModRespIncorrecta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxRespInc1
            // 
            this.textBoxRespInc1.Location = new System.Drawing.Point(12, 108);
            this.textBoxRespInc1.Name = "textBoxRespInc1";
            this.textBoxRespInc1.Size = new System.Drawing.Size(291, 20);
            this.textBoxRespInc1.TabIndex = 3;
            this.textBoxRespInc1.Text = "Respuesta Incorrecta";
            // 
            // textBoxRespInc2
            // 
            this.textBoxRespInc2.Location = new System.Drawing.Point(12, 134);
            this.textBoxRespInc2.Name = "textBoxRespInc2";
            this.textBoxRespInc2.Size = new System.Drawing.Size(291, 20);
            this.textBoxRespInc2.TabIndex = 4;
            this.textBoxRespInc2.Text = "Respuesta Incorrecta";
            // 
            // textBoxRespInc3
            // 
            this.textBoxRespInc3.Location = new System.Drawing.Point(12, 160);
            this.textBoxRespInc3.Name = "textBoxRespInc3";
            this.textBoxRespInc3.Size = new System.Drawing.Size(291, 20);
            this.textBoxRespInc3.TabIndex = 5;
            this.textBoxRespInc3.Text = "Respuesta Incorrecta";
            // 
            // buttonAtras
            // 
            this.buttonAtras.Location = new System.Drawing.Point(12, 196);
            this.buttonAtras.Name = "buttonAtras";
            this.buttonAtras.Size = new System.Drawing.Size(75, 23);
            this.buttonAtras.TabIndex = 6;
            this.buttonAtras.Text = "Atrás";
            this.buttonAtras.UseVisualStyleBackColor = true;
            // 
            // buttonModificar
            // 
            this.buttonModificar.Location = new System.Drawing.Point(333, 196);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(75, 23);
            this.buttonModificar.TabIndex = 7;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            // 
            // labelRespCorrecta
            // 
            this.labelRespCorrecta.AutoSize = true;
            this.labelRespCorrecta.Location = new System.Drawing.Point(9, 42);
            this.labelRespCorrecta.Name = "labelRespCorrecta";
            this.labelRespCorrecta.Size = new System.Drawing.Size(154, 13);
            this.labelRespCorrecta.TabIndex = 8;
            this.labelRespCorrecta.Text = "Introduce la respuesta correcta";
            // 
            // ModificarPregunta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 228);
            this.Controls.Add(this.labelRespCorrecta);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.buttonAtras);
            this.Controls.Add(this.textBoxRespInc3);
            this.Controls.Add(this.textBoxRespInc2);
            this.Controls.Add(this.textBoxRespInc1);
            this.Controls.Add(this.labelModRespIncorrecta);
            this.Controls.Add(this.textBoxRespCorrecta);
            this.Controls.Add(this.comboBoxPreguntas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ModificarPregunta";
            this.Text = "Modificar Pregunta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxPreguntas;
        private System.Windows.Forms.TextBox textBoxRespCorrecta;
        private System.Windows.Forms.Label labelModRespIncorrecta;
        private System.Windows.Forms.TextBox textBoxRespInc1;
        private System.Windows.Forms.TextBox textBoxRespInc2;
        private System.Windows.Forms.TextBox textBoxRespInc3;
        private System.Windows.Forms.Button buttonAtras;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Label labelRespCorrecta;
    }
}