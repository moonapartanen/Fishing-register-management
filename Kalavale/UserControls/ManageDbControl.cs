using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kalavale.Repositories;
using Kalavale.Entities;

//  TO DO:
//  - RESURSSIEN LISÄÄMISEN/MUOKKAAMISEN/POISTAMISEN JÄLKEEN DATAGRIDVIEW PÄIVITETTÄVÄ
//  - TARKASTUS, ONKO KAIKISSA KENTISSÄ ARVOJA JOS LISÄTÄÄN TAI MUOKATAAN
//  - DATAGRIDVIEW SELLAISEKSI, ETTÄ JOS VALITSEE SOLUN NIIN KOKO RIVI VALIKOITUU
//  - KORJAA WARNING-TEKSTIT
//  - PÄIVITÄ DATAGRIDVIEW POISTON JÄLKEEN
//  - TESTAA POISTON TOIMIVUUS

namespace Kalavale {
    public partial class ManageDbControl : UserControl {
		string[] _dbItemTypes = { "Kalat", "Pyydykset", "Haittatekijät", "Käyttäjät", "Vesistöt", "Kalastusalueet", "Tutkimusalueet" };

        FishingAreaRepository faRepository = new FishingAreaRepository();
        ResearchAreaRepository raRepository = new ResearchAreaRepository();
        ResourceRepository rRepository = new ResourceRepository();
        UserRepository uRepository = new UserRepository();
        WaterSystemRepository wsRepository = new WaterSystemRepository();

        DesignHelper _dh = new DesignHelper();
		
        public ManageDbControl() {
            InitializeComponent();
        }

        //cbo = combobox, dgv = datagridview
        private void ManageDbControl1_Load(object sender, EventArgs e) {
            cboItemTypeSelector.DataSource = _dbItemTypes;
        }

        private void cboItemTypeSelector_SelectedIndexChanged(object sender, EventArgs e) {
            int index = cboItemTypeSelector.SelectedIndex;

            dgvItems.DataSource = rRepository.GetByTypeAsDataTable(1);
            //SwitchLayout(index);

            switch (index) {
                case 0:
                    dgvItems.DataSource = rRepository.GetByTypeAsDataTable(1);
                    break;
                case 1:
                    dgvItems.DataSource = rRepository.GetByTypeAsDataTable(2);
                    break;
                case 2:
                    dgvItems.DataSource = rRepository.GetByTypeAsDataTable(3);
                    break;
                case 3:
                    dgvItems.DataSource = uRepository.GetAllAsDataTable();
                    cboResearchAreas.DataSource = raRepository.GetAllAsDataTable(); ;
                    break;
                case 4:
                    dgvItems.DataSource = wsRepository.GetAllAsDataTable();
                    break;
                case 5:
                    dgvItems.DataSource = faRepository.GetAllAsDataTable();
                    cboResearchAreas.DataSource = raRepository.GetAllAsDataTable();
                    break;
                case 6:
                    dgvItems.DataSource = raRepository.GetAllAsDataTable();
                    cboWaterSystems.DataSource = wsRepository.GetAllAsDataTable();
                    break;
                default:
                    MessageBox.Show("Jokin meni pieleen, ota yhteyttä ylläpitäjään");
                    break;
            }
        }

        private void dgvItems_SelectionChanged(object sender, EventArgs e) {
            //MessageBox.Show(dgvItems.SelectedRows[0].Cells[0].Value);

           /* if (cboItemTypeSelector.SelectedIndex == 3)
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
            }*/
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

        private void btnDelete_Click(object sender, EventArgs e) {
            // TIETOKANNAN DELETET
            int selectedEntityId = Convert.ToInt32(dgvItems.SelectedRows[0].Cells[0].Value);

            if (cboItemTypeSelector.SelectedIndex == 3) {
                uRepository.Remove(selectedEntityId);
            }
            else if (cboItemTypeSelector.SelectedIndex == 4) {
                if (MessageBox.Show("Tähän warning, joka varoittaa cascadesta", "Varoitus",
                    MessageBoxButtons.YesNo) == DialogResult.Yes) {

                    wsRepository.Remove(selectedEntityId);
                }
            }
            else if (cboItemTypeSelector.SelectedIndex == 5) {
                faRepository.Remove(selectedEntityId);
            }
            else if (cboItemTypeSelector.SelectedIndex == 6) {
                if (MessageBox.Show("Tähän warning, joka varoittaa cascadesta", "Varoitus",
                    MessageBoxButtons.YesNo) == DialogResult.Yes) {

                    raRepository.Remove(selectedEntityId);
                }
            } else {
                rRepository.Remove(selectedEntityId);
            }
        }

        private void btnSave_Click(object sender, EventArgs e) {
            int selectedEntityId = Convert.ToInt32(dgvItems.SelectedRows[0].Cells[0].Value);

            if (cboItemTypeSelector.SelectedIndex == 3) {
                uRepository.Add(new User {
                    Id = selectedEntityId,
                    Name = tbName.Text,
                    Address = tbAddress.Text,
                    Zip = tbPostalCode.Text,
                    City = tbCity.Text,
                    ResearchAreaId = Convert.ToInt32(cboResearchAreas.SelectedValue)
                });

                dgvItems.DataSource = uRepository.GetAllAsDataTable(); ;
                _dh.EmptyFields();
            }
            else if (cboItemTypeSelector.SelectedIndex == 4) {

            }
            else if (cboItemTypeSelector.SelectedIndex == 5) {

                _dh.FishingAreasLayout();   // pitää kutsua erikseen, koska muuten layout särkyy
            }
            else if (cboItemTypeSelector.SelectedIndex == 6)
            {

                _dh.EmptyFields();
            }
            else
            {

                //dgvItems.DataSource = SelectFromResourcesById(cboItemTypeSelector.SelectedIndex + 1);

                // TODO: PÄIVITÄ DATAGRIDVIEW
            }
        }

        private void SwitchLayout(int id) {
            ClearAll();
            EmptyFields();

            switch (id) {
                case 0:
                    lblName.Text = "Kala:";
                    lblName.Visible = true;
                    tbName.Visible = true;

                    dgvItems.Columns[1].HeaderText = "Kala";
                    dgvItems.Columns[1].Visible = true;
                    break;
                case 1:
                    lblName.Text = "Pyydys:";
                    lblName.Visible = true;
                    tbName.Visible = true;

                    dgvItems.Columns[1].HeaderText = "Pyydys";
                    dgvItems.Columns[1].Visible = true;
                    break;
                case 2:
                    lblName.Text = "Haittatekijä:";
                    lblName.Visible = true;
                    tbName.Visible = true;

                    dgvItems.Columns[1].HeaderText = "Haittatekijä";
                    dgvItems.Columns[1].Visible = true;
                    break;
                case 3:
                    lblName.Text = "Nimi:";
                    lblName.Visible = true;
                    tbName.Visible = true;

                    lblAddress.Text = "Osoite:";
                    lblAddress.Visible = true;
                    tbAddress.Visible = true;

                    lblPostalCode.Text = "Postinumero:";
                    lblPostalCode.Visible = true;
                    tbPostalCode.Visible = true;

                    lblCity.Text = "Toimipaikka:";
                    lblCity.Visible = true;
                    tbCity.Visible = true;

                    lblResearchArea.Text = "Tutkimusalue:";
                    lblResearchArea.Visible = true;
                    cboResearchAreas.Visible = true;

                    dgvItems.Columns[1].HeaderText = "Nimi";
                    dgvItems.Columns[1].Visible = true;
                    dgvItems.Columns[2].HeaderText = "Osoite";
                    dgvItems.Columns[2].Visible = true;
                    dgvItems.Columns[3].HeaderText = "Postinumero";
                    dgvItems.Columns[3].Visible = true;
                    dgvItems.Columns[4].HeaderText = "Toimipaikka";
                    dgvItems.Columns[4].Visible = true;
                    dgvItems.Columns[5].HeaderText = "Tutkimusalue";
                    dgvItems.Columns[5].Visible = true;

                    // massalisäys-nappi näkyy ainoastaan kun käyttäjiä muokataan
                    btnAdd.Visible = true;
                    break;
                case 4:
                    lblName.Text = "Vesistö:";
                    lblName.Visible = true;
                    tbName.Visible = true;

                    dgvItems.Columns[1].HeaderText = "Vesistö";
                    dgvItems.Columns[1].Visible = true;
                    break;
                case 5:
                    lblName.Text = "Kalastusalue:";
                    lblName.Visible = true;
                    tbName.Visible = true;

                    // muutetaan cbon paikkaa
                    lblResearchArea.Location = new System.Drawing.Point(17, 113);
                    cboResearchAreas.Location = new System.Drawing.Point(17, 129);

                    lblResearchArea.Text = "Tutkimusalue:";
                    lblResearchArea.Visible = true;
                    cboResearchAreas.Visible = true;

                    dgvItems.Columns[1].HeaderText = "Kalastusalue";
                    dgvItems.Columns[1].Visible = true;
                    dgvItems.Columns[2].HeaderText = "Tutkimusalue";
                    dgvItems.Columns[2].Visible = true;
                    break;
                case 6:
                    lblName.Text = "Tutkimusalue:";
                    lblName.Visible = true;
                    tbName.Visible = true;

                    lblWaterSystems.Visible = true;
                    cboWaterSystems.Visible = true;

                    dgvItems.Columns[1].HeaderText = "Tutkimusalue";
                    dgvItems.Columns[1].Visible = true;

                    dgvItems.Columns[2].HeaderText = "Vesistö";
                    dgvItems.Columns[2].Visible = true;
                    break;
            }
        }

        private void ClearAll() {
            lblName.Visible = false;
            lblAddress.Visible = false;
            lblPostalCode.Visible = false;
            lblCity.Visible = false;
            lblResearchArea.Visible = false;
            tbName.Visible = false;
            tbAddress.Visible = false;
            tbPostalCode.Visible = false;
            tbCity.Visible = false;
            cboResearchAreas.Visible = false;
            btnAdd.Visible = false;
            cboWaterSystems.Visible = false;
            lblWaterSystems.Visible = false;

            foreach (DataGridViewColumn col in dgvItems.Columns)
            {
                col.Visible = false;
            }
        }

        private void EmptyFields() {
            tbName.Text = "";
            tbAddress.Text = "";
            tbPostalCode.Text = "";
            tbCity.Text = "";
            cboResearchAreas.Text = "";
            cboWaterSystems.Text = "";

            // palautetaan researchArean paikka normaaliksi
            lblResearchArea.Location = new System.Drawing.Point(17, 265);
            cboResearchAreas.Location = new System.Drawing.Point(17, 282);
        }

        private String SHA1(String plaintext)
        {
            try
            {
                System.Security.Cryptography.SHA1 sha1 = System.Security.Cryptography.SHA1.Create();
                byte[] bytes = Encoding.ASCII.GetBytes(plaintext);
                byte[] hash = sha1.ComputeHash(bytes);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hash.Length; i++)
                    sb.Append(hash[i].ToString("x2"));

                return sb.ToString();
            }
            catch
            {
                MessageBox.Show("Salasanan SHA-hashays epäonnistui");
                return null;
            }
        }
    }
}
