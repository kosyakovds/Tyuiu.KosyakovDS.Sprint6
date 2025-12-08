using Tyuiu.KosyakovDS.Sprint6.Task3.V9.Lib;

namespace Tyuiu.KosyakovDS.Sprint6.Task3.V9
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        int[,] mtrx = new int[5, 5] { { -14, 25, 26, 18, 17 },
                                      { 28, 10, 6, -2, 4 },
                                      { 30, 25, -3, 11, -10 },
                                      { 11, 32, -5, -20, 25},
                                      { 2, -18, 11, 8, -20 } };
        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetLength(0);
            int columns = mtrx.GetLength(1);

            dataGridViewMatrix_KDS.ColumnCount = columns;
            dataGridViewMatrix_KDS.RowCount = rows;
            dataGridViewResult_KDS.ColumnCount = columns;
            dataGridViewResult_KDS.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix_KDS.Columns[i].Width = 50;
                dataGridViewResult_KDS.Columns[i].Width = 50;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix_KDS.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }

        private void buttonDone_KDS_Click(object sender, EventArgs e)
        {
            int[,] result_matrix = ds.Calculate(mtrx);

            int rows = result_matrix.GetLength(0);
            int columns = result_matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewResult_KDS.Rows[i].Cells[j].Value = Convert.ToString(result_matrix[i, j]);
                }
            }
        }
        private void buttonHelp_KDS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ИИПб-25-1 Косяков Дмитрий Сергеевич");
        }
    }
}
