using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        BindingList<Question> _questions = new BindingList<Question>();

        SurveyRepository _sRepository = new SurveyRepository();
        ResourceRepository _rRepository = new ResourceRepository();

        public AddSurveyForm() {
            InitializeComponent();
        }

        private void AddSurveyForm_Load(object sender, EventArgs e) {
            cboQuestionTypeSelector.DataSource = _questionTypes;
            lbvAddedQuestions.DataSource = _questions;
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
            // TODO: validaatio
            Question question = new Question {
                Number = (int)numQuestionOrderNumber.Value,
                Type = cboQuestionTypeSelector.SelectedIndex + 1,
                Title = txtQuestionTitle.Text
            };

            question.Fields = new List<Field>();

            if (question.Type == 5){
                foreach(Resource rowItem in lbvRowOptions.SelectedItems)
                foreach(Resource colItem in lbvColumnOptions.SelectedItems) {
                    question.Fields.Add(new Field {
                        RowResourceId = rowItem.Id,
                        ColumnResourceId = colItem.Id
                    });
                }
            } else if(question.Type <= 9) {
                foreach (Resource rowItem in lbvRowOptions.SelectedItems) {
                    question.Fields.Add(new Field {
                        RowResourceId = rowItem.Id,
                        ColumnResourceId = null
                    });
                }
            }

            _questions.Add(question);
        }


        private void btnSaveSurvey_Click(object sender, EventArgs e) {
            // TODO: validaatio
            Survey survey = new Survey {
                Name = txtSurveyName.Text,
                CreationDate = DateTime.Now.ToString("yyyy-MM-dd"),
                Questions = _questions.ToList()
            };

            _sRepository.Add(survey);
        }
    }
}
