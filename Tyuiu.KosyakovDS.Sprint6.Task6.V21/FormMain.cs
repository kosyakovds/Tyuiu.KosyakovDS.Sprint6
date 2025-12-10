using Tyuiu.KosyakovDS.Sprint6.Task6.V21.Lib;

namespace Tyuiu.KosyakovDS.Sprint6.Task6.V21
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        string openFilePath;

        DataService ds = new DataService();
        private void buttonDone_KDS_Click(object sender, EventArgs e)
        {
            textBoxResult_KDS.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonOpenFile_KDS_Click(object sender, EventArgs e)
        {
            openFileDialogTask_KDS.ShowDialog();
            openFilePath = openFileDialogTask_KDS.FileName;
            textBoxLoadFromFile_KDS.Text = File.ReadAllText(openFilePath);
            groupBoxOutPut_KDS.Text = groupBoxOutPut_KDS.Text + " " + openFileDialogTask_KDS.FileName;
            buttonDone_KDS.Enabled = true;
        }

        private void buttonHelp_KDS_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
