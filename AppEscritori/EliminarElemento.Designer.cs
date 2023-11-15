namespace AppEscritori
{
    partial class EliminarElemento
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
            groupBoxElimElement = new GroupBox();
            buttonEliminar = new Button();
            buttonAtras = new Button();
            textBoxSelecElement = new TextBox();
            textBoxnumInventario = new TextBox();
            textBoxNameElement = new TextBox();
            comboBoxSelectElement = new ComboBox();
            pictureBoxElement = new PictureBox();
            groupBoxElimElement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxElement).BeginInit();
            SuspendLayout();
            // 
            // groupBoxElimElement
            // 
            groupBoxElimElement.Controls.Add(buttonEliminar);
            groupBoxElimElement.Controls.Add(buttonAtras);
            groupBoxElimElement.Controls.Add(textBoxSelecElement);
            groupBoxElimElement.Controls.Add(textBoxnumInventario);
            groupBoxElimElement.Controls.Add(textBoxNameElement);
            groupBoxElimElement.Controls.Add(comboBoxSelectElement);
            groupBoxElimElement.Controls.Add(pictureBoxElement);
            groupBoxElimElement.Location = new Point(14, 14);
            groupBoxElimElement.Margin = new Padding(4, 3, 4, 3);
            groupBoxElimElement.Name = "groupBoxElimElement";
            groupBoxElimElement.Padding = new Padding(4, 3, 4, 3);
            groupBoxElimElement.Size = new Size(447, 298);
            groupBoxElimElement.TabIndex = 0;
            groupBoxElimElement.TabStop = false;
            groupBoxElimElement.Text = "Eliminar Elemento";
            // 
            // buttonEliminar
            // 
            buttonEliminar.Location = new Point(349, 257);
            buttonEliminar.Margin = new Padding(4, 3, 4, 3);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(88, 27);
            buttonEliminar.TabIndex = 6;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = true;
            // 
            // buttonAtras
            // 
            buttonAtras.Location = new Point(7, 257);
            buttonAtras.Margin = new Padding(4, 3, 4, 3);
            buttonAtras.Name = "buttonAtras";
            buttonAtras.Size = new Size(88, 27);
            buttonAtras.TabIndex = 5;
            buttonAtras.Text = "Atrás";
            buttonAtras.UseVisualStyleBackColor = true;
            buttonAtras.Click += buttonAtras_Click;
            // 
            // textBoxSelecElement
            // 
            textBoxSelecElement.Location = new Point(7, 22);
            textBoxSelecElement.Margin = new Padding(4, 3, 4, 3);
            textBoxSelecElement.Name = "textBoxSelecElement";
            textBoxSelecElement.Size = new Size(202, 23);
            textBoxSelecElement.TabIndex = 4;
            textBoxSelecElement.Text = "Selecciona un elemento";
            textBoxSelecElement.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxnumInventario
            // 
            textBoxnumInventario.Location = new Point(233, 186);
            textBoxnumInventario.Margin = new Padding(4, 3, 4, 3);
            textBoxnumInventario.Name = "textBoxnumInventario";
            textBoxnumInventario.Size = new Size(202, 23);
            textBoxnumInventario.TabIndex = 3;
            textBoxnumInventario.Text = "Num Inventario";
            textBoxnumInventario.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxNameElement
            // 
            textBoxNameElement.Location = new Point(233, 138);
            textBoxNameElement.Margin = new Padding(4, 3, 4, 3);
            textBoxNameElement.Name = "textBoxNameElement";
            textBoxNameElement.Size = new Size(202, 23);
            textBoxNameElement.TabIndex = 2;
            textBoxNameElement.Text = "Nombre del elemento";
            textBoxNameElement.TextAlign = HorizontalAlignment.Center;
            // 
            // comboBoxSelectElement
            // 
            comboBoxSelectElement.FormattingEnabled = true;
            comboBoxSelectElement.Location = new Point(7, 57);
            comboBoxSelectElement.Margin = new Padding(4, 3, 4, 3);
            comboBoxSelectElement.Name = "comboBoxSelectElement";
            comboBoxSelectElement.Size = new Size(429, 23);
            comboBoxSelectElement.TabIndex = 1;
            // 
            // pictureBoxElement
            // 
            pictureBoxElement.Location = new Point(7, 100);
            pictureBoxElement.Margin = new Padding(4, 3, 4, 3);
            pictureBoxElement.Name = "pictureBoxElement";
            pictureBoxElement.Size = new Size(219, 143);
            pictureBoxElement.TabIndex = 0;
            pictureBoxElement.TabStop = false;
            // 
            // EliminarElemento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 322);
            Controls.Add(groupBoxElimElement);
            Margin = new Padding(4, 3, 4, 3);
            Name = "EliminarElemento";
            Text = "Form7";
            groupBoxElimElement.ResumeLayout(false);
            groupBoxElimElement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxElement).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxElimElement;
        private TextBox textBoxnumInventario;
        private TextBox textBoxNameElement;
        private ComboBox comboBoxSelectElement;
        private PictureBox pictureBoxElement;
        private Button buttonEliminar;
        private Button buttonAtras;
        private TextBox textBoxSelecElement;
    }
}
