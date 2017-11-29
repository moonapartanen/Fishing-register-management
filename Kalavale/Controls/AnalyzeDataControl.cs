using System;
using System.Windows.Forms;
using Kalavale.Forms;
using Kalavale.Repositories;
using Kalavale.Entities;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;

namespace Kalavale.Controls
{  
    public partial class AnalyzeDataControl : UserControl
    {
        ResearchAreaRepository _raRepository = new ResearchAreaRepository();
        SurveyRepository _sRepository = new SurveyRepository();

        Excel.Application excel;

        public AnalyzeDataControl()
        {
            InitializeComponent();
        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            ResearchArea ra = cboResearchArea.SelectedItem as ResearchArea;
            Survey s = cboSurvey.SelectedItem as Survey;
            double groupSize = Double.Parse(txtGroupSize.Text);
            ToExcel(ra, s, groupSize);
        }

        private void AnalyzeDataControl_Load(object sender, EventArgs e)
        {
            cboResearchArea.DataSource = _raRepository.GetAll();
        }

        private void cboResearchArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResearchArea ra = cboResearchArea.SelectedItem as ResearchArea;
            cboSurvey.DataSource = _sRepository.GetByResearchArea(ra);
        }

        private void ToExcel(ResearchArea ra, Survey s, double groupSize)
        {

            excel = new Excel.Application();

            if (excel == null)
            {
                MessageBox.Show("Excel-ohjelmaa ei ole asennettu!");
            }
            else
            {
                Excel.Workbook xlWorkBook;
                Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;

                xlWorkBook = excel.Workbooks.Add(misValue);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                xlWorkSheet.Cells[1, 1] = "ID";
                xlWorkSheet.Cells[1, 2] = "Name";
                xlWorkSheet.Cells[2, 1] = "1";
                xlWorkSheet.Cells[2, 2] = "One";
                xlWorkSheet.Cells[3, 1] = "2";
                xlWorkSheet.Cells[3, 2] = "Two";



                xlWorkBook.SaveAs(saveFileDialog1.ShowDialog());
                // TODO: TÄHÄN TIEDOSTONIMEN JA PATHIN TALLENNUS
                xlWorkBook.Close(true);

                Marshal.ReleaseComObject(xlWorkSheet);
                Marshal.ReleaseComObject(xlWorkBook);
                Marshal.ReleaseComObject(excel);

                MessageBox.Show("Excel file created");

                // TO DO: EXCEL PITÄÄ SAADA SULKEUTUMAAN JOLLAIN KONSTILLA
            }        
        }



    }
}
