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
        private string[] _dbItemTypes = { "Kalat", "Pyydykset", "Käyttäjät" };
        DBHelper _dbh = new DBHelper();

        public MainForm() {
            InitializeComponent();
        }

        //cbo = combobox, dgv = datagridview
        private void Form1_Load(object sender, EventArgs e) {
            cboItemTypeSelector.DataSource = _dbItemTypes;
        }

        private void cmbDBM_SelectedIndexChanged(object sender, EventArgs e) {
            int index = cboItemTypeSelector.SelectedIndex;
            dgvItems.DataSource = _dbh.getResourcesByType(index + 1);
        }

        private void btnAddSurvey_Click(object sender, EventArgs e) {
            AddSurveyForm form = new AddSurveyForm();
            form.Show();
        }
    }
}
