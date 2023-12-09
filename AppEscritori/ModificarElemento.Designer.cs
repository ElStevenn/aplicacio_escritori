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
            selecElemento = new ComboBox();
            labelNombreElemento = new Label();
            buttonAtras = new Button();
            buttonModificar = new Button();
            labelSeleccionarElemento = new Label();
            label1 = new Label();
            foto_elemento = new PictureBox();
            label2 = new Label();
            labnumInventario = new Label();
            ((System.ComponentModel.ISupportInitialize)foto_elemento).BeginInit();
            SuspendLayout();
            // 
            // selecElemento
            // 
            selecElemento.FlatStyle = FlatStyle.System;
            selecElemento.FormattingEnabled = true;
            selecElemento.ImeMode = ImeMode.On;
            selecElemento.Items.AddRange(new object[] { "item1", "item2", "item4" });
            selecElemento.Location = new Point(11, 88);
            selecElemento.Margin = new Padding(4, 3, 4, 3);
            selecElemento.Name = "selecElemento";
            selecElemento.Size = new Size(243, 23);
            selecElemento.TabIndex = 0;
            selecElemento.SelectedIndexChanged += selecElemento_SelectedIndexChanged;
            // 
            // labelNombreElemento
            // 
            labelNombreElemento.AutoSize = true;
            labelNombreElemento.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelNombreElemento.Location = new Point(23, 141);
            labelNombreElemento.Margin = new Padding(4, 0, 4, 0);
            labelNombreElemento.Name = "labelNombreElemento";
            labelNombreElemento.Size = new Size(235, 25);
            labelNombreElemento.TabIndex = 2;
            labelNombreElemento.Text = "Nombre del elemento";
            // 
            // buttonAtras
            // 
            buttonAtras.Location = new Point(11, 349);
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
            buttonModificar.Location = new Point(373, 349);
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
            labelSeleccionarElemento.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelSeleccionarElemento.Location = new Point(13, 66);
            labelSeleccionarElemento.Margin = new Padding(4, 0, 4, 0);
            labelSeleccionarElemento.Name = "labelSeleccionarElemento";
            labelSeleccionarElemento.Size = new Size(146, 19);
            labelSeleccionarElemento.TabIndex = 6;
            labelSeleccionarElemento.Text = "Selecciona el elemento";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(199, 18);
            label1.Name = "label1";
            label1.Size = new Size(229, 28);
            label1.TabIndex = 7;
            label1.Text = "Modificar un elemento";
            // 
            // foto_elemento
            // 
            foto_elemento.Location = new Point(322, 108);
            foto_elemento.Name = "foto_elemento";
            foto_elemento.Size = new Size(285, 202);
            foto_elemento.TabIndex = 8;
            foto_elemento.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(23, 188);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(143, 20);
            label2.TabIndex = 9;
            label2.Text = "Numero de Inventario";
            // 
            // labnumInventario
            // 
            labnumInventario.AutoSize = true;
            labnumInventario.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labnumInventario.ForeColor = SystemColors.Highlight;
            labnumInventario.Location = new Point(23, 217);
            labnumInventario.Name = "labnumInventario";
            labnumInventario.Size = new Size(50, 20);
            labnumInventario.TabIndex = 13;
            labnumInventario.Text = "label5";
            // 
            // ModificarElemento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(619, 388);
            Controls.Add(labnumInventario);
            Controls.Add(label2);
            Controls.Add(foto_elemento);
            Controls.Add(label1);
            Controls.Add(labelSeleccionarElemento);
            Controls.Add(buttonModificar);
            Controls.Add(buttonAtras);
            Controls.Add(labelNombreElemento);
            Controls.Add(selecElemento);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "ModificarElemento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Modificar un elemento";
            ((System.ComponentModel.ISupportInitialize)foto_elemento).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelNombreElemento;
        private Button buttonAtras;
        private Button buttonModificar;
        private Label labelSeleccionarElemento;
        private Label label1;
        private PictureBox foto_elemento;
        public ComboBox selecElemento;
        private Label label2;
        private Label labnumInventario;
    }
}