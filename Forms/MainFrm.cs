using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;


namespace ImportFromExcel
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void CloseBtn_PICBX_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            Import_BTN.Enabled = false;
            CloseBtn_PICBX.Image = Properties.Resources.Close_20;
        }

        private void Import_BTN_Click(object sender, EventArgs e)
        {

            int xlRow;
            int i=0;

            Microsoft.Office.Interop.Excel.Application xlApp;
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorksheet;
            Microsoft.Office.Interop.Excel.Range xlRange;

            xlApp = new Microsoft.Office.Interop.Excel.Application();
            xlWorkbook = xlApp.Workbooks.Open(FileName_LBL.Text);
            xlWorksheet = (Worksheet)xlWorkbook.Worksheets["Sheet1"];
            xlRange = xlWorksheet.UsedRange;


            for (xlRow = 1; xlRow <= xlRange.Rows.Count; xlRow++)
            {
                i++;
                Data_GRD.Rows.Add(i, xlRange.Cells[xlRow, 1].ToString());
            }


        }

        private void FileSelect_BTN_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofp = new OpenFileDialog())
            {
                ofp.InitialDirectory = System.Windows.Forms.Application.StartupPath;
                ofp.RestoreDirectory = true;
                ofp.Filter = "Excel Files | *.xlsx;*.xls;*.xlm";
                ofp.Title = "Choose the file to import";
                if (ofp.ShowDialog() == DialogResult.OK)
                {
                    FileName_LBL.Text = ofp.FileName;
                    Import_BTN.Enabled = true;
                }
            }
        }
    }
}
