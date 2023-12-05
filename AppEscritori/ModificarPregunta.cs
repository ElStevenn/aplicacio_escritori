using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEscritori
{
    public partial class ModificarPregunta : Form
    {
        List<Question> questions;
        ConfigurarPreguntas confpreguntas;
        public ModificarPregunta()
        {
            InitializeComponent();
        }
        public ModificarPregunta(ConfigurarPreguntas confpreguntas)
        {
            InitializeComponent();
            this.confpreguntas = confpreguntas;
        }

        private void buttonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
            this.confpreguntas.Show();
        }

        private void comboBoxIdiomas_SelectedIndexChanged(object sender, EventArgs e)
        {
            String language = comboBoxIdiomas.SelectedItem.ToString();

            loadQuestionsJSON(language);
            labelXPreguntas.Text = "Hay " + questions.Count() + " preguntas";

        }

        private void loadQuestionsJSON(string language)
        {
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

            comboBoxQuestions.DataSource = null;
            comboBoxQuestions.DataSource = questions;
            comboBoxQuestions.DisplayMember = "question";
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
            else
            {
                // Manejar el caso cuando no hay ningún elemento seleccionado.
            }
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            String language = comboBoxIdiomas.SelectedItem.ToString();
            Question questionShown = comboBoxQuestions.SelectedItem as Question;
            Question questionModified = new Question();

            if (questionShown != null)
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
                saveQuestionsJSON(language);
                loadQuestionsJSON(language);
                warning(language);

            }
        }

        private void saveQuestionsJSON(string language)
        {
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

        private void warning(string language)
        {
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
    }
}

