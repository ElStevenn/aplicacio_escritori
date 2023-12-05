namespace AppEscritori
{
    partial class CampsFinal
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
            button_atras = new Button();
            button_generar = new Button();
            titulo = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            panel1 = new Panel();
            label3 = new Label();
            descripcion = new Label();
            ano_creacion = new Label();
            label4 = new Label();
            numero_inventario = new Label();
            label2 = new Label();
            nomb_elem = new Label();
            imagen_elemento = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imagen_elemento).BeginInit();
            SuspendLayout();
            // 
            // button_atras
            // 
            button_atras.Location = new Point(11, 342);
            button_atras.Margin = new Padding(2);
            button_atras.Name = "button_atras";
            button_atras.Size = new Size(87, 26);
            button_atras.TabIndex = 8;
            button_atras.Text = "Atrás";
            button_atras.UseVisualStyleBackColor = true;
            button_atras.Click += button_atras_Click;
            // 
            // button_generar
            // 
            button_generar.Location = new Point(237, 342);
            button_generar.Margin = new Padding(2);
            button_generar.Name = "button_generar";
            button_generar.Size = new Size(87, 26);
            button_generar.TabIndex = 9;
            button_generar.Text = "Confirmar";
            button_generar.UseVisualStyleBackColor = true;
            button_generar.Click += button_generar_Click;
            // 
            // titulo
            // 
            titulo.AutoSize = true;
            titulo.Font = new Font("Microsoft Sans Serif", 17.25F, FontStyle.Regular, GraphicsUnit.Point);
            titulo.ForeColor = Color.Red;
            titulo.Location = new Point(156, 9);
            titulo.Name = "titulo";
            titulo.Size = new Size(351, 29);
            titulo.TabIndex = 10;
            titulo.Text = "RESULTADO DEL ELEMENTO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(6, 29);
            label1.Name = "label1";
            label1.Size = new Size(62, 19);
            label1.TabIndex = 11;
            label1.Text = "Nombre:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(descripcion);
            groupBox1.Controls.Add(ano_creacion);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(numero_inventario);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(nomb_elem);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 65);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(312, 225);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Información principal del elemento";
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Location = new Point(6, 104);
            panel1.Name = "panel1";
            panel1.Size = new Size(297, 100);
            panel1.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(8, 8);
            label3.Name = "label3";
            label3.Size = new Size(115, 15);
            label3.TabIndex = 18;
            label3.Text = "{numero_inventario}";
            // 
            // descripcion
            // 
            descripcion.AutoSize = true;
            descripcion.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            descripcion.ForeColor = SystemColors.Highlight;
            descripcion.Location = new Point(6, 82);
            descripcion.Name = "descripcion";
            descripcion.Size = new Size(82, 19);
            descripcion.TabIndex = 17;
            descripcion.Text = "Descripción:";
            // 
            // ano_creacion
            // 
            ano_creacion.AutoSize = true;
            ano_creacion.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ano_creacion.ForeColor = Color.Black;
            ano_creacion.Location = new Point(218, 56);
            ano_creacion.Name = "ano_creacion";
            ano_creacion.Size = new Size(85, 15);
            ano_creacion.TabIndex = 16;
            ano_creacion.Text = "{ano_creacion}";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(218, 29);
            label4.Name = "label4";
            label4.Size = new Size(88, 19);
            label4.TabIndex = 15;
            label4.Text = "Año creación";
            // 
            // numero_inventario
            // 
            numero_inventario.AutoSize = true;
            numero_inventario.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            numero_inventario.ForeColor = Color.Black;
            numero_inventario.Location = new Point(88, 56);
            numero_inventario.Name = "numero_inventario";
            numero_inventario.Size = new Size(115, 15);
            numero_inventario.TabIndex = 14;
            numero_inventario.Text = "{numero_inventario}";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(88, 29);
            label2.Name = "label2";
            label2.Size = new Size(127, 19);
            label2.TabIndex = 13;
            label2.Text = "Número inventario:";
            // 
            // nomb_elem
            // 
            nomb_elem.AutoSize = true;
            nomb_elem.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            nomb_elem.ForeColor = Color.Black;
            nomb_elem.Location = new Point(8, 56);
            nomb_elem.Name = "nomb_elem";
            nomb_elem.RightToLeft = RightToLeft.No;
            nomb_elem.Size = new Size(78, 15);
            nomb_elem.TabIndex = 12;
            nomb_elem.Text = "{nomb_elem}";
            // 
            // imagen_elemento
            // 
            imagen_elemento.Location = new Point(361, 81);
            imagen_elemento.Name = "imagen_elemento";
            imagen_elemento.Size = new Size(191, 125);
            imagen_elemento.TabIndex = 13;
            imagen_elemento.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Highlight;
            label5.Location = new Point(361, 218);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 18;
            label5.Text = "Autonomía:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Highlight;
            label6.Location = new Point(457, 217);
            label6.Name = "label6";
            label6.Size = new Size(70, 15);
            label6.TabIndex = 19;
            label6.Text = "Autonomía:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.Highlight;
            label7.Location = new Point(361, 244);
            label7.Name = "label7";
            label7.Size = new Size(70, 15);
            label7.TabIndex = 20;
            label7.Text = "Autonomía:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.Highlight;
            label8.Location = new Point(457, 244);
            label8.Name = "label8";
            label8.Size = new Size(70, 15);
            label8.TabIndex = 21;
            label8.Text = "Autonomía:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.Highlight;
            label9.Location = new Point(361, 270);
            label9.Name = "label9";
            label9.Size = new Size(70, 15);
            label9.TabIndex = 22;
            label9.Text = "Autonomía:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.Highlight;
            label10.Location = new Point(457, 301);
            label10.Name = "label10";
            label10.Size = new Size(70, 15);
            label10.TabIndex = 23;
            label10.Text = "Autonomía:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.Highlight;
            label11.Location = new Point(457, 270);
            label11.Name = "label11";
            label11.Size = new Size(70, 15);
            label11.TabIndex = 23;
            label11.Text = "Autonomía:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.Highlight;
            label12.Location = new Point(361, 301);
            label12.Name = "label12";
            label12.Size = new Size(70, 15);
            label12.TabIndex = 24;
            label12.Text = "Autonomía:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = SystemColors.Highlight;
            label13.Location = new Point(361, 333);
            label13.Name = "label13";
            label13.Size = new Size(70, 15);
            label13.TabIndex = 25;
            label13.Text = "Autonomía:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = SystemColors.Highlight;
            label14.Location = new Point(457, 333);
            label14.Name = "label14";
            label14.Size = new Size(70, 15);
            label14.TabIndex = 26;
            label14.Text = "Autonomía:";
            // 
            // CampsFinal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(595, 379);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(imagen_elemento);
            Controls.Add(groupBox1);
            Controls.Add(titulo);
            Controls.Add(button_generar);
            Controls.Add(button_atras);
            Margin = new Padding(2);
            Name = "CampsFinal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Resultat";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imagen_elemento).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button_atras;
        private Button button_generar;
        private Label titulo;
        private Label label1;
        private GroupBox groupBox1;
        private Label nomb_elem;
        private Label label2;
        private Label numero_inventario;
        private PictureBox imagen_elemento;
        private Label ano_creacion;
        private Label label4;
        private Label descripcion;
        private Panel panel1;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
    }
}