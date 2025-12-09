using Tyuiu.KosyakovDS.Sprint6.Task5.V14.Lib;

namespace Tyuiu.KosyakovDS.Sprint6.Task5.V14
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        string path = @"C:\DataSprint6\InPutDataFileTask5V14.txt";

        private void buttonDone_KDS_Click(object sender, EventArgs e)
        {
            dataGridViewNums_KDS.ColumnCount = 2;
            dataGridViewNums_KDS.Columns[0].Width = 20;
            dataGridViewNums_KDS.Columns[1].Width = 50;

            this.chartDiag_KDS.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartDiag_KDS.ChartAreas[0].AxisY.Title = "Ось Y";

            chartDiag_KDS.Series[0].Points.Clear();

            double[] numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewNums_KDS.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartDiag_KDS.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void buttonOpenFile_KDS_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_KDS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ИИПб-25-1 Косяков Дмитрий Сергеевич", "Сообщение",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
