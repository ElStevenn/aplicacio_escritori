namespace AplicacioEscritori
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox_nombre = new TextBox();
            textBox_contra = new TextBox();
            button_login = new Button();
            SuspendLayout();
            // 
            // textBox_nombre
            // 
            textBox_nombre.Location = new Point(278, 96);
            textBox_nombre.Name = "textBox_nombre";
            textBox_nombre.Size = new Size(200, 39);
            textBox_nombre.TabIndex = 0;
            textBox_nombre.Text = "nom";
            // 
            // textBox_contra
            // 
            textBox_contra.Location = new Point(278, 202);
            textBox_contra.Name = "textBox_contra";
            textBox_contra.Size = new Size(200, 39);
            textBox_contra.TabIndex = 1;
            textBox_contra.Text = "contrasenya";
            // 
            // button_login
            // 
            button_login.Location = new Point(290, 290);
            button_login.Name = "button_login";
            button_login.Size = new Size(150, 46);
            button_login.TabIndex = 2;
            button_login.Text = "login";
            button_login.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_login);
            Controls.Add(textBox_contra);
            Controls.Add(textBox_nombre);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_nombre;
        private TextBox textBox_contra;
        private Button button_login;
    }
}