using System;
using System.IO;
using System.Windows.Forms;
using Tyuiu.KosyakovDS.Sprint6.Task7.V20.Lib;

namespace Tyuiu.KosyakovDS.Sprint6.Task7.V20
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            openFileDialogTask_KDS.Filter = "Значения, разделённые запятыми (*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_KDS.Filter = "Значения, разделённые запятыми (*.csv)|*.csv|Все файлы(*.*)|*.*";
        }

        DataService ds = new DataService();
        static int rows;
        static int columns;
        static string openFilePath;

        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace("\n", "\r");
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }

        private void buttonHelp_KDS_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonDone_KDS_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOut_KDS.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonSaveFile_KDS.Enabled = true;
        }

        private void buttonOpenFile_KDS_Click(object sender, EventArgs e)
        {
            openFileDialogTask_KDS.ShowDialog();
            openFilePath = openFileDialogTask_KDS.FileName;

            int[,] arrayValues = LoadFromFileData(openFilePath);

            dataGridViewIn_KDS.ColumnCount = columns;
            dataGridViewIn_KDS.RowCount = rows;
            dataGridViewOut_KDS.ColumnCount = columns;
            dataGridViewOut_KDS.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewIn_KDS.Columns[i].Width = 40;
                dataGridViewOut_KDS.Columns[i].Width = 40;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewIn_KDS.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonDone_KDS.Enabled = true;
        }

        private void buttonSaveFile_KDS_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_KDS.FileName = "OutPutFileTask7V20.csv";
            saveFileDialogMatrix_KDS.InitialDirectory = @"C:\DataSprint6";
            saveFileDialogMatrix_KDS.ShowDialog();

            string path = saveFileDialogMatrix_KDS.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOut_KDS.RowCount;
            int columns = dataGridViewOut_KDS.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOut_KDS.Rows[i].Cells[j].Value + "; ";
                    }
                    else
                    {
                        str = str + dataGridViewOut_KDS.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewIn_KDS.ColumnCount = 50;
            dataGridViewOut_KDS.ColumnCount = 50;
            dataGridViewOut_KDS.RowCount = 50;
            dataGridViewIn_KDS.RowCount = 50;
            panelLeft_KDS.Width = this.Width / 2;

            for (int i = 0; i < 50; i++)
            {
                dataGridViewIn_KDS.Columns[i].Width = 25;
                dataGridViewOut_KDS.Columns[i].Width = 25;
            }
        }

        private void buttonOpenFile_KDS_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_KDS.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_KDS_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_KDS.ToolTipTitle = "Выполнить";
        }

        private void buttonSaveFile_KDS_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_KDS.ToolTipTitle = "Сохранить в файл";
        }

        private void buttonHelp_KDS_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_KDS.ToolTipTitle = "Справка";
        }
    }
}