namespace AppEscritori
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Declaration for labelWarning
        private System.Windows.Forms.Label labelWarning; // Added this line

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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Text = "Login";

            // Initialize labelWarning
            this.labelWarning = new System.Windows.Forms.Label();
            this.labelWarning.AutoSize = true;
            this.labelWarning.Location = new System.Drawing.Point(70, 140); // Adjust the location as needed
            this.labelWarning.Name = "labelWarning";
            this.labelWarning.Size = new System.Drawing.Size(178, 15); // Adjust the size as needed
            this.labelWarning.TabIndex = 3;
            this.labelWarning.Visible = false;
            this.labelWarning.ForeColor = System.Drawing.Color.Red; // Optional: set text color to red for warnings
            this.labelWarning.Text = "You haven't introduced any admin"; // Set the initial text if needed

            // Add the labelWarning control to the form
            this.Controls.Add(this.labelWarning);

            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxNombre.Location = new System.Drawing.Point(70, 33);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(178, 23);
            this.textBoxNombre.TabIndex = 0;
            this.textBoxNombre.Text = "nom";
            this.textBoxNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // Removed the erroneous event subscription

            this.textBoxContra = new System.Windows.Forms.TextBox();
            this.textBoxContra.Location = new System.Drawing.Point(70, 77);
            this.textBoxContra.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBoxContra.Name = "textBoxContra";
            this.textBoxContra.Size = new System.Drawing.Size(178, 23);
            this.textBoxContra.TabIndex = 1;
            this.textBoxContra.Text = "contrasenya";
            this.textBoxContra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

            this.button_login = new System.Windows.Forms.Button();
            this.button_login.Location = new System.Drawing.Point(100, 113);
            this.button_login.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(110, 23);
            this.button_login.TabIndex = 2;
            this.button_login.Text = "login";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click); // Assuming you have a button_login_Click event handler defined

            this.ClientSize = new System.Drawing.Size(315, 173);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.textBoxContra);
            this.Controls.Add(this.textBoxNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
