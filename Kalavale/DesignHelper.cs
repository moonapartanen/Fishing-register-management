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

        public void SelectAllLayoutRefs(ref Label lblName, ref Label lblAddress, ref Label lblPostalCode, ref Label lblCity, ref Label lblResearchArea, ref TextBox tbName, ref TextBox tbAddress, ref TextBox tbPostalCode, ref TextBox tbCity, ref ComboBox cboResearchArea, ref DataGridView dgvItems)
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
        }

        public void FishLayout()
        {
            lblName.Text = "Kala:";
            lblName.Visible = true;
            tbName.Visible = true;
        }

        public void MethodsLayout()
        {
            lblName.Text = "Pyydys:";
            lblName.Visible = true;
            tbName.Visible = true;
        }

        public void AdverseFactorsLayout()
        {
            lblName.Text = "Haittatekijä:";
            lblName.Visible = true;
            tbName.Visible = true;
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

            lblResearchArea.Text = "Kalastusalue:";
            lblResearchArea.Visible = true;
            cboResearchArea.Visible = true;
        }

        public void WaterSystemsLayout()
        {
            lblName.Text = "Vesistö:";
            lblName.Visible = true;
            tbName.Visible = true;

            // Tähän kuvaus jos tarvitsee olla
        }

        public void FishingAreasLayout()
        {
            lblName.Text = "Nimi:";
            lblName.Visible = true;
            tbName.Visible = true;

            lblAddress.Text = "Vesistö:";
            lblAddress.Visible = true;
            tbAddress.Visible = true;
        }

    }
}
