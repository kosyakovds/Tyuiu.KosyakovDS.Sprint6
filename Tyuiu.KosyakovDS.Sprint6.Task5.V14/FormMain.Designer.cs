namespace Tyuiu.KosyakovDS.Sprint6.Task5.V14
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panelTop_KDS = new Panel();
            buttonHelp_KDS = new Button();
            buttonOpenFile_KDS = new Button();
            buttonDone_KDS = new Button();
            groupBoxTask_KDS = new GroupBox();
            textBoxTask_KDS = new TextBox();
            panelLeft_KDS = new Panel();
            groupBoxOutPut_KDS = new GroupBox();
            dataGridViewNums_KDS = new DataGridView();
            panelFill_KDS = new Panel();
            chartDiag_KDS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            splitterWork_KDS = new Splitter();
            panelTop_KDS.SuspendLayout();
            groupBoxTask_KDS.SuspendLayout();
            panelLeft_KDS.SuspendLayout();
            groupBoxOutPut_KDS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNums_KDS).BeginInit();
            panelFill_KDS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartDiag_KDS).BeginInit();
            SuspendLayout();
            // 
            // panelTop_KDS
            // 
            panelTop_KDS.Controls.Add(buttonHelp_KDS);
            panelTop_KDS.Controls.Add(buttonOpenFile_KDS);
            panelTop_KDS.Controls.Add(buttonDone_KDS);
            panelTop_KDS.Controls.Add(groupBoxTask_KDS);
            panelTop_KDS.Dock = DockStyle.Top;
            panelTop_KDS.Location = new Point(0, 0);
            panelTop_KDS.Margin = new Padding(2, 2, 2, 2);
            panelTop_KDS.Name = "panelTop_KDS";
            panelTop_KDS.Size = new Size(872, 83);
            panelTop_KDS.TabIndex = 0;
            // 
            // buttonHelp_KDS
            // 
            buttonHelp_KDS.BackColor = Color.FromArgb(128, 255, 255);
            buttonHelp_KDS.Location = new Point(778, 7);
            buttonHelp_KDS.Margin = new Padding(2, 2, 2, 2);
            buttonHelp_KDS.Name = "buttonHelp_KDS";
            buttonHelp_KDS.Size = new Size(86, 72);
            buttonHelp_KDS.TabIndex = 3;
            buttonHelp_KDS.Text = "Справка";
            buttonHelp_KDS.UseVisualStyleBackColor = false;
            buttonHelp_KDS.Click += buttonHelp_KDS_Click;
            // 
            // buttonOpenFile_KDS
            // 
            buttonOpenFile_KDS.BackColor = Color.FromArgb(128, 128, 255);
            buttonOpenFile_KDS.Location = new Point(680, 7);
            buttonOpenFile_KDS.Margin = new Padding(2, 2, 2, 2);
            buttonOpenFile_KDS.Name = "buttonOpenFile_KDS";
            buttonOpenFile_KDS.Size = new Size(86, 72);
            buttonOpenFile_KDS.TabIndex = 2;
            buttonOpenFile_KDS.Text = "Открыть файл";
            buttonOpenFile_KDS.UseVisualStyleBackColor = false;
            buttonOpenFile_KDS.Click += buttonOpenFile_KDS_Click;
            // 
            // buttonDone_KDS
            // 
            buttonDone_KDS.BackColor = Color.FromArgb(128, 255, 128);
            buttonDone_KDS.Location = new Point(583, 7);
            buttonDone_KDS.Margin = new Padding(2, 2, 2, 2);
            buttonDone_KDS.Name = "buttonDone_KDS";
            buttonDone_KDS.Size = new Size(86, 72);
            buttonDone_KDS.TabIndex = 1;
            buttonDone_KDS.Text = "Выполнить";
            buttonDone_KDS.UseVisualStyleBackColor = false;
            buttonDone_KDS.Click += buttonDone_KDS_Click;
            // 
            // groupBoxTask_KDS
            // 
            groupBoxTask_KDS.Controls.Add(textBoxTask_KDS);
            groupBoxTask_KDS.Location = new Point(8, 2);
            groupBoxTask_KDS.Margin = new Padding(2, 2, 2, 2);
            groupBoxTask_KDS.Name = "groupBoxTask_KDS";
            groupBoxTask_KDS.Padding = new Padding(2, 2, 2, 2);
            groupBoxTask_KDS.Size = new Size(559, 77);
            groupBoxTask_KDS.TabIndex = 0;
            groupBoxTask_KDS.TabStop = false;
            groupBoxTask_KDS.Text = "Условие:";
            // 
            // textBoxTask_KDS
            // 
            textBoxTask_KDS.BackColor = SystemColors.Menu;
            textBoxTask_KDS.BorderStyle = BorderStyle.None;
            textBoxTask_KDS.Location = new Point(6, 18);
            textBoxTask_KDS.Margin = new Padding(2, 2, 2, 2);
            textBoxTask_KDS.Multiline = true;
            textBoxTask_KDS.Name = "textBoxTask_KDS";
            textBoxTask_KDS.ReadOnly = true;
            textBoxTask_KDS.Size = new Size(540, 52);
            textBoxTask_KDS.TabIndex = 0;
            textBoxTask_KDS.Text = "Прочитать данные из файла InPutDataFileTask5V14.txt. Вывести в DataGridView\r\nвсе числа, большие или равные 10. Построить диаграмму по этим значениям.";
            // 
            // panelLeft_KDS
            // 
            panelLeft_KDS.Controls.Add(groupBoxOutPut_KDS);
            panelLeft_KDS.Dock = DockStyle.Left;
            panelLeft_KDS.Location = new Point(0, 83);
            panelLeft_KDS.Margin = new Padding(2, 2, 2, 2);
            panelLeft_KDS.Name = "panelLeft_KDS";
            panelLeft_KDS.Size = new Size(196, 299);
            panelLeft_KDS.TabIndex = 1;
            // 
            // groupBoxOutPut_KDS
            // 
            groupBoxOutPut_KDS.Controls.Add(dataGridViewNums_KDS);
            groupBoxOutPut_KDS.Location = new Point(8, 4);
            groupBoxOutPut_KDS.Margin = new Padding(2, 2, 2, 2);
            groupBoxOutPut_KDS.Name = "groupBoxOutPut_KDS";
            groupBoxOutPut_KDS.Padding = new Padding(2, 2, 2, 2);
            groupBoxOutPut_KDS.Size = new Size(183, 294);
            groupBoxOutPut_KDS.TabIndex = 0;
            groupBoxOutPut_KDS.TabStop = false;
            groupBoxOutPut_KDS.Text = "Вывод данных:";
            // 
            // dataGridViewNums_KDS
            // 
            dataGridViewNums_KDS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNums_KDS.ColumnHeadersVisible = false;
            dataGridViewNums_KDS.Location = new Point(4, 18);
            dataGridViewNums_KDS.Margin = new Padding(2, 2, 2, 2);
            dataGridViewNums_KDS.Name = "dataGridViewNums_KDS";
            dataGridViewNums_KDS.RowHeadersVisible = false;
            dataGridViewNums_KDS.RowHeadersWidth = 62;
            dataGridViewNums_KDS.Size = new Size(175, 272);
            dataGridViewNums_KDS.TabIndex = 0;
            // 
            // panelFill_KDS
            // 
            panelFill_KDS.Controls.Add(chartDiag_KDS);
            panelFill_KDS.Dock = DockStyle.Fill;
            panelFill_KDS.Location = new Point(196, 83);
            panelFill_KDS.Margin = new Padding(2, 2, 2, 2);
            panelFill_KDS.Name = "panelFill_KDS";
            panelFill_KDS.Size = new Size(676, 299);
            panelFill_KDS.TabIndex = 2;
            // 
            // chartDiag_KDS
            // 
            chartArea1.Name = "ChartArea1";
            chartDiag_KDS.ChartAreas.Add(chartArea1);
            chartDiag_KDS.Dock = DockStyle.Fill;
            chartDiag_KDS.Location = new Point(0, 0);
            chartDiag_KDS.Margin = new Padding(2, 2, 2, 2);
            chartDiag_KDS.Name = "chartDiag_KDS";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            chartDiag_KDS.Series.Add(series1);
            chartDiag_KDS.Size = new Size(676, 299);
            chartDiag_KDS.TabIndex = 0;
            chartDiag_KDS.Text = "chart1";
            // 
            // splitterWork_KDS
            // 
            splitterWork_KDS.Location = new Point(196, 83);
            splitterWork_KDS.Margin = new Padding(2, 2, 2, 2);
            splitterWork_KDS.Name = "splitterWork_KDS";
            splitterWork_KDS.Size = new Size(3, 299);
            splitterWork_KDS.TabIndex = 3;
            splitterWork_KDS.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 382);
            Controls.Add(splitterWork_KDS);
            Controls.Add(panelFill_KDS);
            Controls.Add(panelLeft_KDS);
            Controls.Add(panelTop_KDS);
            Margin = new Padding(2, 2, 2, 2);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 5 | Вариант 14 | Косяков Д. С.";
            panelTop_KDS.ResumeLayout(false);
            groupBoxTask_KDS.ResumeLayout(false);
            groupBoxTask_KDS.PerformLayout();
            panelLeft_KDS.ResumeLayout(false);
            groupBoxOutPut_KDS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewNums_KDS).EndInit();
            panelFill_KDS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartDiag_KDS).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop_KDS;
        private GroupBox groupBoxTask_KDS;
        private Panel panelLeft_KDS;
        private Panel panelFill_KDS;
        private Splitter splitterWork_KDS;
        private Button buttonHelp_KDS;
        private Button buttonOpenFile_KDS;
        private Button buttonDone_KDS;
        private TextBox textBoxTask_KDS;
        private GroupBox groupBoxOutPut_KDS;
        private DataGridView dataGridViewNums_KDS;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiag_KDS;
    }
}
