using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalavale
{
    class DesignHelper
    {
        public static Label lblName;
        public static Label lblAddress;
        public static Label lblPostalCode;
        public static Label lblCity;
        public static Label lblResearchArea;
        public static TextBox tbName;
        public static TextBox tbAddress;
        public static TextBox tbPostalCode;
        public static TextBox tbCity;
        public static ComboBox cboResearchArea;
        public static DataGridView dgvItems;
        public static Button btnAdd;

        public void SelectAllLayoutRefs(ref Label lblName, ref Label lblAddress, ref Label lblPostalCode, ref Label lblCity, 
                                        ref Label lblResearchArea, ref TextBox tbName, ref TextBox tbAddress, ref TextBox tbPostalCode,
                                        ref TextBox tbCity, ref ComboBox cboResearchArea, ref DataGridView dgvItems, ref Button btnAdd)
        {
            DesignHelper.lblName = lblName;
            DesignHelper.lblAddress = lblAddress;
            DesignHelper.lblPostalCode = lblPostalCode;
            DesignHelper.lblCity = lblCity;
            DesignHelper.lblResearchArea = lblResearchArea;
            DesignHelper.tbName = tbName;
            DesignHelper.tbAddress = tbAddress;
            DesignHelper.tbPostalCode = tbPostalCode;
            DesignHelper.tbCity = tbCity;
            DesignHelper.cboResearchArea = cboResearchArea;
            DesignHelper.dgvItems = dgvItems;
            DesignHelper.btnAdd = btnAdd;
        }

        public void ClearAll()
        {
            lblName.Visible = false;
            lblAddress.Visible = false;
            lblPostalCode.Visible = false;
            lblCity.Visible = false;
            lblResearchArea.Visible = false;
            tbName.Visible = false;
            tbAddress.Visible = false;
            tbPostalCode.Visible = false;
            tbCity.Visible = false;
            cboResearchArea.Visible = false;
            btnAdd.Visible = false;

            foreach (DataGridViewColumn col in dgvItems.Columns)
            {
                col.Visible = false;
            }
        }

        public void FishLayout()
        {
            lblName.Text = "Kala:";
            lblName.Visible = true;
            tbName.Visible = true;

            dgvItems.Columns[1].HeaderText = "Kala";
            dgvItems.Columns[1].Visible = true;
        }

        public void MethodsLayout()
        {
            lblName.Text = "Pyydys:";
            lblName.Visible = true;
            tbName.Visible = true;

            dgvItems.Columns[1].HeaderText = "Pyydys";
            dgvItems.Columns[1].Visible = true;
        }

        public void AdverseFactorsLayout()
        {
            lblName.Text = "Haittatekijä:";
            lblName.Visible = true;
            tbName.Visible = true;

            dgvItems.Columns[1].HeaderText = "Haittatekijä";
            dgvItems.Columns[1].Visible = true;
        }

        public void UsersLayout()
        {
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
            cboResearchArea.Visible = true;

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
        }

        public void WaterSystemsLayout()
        {
            lblName.Text = "Vesistö:";
            lblName.Visible = true;
            tbName.Visible = true;

            dgvItems.Columns[1].HeaderText = "Vesistö";
            dgvItems.Columns[1].Visible = true;
        }

        public void FishingAreasLayout()
        {
            lblName.Text = "Kalastusalue:";
            lblName.Visible = true;
            tbName.Visible = true;

            // muutetaan cbon paikkaa
            lblResearchArea.Location = new System.Drawing.Point(17, 113);
            cboResearchArea.Location = new System.Drawing.Point(17, 129);

            lblResearchArea.Text = "Tutkimusalue:";
            lblResearchArea.Visible = true;
            cboResearchArea.Visible = true;

            dgvItems.Columns[1].HeaderText = "Kalastusalue";
            dgvItems.Columns[1].Visible = true;
            dgvItems.Columns[2].HeaderText = "Tutkimusalue";
            dgvItems.Columns[2].Visible = true;
        }

        public void ResearchAreasLayout()
        {
            lblName.Text = "Tutkimusalue:";
            lblName.Visible = true;
            tbName.Visible = true;

            dgvItems.Columns[1].HeaderText = "Tutkimusalue";
            dgvItems.Columns[1].Visible = true;
        }

        public void EmptyFields()
        {
            tbName.Text = "";
            tbAddress.Text = "";
            tbPostalCode.Text = "";
            tbCity.Text = "";
            cboResearchArea.Text = "";

            // palautetaan researchArean paikka normaaliksi
            lblResearchArea.Location = new System.Drawing.Point(17, 265);
            cboResearchArea.Location = new System.Drawing.Point(17, 282);
        }
    }
}
