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
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button_atras
            // 
            button_atras.Location = new Point(11, 256);
            button_atras.Margin = new Padding(2);
            button_atras.Name = "button_atras";
            button_atras.Size = new Size(87, 26);
            button_atras.TabIndex = 8;
            button_atras.Text = "Enerere";
            button_atras.UseVisualStyleBackColor = true;
            button_atras.Click += button_atras_Click;
            // 
            // button_generar
            // 
            button_generar.Location = new Point(413, 256);
            button_generar.Margin = new Padding(2);
            button_generar.Name = "button_generar";
            button_generar.Size = new Size(87, 26);
            button_generar.TabIndex = 9;
            button_generar.Text = "Confirmar";
            button_generar.UseVisualStyleBackColor = true;
            button_generar.Click += button_generar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 19);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 10;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 34);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 11;
            label2.Text = "label2";
            // 
            // CampsFinal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 293);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button_generar);
            Controls.Add(button_atras);
            Margin = new Padding(2);
            Name = "CampsFinal";
            Text = "Camps finals";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button_atras;
        private Button button_generar;
        private Label label1;
        private Label label2;
    }
}