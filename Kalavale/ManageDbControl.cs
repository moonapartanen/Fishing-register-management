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
        private static int id;
		
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

            DataTable dt = new DataTable();
            int index = cboItemTypeSelector.SelectedIndex;
            dgvItems.DataSource = SelectFromResourcesById(index + 1);

            // viedään kaikki tietokannan hallinta-komponentit luokalle
            _dh.SelectAllLayoutRefs(ref this.lblName, ref this.lblAddress, ref this.lblPostalCode, 
                                    ref this.lblCity, ref this.lblResearchArea, ref this.lblWaterSystems, ref this.tbName, ref this.tbAddress,
                                    ref this.tbPostalCode, ref this.tbCity, ref this.cboResearchAreas, ref this.cboWaterSystems, ref this.dgvItems, ref this.btnAdd);

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
                    cboResearchAreas.DataSource = _dbh.getResearchAreas();
                    cboResearchAreas.DisplayMember = "nimi";
                    cboResearchAreas.ValueMember = "id";
                    cboResearchAreas.SelectedIndex = -1;
                    break;
                case 4:
                    _dh.ClearAll();
                    _dh.WaterSystemsLayout();
                    break;
                case 5:
                    _dh.ClearAll();
                    _dh.FishingAreasLayout();
                    cboResearchAreas.DataSource = _dbh.getResearchAreas();
                    cboResearchAreas.DisplayMember = "nimi";
                    cboResearchAreas.ValueMember = "id";
                    cboResearchAreas.SelectedIndex = -1;
                    break;
                case 6:
                    _dh.ClearAll();
                    _dh.ResearchAreasLayout();
                    cboWaterSystems.DataSource = _dbh.getWaterSystems();
                    cboWaterSystems.DisplayMember = "nimi";
                    cboWaterSystems.ValueMember = "id";
                    cboWaterSystems.SelectedIndex = -1;
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
                id = Convert.ToInt32(dgvItems.SelectedRows[0].Cells[0].Value);

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
                    cboResearchAreas.Text = dgvItems.SelectedRows[0].Cells[2].Value + String.Empty;
                }
                else if (cboItemTypeSelector.SelectedIndex == 6)
                {
                    tbName.Text = dgvItems.SelectedRows[0].Cells[1].Value + String.Empty;
                    cboWaterSystems.Text = dgvItems.SelectedRows[0].Cells[2].Value + String.Empty;
                }
                else
                {
                    tbName.Text = dgvItems.SelectedRows[0].Cells[1].Value + String.Empty;
                }
            }
            else
            {
                // RIVIÄ EI OLE VALITTUNA

                id = 0;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            _dh.EmptyFields();
            dgvItems.ClearSelection();

            // poikkeus kalastusalueissa
            if (cboItemTypeSelector.SelectedIndex == 5)
            {
                _dh.FishingAreasLayout();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // poisto
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataTable dt = CheckIfExistsInDatabase();

            // lisätään tai updatetaan riippuen mitä dt palautti
            if (dt.Rows.Count > 0)
            {
                // tietokannan update

                if (cboItemTypeSelector.SelectedIndex == 3)
                {
                    _dbh.updateUsers(id, tbName.Text, tbAddress.Text, tbPostalCode.Text, tbCity.Text, Convert.ToInt32(cboResearchAreas.SelectedValue));
                    dgvItems.DataSource = _dbh.getUsers();
                    _dh.EmptyFields();
                }
                else if (cboItemTypeSelector.SelectedIndex == 4)
                {
                    _dbh.updateWaterSystems(id, tbName.Text);
                    dgvItems.DataSource = _dbh.getWaterSystems();
                    _dh.EmptyFields();
                }
                else if (cboItemTypeSelector.SelectedIndex == 5)
                {
                    _dbh.updateFishingAreas(id, tbName.Text, Convert.ToInt32(cboResearchAreas.SelectedValue));
                    dgvItems.DataSource = _dbh.getFishingAreas();
                    _dh.EmptyFields();
                    _dh.FishingAreasLayout();   // pitää kutsua erikseen, koska muuten layout särkyy
                }
                else if (cboItemTypeSelector.SelectedIndex == 6)
                {
                    _dbh.updateResearchAreas(id, tbName.Text, Convert.ToInt32(cboWaterSystems.SelectedValue));
                    dgvItems.DataSource = _dbh.getResearchAreas();
                    _dh.EmptyFields();
                }
                else
                {
                    _dbh.updateResources(id, tbName.Text);
                    //dgvItems.DataSource = SelectFromResourcesById(cboItemTypeSelector.SelectedIndex + 1);

                    // TODO: PÄIVITÄ DATAGRIDVIEW
                }

            }
            else
            {
                // tietokannan insert

                if (cboItemTypeSelector.SelectedIndex == 3)
                {
                   // _dbh.updateUsers(id, tbName.Text, tbAddress.Text, tbPostalCode.Text, tbCity.Text, Convert.ToInt32(cboResearchAreas.SelectedValue));
                    dgvItems.DataSource = _dbh.getUsers();
                    _dh.EmptyFields();
                }
                else if (cboItemTypeSelector.SelectedIndex == 4)
                {
                    _dbh.insertWaterSystems(tbName.Text);
                    dgvItems.DataSource = _dbh.getWaterSystems();
                    _dh.EmptyFields();
                }
                else if (cboItemTypeSelector.SelectedIndex == 5)
                {
                    _dbh.insertFishingAreas(tbName.Text, Convert.ToInt32(cboResearchAreas.SelectedValue));
                    dgvItems.DataSource = _dbh.getFishingAreas();
                    _dh.EmptyFields();
                    _dh.FishingAreasLayout();   // pitää kutsua erikseen, koska muuten layout särkyy
                }
                else if (cboItemTypeSelector.SelectedIndex == 6)
                {
                    _dbh.insertResearchAreas(tbName.Text, Convert.ToInt32(cboWaterSystems.SelectedValue));
                    dgvItems.DataSource = _dbh.getResearchAreas();
                    _dh.EmptyFields();
                }
                else
                {
                    int resourceType = cboItemTypeSelector.SelectedIndex + 1;
                    _dbh.insertResources(tbName.Text, resourceType);
                    //dgvItems.DataSource = SelectFromResourcesById(cboItemTypeSelector.SelectedIndex + 1);

                    // TODO: PÄIVITÄ DATAGRIDVIEW
                }
            }
        }

        private DataTable CheckIfExistsInDatabase()
        {
            DataTable dt = null;

            // tarkistetaan onko olemassa samalla ID:llä itemiä
            if (cboItemTypeSelector.SelectedIndex == 3)
            {
                dt = _dbh.Select("SELECT * FROM kayttajat WHERE ID = " + id + ";");
            }
            else if (cboItemTypeSelector.SelectedIndex == 4)
            {
                dt = _dbh.Select("SELECT * FROM vesistot WHERE ID = " + id + ";");
            }
            else if (cboItemTypeSelector.SelectedIndex == 5)
            {
                dt = _dbh.Select("SELECT * FROM kalastusalueet WHERE ID = " + id + ";");
            }
            else if (cboItemTypeSelector.SelectedIndex == 6)
            {
                dt = _dbh.Select("SELECT * FROM tutkimusalueet WHERE ID = " + id + ";");
            }
            else
            {
                dt = _dbh.Select("SELECT * FROM resurssit WHERE ID = " + id + ";");
            }

            return dt;
        }
    }
}
