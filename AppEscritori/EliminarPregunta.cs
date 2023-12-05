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
    public partial class EliminarPregunta : Form
    {
        List<Question> questions;
        ConfigurarPreguntas confpreguntas;
        public EliminarPregunta()
        {
            InitializeComponent();
        }
        public EliminarPregunta(ConfigurarPreguntas confpreguntas)
        {
            InitializeComponent();
            this.confpreguntas = confpreguntas;
        }


        private void button1Enrere_Click(object sender, EventArgs e)
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
        }

        private void button2Eliminar_Click(object sender, EventArgs e)
        {
            String language = comboBoxIdiomas.SelectedItem.ToString();
            Question questionShown = comboBoxQuestions.SelectedItem as Question;
            if (questionShown != null)
            {
                questions.Remove(questionShown);

                saveQuestionsJSON(language);
                loadQuestionsJSON(language);
                labelXPreguntas.Text = "Hay " + questions.Count() + " preguntas";
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
