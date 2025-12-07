using System.Runtime.CompilerServices;
using Tyuiu.KosyakovDS.Sprint6.Task2.V13.Lib;

namespace Tyuiu.KosyakovDS.Sprint6.Task2.V13
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
                int startValue = Convert.ToInt32(textBoxStartValue_KDS.Text);
                int stopValue = Convert.ToInt32(textBoxStopValue_KDS.Text);

                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startValue, stopValue);

                this.chartFunction_KDS.Titles.Add("График функции");

                this.chartFunction_KDS.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_KDS.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i < len; i++)
                {
                    this.dataGridViewFunction_KDS.Rows.Add(Convert.ToString(startValue), Convert.ToString(valueArray[i]));

                    this.chartFunction_KDS.Series[0].Points.AddXY(startValue, valueArray[i]);

                    startValue++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void buttonHelp_KDS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент групы ИИПб-25-1 Косяков Дмитрий Сергеевич");
        }

        private void chartFunction_Click(object sender, EventArgs e)
        {

        }

        private void buttonDone_KDS_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_KDS.BackColor = Color.Red;
        }

        private void buttonDone_KDS_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_KDS.BackColor = Color.Green;
        }
    }
}
