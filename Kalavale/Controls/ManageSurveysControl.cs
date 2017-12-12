using System;
using System.Windows.Forms;
using Kalavale.Forms;
using Kalavale.Repositories;
using Kalavale.Entities;
using System.Collections.Generic;

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
                dtpStartDate.MinDate = DateTime.Today;
                dtpEndDate.MinDate = dtpStartDate.Value.AddDays(1);
            }
        }

        private void btnAddSurvey_Click(object sender, EventArgs e) {
            AddSurveyForm form = new AddSurveyForm(null);
            form.Show();
            form.FormClosed += AddSurveyForm_FormClosed;
        }

        private void btnEditSurvey_Click(object sender, EventArgs e) {
            if(lbvSurveys.SelectedItem != null) {
                Survey survey = lbvSurveys.SelectedItem as Survey;
                AddSurveyForm form = new AddSurveyForm(survey);
                form.Show();

                form.FormClosed += AddSurveyForm_FormClosed;
            }
        }

        private void btnDeleteSurvey_Click(object sender, EventArgs e) {
            if (lbvSurveys.SelectedItem != null) {
                DialogResult dr = MessageBox.Show("Myös viittaukset kyselyyn ja sen vastauksiin poistetaan tutkimusalueilta." + 
                    " Kyselyn poisto saattaa vaikuttaa meneillään oleviin kyselyihin sekä tallennettuihin vastauksiin.\n\nHaluatko jatkaa?",
                        "Huomio", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes) {
                    Survey survey = lbvSurveys.SelectedItem as Survey;

                    sRepository.Remove(survey);
                    lbvSurveys.DataSource = sRepository.GetAll();
                    lbvResearchAreaSurveys.DataSource = 
                        sRepository.GetResearchAreaSurveys(cboResearchArea.SelectedItem as ResearchArea);
                }
            }
        }

        private void btnAddSurveyToResearchArea_Click(object sender, EventArgs e) {
            if(cboSurveySelector.SelectedItem != null && cboResearchArea.SelectedItem != null) {
                FormHelper.ClearErrors(grpConnectSurvey, errorProvider);

                Survey survey = cboSurveySelector.SelectedItem as Survey;
                ResearchArea researchArea = cboResearchArea.SelectedItem as ResearchArea;
                DateTime start = dtpStartDate.Value;
                DateTime end = dtpEndDate.Value;

                if(ValidateSurveyAdd(survey, researchArea, start, end)) {
                    sRepository.AddToResearchArea(survey, researchArea, start, end);
                    lbvResearchAreaSurveys.DataSource = sRepository.GetResearchAreaSurveys(researchArea);
                }
            }
        }

        private void btnDeleteSurveyFromResearchArea_Click(object sender, EventArgs e) {
            if(lbvResearchAreaSurveys.SelectedItem != null && cboResearchArea.SelectedItem != null) {
                ResearchAreaSurvey rsa = lbvResearchAreaSurveys.SelectedItem as ResearchAreaSurvey;
                ResearchArea ra = cboResearchArea.SelectedItem as ResearchArea;

                if (lbvSurveys.SelectedItem != null) {
                    DialogResult dr = MessageBox.Show("Kyselyn yhteys tutkimusalueeseen poistetaan, eikä siihen voi enää vastata." +
                        " Jos haluat säilyttää kyselyyn liittyvät vastaukset, tuo ne exceliin ennen poistoa.\n\nHaluatko jatkaa?",
                            "Huomio", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (dr == DialogResult.Yes) {
                        sRepository.RemoveFromResearchArea(rsa);
                        lbvResearchAreaSurveys.DataSource = sRepository.GetResearchAreaSurveys(ra);
                    }
                }
            }
        }

        private void cboWaterSystem_SelectedIndexChanged(object sender, EventArgs e) {
            if(cboWaterSystem.SelectedItem != null) {
                WaterSystem ws = cboWaterSystem.SelectedItem as WaterSystem;
                cboResearchArea.DataSource = raRepository.GetByWaterSystem(ws);
            }
        }

        private void cboResearchArea_SelectedIndexChanged(object sender, EventArgs e) {
            if (cboResearchArea.SelectedItem != null) {
                ResearchArea rs = cboResearchArea.SelectedItem as ResearchArea;
                lbvResearchAreaSurveys.DataSource = sRepository.GetResearchAreaSurveys(rs);
            }
        }

        public void AddSurveyForm_FormClosed(object sender, FormClosedEventArgs e) {
            if(cboResearchArea.SelectedItem != null) {
                ResearchArea rs = cboResearchArea.SelectedItem as ResearchArea;
                lbvResearchAreaSurveys.DataSource = sRepository.GetResearchAreaSurveys(rs);
                lbvSurveys.DataSource = sRepository.GetAll();
                cboSurveySelector.DataSource = sRepository.GetAll();
            }
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e) {
            dtpEndDate.MinDate = dtpStartDate.Value.AddDays(1);
        }

        private bool ValidateSurveyAdd(Survey survey, ResearchArea researchArea, DateTime start, DateTime end) {
            bool isValid = true;
            List<ResearchAreaSurvey> surveys = (List<ResearchAreaSurvey>)sRepository
                .GetResearchAreaSurveys(researchArea);

            foreach(ResearchAreaSurvey addedSurvey in surveys) {
                if(addedSurvey.SurveyId == survey.Id) {
                    errorProvider.SetError(cboSurveySelector,
                            "Tämä kysely on jo yhdistetty valittuun tutkimusalueeseen.");
                    isValid = false;
                }

                if(addedSurvey.StartDate <= start && addedSurvey.EndDate >= start) {
                    errorProvider.SetError(dtpStartDate,
                            "Kyselyn alkuajankohta on toisen kyselyn voimassaoloajan sisällä.\n" +
                            "Tutkimusalueella voi olla vain yksi aktiivinen kysely kerrallaan.");
                    isValid = false;
                }

                if (addedSurvey.StartDate <= end && addedSurvey.EndDate >= end) {
                    errorProvider.SetError(dtpEndDate,
                            "Kyselyn loppuajankohta on toisen kyselyn voimassaoloajan sisällä.\n" +
                            "Tutkimusalueella voi olla vain yksi aktiivinen kysely kerrallaan.");
                    isValid = false;
                }
            }

            return isValid;
        }
    }
}
