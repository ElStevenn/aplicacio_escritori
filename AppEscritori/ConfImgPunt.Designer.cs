namespace AppEscritori
{
    partial class ConfImgPunt
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
            groupBox1Resultat = new GroupBox();
            radioButton3NouDeu = new RadioButton();
            radioButton2CincVuit = new RadioButton();
            radioButton1ZeroQuatre = new RadioButton();
            label1 = new Label();
            openFileDialog1 = new OpenFileDialog();
            groupBox2ImatgeVehicle = new GroupBox();
            button2Enrere = new Button();
            button3ConfirmarCanvis = new Button();
            button1SeleccionarImatge = new Button();
            groupBox1Resultat.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1Resultat
            // 
            groupBox1Resultat.Controls.Add(radioButton3NouDeu);
            groupBox1Resultat.Controls.Add(radioButton2CincVuit);
            groupBox1Resultat.Controls.Add(radioButton1ZeroQuatre);
            groupBox1Resultat.Location = new Point(15, 14);
            groupBox1Resultat.Name = "groupBox1Resultat";
            groupBox1Resultat.Size = new Size(273, 53);
            groupBox1Resultat.TabIndex = 0;
            groupBox1Resultat.TabStop = false;
            groupBox1Resultat.Text = "Resultat:";
            // 
            // radioButton3NouDeu
            // 
            radioButton3NouDeu.AutoSize = true;
            radioButton3NouDeu.Location = new Point(114, 22);
            radioButton3NouDeu.Name = "radioButton3NouDeu";
            radioButton3NouDeu.Size = new Size(48, 19);
            radioButton3NouDeu.TabIndex = 2;
            radioButton3NouDeu.TabStop = true;
            radioButton3NouDeu.Text = "9-10";
            radioButton3NouDeu.UseVisualStyleBackColor = true;
            // 
            // radioButton2CincVuit
            // 
            radioButton2CincVuit.AutoSize = true;
            radioButton2CincVuit.Location = new Point(61, 22);
            radioButton2CincVuit.Name = "radioButton2CincVuit";
            radioButton2CincVuit.Size = new Size(42, 19);
            radioButton2CincVuit.TabIndex = 1;
            radioButton2CincVuit.TabStop = true;
            radioButton2CincVuit.Text = "5-8";
            radioButton2CincVuit.UseVisualStyleBackColor = true;
            // 
            // radioButton1ZeroQuatre
            // 
            radioButton1ZeroQuatre.AutoSize = true;
            radioButton1ZeroQuatre.Location = new Point(7, 22);
            radioButton1ZeroQuatre.Name = "radioButton1ZeroQuatre";
            radioButton1ZeroQuatre.Size = new Size(42, 19);
            radioButton1ZeroQuatre.TabIndex = 0;
            radioButton1ZeroQuatre.TabStop = true;
            radioButton1ZeroQuatre.Text = "0-4";
            radioButton1ZeroQuatre.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 82);
            label1.Name = "label1";
            label1.Size = new Size(133, 15);
            label1.TabIndex = 1;
            label1.Text = "Escollir vehicle assignat:";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox2ImatgeVehicle
            // 
            groupBox2ImatgeVehicle.Location = new Point(14, 110);
            groupBox2ImatgeVehicle.Name = "groupBox2ImatgeVehicle";
            groupBox2ImatgeVehicle.Size = new Size(274, 115);
            groupBox2ImatgeVehicle.TabIndex = 2;
            groupBox2ImatgeVehicle.TabStop = false;
            groupBox2ImatgeVehicle.Text = "Imatge Seleccionada:";
            // 
            // button2Enrere
            // 
            button2Enrere.Location = new Point(15, 232);
            button2Enrere.Name = "button2Enrere";
            button2Enrere.Size = new Size(87, 27);
            button2Enrere.TabIndex = 3;
            button2Enrere.Text = "Atrás";
            button2Enrere.UseVisualStyleBackColor = true;
            button2Enrere.Click += button2Enrere_Click;
            // 
            // button3ConfirmarCanvis
            // 
            button3ConfirmarCanvis.Location = new Point(201, 232);
            button3ConfirmarCanvis.Name = "button3ConfirmarCanvis";
            button3ConfirmarCanvis.Size = new Size(87, 27);
            button3ConfirmarCanvis.TabIndex = 4;
            button3ConfirmarCanvis.Text = "Confirmar canvis";
            button3ConfirmarCanvis.UseVisualStyleBackColor = true;
            // 
            // button1SeleccionarImatge
            // 
            button1SeleccionarImatge.Location = new Point(190, 76);
            button1SeleccionarImatge.Name = "button1SeleccionarImatge";
            button1SeleccionarImatge.Size = new Size(98, 27);
            button1SeleccionarImatge.TabIndex = 5;
            button1SeleccionarImatge.Text = "Seleccionar...";
            button1SeleccionarImatge.UseVisualStyleBackColor = true;
            // 
            // ConfImgPunt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(309, 272);
            Controls.Add(button1SeleccionarImatge);
            Controls.Add(button3ConfirmarCanvis);
            Controls.Add(button2Enrere);
            Controls.Add(groupBox2ImatgeVehicle);
            Controls.Add(label1);
            Controls.Add(groupBox1Resultat);
            Name = "ConfImgPunt";
            Text = "Formulari 14";
            groupBox1Resultat.ResumeLayout(false);
            groupBox1Resultat.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1Resultat;
        private RadioButton radioButton3NouDeu;
        private RadioButton radioButton2CincVuit;
        private RadioButton radioButton1ZeroQuatre;
        private Label label1;
        private OpenFileDialog openFileDialog1;
        private GroupBox groupBox2ImatgeVehicle;
        private Button button2Enrere;
        private Button button3ConfirmarCanvis;
        private Button button1SeleccionarImatge;
    }
}