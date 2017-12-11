using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Kalavale.Entities;
using Kalavale.Repositories;
using System.Drawing;

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
        bool _editMode;

        public AddSurveyForm(Survey survey) {
            InitializeComponent();
            _survey = survey;
            _editMode = false;

        }

        private void AddSurveyForm_Load(object sender, EventArgs e) {
            cboQuestionTypeSelector.DataSource = _questionTypes;
            lbvAddedQuestions.DataSource = _questions;
            grpAddQuestion.Enabled = false;
            InitializeSurvey();
        }

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
            FormHelper.ClearErrors(grpAddQuestion, errorProvider);

            if (ValidateQuestion(question)) {
                grpAddQuestion.Enabled = false;

                if (_editMode && question.Id != null) {
                    int editedQuestionIndex = _questions.IndexOf(_questions.Where(q => q.Id == question.Id).First());
                    _questions[editedQuestionIndex] = question;
                } else if (_editMode) {
                    int editedQuestionIndex = _questions.IndexOf(_questions.Where(q => q.Number == question.Number).First());
                    _questions[editedQuestionIndex] = question;
                } else {
                    _questions.Add(question);
                }

                FormHelper.ClearFields(grpAddQuestion);
                SetEditMode(false);
            }
        }

        private void btnSaveSurvey_Click(object sender, EventArgs e) {
            Survey survey = CreateSurvey();
            FormHelper.ClearErrors(grpSurveySettings, errorProvider);

            if (ValidateSurvey(survey)) {
                _sRepository.Add(survey);
                Close();
            }
        }

        private void btnAddQuestion_Click(object sender, EventArgs e) {
            grpAddQuestion.Enabled = true;
        }

        private void btnEditQuestion_Click(object sender, EventArgs e) {
            if(lbvAddedQuestions.SelectedItem != null) {
                Question question = lbvAddedQuestions.SelectedItem as Question;
                grpAddQuestion.Enabled = true;

                numQuestionNumber.Value = question.Number;
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

        private void btnAbortQuestion_Click(object sender, EventArgs e) {
            FormHelper.ClearFields(grpAddQuestion);
            FormHelper.ClearErrors(grpAddQuestion, errorProvider);
            grpAddQuestion.Enabled = false;
            SetEditMode(false);
        }

        private void btnAbortSurvey_Click(object sender, EventArgs e) {
            Close();
        }

        private Question CreateQuestion() {
            Question question = new Question {
                Number = (int)numQuestionNumber.Value,
                Type = cboQuestionTypeSelector.SelectedIndex + 1,
                Title = txtQuestionTitle.Text,
                Fields = GetQuestionFields()
            };

            if (_editMode) {
                Question editedQuestion = lbvAddedQuestions.SelectedItem as Question;
                question.Id = editedQuestion.Id;
            }

            return question;
        }

        private Survey CreateSurvey() {
            return new Survey {
                Id = _survey?.Id,
                Name = txtSurveyName.Text,
                CreationDate = DateTime.Now.ToString("yyyy-MM-dd"),
                Questions = _questions.ToList()
            };
        }

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
            _editMode = mode;
            grpSurveySettings.Enabled = !mode;
            btnSaveSurvey.Enabled = !mode;
        }

        private bool ValidateQuestion(Question question) {
            bool isValid = true;

            if (!_editMode) {
                foreach (Question q in _questions) {
                    if (q.Number == question.Number) {
                        errorProvider.SetError(numQuestionNumber,
                            "Kyselyssä ei voi olla kahta kysymystä samalla numerolla.");
                        isValid = false;
                        break;
                    }
                }
            }

            if (question.Type >= 6 && question.Fields.Count < 1) {
                errorProvider.SetError(lblRowOptions,
                    "Tämän tyyppisellä kysymyksellä täytyy olla vähintään yksi rivi.");
                isValid = false;
            } else if (question.Type == 5 && question.Fields.Count < 1) {
                errorProvider.SetError(lblRowOptions,
                    "Tämän tyyppisellä kysymyksellä täytyy olla vähintään yksi rivi.");
                errorProvider.SetError(lblColOptions,
                    "Tämän tyyppisellä kysymyksellä täytyy olla vähintään yksi sarake.");
                isValid = false;
            }

            if(txtQuestionTitle.Text.Length <= 10) {
                errorProvider.SetError(txtQuestionTitle,
                    "Kysymyksen otsikon täytyy olla vähintään 10 merkkiä pitkä.");
                isValid = false;
            }

            return isValid;
        }

        private bool ValidateSurvey(Survey survey) {
            bool isValid = true;

            if(txtSurveyName.Text.Length < 5) {
                errorProvider.SetError(txtSurveyName,
                    "Kyselyn nimen täytyy olla vähintään 5 merkkiä pitkä.");
                isValid = false;
            }

            if(_questions.Count < 1) {
                errorProvider.SetError(lblAddedQuestions,
                    "Kyselyllä täytyy olla vähintään yksi kysymys.");
                isValid = false;
            }

            return isValid;
        }
    }
}
