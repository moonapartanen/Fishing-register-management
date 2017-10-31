using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalavale {
    public partial class ManageSurveysControl : UserControl {
        DBHelper _dbh;

        public ManageSurveysControl() {
            InitializeComponent();

            // varmistaa ettei usercontrol tavoittele ajonaikaisia resursseja design modessa
            if (LicenseManager.UsageMode == LicenseUsageMode.Runtime) {
                _dbh = new DBHelper();
            }
        }

        private void ManageSurveysControl_Load(object sender, EventArgs e) {
            if(_dbh != null) {
                dgvSurveys.DataSource = _dbh.getSurveys();
                cboSurveySelector.DataSource = _dbh.getSurveys();
                cboResearchAreaSelector.DataSource = _dbh.getResearchAreas();
            }
        }

        private void btnAddSurvey_Click(object sender, EventArgs e) {
            AddSurveyForm form = new AddSurveyForm();
            form.Show();
            form.FormClosed += this.AddSurveyForm_FormClosed;
        }

        private void btnEditSurvey_Click(object sender, EventArgs e) {
            int selectedSurveyId = (int)dgvSurveys.SelectedRows[0].Cells["id"].Value;

            MessageBox.Show(selectedSurveyId.ToString());
        }

        public void AddSurveyForm_FormClosed(object sender, FormClosedEventArgs e) {
            dgvSurveys.DataSource = _dbh.getSurveys();
            cboSurveySelector.DataSource = _dbh.getSurveys();
        }

        private void btnDeleteSurvey_Click(object sender, EventArgs e) {
            int selectedSurveyId = (int)dgvSurveys.SelectedRows[0].Cells["id"].Value;

            MessageBox.Show(selectedSurveyId.ToString());
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

            lbvRASurveys.DataSource = _dbh.getSurveysByRAId(selectedResearchAreaId);
        }
    }
}
