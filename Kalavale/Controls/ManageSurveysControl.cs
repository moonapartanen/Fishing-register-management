using System;
using System.Windows.Forms;
using Kalavale.Forms;
using Kalavale.Repositories;
using Kalavale.Entities;

namespace Kalavale.Controls {
    public partial class ManageSurveysControl : UserControl {
        SurveyRepository sRepository = new SurveyRepository();
        ResearchAreaRepository raRepository = new ResearchAreaRepository();

        public ManageSurveysControl() {
            InitializeComponent();
        }

        private void ManageSurveysControl_Load(object sender, EventArgs e) {
            lbvSurveys.DataSource = sRepository.GetAll();
            cboSurveySelector.DataSource = sRepository.GetAll();
            cboResearchAreaSelector.DataSource = raRepository.GetAll();
        }

        private void btnAddSurvey_Click(object sender, EventArgs e) {
            AddSurveyForm form = new AddSurveyForm();
            form.Show();

            form.FormClosed += AddSurveyForm_FormClosed;
        }

        private void btnEditSurvey_Click(object sender, EventArgs e) {
            Survey survey = lbvSurveys.SelectedItem as Survey;

            MessageBox.Show(survey.Id.ToString());
        }

        public void AddSurveyForm_FormClosed(object sender, FormClosedEventArgs e) {
            lbvSurveys.DataSource = sRepository.GetAll();
            cboSurveySelector.DataSource = sRepository.GetAll();
        }

        private void btnDeleteSurvey_Click(object sender, EventArgs e) {
            Survey survey = lbvSurveys.SelectedItem as Survey;

            MessageBox.Show(survey.Id.ToString());
        }

        private void btnAddSurveyToRA_Click(object sender, EventArgs e) {
            int selectedSurveyId = (int)cboSurveySelector.SelectedValue;

            MessageBox.Show(selectedSurveyId.ToString());
        }

        private void btnDeleteSurveyFromRA_Click(object sender, EventArgs e) {
            int selectedSurveyId = (int)lbvRASurveys.SelectedValue;
            int selectedResearchAreaId = (int)cboResearchAreaSelector.SelectedValue;

            MessageBox.Show(selectedSurveyId.ToString());
        }

        private void cboResearchAreaSelector_SelectedIndexChanged(object sender, EventArgs e) {
            int selectedResearchAreaId = (int)cboResearchAreaSelector.SelectedValue;

            lbvRASurveys.DataSource = sRepository.GetByResearchArea(selectedResearchAreaId);
        }
    }
}
