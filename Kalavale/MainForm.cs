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
        private string[] dbItemTypes = { "Kalat", "Pyydykset", "Käyttäjät" };
        DBHelper dbh = new DBHelper();

        public MainForm() {
            InitializeComponent();
        }

        //cbo = combobox, dgv = datagridview
        private void Form1_Load(object sender, EventArgs e) {
            cboItemTypeSelector.DataSource = dbItemTypes;
        }

        private void cmbDBM_SelectedIndexChanged(object sender, EventArgs e) {
            int index = cboItemTypeSelector.SelectedIndex;
            dgvItems.DataSource = dbh.getResourcesByType(index);
        }

        private void btnAddSurvey_Click(object sender, EventArgs e) {
            AddSurveyForm form = new AddSurveyForm();
            form.Show();
        }
    }
}
