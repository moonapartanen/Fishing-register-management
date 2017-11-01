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
        DBHelper _dbh = new DBHelper();
        BindingList<Question> _questions = new BindingList<Question>();
        DataTable _resources;

        public AddSurveyForm() {
            InitializeComponent();
            _resources = _dbh.getResources();
        }

        private void AddSurveyForm_Load(object sender, EventArgs e) {
            cboQuestionTypeSelector.DataSource = _dbh.getQuestionTypes();
            lbvAddedQuestions.DataSource = _questions;
        }

        //TODO: parempi ratkaisu
        private void cboQuestionTypeSelector_SelectedIndexChanged(object sender, EventArgs e) {
            int questionType = (int)cboQuestionTypeSelector.SelectedValue;

            ResetQuestionFields();

            switch (questionType) {
                case 5:
                    lbvRowOptions.DataSource = SelectFromResourcesById(2);
                    lbvColumnOptions.DataSource = SelectFromResourcesById(1);
                    break;
                case 6:
                case 7:
                    lbvRowOptions.DataSource = SelectFromResourcesById(2);
                    break;
                case 8:
                    lbvRowOptions.DataSource = SelectFromResourcesById(1);
                    break;
                case 9:
                    lbvRowOptions.DataSource = SelectFromResourcesById(3);
                    break;
            }
        }

        private void btnSaveQuestion_Click(object sender, EventArgs e) {
            // TODO: validaatio
            Question q = new Question {
                Number = (int)numQuestionOrderNumber.Value,
                Type = (int)cboQuestionTypeSelector.SelectedValue,
                Title = txtQuestionTitle.Text
            };

            if (q.Type == 5) {
                q.Columns = SelectedItemsToList(lbvColumnOptions);
                q.Rows = SelectedItemsToList(lbvRowOptions);
            }else if(q.Type <= 9) {
                q.Rows = SelectedItemsToList(lbvRowOptions);
            }

            _questions.Add(q);
        }


        private void btnSaveSurvey_Click(object sender, EventArgs e) {
            // TODO: validaatio
            Survey s = new Survey {
                Name = txtSurveyName.Text,
                Questions = _questions.ToList(),
                CreationDate = dtpCreationDate.Value.ToString("yyyy-MM-dd")
            };

            _dbh.saveSurvey(s);
        }

        private DataTable SelectFromResourcesById(int id) {
            return _resources.Select("resurssityyppi_id = " + id).CopyToDataTable();
        }

        private List<int> SelectedItemsToList(ListBox lb) {
            List<int> list = new List<int>();

            foreach (DataRowView item in lb.SelectedItems) {
                list.Add(int.Parse(item["id"].ToString()));
            }

            return list;
        }

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
