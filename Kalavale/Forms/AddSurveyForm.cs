using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Kalavale.Entities;
using Kalavale.Repositories;


namespace Kalavale.Forms {
    public partial class AddSurveyForm : Form {
        string[] _questionTypes = { "Vapaa teksti", "Kyllä/Ei", "Pääasiallisen kalastusalueen valinta",
            "Kalastuspäivien määrä kuukaudessa", "Kalamäärät per pyydystyyppi",
            "Koentakertojen/Kalastusvuorokausien määrä per pyydys", "Keskimääräinen pyydysten lukumäärä per päivä",
            "Lajien yleistyminen/vähentyminen", "Kalastuksen haittatekijät", "Alueen merkitys kalojen lisääntymisalueena"};

        Survey _survey;
        BindingList<Question> _questions = new BindingList<Question>();
        SurveyRepository _sRepository = new SurveyRepository();
        ResourceRepository _rRepository = new ResourceRepository();
        bool editMode;

        public AddSurveyForm(Survey survey) {
            InitializeComponent();
            _survey = survey;
        }

        private void AddSurveyForm_Load(object sender, EventArgs e) {
            cboQuestionTypeSelector.DataSource = _questionTypes;
            lbvAddedQuestions.DataSource = _questions;
            InitializeSurvey();
            editMode = false;
        }

        // alustaa muokattavan kyselyn formiin
        private void InitializeSurvey() {
            if (_survey != null) {
                txtSurveyName.Text = _survey.Name;

                foreach (Question q in _survey.Questions) {
                    _questions.Add(q);
                }
            }
        }

        private void cboQuestionTypeSelector_SelectedIndexChanged(object sender, EventArgs e) {
            int questionType = cboQuestionTypeSelector.SelectedIndex + 1;

            lbvRowOptions.DataSource = null;
            lbvColumnOptions.DataSource = null;

            switch (questionType) {
                case 5:
                    lbvRowOptions.DataSource = _rRepository.GetByType(2);
                    lbvColumnOptions.DataSource = _rRepository.GetByType(1);
                    break;
                case 6:
                case 7:
                    lbvRowOptions.DataSource = _rRepository.GetByType(2);
                    break;
                case 8:
                    lbvRowOptions.DataSource = _rRepository.GetByType(1);
                    break;
                case 9:
                    lbvRowOptions.DataSource = _rRepository.GetByType(3);
                    break;
            }
        }

        private void btnSaveQuestion_Click(object sender, EventArgs e) {
            Question question = CreateQuestion();

            if (editMode && question.Id != null) {
                int editedQuestionIndex = _questions.IndexOf(_questions.Where(q => q.Id == question.Id).First());
                _questions[editedQuestionIndex] = question;
            } else if(editMode){
                int editedQuestionIndex = _questions.IndexOf(_questions.Where(q => q.Number == question.Number).First());
                _questions[editedQuestionIndex] = question;
            } else {
                _questions.Add(question);
            }

            FormHelper.ClearFields(grpAddQuestion);
            SetEditMode(false);
        }

        private void btnEditQuestion_Click(object sender, EventArgs e) {
            if(lbvAddedQuestions.SelectedItem != null) {
                Question question = lbvAddedQuestions.SelectedItem as Question;

                numQuestionOrderNumber.Value = question.Number;
                cboQuestionTypeSelector.SelectedIndex = question.Type - 1;
                txtQuestionTitle.Text = question.Title;

                if (question.Type >= 5 && question.Type <= 9)
                    SetQuestionFields(question.Fields);


                SetEditMode(true);
            }
        }

        private void btnDeleteQuestion_Click(object sender, EventArgs e) {
            if (lbvAddedQuestions.SelectedItem != null)
                _questions.RemoveAt(lbvAddedQuestions.SelectedIndex);
        }

        private void btnSaveSurvey_Click(object sender, EventArgs e) {
            Survey survey = CreateSurvey();

            _sRepository.Add(survey);
            Close();
        }

        private void btnAbortQuestion_Click(object sender, EventArgs e) {
            FormHelper.ClearFields(grpAddQuestion);
            SetEditMode(false);
        }

        private void btnAbortSurvey_Click(object sender, EventArgs e) {
            Close();
        }

        // luo kysymyksen id:llä tai ilman riippuen ollaanko muokkaustilassa
        private Question CreateQuestion() {
            Question question = new Question {
                Number = (int)numQuestionOrderNumber.Value,
                Type = cboQuestionTypeSelector.SelectedIndex + 1,
                Title = txtQuestionTitle.Text,
                Fields = GetQuestionFields()
            };

            if (editMode) {
                Question editedQuestion = lbvAddedQuestions.SelectedItem as Question;
                question.Id = editedQuestion.Id;
            }

            return question;
        }

        // luo kyselyn id:llä tai ilman riippuen ollaanko muokkaustilassa
        private Survey CreateSurvey() {
            return new Survey {
                Id = _survey != null ? _survey.Id : null,
                Name = txtSurveyName.Text,
                CreationDate = DateTime.Now.ToString("yyyy-MM-dd"),
                Questions = _questions.ToList()
            };
        }

        // palauttaa kentät tietyn tyyppisille kysymyksille, muuten null
        private List<Field> GetQuestionFields() {
            int questionType = cboQuestionTypeSelector.SelectedIndex + 1;
            List<Field> fields = null;

            if(questionType >= 5 && questionType <= 9) {
                fields = new List<Field>();

                foreach (Resource rowItem in lbvRowOptions.SelectedItems)
                    if (questionType == 5)
                        foreach (Resource colItem in lbvColumnOptions.SelectedItems)
                            fields.Add(new Field {
                                RowResourceId = rowItem.Id,
                                ColumnResourceId = colItem.Id
                            });
                    else
                        fields.Add(new Field {
                            RowResourceId = rowItem.Id
                        });
            }

            return fields;
        }

        // asettaa kysymyksen kentät valituiksi
        private void SetQuestionFields(List<Field> fields) {
            int questionType = cboQuestionTypeSelector.SelectedIndex + 1;

            lbvColumnOptions.ClearSelected();
            lbvRowOptions.ClearSelected();

            foreach (Field field in fields) {
                if (field.RowResourceId != null)
                    lbvRowOptions.SetSelected(lbvRowOptions
                        .FindStringExact((lbvRowOptions.DataSource as List<Resource>)
                        .Where(entity => entity.Id == field.RowResourceId)
                        .FirstOrDefault().Name), true);

                if (field.ColumnResourceId != null)
                    lbvColumnOptions.SetSelected(lbvColumnOptions
                        .FindStringExact((lbvColumnOptions.DataSource as List<Resource>)
                        .Where(entity => entity.Id == field.ColumnResourceId)
                        .FirstOrDefault().Name), true);
            }
        }

        private void SetEditMode(bool mode) {
            editMode = mode;

            lbvAddedQuestions.Enabled = !mode;
            btnDeleteQuestion.Enabled = !mode;
            btnEditQuestion.Enabled = !mode;
        }
    }
}
