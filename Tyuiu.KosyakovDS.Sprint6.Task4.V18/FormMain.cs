using Tyuiu.KosyakovDS.Sprint6.Task4.V18.Lib;

namespace Tyuiu.KosyakovDS.Sprint6.Task4.V18
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonDone_KDS_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_KDS.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_KDS.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                chartFunction_KDS.ChartAreas[0].AxisX.Title = "Ось X";
                chartFunction_KDS.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxResult_KDS.Text = "";
                chartFunction_KDS.Series[0].Points.Clear();

                for (int i = 0; i < len; i++)
                {
                    chartFunction_KDS.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxResult_KDS.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_KDS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы ИИПб-25-1 Косяков Дмитрий Сергеевич");
        }

        private void buttonSave_KDS_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask4.txt");
                File.WriteAllText(path, textBoxResult_KDS.Text);

                DialogResult dialogResult = MessageBox.Show($"Файл {path} сохранен успешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path; 
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
