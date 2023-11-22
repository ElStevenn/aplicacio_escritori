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
            pictureBoxElement = new PictureBox();
            textBoxNameElement = new TextBox();
            textBoxnumInventario = new TextBox();
            buttonAtras = new Button();
            buttonEliminar = new Button();
            label1 = new Label();
            label2 = new Label();
            groupBoxElimElement = new GroupBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxElement).BeginInit();
            groupBoxElimElement.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxElement
            // 
            pictureBoxElement.Location = new Point(6, 82);
            pictureBoxElement.Margin = new Padding(4, 3, 4, 3);
            pictureBoxElement.Name = "pictureBoxElement";
            pictureBoxElement.Size = new Size(219, 142);
            pictureBoxElement.TabIndex = 0;
            pictureBoxElement.TabStop = false;
            // 
            // textBoxNameElement
            // 
            textBoxNameElement.Location = new Point(233, 103);
            textBoxNameElement.Margin = new Padding(4, 3, 4, 3);
            textBoxNameElement.Name = "textBoxNameElement";
            textBoxNameElement.Size = new Size(202, 23);
            textBoxNameElement.TabIndex = 2;
            textBoxNameElement.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxnumInventario
            // 
            textBoxnumInventario.Location = new Point(233, 202);
            textBoxnumInventario.Margin = new Padding(4, 3, 4, 3);
            textBoxnumInventario.Name = "textBoxnumInventario";
            textBoxnumInventario.Size = new Size(202, 23);
            textBoxnumInventario.TabIndex = 3;
            textBoxnumInventario.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonAtras
            // 
            buttonAtras.Location = new Point(8, 245);
            buttonAtras.Margin = new Padding(4, 3, 4, 3);
            buttonAtras.Name = "buttonAtras";
            buttonAtras.Size = new Size(88, 26);
            buttonAtras.TabIndex = 5;
            buttonAtras.Text = "Atrás";
            buttonAtras.UseVisualStyleBackColor = true;
            buttonAtras.Click += buttonAtras_Click;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Location = new Point(347, 245);
            buttonEliminar.Margin = new Padding(4, 3, 4, 3);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(88, 26);
            buttonEliminar.TabIndex = 6;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(232, 85);
            label1.Name = "label1";
            label1.Size = new Size(123, 15);
            label1.TabIndex = 7;
            label1.Text = "Nombre del elemento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(232, 184);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 8;
            label2.Text = "Num Inventario";
            label2.Click += label2_Click;
            // 
            // groupBoxElimElement
            // 
            groupBoxElimElement.Controls.Add(button1);
            groupBoxElimElement.Controls.Add(label2);
            groupBoxElimElement.Controls.Add(label1);
            groupBoxElimElement.Controls.Add(buttonEliminar);
            groupBoxElimElement.Controls.Add(buttonAtras);
            groupBoxElimElement.Controls.Add(textBoxnumInventario);
            groupBoxElimElement.Controls.Add(textBoxNameElement);
            groupBoxElimElement.Controls.Add(pictureBoxElement);
            groupBoxElimElement.Location = new Point(6, 14);
            groupBoxElimElement.Margin = new Padding(4, 3, 4, 3);
            groupBoxElimElement.Name = "groupBoxElimElement";
            groupBoxElimElement.Padding = new Padding(4, 3, 4, 3);
            groupBoxElimElement.Size = new Size(451, 277);
            groupBoxElimElement.TabIndex = 0;
            groupBoxElimElement.TabStop = false;
            groupBoxElimElement.Text = "Eliminar Elemento";
            // 
            // button1
            // 
            button1.Location = new Point(6, 29);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(88, 26);
            button1.TabIndex = 10;
            button1.Text = "Seleccionar elemento";
            button1.UseVisualStyleBackColor = true;
            // 
            // EliminarElemento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(472, 303);
            Controls.Add(groupBoxElimElement);
            Margin = new Padding(4, 3, 4, 3);
            Name = "EliminarElemento";
            Text = "Eliminar elemento";
            ((System.ComponentModel.ISupportInitialize)pictureBoxElement).EndInit();
            groupBoxElimElement.ResumeLayout(false);
            groupBoxElimElement.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxElement;
        private TextBox textBoxNameElement;
        private TextBox textBoxnumInventario;
        private Button buttonAtras;
        private Button buttonEliminar;
        private Label label1;
        private Label label2;
        private GroupBox groupBoxElimElement;
        private Button button1;
    }
}
