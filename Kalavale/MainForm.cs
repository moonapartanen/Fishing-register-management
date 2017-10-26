using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalavale {
    public partial class MainForm : Form {

        private string[] _dbItemTypes = { "Kalat", "Pyydykset", "Haittatekijät", "Käyttäjät", "Vesistöt", "Kalastusalueet" };
        DBHelper _dbh = new DBHelper();



        public MainForm() {
            InitializeComponent();
        }

        //cbo = combobox, dgv = datagridview
        private void Form1_Load(object sender, EventArgs e) {
            cboItemTypeSelector.DataSource = _dbItemTypes;

            //Form form = FindForm();
            //DesignHelper _dh = new DesignHelper();
        }

        private void cmbDBM_SelectedIndexChanged(object sender, EventArgs e) {
            int index = cboItemTypeSelector.SelectedIndex;
            dgvItems.DataSource = _dbh.getResourcesByType(index + 1);

            //dgvItems.Columns[0].Visible = false;
            //dgvItems.Columns[1].HeaderText = "Kala:";
            // TO DO: PIILOTETAAN TURHAT KOLUMNIT JA LISÄTÄÄN HEADERTEKSTIT
        }

        private void btnAddSurvey_Click(object sender, EventArgs e) {
            AddSurveyForm form = new AddSurveyForm();
            form.Show();
        }         
    }
}
