﻿using System;
using System.Text;
using System.Windows.Forms;
using Kalavale.Repositories;
using Kalavale.Entities;

//  TO DO:
//  - KORJAA WARNING-TEKSTIT
//  - TESTAA POISTON TOIMIVUUS

namespace Kalavale.Controls {
    public partial class ManageDbControl : UserControl {
		string[] dbItemTypes = { "Kalat", "Pyydykset", "Haittatekijät", "Käyttäjät", "Vesistöt", "Kalastusalueet", "Tutkimusalueet" };

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
            cboItemTypeSelector.DataSource = dbItemTypes;
            SetEditMode(false);
        }

        private void cboItemTypeSelector_SelectedIndexChanged(object sender, EventArgs e) {
            int type = cboItemTypeSelector.SelectedIndex;
            btnAdd.Enabled = false;

            if (currentLayout != null) {
                FormHelper.ClearFields(currentLayout);
                FormHelper.ClearErrors(currentLayout, errorProvider);
                currentLayout.Visible = false;
                currentLayout = null;
            }

            switch (type) {
                case 0:
                case 1:
                case 2:
                    dgvItems.DataSource = rRepository.GetByType(type + 1);
                    pnResourceLayout.Visible = true;
                    currentLayout = pnResourceLayout;
                    break;
                case 3:
                    dgvItems.DataSource = uRepository.GetAll();
                    cboUserResearchArea.DataSource = raRepository.GetAll();
                    pnUserLayout.Visible = true;
                    currentLayout = pnUserLayout;
                    btnAdd.Enabled = true;
                    break;
                case 4:
                    dgvItems.DataSource = wsRepository.GetAll();
                    pnResourceLayout.Visible = true;
                    currentLayout = pnResourceLayout;
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
            FormHelper.ClearFields(currentLayout);
            FormHelper.ClearErrors(currentLayout, errorProvider);
            SetEditMode(false);
        }

        // kantaan tallennus ja update samassa sql tasolla
        private void btnSave_Click(object sender, EventArgs e) {
            int selectedItemType = cboItemTypeSelector.SelectedIndex;
            EntityBase selectedItem = (EntityBase)dgvItems.SelectedRows[0].DataBoundItem;
            FormHelper.ClearErrors(currentLayout, errorProvider);

            if (FormHelper.ValidateTextFields(currentLayout, errorProvider)) {
                switch (selectedItemType) {
                    case 0:
                    case 1:
                    case 2:
                        rRepository.Add(new Resource {
                            Id = editMode ? selectedItem.Id : default(int?),    //editmodessa id valitusta rivistä, muuten null
                            Name = tbResourceName.Text,
                            Type = cboItemTypeSelector.SelectedIndex + 1
                        });
                        break;
                    case 3:
                        uRepository.Add(new User {
                            Id = editMode ? selectedItem.Id : default(int?),
                            Name = tbUserName.Text,
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
                            Name = tbResourceName.Text
                        });
                        break;
                    case 5:
                        faRepository.Add(new FishingArea {
                            Id = editMode ? selectedItem.Id : default(int?),
                            Name = tbFishingAreaName.Text,
                            ResearchAreaId = (int)cboFishingAreaResearchArea.SelectedValue
                        });
                        break;
                    case 6:
                        raRepository.Add(new ResearchArea {
                            Id = editMode ? selectedItem.Id : default(int?),
                            Name = tbResearchAreaName.Text,
                            WaterSystemId = (int)cboResearchAreaWaterSystem.SelectedValue
                        });
                        break;
                    default:
                        break;
                }

                FormHelper.ClearFields(currentLayout);
                SetEditMode(false);
                cboItemTypeSelector_SelectedIndexChanged(null, null);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            int selectedItemType = cboItemTypeSelector.SelectedIndex;
            int selectedItemId = (int)dgvItems.SelectedRows[0].Cells["Id"].Value;

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

            FormHelper.ClearFields(currentLayout);
            SetEditMode(!editMode);

            switch (selectedItemType) {
                case 0:
                case 1:
                case 2:
                    Resource r = (Resource)selectedItem;
                    tbResourceName.Text = r.Name;
                    break;
                case 3:
                    User u = (User)selectedItem;
                    tbUserName.Text = u.Name;
                    tbUserAddress.Text = u.Address;
                    tbUserCity.Text = u.City;
                    tbUserKey.Text = u.Key;
                    tbUserZip.Text = u.Zip;
                    cboUserResearchArea.SelectedValue = u.ResearchAreaId;
                    break;
                case 4:
                    WaterSystem ws = (WaterSystem)selectedItem;
                    tbResourceName.Text = ws.Name;
                    break;
                case 5:
                    FishingArea fa = (FishingArea)selectedItem;
                    tbFishingAreaName.Text = fa.Name;
                    cboFishingAreaResearchArea.SelectedValue = fa.ResearchAreaId;
                    break;
                case 6:
                    ResearchArea ra = (ResearchArea)selectedItem;
                    tbResearchAreaName.Text = ra.Name;
                    cboResearchAreaWaterSystem.SelectedValue = ra.WaterSystemId;
                    break;
            }
        }

        // tämän voisi automatisoida, vaikka onkin hauskaa generoida itse
        private void btnGenerateKey_Click(object sender, EventArgs e) {
            tbUserKey.Text = GenerateId(10);
        }

        // editmode = true; tietyt kontrollit disabloidaan editoinnin ajaksi
        private void SetEditMode(bool mode) {
            editMode = mode;
            cbEditItem.Checked = mode;
            cbEditItem.Enabled = !mode;
            btnDelete.Enabled = !mode;
            cboItemTypeSelector.Enabled = !mode;
            dgvItems.Enabled = !mode;
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

        private void btnAdd_Click(object sender, EventArgs e) {
            if (dlgChooseFile.ShowDialog() == DialogResult.OK) {
                DialogResult dr = MessageBox.Show("Kaikki tiedoston sisältämät henkilörivit lisätään tietokantaan.\n\nHaluatko jatkaa?",
                    "Huomio", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes) {
                    using (System.IO.StreamReader sr = new System.IO.StreamReader(dlgChooseFile.FileName)) {
                        string line = "";

                        try {
                            while ((line = sr.ReadLine()) != null) {
                                string[] userRow = line.Split(';');
                                User u = new User {
                                    Name = userRow[0],
                                    Address = userRow[1],
                                    Zip = userRow[2],
                                    City = userRow[3],
                                    ResearchAreaId = Convert.ToInt32(userRow[4]),
                                    Key = GenerateId(10)
                                };

                                uRepository.Add(u);
                            }
                        } catch (Exception ex) {
                            MessageBox.Show("Tiedoston formaatti virheellinen.\n Virheellinen rivi: " + line,
                                "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }               
            }
        }
    }
}
