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
                string[] options = questionShown.options;
                string correctOption = questionShown.correctOption;

                textBoxPregunta.Text = questionShown.question;
                respuestaA.Text = options[0];
                respuestaB.Text = options[1];
                respuestaC.Text = options[2];
                respuestaD.Text = options[3];

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
    }
}
