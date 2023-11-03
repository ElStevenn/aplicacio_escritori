namespace AppEscritori
{
    partial class Login
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
        /// </summary>ss
        private void InitializeComponent()
        {
            textBoxNombre = new TextBox();
            textBoxContra = new TextBox();
            button_login = new Button();
            SuspendLayout();
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(70, 33);
            textBoxNombre.Margin = new Padding(2, 1, 2, 1);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(178, 23);
            textBoxNombre.TabIndex = 0;
            textBoxNombre.Text = "nom";
            textBoxNombre.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxContra
            // 
            textBoxContra.Location = new Point(70, 77);
            textBoxContra.Margin = new Padding(2, 1, 2, 1);
            textBoxContra.Name = "textBoxContra";
            textBoxContra.Size = new Size(178, 23);
            textBoxContra.TabIndex = 1;
            textBoxContra.Text = "contrasenya";
            textBoxContra.TextAlign = HorizontalAlignment.Center;
            // 
            // button_login
            // 
            button_login.Location = new Point(100, 113);
            button_login.Margin = new Padding(2, 1, 2, 1);
            button_login.Name = "button_login";
            button_login.Size = new Size(110, 23);
            button_login.TabIndex = 2;
            button_login.Text = "login";
            button_login.UseVisualStyleBackColor = true;
            button_login.Click += button_login_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(315, 173);
            Controls.Add(button_login);
            Controls.Add(textBoxContra);
            Controls.Add(textBoxNombre);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2, 1, 2, 1);
            Name = "Login";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNombre;
        private TextBox textBoxContra;
        private Button button_login;
    }
}