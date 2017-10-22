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
        private DBHelper dbh = new DBHelper();
        private string[] questionTypes = { "Type 1", "Type 2", "Type 3"};

        public AddSurveyForm() {
            InitializeComponent();
        }

        private void AddSurveyForm_Load(object sender, EventArgs e) {
            cboWaterSystemSelector.ValueMember = "nimi";
            cboWaterSystemSelector.DataSource = dbh.getWaterSystems();

            cboQuestionTypeSelector.DataSource = questionTypes;

            grpQuestionSettings.Enabled = false;

            lstAreaSelector.SelectionMode = SelectionMode.MultiSimple;
            lstAreaSelector.DisplayMember = "nimi";
        }

        private void cboWaterSystemSelector_SelectedIndexChanged(object sender, EventArgs e) {
            string ws = cboWaterSystemSelector.SelectedValue.ToString();

            lstAreaSelector.DataSource = dbh.getAreas(ws);
        }

        private void cboQuestionTypeSelector_SelectedIndexChanged(object sender, EventArgs e) {
            int index = cboQuestionTypeSelector.SelectedIndex;

            switch (index) {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    break;
            }
        }
    }
}
