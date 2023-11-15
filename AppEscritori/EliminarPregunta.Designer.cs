namespace AppEscritori
{
    partial class EliminarPregunta
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
            label1RespostesIncorrectes = new Label();
            comboBox1Preguntes = new ComboBox();
            textBox1 = new TextBox();
            button1Enrere = new Button();
            button2Eliminar = new Button();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // label1RespostesIncorrectes
            // 
            label1RespostesIncorrectes.AutoSize = true;
            label1RespostesIncorrectes.Location = new Point(0, 69);
            label1RespostesIncorrectes.Margin = new Padding(4, 0, 4, 0);
            label1RespostesIncorrectes.Name = "label1RespostesIncorrectes";
            label1RespostesIncorrectes.Size = new Size(123, 15);
            label1RespostesIncorrectes.TabIndex = 0;
            label1RespostesIncorrectes.Text = "Respostes incorrectes:";
            // 
            // comboBox1Preguntes
            // 
            comboBox1Preguntes.FormattingEnabled = true;
            comboBox1Preguntes.Location = new Point(3, 6);
            comboBox1Preguntes.Margin = new Padding(4, 3, 4, 3);
            comboBox1Preguntes.Name = "comboBox1Preguntes";
            comboBox1Preguntes.Size = new Size(383, 23);
            comboBox1Preguntes.TabIndex = 1;
            comboBox1Preguntes.Text = "Pregunta";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 38);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(383, 23);
            textBox1.TabIndex = 2;
            textBox1.Text = "Resposta correcta";
            // 
            // button1Enrere
            // 
            button1Enrere.Location = new Point(3, 180);
            button1Enrere.Margin = new Padding(4, 3, 4, 3);
            button1Enrere.Name = "button1Enrere";
            button1Enrere.Size = new Size(88, 27);
            button1Enrere.TabIndex = 3;
            button1Enrere.Text = "Atrás";
            button1Enrere.UseVisualStyleBackColor = true;
            button1Enrere.Click += button1Enrere_Click;
            // 
            // button2Eliminar
            // 
            button2Eliminar.Location = new Point(453, 180);
            button2Eliminar.Margin = new Padding(4, 3, 4, 3);
            button2Eliminar.Name = "button2Eliminar";
            button2Eliminar.Size = new Size(88, 27);
            button2Eliminar.TabIndex = 4;
            button2Eliminar.Text = "Eliminar";
            button2Eliminar.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(3, 88);
            textBox2.Margin = new Padding(4, 3, 4, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(116, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(3, 119);
            textBox3.Margin = new Padding(4, 3, 4, 3);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(116, 23);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(3, 151);
            textBox4.Margin = new Padding(4, 3, 4, 3);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(116, 23);
            textBox4.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(394, 19);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(154, 25);
            label1.TabIndex = 8;
            label1.Text = "Hi ha X preguntes";
            label1.Click += label1_Click;
            // 
            // EliminarPregunta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 215);
            Controls.Add(label1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(button2Eliminar);
            Controls.Add(button1Enrere);
            Controls.Add(textBox1);
            Controls.Add(comboBox1Preguntes);
            Controls.Add(label1RespostesIncorrectes);
            Margin = new Padding(4, 3, 4, 3);
            Name = "EliminarPregunta";
            Text = "Formulari 12";
            Load += EliminarPregunta_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1RespostesIncorrectes;
        private ComboBox comboBox1Preguntes;
        private TextBox textBox1;
        private Button button1Enrere;
        private Button button2Eliminar;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label1;
    }
}
