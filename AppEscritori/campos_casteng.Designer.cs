namespace AppEscritori
{
    partial class campos_casteng
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
            components = new System.ComponentModel.Container();
            label18 = new Label();
            groupBox1 = new GroupBox();
            descrp_esp = new TextBox();
            label3 = new Label();
            label1 = new Label();
            nombre_esp = new TextBox();
            groupBox2 = new GroupBox();
            descrp_eng = new TextBox();
            label4 = new Label();
            label2 = new Label();
            nombre_eng = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            buttonAtras = new Button();
            buttonSiguiente = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label18.ForeColor = Color.Red;
            label18.Location = new Point(142, 9);
            label18.Name = "label18";
            label18.Size = new Size(297, 25);
            label18.TabIndex = 41;
            label18.Text = "CAMPOS EN ESPAÑOL E INGLÉS";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(descrp_esp);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(nombre_esp);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 54);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(274, 230);
            groupBox1.TabIndex = 42;
            groupBox1.TabStop = false;
            groupBox1.Text = "ESPAÑOL";
            // 
            // descrp_esp
            // 
            descrp_esp.Location = new Point(6, 88);
            descrp_esp.Multiline = true;
            descrp_esp.Name = "descrp_esp";
            descrp_esp.Size = new Size(262, 136);
            descrp_esp.TabIndex = 47;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 70);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 46;
            label3.Text = "Descripción";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 26);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 45;
            label1.Text = "Nombe elemento";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // nombre_esp
            // 
            nombre_esp.Location = new Point(6, 44);
            nombre_esp.Name = "nombre_esp";
            nombre_esp.Size = new Size(262, 23);
            nombre_esp.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(descrp_eng);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(nombre_eng);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(308, 54);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(300, 230);
            groupBox2.TabIndex = 43;
            groupBox2.TabStop = false;
            groupBox2.Text = "INGLÉS";
            // 
            // descrp_eng
            // 
            descrp_eng.Location = new Point(6, 88);
            descrp_eng.Multiline = true;
            descrp_eng.Name = "descrp_eng";
            descrp_eng.Size = new Size(288, 136);
            descrp_eng.TabIndex = 48;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 70);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 47;
            label4.Text = "Descripción";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 26);
            label2.Name = "label2";
            label2.Size = new Size(110, 15);
            label2.TabIndex = 46;
            label2.Text = "Nombre elemento";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // nombre_eng
            // 
            nombre_eng.Location = new Point(6, 44);
            nombre_eng.Name = "nombre_eng";
            nombre_eng.Size = new Size(288, 23);
            nombre_eng.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // buttonAtras
            // 
            buttonAtras.Location = new Point(18, 296);
            buttonAtras.Name = "buttonAtras";
            buttonAtras.Size = new Size(133, 23);
            buttonAtras.TabIndex = 45;
            buttonAtras.Text = "Atrás";
            buttonAtras.UseVisualStyleBackColor = true;
            buttonAtras.Click += buttonAtras_Click;
            // 
            // buttonSiguiente
            // 
            buttonSiguiente.Location = new Point(469, 296);
            buttonSiguiente.Name = "buttonSiguiente";
            buttonSiguiente.Size = new Size(133, 23);
            buttonSiguiente.TabIndex = 46;
            buttonSiguiente.Text = "Siguiente";
            buttonSiguiente.UseVisualStyleBackColor = true;
            buttonSiguiente.Click += buttonSiguiente_Click;
            // 
            // campos_casteng
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(620, 331);
            Controls.Add(buttonSiguiente);
            Controls.Add(buttonAtras);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label18);
            Name = "campos_casteng";
            Text = "campos_casteng";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label18;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox nombre_esp;
        private TextBox nombre_eng;
        private Label label3;
        private Label label1;
        private Label label4;
        private Label label2;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox descrp_esp;
        private TextBox descrp_eng;
        private Button buttonAtras;
        private Button buttonSiguiente;
    }
}