using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Channels;
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

        private List<Question> questions;
        private List<Question> displayedQuestions;
        Mode mode = Mode.Add;
        ConfJuego confjuego;

        public ConfPregunta(ConfJuego confjuego)
        {
            InitializeComponent();
            this.confjuego = confjuego;

        }

        private void buttonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = Mode.Add;
            showControls();
            loadQuestionsJSON();
        }

        private void modToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = Mode.Mod;
            showControls();
            loadQuestionsJSON();
        }

        private void delToolStripMenuItem_Click(object sender, EventArgs e)
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

                questionAdded.question = textBoxPregunta.Text.Trim();

                string[] optionsModified = new string[4];
                optionsModified[0] = respuestaA.Text.Trim();
                optionsModified[1] = respuestaB.Text.Trim();
                optionsModified[2] = respuestaC.Text.Trim();
                optionsModified[3] = respuestaD.Text.Trim();

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
            if (textBoxPregunta.Text.Trim() == "" || respuestaA.Text.Trim() == ""
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

            }
            else
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
                questionModified.question = textBoxPregunta.Text.Trim();

                string[] optionsModified = new string[4];
                optionsModified[0] = respuestaA.Text.Trim();
                optionsModified[1] = respuestaB.Text.Trim();
                optionsModified[2] = respuestaC.Text.Trim();
                optionsModified[3] = respuestaD.Text.Trim();

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
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que quieres eliminar esta pregunta?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Question questionShown = comboBoxQuestions.SelectedItem as Question;
                if (questionShown != null)
                {
                    questions.Remove(questionShown);

                    saveQuestionsJSON();
                    loadQuestionsJSON();
                    warning();
                }
            }

        }


        private void showControls()
        {
            switch (mode)
            {
                case Mode.Add:

                    labelSearchQuestionFilter.Visible = false;
                    textBoxBuscar.Visible = false;
                    textBoxBuscar.Text = "";

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

                    buttonAccion.Text = "Afegir";
                    break;
                case Mode.Mod:

                    labelSearchQuestionFilter.Visible = true;
                    textBoxBuscar.Visible = true;

                    labelIdioma.Location = new System.Drawing.Point(8, 42);
                    labelSeleccionarPregunta.Visible = true;
                    comboBoxIdiomas.Location = new System.Drawing.Point(73, 40);
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

                    labelSearchQuestionFilter.Visible = true;
                    textBoxBuscar.Visible = true;

                    labelIdioma.Location = new System.Drawing.Point(8, 42);
                    labelSeleccionarPregunta.Visible = true;
                    comboBoxIdiomas.Location = new System.Drawing.Point(73, 40);
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
                if (control is RadioButton radioButton)
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

            switch (language)
            {
                case "Castellà":
                    JArray jarrayquestionsES = JArray.Parse(File.ReadAllText(@"JSON\questionsES.json", Encoding.Default));
                    questions = jarrayquestionsES.ToObject<List<Question>>();
                    break;
                case "Català":
                    JArray jarrayquestionsCAT = JArray.Parse(File.ReadAllText(@"JSON\questionsCAT.json", Encoding.Default));
                    questions = jarrayquestionsCAT.ToObject<List<Question>>();
                    break;
                case "Anglès":
                    JArray jarrayquestionsEN = JArray.Parse(File.ReadAllText(@"JSON\questionsEN.json", Encoding.Default));
                    questions = jarrayquestionsEN.ToObject<List<Question>>();
                    break;
            }

            if (mode != Mode.Add)
            {
                comboBoxQuestions.DataSource = null;
                comboBoxQuestions.DisplayMember = "question";

                // Aplica el filtro si hay texto en el cuadro de búsqueda
                if (!string.IsNullOrEmpty(textBoxBuscar.Text))
                {
                    displayedQuestions = questions
                        .Where(q => ContainsIgnoreCaseAndAccentInsensitive(q.question, textBoxBuscar.Text))
                        .ToList();
                }
                else
                {
                    // Si no hay texto de búsqueda, muestra todas las preguntas
                    displayedQuestions = new List<Question>(questions);
                }

                // Actualiza la lista visual de preguntas
                UpdateDisplayedQuestions();
            }
            else
            {
                labelXPreguntas.Text = "Hay " + questions.Count() + " preguntas en total";
            }

        }

        private bool ContainsIgnoreCaseAndAccentInsensitive(string source, string searchString)
        {
            // Normaliza ambas cadenas para comparación sin distinción de mayúsculas y tildes
            string normalizedSource = RemoveAccents(source.ToLower());
            string normalizedSearch = RemoveAccents(searchString.ToLower());

            // Realiza la comparación
            return normalizedSource.Contains(normalizedSearch);
        }

        private string RemoveAccents(string input)
        {
            return new string(input.Normalize(NormalizationForm.FormD)
                                    .Where(c => CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
                                    .ToArray());
        }


        private void UpdateDisplayedQuestions()
        {
            // Actualiza la lista visual de preguntas
            comboBoxQuestions.DataSource = null;
            comboBoxQuestions.DataSource = displayedQuestions;
            comboBoxQuestions.DisplayMember = "question";

            labelXPreguntas.Text = "S'han trobat " + displayedQuestions.Count + " preguntes";
        }

        private void saveQuestionsJSON()
        {

            string language = comboBoxIdiomas.SelectedItem.ToString();

            switch (language)
            {
                case "Castellà":
                    JArray arrayquestionsES = (JArray)JToken.FromObject(questions);
                    File.WriteAllText(@"JSON\questionsES.json", arrayquestionsES.ToString());
                    break;
                case "Català":
                    JArray arrayquestionsCAT = (JArray)JToken.FromObject(questions);
                    File.WriteAllText(@"JSON\questionsCAT.json", arrayquestionsCAT.ToString());
                    break;
                case "Anglès":
                    JArray arrayquestionsEN = (JArray)JToken.FromObject(questions);
                    File.WriteAllText(@"JSON\questionsEN.json", arrayquestionsEN.ToString());
                    break;
            }
        }
        private void warning()
        {
            string language = comboBoxIdiomas.SelectedItem.ToString();

            switch (language)
            {
                case "Castellà":
                    MessageBox.Show("S'han aplicat els canvis. Revisa les preguntes també en català i en anglès.", "Avís", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case "Català":
                    MessageBox.Show("S'han aplicat els canvis. Revisa les preguntes també en castellà i en anglès.", "Avís", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case "Anglès":
                    MessageBox.Show("S'han aplicat els canvis. Revisa les preguntes també en català i en castellà.", "Avís", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        }

        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            loadQuestionsJSON();
        }

        private void ConfPregunta_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Estàs segur que vols tancar?", "Confirmació", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                e.Cancel = false;
                this.confjuego.Show();
            }
        }
    }
}
