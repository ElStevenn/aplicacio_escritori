namespace AppEscritori
{
    partial class CampsMain
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            imageList1 = new ImageList(components);
            pictureBox1 = new PictureBox();
            textBox4 = new TextBox();
            label4 = new Label();
            buttonAtras = new Button();
            buttonSiguiente = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 28);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(177, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(195, 28);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(186, 23);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(387, 28);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(177, 23);
            textBox3.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 9);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 6;
            label1.Text = "Nom Element";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(225, 9);
            label2.Name = "label2";
            label2.Size = new Size(110, 15);
            label2.TabIndex = 7;
            label2.Text = "Numero d'inventari";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(442, 9);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 8;
            label3.Text = "Any de creació";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 57);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(552, 125);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(12, 206);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(552, 100);
            textBox4.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 188);
            label4.Name = "label4";
            label4.Size = new Size(127, 15);
            label4.TabIndex = 11;
            label4.Text = "Descripció del element";
            // 
            // buttonAtras
            // 
            buttonAtras.Location = new Point(12, 312);
            buttonAtras.Name = "buttonAtras";
            buttonAtras.Size = new Size(133, 23);
            buttonAtras.TabIndex = 12;
            buttonAtras.Text = "Enrrere";
            buttonAtras.UseVisualStyleBackColor = true;
            buttonAtras.Click += buttonAtras_Click;
            // 
            // buttonSiguiente
            // 
            buttonSiguiente.Location = new Point(431, 312);
            buttonSiguiente.Name = "buttonSiguiente";
            buttonSiguiente.Size = new Size(133, 23);
            buttonSiguiente.TabIndex = 13;
            buttonSiguiente.Text = "Següent";
            buttonSiguiente.UseVisualStyleBackColor = true;
            buttonSiguiente.Click += buttonSiguiente_Click;
            // 
            // CampsMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 345);
            Controls.Add(buttonSiguiente);
            Controls.Add(buttonAtras);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "CampsMain";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private ImageList imageList1;
        private PictureBox pictureBox1;
        private TextBox textBox4;
        private Label label4;
        private Button buttonAtras;
        private Button buttonSiguiente;
    }
}