namespace AppEscritori
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Declaration for labelWarning
        private Label labelWarning; // Added this line

        private TextBox textBoxNombre;
        private TextBox textBoxContra;
        private Button button_login;

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
            labelWarning = new Label();
            textBoxNombre = new TextBox();
            textBoxContra = new TextBox();
            button_login = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // labelWarning
            // 
            labelWarning.AutoSize = true;
            labelWarning.ForeColor = Color.Red;
            labelWarning.Location = new Point(59, 176);
            labelWarning.Name = "labelWarning";
            labelWarning.Size = new Size(189, 15);
            labelWarning.TabIndex = 3;
            labelWarning.Text = "You haven't introduced any admin";
            labelWarning.Visible = false;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(70, 57);
            textBoxNombre.Margin = new Padding(2, 1, 2, 1);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(178, 23);
            textBoxNombre.TabIndex = 0;
            textBoxNombre.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxContra
            // 
            textBoxContra.Location = new Point(70, 104);
            textBoxContra.Margin = new Padding(2, 1, 2, 1);
            textBoxContra.Name = "textBoxContra";
            textBoxContra.PasswordChar = '*';
            textBoxContra.PlaceholderText = "*";
            textBoxContra.Size = new Size(178, 23);
            textBoxContra.TabIndex = 1;
            textBoxContra.TextAlign = HorizontalAlignment.Center;
            // 
            // button_login
            // 
            button_login.Location = new Point(96, 144);
            button_login.Margin = new Padding(2, 1, 2, 1);
            button_login.Name = "button_login";
            button_login.Size = new Size(110, 23);
            button_login.TabIndex = 2;
            button_login.Text = "Accedir";
            button_login.UseVisualStyleBackColor = true;
            button_login.Click += button_login_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(15, 9);
            label1.Name = "label1";
            label1.Size = new Size(291, 25);
            label1.TabIndex = 4;
            label1.Text = "Gestió de dades d'App Android";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 41);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 5;
            label2.Text = "Nom de usuari";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 89);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 6;
            label3.Text = "Contrasenya";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(318, 203);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelWarning);
            Controls.Add(button_login);
            Controls.Add(textBoxContra);
            Controls.Add(textBoxNombre);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2, 1, 2, 1);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
    }
}
