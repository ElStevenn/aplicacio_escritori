namespace AplicacioEscritori
{
    partial class Form13
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
            this.textBoxformulario13 = new System.Windows.Forms.TextBox();
            this.button_facil = new System.Windows.Forms.Button();
            this.button_normal = new System.Windows.Forms.Button();
            this.button_dificil = new System.Windows.Forms.Button();
            this.button_atras13 = new System.Windows.Forms.Button();
            this.textBox_dificultad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxformulario13
            // 
            this.textBoxformulario13.Location = new System.Drawing.Point(13, 13);
            this.textBoxformulario13.Name = "textBoxformulario13";
            this.textBoxformulario13.Size = new System.Drawing.Size(295, 31);
            this.textBoxformulario13.TabIndex = 0;
            this.textBoxformulario13.Text = "formulario 13";
            // 
            // button_facil
            // 
            this.button_facil.Location = new System.Drawing.Point(218, 122);
            this.button_facil.Name = "button_facil";
            this.button_facil.Size = new System.Drawing.Size(295, 90);
            this.button_facil.TabIndex = 1;
            this.button_facil.Text = "Fácil";
            this.button_facil.UseVisualStyleBackColor = true;
            // 
            // button_normal
            // 
            this.button_normal.Location = new System.Drawing.Point(218, 232);
            this.button_normal.Name = "button_normal";
            this.button_normal.Size = new System.Drawing.Size(295, 82);
            this.button_normal.TabIndex = 2;
            this.button_normal.Text = "Normal";
            this.button_normal.UseVisualStyleBackColor = true;
            // 
            // button_dificil
            // 
            this.button_dificil.Location = new System.Drawing.Point(218, 334);
            this.button_dificil.Name = "button_dificil";
            this.button_dificil.Size = new System.Drawing.Size(295, 92);
            this.button_dificil.TabIndex = 3;
            this.button_dificil.Text = "Difícil";
            this.button_dificil.UseVisualStyleBackColor = true;
            // 
            // button_atras13
            // 
            this.button_atras13.Location = new System.Drawing.Point(12, 424);
            this.button_atras13.Name = "button_atras13";
            this.button_atras13.Size = new System.Drawing.Size(200, 54);
            this.button_atras13.TabIndex = 4;
            this.button_atras13.Text = "Atrás";
            this.button_atras13.UseVisualStyleBackColor = true;
            // 
            // textBox_dificultad
            // 
            this.textBox_dificultad.Location = new System.Drawing.Point(203, 68);
            this.textBox_dificultad.Name = "textBox_dificultad";
            this.textBox_dificultad.Size = new System.Drawing.Size(329, 31);
            this.textBox_dificultad.TabIndex = 5;
            this.textBox_dificultad.Text = "Que dificultad quieres configurar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 521);
            this.Controls.Add(this.textBox_dificultad);
            this.Controls.Add(this.button_atras13);
            this.Controls.Add(this.button_dificil);
            this.Controls.Add(this.button_normal);
            this.Controls.Add(this.button_facil);
            this.Controls.Add(this.textBoxformulario13);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxformulario13;
        private System.Windows.Forms.Button button_facil;
        private System.Windows.Forms.Button button_normal;
        private System.Windows.Forms.Button button_dificil;
        private System.Windows.Forms.Button button_atras13;
        private System.Windows.Forms.TextBox textBox_dificultad;
    }
}