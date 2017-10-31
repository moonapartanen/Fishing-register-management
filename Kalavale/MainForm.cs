using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Kalavale {
    public partial class MainForm : Form {
        DBHelper _dbh = new DBHelper();

        public MainForm() {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            dgvSurveys.DataSource = _dbh.getSurveys();
            cboResearchAreaSelector.DataSource = _dbh.getResearchAreas();
            cboSurveySelector.DataSource = _dbh.getSurveys();
        }

        private void btnAddSurvey_Click(object sender, EventArgs e) {
            AddSurveyForm form = new AddSurveyForm();
            form.Show();
        }

        private void dgvSurveys_SelectionChanged(object sender, EventArgs e) {
        }
    }
}
