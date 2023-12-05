namespace AppEscritori
{
    partial class ModificarElemento
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
            comboBoxSelecElemento = new ComboBox();
            pictureBoxElemento = new PictureBox();
            labelNombreElemento = new Label();
            labelNumInventario = new Label();
            buttonAtras = new Button();
            buttonModificar = new Button();
            labelSeleccionarElemento = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxElemento).BeginInit();
            SuspendLayout();
            // 
            // comboBoxSelecElemento
            // 
            comboBoxSelecElemento.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSelecElemento.FormattingEnabled = true;
            comboBoxSelecElemento.Items.AddRange(new object[] { "a", "b", "c", "d", "e", "f", "g", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "s", "d", "d", "d", "d", "df", "f", "f", "f", "f", "f", "f" });
            comboBoxSelecElemento.Location = new Point(14, 43);
            comboBoxSelecElemento.Margin = new Padding(4, 3, 4, 3);
            comboBoxSelecElemento.Name = "comboBoxSelecElemento";
            comboBoxSelecElemento.Size = new Size(576, 23);
            comboBoxSelecElemento.TabIndex = 0;
            // 
            // pictureBoxElemento
            // 
            pictureBoxElemento.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxElemento.Location = new Point(14, 81);
            pictureBoxElemento.Margin = new Padding(4, 3, 4, 3);
            pictureBoxElemento.Name = "pictureBoxElemento";
            pictureBoxElemento.Size = new Size(243, 169);
            pictureBoxElemento.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBoxElemento.TabIndex = 1;
            pictureBoxElemento.TabStop = false;
            // 
            // labelNombreElemento
            // 
            labelNombreElemento.AutoSize = true;
            labelNombreElemento.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            labelNombreElemento.Location = new Point(265, 119);
            labelNombreElemento.Margin = new Padding(4, 0, 4, 0);
            labelNombreElemento.Name = "labelNombreElemento";
            labelNombreElemento.Size = new Size(221, 26);
            labelNombreElemento.TabIndex = 2;
            labelNombreElemento.Text = "Nombre del elemento";
            // 
            // labelNumInventario
            // 
            labelNumInventario.AutoSize = true;
            labelNumInventario.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            labelNumInventario.Location = new Point(265, 183);
            labelNumInventario.Margin = new Padding(4, 0, 4, 0);
            labelNumInventario.Name = "labelNumInventario";
            labelNumInventario.Size = new Size(221, 26);
            labelNumInventario.TabIndex = 3;
            labelNumInventario.Text = "Numero de Inventario";
            // 
            // buttonAtras
            // 
            buttonAtras.Location = new Point(14, 298);
            buttonAtras.Margin = new Padding(4, 3, 4, 3);
            buttonAtras.Name = "buttonAtras";
            buttonAtras.Size = new Size(223, 27);
            buttonAtras.TabIndex = 4;
            buttonAtras.Text = "Atrás";
            buttonAtras.UseVisualStyleBackColor = true;
            buttonAtras.Click += buttonAtras_Click;
            // 
            // buttonModificar
            // 
            buttonModificar.Location = new Point(368, 298);
            buttonModificar.Margin = new Padding(4, 3, 4, 3);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Size = new Size(223, 27);
            buttonModificar.TabIndex = 5;
            buttonModificar.Text = "Modificar";
            buttonModificar.UseVisualStyleBackColor = true;
            buttonModificar.Click += buttonModificar_Click;
            // 
            // labelSeleccionarElemento
            // 
            labelSeleccionarElemento.AutoSize = true;
            labelSeleccionarElemento.Location = new Point(14, 21);
            labelSeleccionarElemento.Margin = new Padding(4, 0, 4, 0);
            labelSeleccionarElemento.Name = "labelSeleccionarElemento";
            labelSeleccionarElemento.Size = new Size(128, 15);
            labelSeleccionarElemento.TabIndex = 6;
            labelSeleccionarElemento.Text = "Selecciona el elemento";
            // 
            // ModificarElemento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 351);
            Controls.Add(labelSeleccionarElemento);
            Controls.Add(buttonModificar);
            Controls.Add(buttonAtras);
            Controls.Add(labelNumInventario);
            Controls.Add(labelNombreElemento);
            Controls.Add(pictureBoxElemento);
            Controls.Add(comboBoxSelecElemento);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "ModificarElemento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ModificarElemento";
            ((System.ComponentModel.ISupportInitialize)pictureBoxElemento).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxSelecElemento;
        private PictureBox pictureBoxElemento;
        private Label labelNombreElemento;
        private Label labelNumInventario;
        private Button buttonAtras;
        private Button buttonModificar;
        private Label labelSeleccionarElemento;
    }
}