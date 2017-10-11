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

namespace Kalavale
{
    public partial class Form1 : Form
    {
        private string[] dbmItems = { "Kalat", "Pyydykset", "Käyttäjät" };
        DBConnection db = new DBConnection();

        public void UpdateDataGridViews()
        {

            int index = cmbDBM.SelectedIndex;
            switch(index)
            {
                case 0:
                    dgDBM.DataSource = db.Select(db.dbmFishQuery);
                    break;
                case 1:
                    dgDBM.DataSource = db.Select(db.dbmMethodQuery);
                    break;
                case 2:
                    dgDBM.DataSource = db.Select(db.dbmUserQuery);
                    break;            
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            db.OpenConnection();
            cmbDBM.DataSource = dbmItems;
            UpdateDataGridViews();
            
        }

        private void cmbDBM_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDataGridViews();
        }
    }
}
