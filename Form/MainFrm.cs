using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.IO;


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
            this.CenterToScreen();
            Import_BTN.Enabled = false;
            Export_BTN.Enabled = false;
            CloseBtn_PICBX.Image = Properties.Resources.Close_20;
            VersionInfo_LBL.Text = "Version: "+ Application.ProductVersion;

        }

        private void Import_BTN_Click(object sender, EventArgs e)
        {

            if (FileName_LBL.Text != "")
            {
                // Clears datagrideview before each import
                Data_GRD.Rows.Clear();


                // Creating variables to open Excel files
                Microsoft.Office.Interop.Excel.Application xlApp;
                Microsoft.Office.Interop.Excel.Workbook xlWorkbook;
                Microsoft.Office.Interop.Excel.Worksheet xlWorksheet;
                Microsoft.Office.Interop.Excel.Range xlRange;

                try
                {
                    // Assigning file attirbutes to its coresponding variable
                    xlApp = new Microsoft.Office.Interop.Excel.Application();
                    xlWorkbook = xlApp.Workbooks.Open(FileName_LBL.Text);
                    xlWorksheet = xlWorkbook.Worksheets["Sheet1"];
                    xlRange = xlWorksheet.UsedRange;

                    // Iteration through the file Rows and Columns 
                    for (int xlRow = 1; xlRow <= xlRange.Rows.Count; xlRow++)
                    {

                        // Example : => 12 columns 
                        Data_GRD.Rows.Add(xlRange.Cells[xlRow, 1].Text, xlRange.Cells[xlRow, 2].Text,
                            xlRange.Cells[xlRow, 3].Text, xlRange.Cells[xlRow, 4].Text, xlRange.Cells[xlRow, 5].Text,
                            xlRange.Cells[xlRow, 6].Text, xlRange.Cells[xlRow, 7].Text, xlRange.Cells[xlRow, 8].Text,
                            xlRange.Cells[xlRow, 9].Text, xlRange.Cells[xlRow, 10].Text, xlRange.Cells[xlRow, 11].Text,
                            xlRange.Cells[xlRow, 12].Text);
                    }
                    // MUST DO THE FOLLOWING TO CLOSE THE EXCEL APPLICATION AND PREVENT BLUESCREEN!
                    xlWorkbook.Close();
                    xlApp.Quit();

                    Export_BTN.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Unexpected error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void FileSelect_BTN_Click(object sender, EventArgs e)
        {

            // File Dialog to find and select excel files
            using (OpenFileDialog ofp = new OpenFileDialog())
            {
                ofp.RestoreDirectory = false;
                ofp.Filter = "Excel Files | *.xlsx;*.xls;*.xlm";
                ofp.Title = "Choose the file to import";
                if (ofp.ShowDialog() == DialogResult.OK)
                {
                    FileName_LBL.Text = ofp.FileName;
                    Import_BTN.Enabled = true;
                    info_LBL.Visible = true;
                }
            }
        }

        private void Export_BTN_Click(object sender, EventArgs e)
        {
            string exportPath;

            // Creating filename using the selected excel file and extractiing the filename without extention
            // Example : => File extention will be .examp
            exportPath = Environment.CurrentDirectory + @"\Export\" + Path.GetFileNameWithoutExtension(FileName_LBL.Text) +".exmp";


            // Checking for the directory to store the file
            if (!Directory.Exists(Environment.CurrentDirectory + @"\Export\"))
                Directory.CreateDirectory(Environment.CurrentDirectory + @"\Export\");

            try
            {
                // Copying datagridview items into an array of type byte[] with the size of (Rows * Column)
                // Example : => Array size is 144
                byte[] map_Temparray = new byte[144];


                // Procedure to add datagridview items into the array
                for (int i = 0; i < 12; i++)
                    for (int j = 0; j < 12; j++)
                        if (Data_GRD.Rows[i].Cells[j].Value != null)
                            map_Temparray[i + (j * 12)] = (Byte.Parse(Data_GRD.Rows[i].Cells[j].Value.ToString()));


                // Creating and storing the Exported file
                using (FileStream fstr = new FileStream(exportPath, FileMode.Create, FileAccess.Write))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fstr, map_Temparray);

                    // MUST CLOSE THE FILESTREAM IN ORDER TO PROPERLY SAVE THE FILE
                    fstr.Close();
                }
                MessageBox.Show("Data Exported", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Unexpected error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
