namespace AplicacioEscritori
{
    partial class Form6
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
            this.comboBoxSelecElemento = new System.Windows.Forms.ComboBox();
            this.pictureBoxElemento = new System.Windows.Forms.PictureBox();
            this.labelNombreElemento = new System.Windows.Forms.Label();
            this.labelNumInventario = new System.Windows.Forms.Label();
            this.buttonAtras = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.labelSeleccionarElemento = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxElemento)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxSelecElemento
            // 
            this.comboBoxSelecElemento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelecElemento.FormattingEnabled = true;
            this.comboBoxSelecElemento.Items.AddRange(new object[] {
            "a",
            "b",
            "c",
            "d",
            "e",
            "f",
            "g",
            "i",
            "j",
            "k",
            "l",
            "m",
            "n",
            "o",
            "p",
            "q",
            "r",
            "s",
            "a",
            "a",
            "a",
            "a",
            "a",
            "a",
            "a",
            "a",
            "a",
            "a",
            "s",
            "d",
            "d",
            "d",
            "d",
            "df",
            "f",
            "f",
            "f",
            "f",
            "f",
            "f"});
            this.comboBoxSelecElemento.Location = new System.Drawing.Point(12, 37);
            this.comboBoxSelecElemento.Name = "comboBoxSelecElemento";
            this.comboBoxSelecElemento.Size = new System.Drawing.Size(494, 21);
            this.comboBoxSelecElemento.TabIndex = 0;
            // 
            // pictureBoxElemento
            // 
            this.pictureBoxElemento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxElemento.Location = new System.Drawing.Point(12, 70);
            this.pictureBoxElemento.Name = "pictureBoxElemento";
            this.pictureBoxElemento.Size = new System.Drawing.Size(209, 147);
            this.pictureBoxElemento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxElemento.TabIndex = 1;
            this.pictureBoxElemento.TabStop = false;
            // 
            // labelNombreElemento
            // 
            this.labelNombreElemento.AutoSize = true;
            this.labelNombreElemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreElemento.Location = new System.Drawing.Point(227, 103);
            this.labelNombreElemento.Name = "labelNombreElemento";
            this.labelNombreElemento.Size = new System.Drawing.Size(221, 26);
            this.labelNombreElemento.TabIndex = 2;
            this.labelNombreElemento.Text = "Nombre del elemento";
            // 
            // labelNumInventario
            // 
            this.labelNumInventario.AutoSize = true;
            this.labelNumInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumInventario.Location = new System.Drawing.Point(227, 159);
            this.labelNumInventario.Name = "labelNumInventario";
            this.labelNumInventario.Size = new System.Drawing.Size(221, 26);
            this.labelNumInventario.TabIndex = 3;
            this.labelNumInventario.Text = "Numero de Inventario";
            // 
            // buttonAtras
            // 
            this.buttonAtras.Location = new System.Drawing.Point(12, 258);
            this.buttonAtras.Name = "buttonAtras";
            this.buttonAtras.Size = new System.Drawing.Size(191, 23);
            this.buttonAtras.TabIndex = 4;
            this.buttonAtras.Text = "Atrás";
            this.buttonAtras.UseVisualStyleBackColor = true;
            // 
            // buttonModificar
            // 
            this.buttonModificar.Location = new System.Drawing.Point(315, 258);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(191, 23);
            this.buttonModificar.TabIndex = 5;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            // 
            // labelSeleccionarElemento
            // 
            this.labelSeleccionarElemento.AutoSize = true;
            this.labelSeleccionarElemento.Location = new System.Drawing.Point(12, 18);
            this.labelSeleccionarElemento.Name = "labelSeleccionarElemento";
            this.labelSeleccionarElemento.Size = new System.Drawing.Size(117, 13);
            this.labelSeleccionarElemento.TabIndex = 6;
            this.labelSeleccionarElemento.Text = "Selecciona el elemento";
            // 
            // ModificarElemento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 304);
            this.Controls.Add(this.labelSeleccionarElemento);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.buttonAtras);
            this.Controls.Add(this.labelNumInventario);
            this.Controls.Add(this.labelNombreElemento);
            this.Controls.Add(this.pictureBoxElemento);
            this.Controls.Add(this.comboBoxSelecElemento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ModificarElemento";
            this.Text = "ModificarElemento";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxElemento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSelecElemento;
        private System.Windows.Forms.PictureBox pictureBoxElemento;
        private System.Windows.Forms.Label labelNombreElemento;
        private System.Windows.Forms.Label labelNumInventario;
        private System.Windows.Forms.Button buttonAtras;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Label labelSeleccionarElemento;
    }
}