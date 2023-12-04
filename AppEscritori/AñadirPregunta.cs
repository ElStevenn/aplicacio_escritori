using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEscritori
{
    public partial class AñadirPregunta : Form
    {
        List<Question> questions;
        ConfigurarPreguntas confpreguntas;
        public AñadirPregunta()
        {
            InitializeComponent();

        }
        public AñadirPregunta(ConfigurarPreguntas confpreguntas)
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

        private void buttonAnadir_Click(object sender, EventArgs e)
        {
            String language = comboBoxIdiomas.SelectedItem.ToString();
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
                saveQuestionsJSON(language);
                loadQuestionsJSON(language);
                warning(language);

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
                    MessageBox.Show("Se ha añadido la pregunta. Añadelas también en catalán e inglés.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case "Catalán":
                    MessageBox.Show("Se ha añadido la pregunta. Añadelas también en castellano e inglés.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case "Inglés":
                    MessageBox.Show("Se ha añadido la pregunta. Añadelas también en catalán y castellano.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    break;
            }
        }


    }
}
