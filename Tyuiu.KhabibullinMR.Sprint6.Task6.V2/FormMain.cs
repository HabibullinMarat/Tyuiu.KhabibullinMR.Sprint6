using Tyuiu.KhabibullinMR.Sprint6.Task6.V2.Lib;

namespace Tyuiu.KhabibullinMR.Sprint6.Task6.V2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        string openFilePath;
        DataService ds = new DataService();

        public void buttonDone_Click(object sender, EventArgs e)
        {
            textBoxOut_KMR.Text = ds.CollectTextFromFile(openFilePath);
        }

        public void buttonHelp_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        public void buttonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialogTask_KMR.ShowDialog();
            openFilePath = openFileDialogTask_KMR.FileName;
            textBoxIn_KMR.Text = File.ReadAllText(openFilePath);
            groupBoxCondition_KMR.Text = groupBoxCondition_KMR.Text + openFileDialogTask_KMR.FileName;
            buttonDone_KMR.Enabled = true;
        }
    }
}
