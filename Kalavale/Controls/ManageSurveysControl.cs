using System;
using System.Windows.Forms;
using Kalavale.Forms;
using Kalavale.Repositories;
using Kalavale.Entities;

namespace Kalavale.Controls {
    public partial class ManageSurveysControl : UserControl {
        SurveyRepository sRepository = new SurveyRepository();
        ResearchAreaRepository raRepository = new ResearchAreaRepository();
        WaterSystemRepository wsRepository = new WaterSystemRepository();

        public ManageSurveysControl() {
            InitializeComponent();
        }

        private void ManageSurveysControl_Load(object sender, EventArgs e) {
            if (!DesignMode) {
                lbvSurveys.DataSource = sRepository.GetAll();
                cboSurveySelector.DataSource = sRepository.GetAll();
                cboWaterSystem.DataSource = wsRepository.GetAll();
            }
        }

        private void btnAddSurvey_Click(object sender, EventArgs e) {
            AddSurveyForm form = new AddSurveyForm(null);
            form.Show();

            form.FormClosed += AddSurveyForm_FormClosed;
        }

        private void btnEditSurvey_Click(object sender, EventArgs e) {
            Survey survey = lbvSurveys.SelectedItem as Survey;
            AddSurveyForm form = new AddSurveyForm(survey);
            form.Show();

            form.FormClosed += AddSurveyForm_FormClosed;
        }

        private void btnDeleteSurvey_Click(object sender, EventArgs e) {
            Survey survey = lbvSurveys.SelectedItem as Survey;

            sRepository.Remove(survey);
            lbvSurveys.DataSource = sRepository.GetAll();
        }

        private void btnAddSurveyToResearchArea_Click(object sender, EventArgs e) {
            Survey survey = cboSurveySelector.SelectedItem as Survey;
            ResearchArea researchArea = cboResearchArea.SelectedItem as ResearchArea;
            string start = dtpBeginDate.Value.ToString("yyyy-MM-dd");
            string end = dtpEndDate.Value.ToString("yyyy-MM-dd");

            sRepository.AddToResearchArea(survey, researchArea, start, end);
            cboResearchArea_SelectedIndexChanged(null, null);
        }

        private void btnDeleteSurveyFromRA_Click(object sender, EventArgs e) {
            Survey survey = lbvResearchAreaSurveys.SelectedItem as Survey;
            ResearchArea researchArea = cboResearchArea.SelectedItem as ResearchArea;

            sRepository.RemoveFromResearchArea(survey, researchArea);
            cboResearchArea_SelectedIndexChanged(null, null);
        }

        private void cboWaterSystem_SelectedIndexChanged(object sender, EventArgs e) {
            WaterSystem ws = cboWaterSystem.SelectedItem as WaterSystem;

            cboResearchArea.DataSource = raRepository.GetByWaterSystem(ws);
        }

        private void cboResearchArea_SelectedIndexChanged(object sender, EventArgs e) {
            ResearchArea rs = cboResearchArea.SelectedItem as ResearchArea;

            lbvResearchAreaSurveys.DataSource = sRepository.GetByResearchArea(rs);
        }

        public void AddSurveyForm_FormClosed(object sender, FormClosedEventArgs e) {
            lbvSurveys.DataSource = sRepository.GetAll();
            cboSurveySelector.DataSource = sRepository.GetAll();
        }
    }
}
