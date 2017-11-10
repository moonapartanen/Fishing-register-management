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
//  - KORJAA WARNING-TEKSTIT
//  - TESTAA POISTON TOIMIVUUS

namespace Kalavale {
    public partial class ManageDbControl : UserControl {
		string[] _dbItemTypes = { "Kalat", "Pyydykset", "Haittatekijät", "Käyttäjät", "Vesistöt", "Kalastusalueet", "Tutkimusalueet" };

        FishingAreaRepository faRepository = new FishingAreaRepository();
        ResearchAreaRepository raRepository = new ResearchAreaRepository();
        ResourceRepository rRepository = new ResourceRepository();
        UserRepository uRepository = new UserRepository();
        WaterSystemRepository wsRepository = new WaterSystemRepository();

        // täytettävät kentät ovat omissa paneeleissaan päällekkäin alustettu näkymättömiksi
        // itemTypen vaihtuessa näytetään/piilotetaan oikea layout
        Panel currentLayout;
        bool editMode;
		
        public ManageDbControl() {
            InitializeComponent();
        }

        private void ManageDbControl1_Load(object sender, EventArgs e) {
            cboItemTypeSelector.DataSource = _dbItemTypes;
            SetEditMode(false);
        }

        private void cboItemTypeSelector_SelectedIndexChanged(object sender, EventArgs e) {
            int type = cboItemTypeSelector.SelectedIndex;
            ClearLayoutFields();

            if(currentLayout != null) {
                currentLayout.Visible = false;
                currentLayout = null;
            }

            btnAdd.Enabled = false;

            switch (type) {
                case 0:
                case 1:
                case 2:
                    dgvItems.DataSource = rRepository.GetByType(type + 1);
                    break;
                case 3:
                    dgvItems.DataSource = uRepository.GetAll();
                    cboUserResearchArea.DataSource = raRepository.GetAll();
                    pnUserLayout.Visible = true;
                    btnAdd.Enabled = true;
                    currentLayout = pnUserLayout;
                    break;
                case 4:
                    dgvItems.DataSource = wsRepository.GetAll();
                    break;
                case 5:
                    dgvItems.DataSource = faRepository.GetAll();
                    cboFishingAreaResearchArea.DataSource = raRepository.GetAll();
                    pnFishingAreaLayout.Visible = true;
                    currentLayout = pnFishingAreaLayout;
                    break;
                case 6:
                    dgvItems.DataSource = raRepository.GetAll();
                    cboResearchAreaWaterSystem.DataSource = wsRepository.GetAll();
                    pnResearchAreaLayout.Visible = true;
                    currentLayout = pnResearchAreaLayout;
                    break;
            }
        }

        // keskeytetään editmode ja palataan alkutilaan
        private void btnAbort_Click(object sender, EventArgs e) {
            ClearLayoutFields();
            SetEditMode(false);
        }

        // TODO: parempi validaatio
        // kantaan tallennus ja update samassa sql tasolla
        private void btnSave_Click(object sender, EventArgs e) {
            int selectedItemType = cboItemTypeSelector.SelectedIndex;
            EntityBase selectedItem = (EntityBase)dgvItems.SelectedRows[0].DataBoundItem;

            if (ValidateFields()) {
                switch (selectedItemType) {
                    case 0:
                    case 1:
                    case 2:
                        rRepository.Add(new Resource {
                            Id = editMode ? selectedItem.Id : default(int?),    //editmodessa id valitusta rivistä, muuten null
                            Name = tbItemName.Text,
                            Type = cboItemTypeSelector.SelectedIndex + 1
                        });
                        break;
                    case 3:
                        uRepository.Add(new User {
                            Id = editMode ? selectedItem.Id : default(int?),
                            Name = tbItemName.Text,
                            Address = tbUserAddress.Text,
                            Zip = tbUserZip.Text,
                            City = tbUserCity.Text,
                            ResearchAreaId = (int)cboUserResearchArea.SelectedValue,
                            Key = tbUserKey.Text
                        });
                        break;
                    case 4:
                        wsRepository.Add(new WaterSystem {
                            Id = editMode ? selectedItem.Id : default(int?),
                            Name = tbItemName.Text
                        });
                        break;
                    case 5:
                        faRepository.Add(new FishingArea {
                            Id = editMode ? selectedItem.Id : default(int?),
                            Name = tbItemName.Text,
                            ResearchAreaId = (int)cboFishingAreaResearchArea.SelectedValue
                        });
                        break;
                    case 6:
                        raRepository.Add(new ResearchArea {
                            Id = editMode ? selectedItem.Id : default(int?),
                            Name = tbItemName.Text,
                            WaterSystemId = (int)cboResearchAreaWaterSystem.SelectedValue
                        });
                        break;
                    default:
                        break;
                }

                ClearLayoutFields();
                SetEditMode(false);
                cboItemTypeSelector_SelectedIndexChanged(null, null);
            } else {
                MessageBox.Show("Täytä kaikki kentät!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            int selectedItemType = cboItemTypeSelector.SelectedIndex;
            int selectedItemId = (int)dgvItems.SelectedRows[0].Cells["Id"].Value;

            // TODO: TÄRKEÄ!!
            // poistot cascadee koko kannan laajuudelta jos esim. vaikka vesistö tai tutkimusalue poistetaan :D
            // pitää määritellä esto joko sovelluksen tai kannan tasolla

            switch (selectedItemType) {
                case 0:
                case 1:
                case 2:
                    rRepository.Remove(selectedItemId);
                    break;
                case 3:
                    uRepository.Remove(selectedItemId);
                    break;
                case 4:
                    wsRepository.Remove(selectedItemId);
                    break;
                case 5:
                    faRepository.Remove(selectedItemId);
                    break;
                case 6:
                    raRepository.Remove(selectedItemId);
                    break;
            }

            cboItemTypeSelector_SelectedIndexChanged(null, null);
        }

        // objektien sidonta vastaaviin kenttiin
        private void cbEditItem_Click(object sender, EventArgs e) {
            int selectedItemType = cboItemTypeSelector.SelectedIndex;
            object selectedItem = dgvItems.SelectedRows[0].DataBoundItem;

            ClearLayoutFields();
            SetEditMode(!editMode);

            switch (selectedItemType) {
                case 0:
                case 1:
                case 2:
                    Resource r = (Resource)selectedItem;
                    tbItemName.Text = r.Name;
                    break;
                case 3:
                    User u = (User)selectedItem;
                    tbItemName.Text = u.Name;
                    tbUserAddress.Text = u.Address;
                    tbUserCity.Text = u.City;
                    tbUserKey.Text = u.Key;
                    tbUserZip.Text = u.Zip;
                    cboUserResearchArea.SelectedValue = u.ResearchAreaId;
                    break;
                case 4:
                    WaterSystem ws = (WaterSystem)selectedItem;
                    tbItemName.Text = ws.Name;
                    break;
                case 5:
                    FishingArea fa = (FishingArea)selectedItem;
                    tbItemName.Text = fa.Name;
                    break;
                case 6:
                    ResearchArea ra = (ResearchArea)selectedItem;
                    tbItemName.Text = ra.Name;
                    break;
            }
        }

        // tämän voisi automatisoida, vaikka onkin hauskaa generoida itse
        private void btnGenerateKey_Click(object sender, EventArgs e) {
            tbUserKey.Text = GenerateId(10);
        }

        // tällä hetkellä kaikkiin kenttiin vaaditaan jotain
        private bool ValidateFields() {
            if (currentLayout != null) {
                foreach (Control c in currentLayout.Controls)
                    if (c.Text.Length < 1) return false;
            }

            return tbItemName.Text.Length < 1 ? false : true;
        }

        // editmode = false; tietyt kontrollit disabloidaan editoinnin ajaksi
        private void SetEditMode(bool mode) {
            editMode = mode;
            cbEditItem.Checked = mode;
            btnDelete.Enabled = !mode;
            cboItemTypeSelector.Enabled = !mode;
            dgvItems.Enabled = !mode;
        }

        // tyhjentää täytettävät kentät
        private void ClearLayoutFields() {
            Action<ControlCollection> ClearTexts = null;

            ClearTexts = (controls) => {
                foreach (Control control in controls)
                    if (control is TextBox)
                        control.Text = "";
                    else
                        ClearTexts(control.Controls);
            };

            ClearTexts(Controls);
        }

        // generoi halutun pituisen "uniikin" id:n esim; z5k7e2o4, l35d8hd3 jne...
        // vokaalit voisi ottaa poikkeen tai saattaa tulla tuhmia sanoja :D
        // jos halutaan kaikille käyttäjille uniikki, tarkastetaan kantaan lisätessä
        private string GenerateId(int length) {
            char[] chars = "abcdefghijklmnopqrstuvwxyz0123456789".ToCharArray();

            StringBuilder sb = new StringBuilder(length);
            Random rnd = new Random();

            for (int i = 0; i < length; i++)
                sb.Append(chars[rnd.Next(36)]);

            return sb.ToString();
        }
    }
}
