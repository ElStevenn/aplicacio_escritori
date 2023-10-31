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
            this.groupBoxElimElement = new System.Windows.Forms.GroupBox();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonAtras = new System.Windows.Forms.Button();
            this.textBoxSelecElement = new System.Windows.Forms.TextBox();
            this.textBoxnumInventario = new System.Windows.Forms.TextBox();
            this.textBoxNameElement = new System.Windows.Forms.TextBox();
            this.comboBoxSelectElement = new System.Windows.Forms.ComboBox();
            this.pictureBoxElement = new System.Windows.Forms.PictureBox();
            this.groupBoxElimElement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxElement)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxElimElement
            // 
            this.groupBoxElimElement.Controls.Add(this.buttonEliminar);
            this.groupBoxElimElement.Controls.Add(this.buttonAtras);
            this.groupBoxElimElement.Controls.Add(this.textBoxSelecElement);
            this.groupBoxElimElement.Controls.Add(this.textBoxnumInventario);
            this.groupBoxElimElement.Controls.Add(this.textBoxNameElement);
            this.groupBoxElimElement.Controls.Add(this.comboBoxSelectElement);
            this.groupBoxElimElement.Controls.Add(this.pictureBoxElement);
            this.groupBoxElimElement.Location = new System.Drawing.Point(12, 12);
            this.groupBoxElimElement.Name = "groupBoxElimElement";
            this.groupBoxElimElement.Size = new System.Drawing.Size(383, 258);
            this.groupBoxElimElement.TabIndex = 0;
            this.groupBoxElimElement.TabStop = false;
            this.groupBoxElimElement.Text = "Eliminar Elemento";
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(299, 223);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminar.TabIndex = 6;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            // 
            // buttonAtras
            // 
            this.buttonAtras.Location = new System.Drawing.Point(6, 223);
            this.buttonAtras.Name = "buttonAtras";
            this.buttonAtras.Size = new System.Drawing.Size(75, 23);
            this.buttonAtras.TabIndex = 5;
            this.buttonAtras.Text = "Atrás";
            this.buttonAtras.UseVisualStyleBackColor = true;
            // 
            // textBoxSelecElement
            // 
            this.textBoxSelecElement.Location = new System.Drawing.Point(6, 19);
            this.textBoxSelecElement.Name = "textBoxSelecElement";
            this.textBoxSelecElement.Size = new System.Drawing.Size(174, 20);
            this.textBoxSelecElement.TabIndex = 4;
            this.textBoxSelecElement.Text = "Selecciona un elemento";
            this.textBoxSelecElement.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxnumInventario
            // 
            this.textBoxnumInventario.Location = new System.Drawing.Point(200, 161);
            this.textBoxnumInventario.Name = "textBoxnumInventario";
            this.textBoxnumInventario.Size = new System.Drawing.Size(174, 20);
            this.textBoxnumInventario.TabIndex = 3;
            this.textBoxnumInventario.Text = "Num Inventario";
            this.textBoxnumInventario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxNameElement
            // 
            this.textBoxNameElement.Location = new System.Drawing.Point(200, 120);
            this.textBoxNameElement.Name = "textBoxNameElement";
            this.textBoxNameElement.Size = new System.Drawing.Size(174, 20);
            this.textBoxNameElement.TabIndex = 2;
            this.textBoxNameElement.Text = "Nombre del elemento";
            this.textBoxNameElement.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBoxSelectElement
            // 
            this.comboBoxSelectElement.FormattingEnabled = true;
            this.comboBoxSelectElement.Location = new System.Drawing.Point(6, 49);
            this.comboBoxSelectElement.Name = "comboBoxSelectElement";
            this.comboBoxSelectElement.Size = new System.Drawing.Size(368, 21);
            this.comboBoxSelectElement.TabIndex = 1;
            // 
            // pictureBoxElement
            // 
            this.pictureBoxElement.Location = new System.Drawing.Point(6, 87);
            this.pictureBoxElement.Name = "pictureBoxElement";
            this.pictureBoxElement.Size = new System.Drawing.Size(188, 124);
            this.pictureBoxElement.TabIndex = 0;
            this.pictureBoxElement.TabStop = false;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 279);
            this.Controls.Add(this.groupBoxElimElement);
            this.Name = "Form7";
            this.Text = "Form7";
            this.groupBoxElimElement.ResumeLayout(false);
            this.groupBoxElimElement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxElement)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxElimElement;
        private System.Windows.Forms.TextBox textBoxnumInventario;
        private System.Windows.Forms.TextBox textBoxNameElement;
        private System.Windows.Forms.ComboBox comboBoxSelectElement;
        private System.Windows.Forms.PictureBox pictureBoxElement;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonAtras;
        private System.Windows.Forms.TextBox textBoxSelecElement;
    }
}
