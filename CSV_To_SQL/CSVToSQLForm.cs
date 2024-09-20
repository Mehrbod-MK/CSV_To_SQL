namespace CSV_To_SQL
{
    public partial class CSVToSQLForm : Form
    {
        public CSVToSQLForm()
        {
            InitializeComponent();
        }

        private void buttonLoadCSV_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialogCSV = new OpenFileDialog()
            {
                AddExtension = true,
                AutoUpgradeEnabled = true,
                CheckFileExists = true,
                CheckPathExists = true,
                Filter = "CSV Files|*.csv",
                Multiselect = false,
                SupportMultiDottedExtensions = true,
                ValidateNames = true,
                Title = "Please choose input CSV file:"
            };

            if(openFileDialogCSV.ShowDialog() == DialogResult.OK)
            {
                textBoxCSVFilePath.Text = openFileDialogCSV.FileName;
            }
        }
    }
}
