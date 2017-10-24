using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Kalavale {
    public partial class AddSurveyForm : Form {
        private DBHelper _dbh = new DBHelper();

        public AddSurveyForm() {
            InitializeComponent();
        }

        private void AddSurveyForm_Load(object sender, EventArgs e) {
            cboQuestionTypeSelector.DataSource = _dbh.getQuestionTypes();
            cboWaterSystemSelector.DataSource = _dbh.getWaterSystems();
        }
        
        private void cboWaterSystemSelector_SelectedIndexChanged(object sender, EventArgs e) {
            int waterSystemId = (int)cboWaterSystemSelector.SelectedValue;

            lbvAreaSelector.DataSource = _dbh.getFishingAreas(waterSystemId);
        }

        //TODO: parempi ratkaisu
        private void cboQuestionTypeSelector_SelectedIndexChanged(object sender, EventArgs e) {
            int questionType = (int)cboQuestionTypeSelector.SelectedValue;

            grpQuestionSettings.Enabled = true;
            ResetQuestionFields();

            switch (questionType) {
                case 4:
                    lbvColumnOptions.DataSource = _dbh.getResourcesByType(1);
                    lbvRowOptions.DataSource = _dbh.getResourcesByType(2);
                    break;
                case 5:
                case 6:
                    lbvRowOptions.DataSource = _dbh.getResourcesByType(2);
                    break;
                case 7:
                    lbvRowOptions.DataSource = _dbh.getResourcesByType(1);
                    break;
                case 8:
                    lbvRowOptions.DataSource = _dbh.getResourcesByType(3);
                    break;
                default:
                    grpQuestionSettings.Enabled = false;
                    break;
            }
        }

        private void btnSaveQuestion_Click(object sender, EventArgs e) {
            // TODO: validaatio ja kysymysten tallennus listaan olioina
        }

        // ...
        private void ResetQuestionFields() {
            lbvColumnOptions.DataSource = null;
            lbvRowOptions.DataSource = null;
            lbvColumnOptions.Items.Clear();
            lbvRowOptions.Items.Clear();
            lbvColumnOptions.DisplayMember = "nimi";
            lbvRowOptions.DisplayMember = "nimi";
            lbvColumnOptions.ValueMember = "id";
            lbvRowOptions.ValueMember = "id";
        }
    }
}
