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
		string[] _dbItemTypes = { "Kalat", "Pyydykset", "Haittatekijät", "Käyttäjät", "Vesistöt", "Kalastusalueet", "Tutkimusalueet" };
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
                                    ref this.tbPostalCode, ref this.tbCity, ref this.cboResearchAreas, ref this.dgvItems);

            _dh.EmptyFields();

            switch (index)
            {
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
                    // TODO: COMBOBOXIIN TUTKIMUSALUEET
                    break;
                case 4:
                    _dh.ClearAll();
                    _dh.WaterSystemsLayout();
                    break;
                case 5:
                    _dh.ClearAll();
                    _dh.FishingAreasLayout();
                    // TODO: COMBOBOXIIN TUTKIMUSALUEET JA COMBOBOXIN NÄYTTÄMINEN OIKEASSA PAIKASSA
                    break;
                case 6:
                    _dh.ClearAll();
                    _dh.ResearchAreasLayout();
                    break;
                default:
                    MessageBox.Show("Jokin meni pieleen, ota yhteyttä ylläpitäjään");
                    break;
            }
        }

        private DataTable SelectFromResourcesById(int type) {
            DataTable dt = new DataTable();

            switch (type) {

                case 4:
                    dt = _dbh.getUsers();
                    break;
                case 5:
                    dt = _dbh.getWaterSystems();
                    break;
                case 6:
                    dt = _dbh.getFishingAreas();
                    break;
                case 7:
                    dt = _dbh.getResearchAreas();
                    break;
                default:
                    dt = _resources.Select("resurssityyppi_id = " + type).CopyToDataTable();
                    break;
            }

            return dt;
        }

        private void dgvItems_SelectionChanged(object sender, EventArgs e)
        {

            if (dgvItems.SelectedRows.Count > 0)
            {
                if (cboItemTypeSelector.SelectedIndex == 3)
                {
                    tbName.Text = dgvItems.SelectedRows[0].Cells[1].Value + String.Empty;
                    tbAddress.Text = dgvItems.SelectedRows[0].Cells[2].Value + String.Empty;
                    tbPostalCode.Text = dgvItems.SelectedRows[0].Cells[3].Value + String.Empty;
                    tbCity.Text = dgvItems.SelectedRows[0].Cells[4].Value + String.Empty;
                    cboResearchAreas.Text = dgvItems.SelectedRows[0].Cells[5].Value + String.Empty;
                }
                else if (cboItemTypeSelector.SelectedIndex == 5)
                {
                    tbName.Text = dgvItems.SelectedRows[0].Cells[1].Value + String.Empty;
                    tbAddress.Text = dgvItems.SelectedRows[0].Cells[2].Value + String.Empty;
                }
                else
                {
                    tbName.Text = dgvItems.SelectedRows[0].Cells[1].Value + String.Empty;
                }
            }
            else
            {
                // RIVIÄ EI OLE VALITTUNA
            }
        }
    }
}
