using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEscritori
{
    public partial class ConfPregunta : Form
    {

        public enum Mode
        {
            Add,
            Mod,
            Del
        }

        List<Question> questions;
        Mode mode = Mode.Mod;
        ConfJuego confjuego;
        public ConfPregunta()
        {
            InitializeComponent();
        }
        public ConfPregunta(ConfJuego confjuego)
        {
            InitializeComponent();
            this.confjuego = confjuego;

        }

        private void buttonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
            this.confjuego.Show();
        }

        private void añadirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = Mode.Add;
            showControls();
            loadQuestionsJSON();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = Mode.Mod;
            showControls();
            loadQuestionsJSON();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = Mode.Del;
            showControls();
            loadQuestionsJSON();
        }

        private void buttonAccion_Click(object sender, EventArgs e)
        {
            switch (mode)
            {
                case Mode.Add:
                    buttonAdd();
                    break;
                case Mode.Mod:
                    buttonMod();
                    break;
                case Mode.Del:
                    buttonDel();
                    break;
            }
        }

        private void buttonAdd()
        {
            if (checkBlank())
            {
                Question questionAdded = new Question();

                questionAdded.question = textBoxPregunta.Text;

                string[] optionsModified = new string[4];
                optionsModified[0] = respuestaA.Text;
                optionsModified[1] = respuestaB.Text;
                optionsModified[2] = respuestaC.Text;
                optionsModified[3] = respuestaD.Text;

                questionAdded.options = optionsModified;

                questionAdded.correctOption = GetSelectedRadioButtonText();

                questions.Add(questionAdded);

                // Guarda y carga las preguntas
                saveQuestionsJSON();
                loadQuestionsJSON();
                warning();
            }
        }

        private bool checkBlank()
        {
            if(textBoxPregunta.Text.Trim() == "" || respuestaA.Text.Trim() == ""
                || respuestaB.Text.Trim() == "" || respuestaC.Text.Trim() == ""
                || respuestaD.Text.Trim() == "")
            {
                MessageBox.Show("Rellena todos los campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!IsAnyRadioButtonSelected())
            {
                MessageBox.Show("Selecciona una repuesta correcta.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            } else
            {
                return true;
            }
            
        }

        private void buttonMod()
        {
            Question questionShown = comboBoxQuestions.SelectedItem as Question;
            Question questionModified = new Question();

            if (questionShown != null && checkBlank())
            {
                questionModified.question = textBoxPregunta.Text;

                string[] optionsModified = new string[4];
                optionsModified[0] = respuestaA.Text;
                optionsModified[1] = respuestaB.Text;
                optionsModified[2] = respuestaC.Text;
                optionsModified[3] = respuestaD.Text;

                questionModified.options = optionsModified;

                questionModified.correctOption = GetSelectedRadioButtonText();

                // Obtén la posición de questionShown en la lista
                int index = questions.IndexOf(questionShown);

                // Inserta questionModified en la misma posición
                questions.Insert(index, questionModified);

                // Elimina questionShown de la lista
                questions.Remove(questionShown);

                // Guarda y carga las preguntas
                saveQuestionsJSON();
                loadQuestionsJSON();
                warning();

            }
        }

        private void buttonDel()
        {
            Question questionShown = comboBoxQuestions.SelectedItem as Question;
            if (questionShown != null)
            {
                questions.Remove(questionShown);

                saveQuestionsJSON();
                loadQuestionsJSON();
                labelXPreguntas.Text = "Hay " + questions.Count() + " preguntas";
                warning();
            }
        }


        private void showControls()
        {
            switch (mode)
            {
                case Mode.Add:
                    labelIdioma.Location = new System.Drawing.Point(11, 56);
                    labelSeleccionarPregunta.Visible = false;
                    comboBoxIdiomas.Location = new System.Drawing.Point(76, 56);
                    comboBoxQuestions.Visible = false;

                    textBoxPregunta.ReadOnly = false;
                    textBoxPregunta.Text = "";

                    respuestaA.ReadOnly = false;
                    respuestaA.Text = "";
                    respuestaB.ReadOnly = false;
                    respuestaB.Text = "";
                    respuestaC.ReadOnly = false;
                    respuestaC.Text = "";
                    respuestaD.ReadOnly = false;
                    respuestaD.Text = "";

                    clearButtonSelection();
                    enableButtons();

                    buttonAccion.Text = "Añadir";
                    break;
                case Mode.Mod:
                    labelIdioma.Location = new System.Drawing.Point(11, 31);
                    labelSeleccionarPregunta.Visible = true;
                    comboBoxIdiomas.Location = new System.Drawing.Point(76, 29);
                    comboBoxQuestions.Visible = true;

                    textBoxPregunta.ReadOnly = false;
                    respuestaA.ReadOnly = false;
                    respuestaB.ReadOnly = false;
                    respuestaC.ReadOnly = false;
                    respuestaD.ReadOnly = false;

                    enableButtons();

                    buttonAccion.Text = "Modificar";
                    break;
                case Mode.Del:
                    labelIdioma.Location = new System.Drawing.Point(11, 31);
                    labelSeleccionarPregunta.Visible = true;
                    comboBoxIdiomas.Location = new System.Drawing.Point(76, 29);
                    comboBoxQuestions.Visible = true;

                    textBoxPregunta.ReadOnly = true;
                    respuestaA.ReadOnly = true;
                    respuestaB.ReadOnly = true;
                    respuestaC.ReadOnly = true;
                    respuestaD.ReadOnly = true;

                    disableButtons();

                    buttonAccion.Text = "Eliminar";
                    break;
            }
        }

        private void clearButtonSelection()
        {
            foreach (Control control in groupBoxButtonsCO.Controls)
            {
                if(control is RadioButton radioButton)
                {
                    radioButton.Checked = false;
                }
            }
        }
        private void disableButtons()
        {
            foreach (Control control in groupBoxButtonsCO.Controls)
            {
                if (control is RadioButton radioButton)
                {
                    radioButton.Enabled = false;
                }
            }
        }
        private void enableButtons()
        {
            foreach (Control control in groupBoxButtonsCO.Controls)
            {
                if (control is RadioButton radioButton)
                {
                    radioButton.Enabled = true;
                }
            }
        }
        private string GetSelectedRadioButtonText()
        {
            foreach (Control control in groupBoxButtonsCO.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    // Retorna el texto del RadioButton seleccionado
                    return radioButton.Text;
                }
            }
            // Retorna una cadena vacía si no se encuentra ningún RadioButton seleccionado
            return string.Empty;
        }

        private bool IsAnyRadioButtonSelected()
        {
            foreach (Control control in groupBoxButtonsCO.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    return true;
                }
            }
            return false;
        }
        private void loadQuestionsJSON()
        {
            string language = comboBoxIdiomas.SelectedItem.ToString();

            string basePath = AppDomain.CurrentDomain.BaseDirectory;

            switch (language)
            {
                case "Castellano":
                    JArray jarrayquestionsES = JArray.Parse(File.ReadAllText(Path.Combine(basePath, @"..\..\..\JSON\questionsES.json"), Encoding.Default));
                    questions = jarrayquestionsES.ToObject<List<Question>>();
                    break;
                case "Catalán":
                    JArray jarrayquestionsCAT = JArray.Parse(File.ReadAllText(Path.Combine(basePath, @"..\..\..\JSON\questionsCAT.json"), Encoding.Default));
                    questions = jarrayquestionsCAT.ToObject<List<Question>>();
                    break;
                case "Inglés":
                    JArray jarrayquestionsEN = JArray.Parse(File.ReadAllText(Path.Combine(basePath, @"..\..\..\JSON\questionsEN.json"), Encoding.Default));
                    questions = jarrayquestionsEN.ToObject<List<Question>>();
                    break;
            }

            if (mode != Mode.Add)
            {
                comboBoxQuestions.DataSource = null;
                comboBoxQuestions.DataSource = questions;
                comboBoxQuestions.DisplayMember = "question";
            }
        }

        private void saveQuestionsJSON()
        {

            string language = comboBoxIdiomas.SelectedItem.ToString();
            string basePath = AppDomain.CurrentDomain.BaseDirectory;

            switch (language)
            {
                case "Castellano":
                    JArray arrayquestionsES = (JArray)JToken.FromObject(questions);
                    File.WriteAllText(Path.Combine(basePath, @"..\..\..\JSON\questionsES.json"), arrayquestionsES.ToString());
                    break;
                case "Catalán":
                    JArray arrayquestionsCAT = (JArray)JToken.FromObject(questions);
                    File.WriteAllText(Path.Combine(basePath, @"..\..\..\JSON\questionsCAT.json"), arrayquestionsCAT.ToString());
                    break;
                case "Inglés":
                    JArray arrayquestionsEN = (JArray)JToken.FromObject(questions);
                    File.WriteAllText(Path.Combine(basePath, @"..\..\..\JSON\questionsEN.json"), arrayquestionsEN.ToString());
                    break;
            }
        }
        private void warning()
        {
            string language = comboBoxIdiomas.SelectedItem.ToString();
           
                switch (language)
                {
                case "Castellano":
                    MessageBox.Show("Los cambios se han aplicado. Revisa las preguntas también en catalán e inglés.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case "Catalán":
                    MessageBox.Show("Los cambios se han aplicado. Revisa las preguntas también en castellano e inglés.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case "Inglés":
                    MessageBox.Show("Los cambios se han aplicado. Revisa las preguntas también en catalán y castellano.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                }
        }

        private void comboBoxIdiomas_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadQuestionsJSON();
        }
        private void comboBoxQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {
            Question questionShown = comboBoxQuestions.SelectedItem as Question;

            if (questionShown != null)
            {
                textBoxPregunta.Text = questionShown.question;

                string[] options = questionShown.options;
                respuestaA.Text = options[0];
                respuestaB.Text = options[1];
                respuestaC.Text = options[2];
                respuestaD.Text = options[3];

                string correctOption = questionShown.correctOption;

                switch (correctOption)
                {
                    case "A":
                        RespuestaCorrectaA.Select();
                        break;
                    case "B":
                        RespuestaCorrectaB.Select();
                        break;
                    case "C":
                        RespuestaCorrectaC.Select();
                        break;
                    case "D":
                        RespuestaCorrectaD.Select();
                        break;
                }
            }
        }

        private void ConfPregunta_Load(object sender, EventArgs e)
        {
            showControls();
            comboBoxIdiomas.SelectedIndex = 0;
            loadQuestionsJSON();
            labelXPreguntas.Text = "Hay " + questions.Count + " preguntas";
        }
    }
}
