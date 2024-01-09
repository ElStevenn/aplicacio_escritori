namespace AppEscritori
{
    partial class ManejarIdioma
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
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(30, 9);
            label1.Name = "label1";
            label1.Size = new Size(242, 21);
            label1.TabIndex = 0;
            label1.Text = "Canviar l'idioma de l'aplicació";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 196);
            button1.Name = "button1";
            button1.Size = new Size(63, 32);
            button1.TabIndex = 1;
            button1.Text = "Enrere";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(103, 37);
            button2.Name = "button2";
            button2.Size = new Size(149, 51);
            button2.TabIndex = 2;
            button2.Text = "Català";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(103, 102);
            button3.Name = "button3";
            button3.Size = new Size(149, 51);
            button3.TabIndex = 3;
            button3.Text = "Castellano";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(103, 164);
            button4.Name = "button4";
            button4.Size = new Size(149, 51);
            button4.TabIndex = 4;
            button4.Text = "English";
            button4.UseVisualStyleBackColor = true;
            // 
            // ManejarIdioma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(362, 239);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "ManejarIdioma";
            Text = "Canviar l'idioma de l'aplicació";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}