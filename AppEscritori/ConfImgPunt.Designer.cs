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
            components = new System.ComponentModel.Container();
            groupBoxResultat = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            radioButton3NouDeu = new RadioButton();
            radioButton2CincVuit = new RadioButton();
            radioButton1ZeroQuatre = new RadioButton();
            label1 = new Label();
            openFileDialog1 = new OpenFileDialog();
            groupBox2ImatgeVehicle = new GroupBox();
            pictureBox1 = new PictureBox();
            button2Enrere = new Button();
            button3ConfirmarCanvis = new Button();
            button1SeleccionarImatge = new Button();
            bindingSource1 = new BindingSource(components);
            textBoxRuta = new TextBox();
            buttonBuscarRuta = new Button();
            labelRuta = new Label();
            comboBoxDifs = new ComboBox();
            labelExplanation = new Label();
            labelDif = new Label();
            groupBoxResultat.SuspendLayout();
            groupBox2ImatgeVehicle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // groupBoxResultat
            // 
            groupBoxResultat.Controls.Add(radioButton2);
            groupBoxResultat.Controls.Add(radioButton1);
            groupBoxResultat.Controls.Add(radioButton3NouDeu);
            groupBoxResultat.Controls.Add(radioButton2CincVuit);
            groupBoxResultat.Controls.Add(radioButton1ZeroQuatre);
            groupBoxResultat.Location = new Point(13, 54);
            groupBoxResultat.Name = "groupBoxResultat";
            groupBoxResultat.Size = new Size(318, 53);
            groupBoxResultat.TabIndex = 0;
            groupBoxResultat.TabStop = false;
            groupBoxResultat.Text = "Resultat:";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(228, 22);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(54, 19);
            radioButton2.TabIndex = 4;
            radioButton2.TabStop = true;
            radioButton2.Text = "17-20";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(168, 22);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(54, 19);
            radioButton1.TabIndex = 3;
            radioButton1.TabStop = true;
            radioButton1.Text = "13-16";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton3NouDeu
            // 
            radioButton3NouDeu.AutoSize = true;
            radioButton3NouDeu.Location = new Point(114, 22);
            radioButton3NouDeu.Name = "radioButton3NouDeu";
            radioButton3NouDeu.Size = new Size(48, 19);
            radioButton3NouDeu.TabIndex = 2;
            radioButton3NouDeu.TabStop = true;
            radioButton3NouDeu.Text = "9-12";
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
            label1.Location = new Point(12, 168);
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
            groupBox2ImatgeVehicle.Controls.Add(pictureBox1);
            groupBox2ImatgeVehicle.Location = new Point(13, 195);
            groupBox2ImatgeVehicle.Name = "groupBox2ImatgeVehicle";
            groupBox2ImatgeVehicle.Size = new Size(443, 212);
            groupBox2ImatgeVehicle.TabIndex = 2;
            groupBox2ImatgeVehicle.TabStop = false;
            groupBox2ImatgeVehicle.Text = "Imatge Seleccionada:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.noimageselected;
            pictureBox1.Location = new Point(1, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(443, 196);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button2Enrere
            // 
            button2Enrere.Location = new Point(11, 419);
            button2Enrere.Name = "button2Enrere";
            button2Enrere.Size = new Size(87, 27);
            button2Enrere.TabIndex = 3;
            button2Enrere.Text = "Atrás";
            button2Enrere.UseVisualStyleBackColor = true;
            button2Enrere.Click += button2Enrere_Click;
            // 
            // button3ConfirmarCanvis
            // 
            button3ConfirmarCanvis.Location = new Point(378, 419);
            button3ConfirmarCanvis.Name = "button3ConfirmarCanvis";
            button3ConfirmarCanvis.Size = new Size(87, 27);
            button3ConfirmarCanvis.TabIndex = 4;
            button3ConfirmarCanvis.Text = "Confirmar canvis";
            button3ConfirmarCanvis.UseVisualStyleBackColor = true;
            button3ConfirmarCanvis.Click += button3ConfirmarCanvis_Click;
            // 
            // button1SeleccionarImatge
            // 
            button1SeleccionarImatge.Location = new Point(151, 162);
            button1SeleccionarImatge.Name = "button1SeleccionarImatge";
            button1SeleccionarImatge.Size = new Size(98, 27);
            button1SeleccionarImatge.TabIndex = 5;
            button1SeleccionarImatge.Text = "Seleccionar...";
            button1SeleccionarImatge.UseVisualStyleBackColor = true;
            button1SeleccionarImatge.Click += button1SeleccionarImatge_Click;
            // 
            // textBoxRuta
            // 
            textBoxRuta.Location = new Point(12, 132);
            textBoxRuta.Name = "textBoxRuta";
            textBoxRuta.ReadOnly = true;
            textBoxRuta.Size = new Size(294, 23);
            textBoxRuta.TabIndex = 6;
            // 
            // buttonBuscarRuta
            // 
            buttonBuscarRuta.Location = new Point(231, 106);
            buttonBuscarRuta.Name = "buttonBuscarRuta";
            buttonBuscarRuta.Size = new Size(75, 23);
            buttonBuscarRuta.TabIndex = 7;
            buttonBuscarRuta.Text = "Buscar";
            buttonBuscarRuta.UseVisualStyleBackColor = true;
            buttonBuscarRuta.Click += buttonBuscarRuta_Click;
            // 
            // labelRuta
            // 
            labelRuta.AutoSize = true;
            labelRuta.Location = new Point(12, 110);
            labelRuta.Name = "labelRuta";
            labelRuta.Size = new Size(213, 15);
            labelRuta.TabIndex = 8;
            labelRuta.Text = "Selecciona donde guardarás la imagen:";
            // 
            // comboBoxDifs
            // 
            comboBoxDifs.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDifs.FormattingEnabled = true;
            comboBoxDifs.Items.AddRange(new object[] { "Fácil", "Normal", "Difícil" });
            comboBoxDifs.Location = new Point(347, 84);
            comboBoxDifs.Name = "comboBoxDifs";
            comboBoxDifs.Size = new Size(121, 23);
            comboBoxDifs.TabIndex = 9;
            comboBoxDifs.SelectedIndexChanged += comboBoxDifs_SelectedIndexChanged;
            // 
            // labelExplanation
            // 
            labelExplanation.AutoSize = true;
            labelExplanation.Location = new Point(13, 9);
            labelExplanation.Name = "labelExplanation";
            labelExplanation.Size = new Size(458, 30);
            labelExplanation.TabIndex = 10;
            labelExplanation.Text = "Selecciona la dificultad a la que quieres cambiar la foto, después el rango de pregunta\r\nal que quieres asignar y por último donde guardarás la imagen.";
            // 
            // labelDif
            // 
            labelDif.AutoSize = true;
            labelDif.Location = new Point(347, 66);
            labelDif.Name = "labelDif";
            labelDif.Size = new Size(58, 15);
            labelDif.TabIndex = 11;
            labelDif.Text = "Dificultad";
            // 
            // ConfImgPunt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(472, 458);
            Controls.Add(labelDif);
            Controls.Add(labelExplanation);
            Controls.Add(comboBoxDifs);
            Controls.Add(labelRuta);
            Controls.Add(buttonBuscarRuta);
            Controls.Add(textBoxRuta);
            Controls.Add(button1SeleccionarImatge);
            Controls.Add(button3ConfirmarCanvis);
            Controls.Add(button2Enrere);
            Controls.Add(groupBox2ImatgeVehicle);
            Controls.Add(label1);
            Controls.Add(groupBoxResultat);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ConfImgPunt";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formulari 14";
            groupBoxResultat.ResumeLayout(false);
            groupBoxResultat.PerformLayout();
            groupBox2ImatgeVehicle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxResultat;
        private RadioButton radioButton3NouDeu;
        private RadioButton radioButton2CincVuit;
        private RadioButton radioButton1ZeroQuatre;
        private Label label1;
        private OpenFileDialog openFileDialog1;
        private GroupBox groupBox2ImatgeVehicle;
        private Button button2Enrere;
        private Button button3ConfirmarCanvis;
        private Button button1SeleccionarImatge;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private PictureBox pictureBox1;
        private BindingSource bindingSource1;
        private TextBox textBoxRuta;
        private Button buttonBuscarRuta;
        private Label labelRuta;
        private ComboBox comboBoxDifs;
        private Label labelExplanation;
        private Label labelDif;
    }
}