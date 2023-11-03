namespace AppEscritori
{
    partial class ConfigurarPreguntas
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
            buttonAnadir = new Button();
            buttonModificar = new Button();
            buttonEliminar = new Button();
            buttonAtrasConfPreg = new Button();
            SuspendLayout();
            // 
            // buttonAnadir
            // 
            buttonAnadir.Location = new Point(13, 12);
            buttonAnadir.Margin = new Padding(4, 3, 4, 3);
            buttonAnadir.Name = "buttonAnadir";
            buttonAnadir.Size = new Size(160, 29);
            buttonAnadir.TabIndex = 0;
            buttonAnadir.Text = "AñadirPreg";
            buttonAnadir.UseVisualStyleBackColor = true;
            // 
            // buttonModificar
            // 
            buttonModificar.Location = new Point(13, 48);
            buttonModificar.Margin = new Padding(4, 3, 4, 3);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Size = new Size(160, 29);
            buttonModificar.TabIndex = 1;
            buttonModificar.Text = "ModificarPreg";
            buttonModificar.UseVisualStyleBackColor = true;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Location = new Point(13, 84);
            buttonEliminar.Margin = new Padding(4, 3, 4, 3);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(160, 29);
            buttonEliminar.TabIndex = 2;
            buttonEliminar.Text = "EliminarPreg";
            buttonEliminar.UseVisualStyleBackColor = true;
            // 
            // buttonAtrasConfPreg
            // 
            buttonAtrasConfPreg.Location = new Point(52, 119);
            buttonAtrasConfPreg.Margin = new Padding(4, 3, 4, 3);
            buttonAtrasConfPreg.Name = "buttonAtrasConfPreg";
            buttonAtrasConfPreg.Size = new Size(80, 29);
            buttonAtrasConfPreg.TabIndex = 3;
            buttonAtrasConfPreg.Text = "Atrás";
            buttonAtrasConfPreg.UseVisualStyleBackColor = true;
            // 
            // ConfigurarPreguntas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(187, 155);
            Controls.Add(buttonAtrasConfPreg);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonModificar);
            Controls.Add(buttonAnadir);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "ConfigurarPreguntas";
            Text = "Configuración Preguntas";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonAnadir;
        private Button buttonModificar;
        private Button buttonEliminar;
        private Button buttonAtrasConfPreg;
    }
}