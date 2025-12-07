using System.Runtime.CompilerServices;
using Tyuiu.KosyakovDS.Sprint6.Task1.V23.Lib;

namespace Tyuiu.KosyakovDS.Sprint6.Task1.V23
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

                string strLine;

                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startValue, stopValue);
                textBoxResult_KDS.Text = "";
                textBoxResult_KDS.AppendText("+----------+-----------+" + Environment.NewLine);
                textBoxResult_KDS.AppendText("|     X    |    f(x)   |" + Environment.NewLine);
                textBoxResult_KDS.AppendText("+----------+-----------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}     |  {1,5:f2}   |", startValue, valueArray[i]);
                    textBoxResult_KDS.AppendText(strLine + Environment.NewLine);
                    startValue++;
                }
                textBoxResult_KDS.AppendText("+----------+-----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void buttonHelp_KDS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент групы ИИПб-25-1 Косяков Дмитрий Сергеевич");
        }
    }
}
