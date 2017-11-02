using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalavale {
    public partial class ManageDbControl : UserControl {
		string[] _dbItemTypes = { "Kalat", "Pyydykset", "Haittatekijät", "Käyttäjät", "Vesistöt", "Kalastusalueet" };
        DesignHelper _dh = new DesignHelper();
		DBHelper _dbh;
		DataTable _resources;
		
        public ManageDbControl() {
            InitializeComponent();
			
			if (LicenseManager.UsageMode == LicenseUsageMode.Runtime) {
                _dbh = new DBHelper();
				_resources = _dbh.getResources();
            }
        }

        //cbo = combobox, dgv = datagridview
        private void ManageDbControl1_Load(object sender, EventArgs e) {
            cboItemTypeSelector.DataSource = _dbItemTypes;
        }

        private void cboItemTypeSelector_SelectedIndexChanged(object sender, EventArgs e) {
            int index = cboItemTypeSelector.SelectedIndex;
            dgvItems.DataSource = SelectFromResourcesById(index + 1);

            // viedään kaikki tietokannan hallinta-komponentit luokalle
            _dh.SelectAllLayoutRefs(ref this.lblName, ref this.lblAddress, ref this.lblPostalCode, 
                                    ref this.lblCity, ref this.lblResearchArea, ref this.tbName, ref this.tbAddress,
                                    ref this.tbPostalCode, ref this.tbCity, ref this.cboResearchAreas);
            switch (index)
            {
                // TODO: HEADERTEKSTIT VOISI TÄÄLLÄ LISÄTÄ

                case 0:
                    _dh.ClearAll();
                    _dh.FishLayout();
                    break;
                case 1:
                    _dh.ClearAll();
                    _dh.MethodsLayout();
                    break;
                case 2:
                    _dh.ClearAll();
                    _dh.AdverseFactorsLayout();
                    break;
                case 3:
                    _dh.ClearAll();
                    _dh.UsersLayout();
                    break;
                case 4:
                    _dh.ClearAll();
                    _dh.WaterSystemsLayout();
                    break;
                case 5:
                    _dh.ClearAll();
                    _dh.FishingAreasLayout();
                    break;
                default:
                    MessageBox.Show("Jokin meni pieleen, ota yhteyttä ylläpitäjään");
                    break;
            }
        }

        private void btnAddSurvey_Click(object sender, EventArgs e) {
            AddSurveyForm form = new AddSurveyForm();
            form.Show();
        }

        private DataTable SelectFromResourcesById(int type) {
            DataTable dt = new DataTable();

            switch (type) {
                case 3:
                    //dt = _dbh.getUsers();
                    break;
                case 4:
                    dt = _dbh.getWaterSystems();
                    break;
                case 5:
                    //dt = _dbh.getFishingAreas()
                    break;
                default:
                    dt = _resources.Select("resurssityyppi_id = " + type).CopyToDataTable();
                    break;
            }

            return dt;
        }
    }
}
