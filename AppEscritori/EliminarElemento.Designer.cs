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
            fotoElemento = new PictureBox();
            nombreElemento = new TextBox();
            numInventario = new TextBox();
            buttonAtras = new Button();
            buttonEliminar = new Button();
            label1 = new Label();
            label2 = new Label();
            groupBoxElimElement = new GroupBox();
            selecElemento = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)fotoElemento).BeginInit();
            groupBoxElimElement.SuspendLayout();
            SuspendLayout();
            // 
            // fotoElemento
            // 
            fotoElemento.Location = new Point(6, 82);
            fotoElemento.Margin = new Padding(4, 3, 4, 3);
            fotoElemento.Name = "fotoElemento";
            fotoElemento.Size = new Size(219, 142);
            fotoElemento.TabIndex = 0;
            fotoElemento.TabStop = false;
            // 
            // nombreElemento
            // 
            nombreElemento.Location = new Point(233, 103);
            nombreElemento.Margin = new Padding(4, 3, 4, 3);
            nombreElemento.Name = "nombreElemento";
            nombreElemento.Size = new Size(202, 23);
            nombreElemento.TabIndex = 2;
            nombreElemento.TextAlign = HorizontalAlignment.Center;
            // 
            // numInventario
            // 
            numInventario.Location = new Point(233, 177);
            numInventario.Margin = new Padding(4, 3, 4, 3);
            numInventario.Name = "numInventario";
            numInventario.Size = new Size(202, 23);
            numInventario.TabIndex = 3;
            numInventario.TextAlign = HorizontalAlignment.Center;
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
            buttonEliminar.Click += buttonEliminar_Click;
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
            label2.Location = new Point(233, 159);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 8;
            label2.Text = "Num Inventario";
            // 
            // groupBoxElimElement
            // 
            groupBoxElimElement.Controls.Add(selecElemento);
            groupBoxElimElement.Controls.Add(label2);
            groupBoxElimElement.Controls.Add(label1);
            groupBoxElimElement.Controls.Add(buttonEliminar);
            groupBoxElimElement.Controls.Add(buttonAtras);
            groupBoxElimElement.Controls.Add(numInventario);
            groupBoxElimElement.Controls.Add(nombreElemento);
            groupBoxElimElement.Controls.Add(fotoElemento);
            groupBoxElimElement.Location = new Point(6, 14);
            groupBoxElimElement.Margin = new Padding(4, 3, 4, 3);
            groupBoxElimElement.Name = "groupBoxElimElement";
            groupBoxElimElement.Padding = new Padding(4, 3, 4, 3);
            groupBoxElimElement.Size = new Size(451, 277);
            groupBoxElimElement.TabIndex = 0;
            groupBoxElimElement.TabStop = false;
            groupBoxElimElement.Text = "Eliminar Elemento";
            // 
            // selecElemento
            // 
            selecElemento.FlatStyle = FlatStyle.System;
            selecElemento.FormattingEnabled = true;
            selecElemento.ImeMode = ImeMode.On;
            selecElemento.Items.AddRange(new object[] { "item1", "item2", "item4" });
            selecElemento.Location = new Point(8, 32);
            selecElemento.Margin = new Padding(4, 3, 4, 3);
            selecElemento.Name = "selecElemento";
            selecElemento.Size = new Size(243, 23);
            selecElemento.TabIndex = 11;
            selecElemento.SelectedIndexChanged += selecElemento_SelectedIndexChanged;
            // 
            // EliminarElemento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(472, 303);
            Controls.Add(groupBoxElimElement);
            Margin = new Padding(4, 3, 4, 3);
            Name = "EliminarElemento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Eliminar elemento";
            ((System.ComponentModel.ISupportInitialize)fotoElemento).EndInit();
            groupBoxElimElement.ResumeLayout(false);
            groupBoxElimElement.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox fotoElemento;
        private TextBox nombreElemento;
        private TextBox numInventario;
        private Button buttonAtras;
        private Button buttonEliminar;
        private Label label1;
        private Label label2;
        private GroupBox groupBoxElimElement;
        public ComboBox selecElemento;
    }
}
