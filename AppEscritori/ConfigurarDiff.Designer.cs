namespace AppEscritori
{
    partial class ConfigurarDiff
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
            buttonNormal = new Button();
            button_atras13 = new Button();
            labelCreando = new Label();
            buttonFacil = new Button();
            buttonDificil = new Button();
            SuspendLayout();
            // 
            // buttonNormal
            // 
            buttonNormal.Location = new Point(48, 97);
            buttonNormal.Margin = new Padding(2);
            buttonNormal.Name = "buttonNormal";
            buttonNormal.Size = new Size(172, 49);
            buttonNormal.TabIndex = 2;
            buttonNormal.Text = "Normal";
            buttonNormal.UseVisualStyleBackColor = true;
            // 
            // button_atras13
            // 
            button_atras13.Location = new Point(73, 203);
            button_atras13.Margin = new Padding(2);
            button_atras13.Name = "button_atras13";
            button_atras13.Size = new Size(117, 32);
            button_atras13.TabIndex = 4;
            button_atras13.Text = "Atrás";
            button_atras13.UseVisualStyleBackColor = true;
            // 
            // labelCreando
            // 
            labelCreando.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelCreando.Location = new Point(9, 9);
            labelCreando.Margin = new Padding(4, 0, 4, 0);
            labelCreando.Name = "labelCreando";
            labelCreando.Size = new Size(260, 45);
            labelCreando.TabIndex = 20;
            labelCreando.Text = "Selecciona la dificultad a configurar";
            labelCreando.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonFacil
            // 
            buttonFacil.Location = new Point(48, 44);
            buttonFacil.Margin = new Padding(2);
            buttonFacil.Name = "buttonFacil";
            buttonFacil.Size = new Size(172, 49);
            buttonFacil.TabIndex = 21;
            buttonFacil.Text = "Fácil";
            buttonFacil.UseVisualStyleBackColor = true;
            // 
            // buttonDificil
            // 
            buttonDificil.Location = new Point(48, 150);
            buttonDificil.Margin = new Padding(2);
            buttonDificil.Name = "buttonDificil";
            buttonDificil.Size = new Size(172, 49);
            buttonDificil.TabIndex = 22;
            buttonDificil.Text = "Difícil";
            buttonDificil.UseVisualStyleBackColor = true;
            // 
            // ConfigurarDiff
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(269, 243);
            Controls.Add(buttonDificil);
            Controls.Add(buttonFacil);
            Controls.Add(labelCreando);
            Controls.Add(button_atras13);
            Controls.Add(buttonNormal);
            Margin = new Padding(2);
            Name = "ConfigurarDiff";
            Text = "Form13";
            ResumeLayout(false);
        }

        #endregion
        private Button button_facil;
        private Button buttonNormal;
        private Button button_dificil;
        private Button button_atras13;
        private Label labelCreando;
        private Button buttonFacil;
        private Button buttonDificil;
    }
}
