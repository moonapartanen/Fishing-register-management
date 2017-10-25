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
        private List<Question> _questions = new List<Question>();

        public AddSurveyForm() {
            InitializeComponent();
        }

        private void AddSurveyForm_Load(object sender, EventArgs e) {
            cboQuestionTypeSelector.DataSource = _dbh.getQuestionTypes();
            BindingList<Question> bl = new BindingList<Question>(_questions);
            lbvAddedQuestions.DataSource = bl;
            lbvAddedQuestions.DisplayMember = "Type";
        }

        //TODO: parempi ratkaisu
        private void cboQuestionTypeSelector_SelectedIndexChanged(object sender, EventArgs e) {
            int questionType = (int)cboQuestionTypeSelector.SelectedValue;

            grpQuestionSettings.Enabled = true;
            ResetQuestionFields();

            switch (questionType) {
                case 5:
                    lbvColumnOptions.DataSource = _dbh.getResourcesByType(1);
                    lbvRowOptions.DataSource = _dbh.getResourcesByType(2);
                    break;
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
            // TODO: validaatio
            Question q = new Question {
                Number = (int)numQuestionOrderNumber.Value,
                Type = (int)cboQuestionTypeSelector.SelectedValue,
                Title = txtQuestionTitle.Text
            };

            if (q.Type == 5) {
                q.Columns = GetSelectedItems(lbvColumnOptions);
                q.Rows = GetSelectedItems(lbvRowOptions);
            }else if(q.Type <= 8) {
                q.Rows = GetSelectedItems(lbvRowOptions);
            }

            _questions.Add(q);
        }

        private List<int> GetSelectedItems(ListBox lb) {
            List<int> list = new List<int>();

            foreach (DataRowView item in lb.SelectedItems) {
                list.Add(int.Parse(item["id"].ToString()));
            }

            return list;
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
