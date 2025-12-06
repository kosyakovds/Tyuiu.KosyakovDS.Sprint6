using Tyuiu.KosyakovDS.Sprint6.Task0.V26.Lib;

namespace Tyuiu.KosyakovDS.Sprint6.Task0.V26
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDone_KDS_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult_KDS.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarX_KDS.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", " Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxVarX_KDS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void buttonHelp_KDS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы ИИПб-25-1 Косяков Дмитрий Сергеевич", "Сообщение", MessageBoxButtons.OK);
        }
    }
}