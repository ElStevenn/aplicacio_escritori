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
            ano_creacion = new Label();
            label4 = new Label();
            numero_inventario = new Label();
            label2 = new Label();
            nombr_elem = new Label();
            imagen_elemento = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imagen_elemento).BeginInit();
            SuspendLayout();
            // 
            // button_atras
            // 
            button_atras.Location = new Point(18, 318);
            button_atras.Margin = new Padding(2);
            button_atras.Name = "button_atras";
            button_atras.Size = new Size(122, 26);
            button_atras.TabIndex = 8;
            button_atras.Text = "Enrere";
            button_atras.UseVisualStyleBackColor = true;
            button_atras.Click += button_atras_Click;
            // 
            // button_generar
            // 
            button_generar.Location = new Point(437, 318);
            button_generar.Margin = new Padding(2);
            button_generar.Name = "button_generar";
            button_generar.Size = new Size(146, 26);
            button_generar.TabIndex = 9;
            button_generar.Text = "Confirmar";
            button_generar.UseVisualStyleBackColor = true;
            button_generar.Click += button_generar_Click;
            // 
            // titulo
            // 
            titulo.AutoSize = true;
            titulo.Font = new Font("Microsoft Sans Serif", 17.25F, FontStyle.Bold, GraphicsUnit.Point);
            titulo.ForeColor = Color.Red;
            titulo.Location = new Point(118, 9);
            titulo.Name = "titulo";
            titulo.Size = new Size(337, 29);
            titulo.TabIndex = 10;
            titulo.Text = "RESULTAT DE L'ELEMENT";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(13, 29);
            label1.Name = "label1";
            label1.Size = new Size(48, 21);
            label1.TabIndex = 11;
            label1.Text = "Nom:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ano_creacion);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(numero_inventario);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(nombr_elem);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 65);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(312, 225);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informació principal de l'element";
            // 
            // ano_creacion
            // 
            ano_creacion.AutoSize = true;
            ano_creacion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ano_creacion.ForeColor = Color.Black;
            ano_creacion.Location = new Point(181, 56);
            ano_creacion.Name = "ano_creacion";
            ano_creacion.Size = new Size(111, 21);
            ano_creacion.TabIndex = 16;
            ano_creacion.Text = "{ano_creacion}";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(181, 29);
            label4.Name = "label4";
            label4.Size = new Size(114, 21);
            label4.TabIndex = 15;
            label4.Text = "Any de creació:";
            // 
            // numero_inventario
            // 
            numero_inventario.AutoSize = true;
            numero_inventario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numero_inventario.ForeColor = Color.Black;
            numero_inventario.Location = new Point(6, 116);
            numero_inventario.Name = "numero_inventario";
            numero_inventario.Size = new Size(152, 21);
            numero_inventario.TabIndex = 14;
            numero_inventario.Text = "{numero_inventario}";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(6, 95);
            label2.Name = "label2";
            label2.Size = new Size(149, 21);
            label2.TabIndex = 13;
            label2.Text = "Número d'inventari:";
            // 
            // nombr_elem
            // 
            nombr_elem.AutoSize = true;
            nombr_elem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nombr_elem.ForeColor = Color.Black;
            nombr_elem.Location = new Point(6, 56);
            nombr_elem.Name = "nombr_elem";
            nombr_elem.RightToLeft = RightToLeft.No;
            nombr_elem.Size = new Size(102, 21);
            nombr_elem.TabIndex = 12;
            nombr_elem.Text = "{nomb_elem}";
            // 
            // imagen_elemento
            // 
            imagen_elemento.Location = new Point(330, 107);
            imagen_elemento.Name = "imagen_elemento";
            imagen_elemento.Size = new Size(253, 162);
            imagen_elemento.TabIndex = 13;
            imagen_elemento.TabStop = false;
            // 
            // CampsFinal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(595, 350);
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
        private Label nombr_elem;
        private Label label2;
        private Label numero_inventario;
        private PictureBox imagen_elemento;
        private Label ano_creacion;
        private Label label4;
    }
}