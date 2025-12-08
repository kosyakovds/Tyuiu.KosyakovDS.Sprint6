namespace Tyuiu.KosyakovDS.Sprint6.Task3.V9
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
            groupBoxTask_KDS = new GroupBox();
            dataGridViewMatrix_KDS = new DataGridView();
            textBoxTask_KDS = new TextBox();
            groupBoxResult_KDS = new GroupBox();
            dataGridViewResult_KDS = new DataGridView();
            labelResult_KDS = new Label();
            buttonHelp_KDS = new Button();
            buttonDone_KDS = new Button();
            groupBoxTask_KDS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_KDS).BeginInit();
            groupBoxResult_KDS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_KDS).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_KDS
            // 
            groupBoxTask_KDS.Controls.Add(dataGridViewMatrix_KDS);
            groupBoxTask_KDS.Controls.Add(textBoxTask_KDS);
            groupBoxTask_KDS.Location = new Point(8, 7);
            groupBoxTask_KDS.Margin = new Padding(2, 2, 2, 2);
            groupBoxTask_KDS.Name = "groupBoxTask_KDS";
            groupBoxTask_KDS.Padding = new Padding(2, 2, 2, 2);
            groupBoxTask_KDS.Size = new Size(517, 254);
            groupBoxTask_KDS.TabIndex = 0;
            groupBoxTask_KDS.TabStop = false;
            groupBoxTask_KDS.Text = "Условие";
            // 
            // dataGridViewMatrix_KDS
            // 
            dataGridViewMatrix_KDS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrix_KDS.ColumnHeadersVisible = false;
            dataGridViewMatrix_KDS.Location = new Point(251, 33);
            dataGridViewMatrix_KDS.Margin = new Padding(2, 2, 2, 2);
            dataGridViewMatrix_KDS.Name = "dataGridViewMatrix_KDS";
            dataGridViewMatrix_KDS.RowHeadersVisible = false;
            dataGridViewMatrix_KDS.RowHeadersWidth = 62;
            dataGridViewMatrix_KDS.Size = new Size(252, 175);
            dataGridViewMatrix_KDS.TabIndex = 1;
            // 
            // textBoxTask_KDS
            // 
            textBoxTask_KDS.BackColor = SystemColors.Menu;
            textBoxTask_KDS.BorderStyle = BorderStyle.None;
            textBoxTask_KDS.Location = new Point(4, 23);
            textBoxTask_KDS.Margin = new Padding(2, 2, 2, 2);
            textBoxTask_KDS.Multiline = true;
            textBoxTask_KDS.Name = "textBoxTask_KDS";
            textBoxTask_KDS.Size = new Size(251, 160);
            textBoxTask_KDS.TabIndex = 0;
            textBoxTask_KDS.Text = "Дан массив 5 на 5 элементов. Выполнить\r\nсортировку по возрастанию в пятом столбце.\r\n\r\n-14  25  26  18  17\r\n  28  10   6  -2   4\r\n  30  25  -3  11 -10\r\n  11  32  -5 -20  25\r\n   2 -18  11   8 -20";
            // 
            // groupBoxResult_KDS
            // 
            groupBoxResult_KDS.Controls.Add(dataGridViewResult_KDS);
            groupBoxResult_KDS.Controls.Add(labelResult_KDS);
            groupBoxResult_KDS.Location = new Point(530, 7);
            groupBoxResult_KDS.Margin = new Padding(2, 2, 2, 2);
            groupBoxResult_KDS.Name = "groupBoxResult_KDS";
            groupBoxResult_KDS.Padding = new Padding(2, 2, 2, 2);
            groupBoxResult_KDS.Size = new Size(304, 220);
            groupBoxResult_KDS.TabIndex = 1;
            groupBoxResult_KDS.TabStop = false;
            groupBoxResult_KDS.Text = "Вывод данных";
            // 
            // dataGridViewResult_KDS
            // 
            dataGridViewResult_KDS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_KDS.ColumnHeadersVisible = false;
            dataGridViewResult_KDS.Location = new Point(11, 33);
            dataGridViewResult_KDS.Margin = new Padding(2, 2, 2, 2);
            dataGridViewResult_KDS.Name = "dataGridViewResult_KDS";
            dataGridViewResult_KDS.RowHeadersVisible = false;
            dataGridViewResult_KDS.RowHeadersWidth = 62;
            dataGridViewResult_KDS.Size = new Size(278, 175);
            dataGridViewResult_KDS.TabIndex = 2;
            // 
            // labelResult_KDS
            // 
            labelResult_KDS.AutoSize = true;
            labelResult_KDS.Location = new Point(4, 16);
            labelResult_KDS.Margin = new Padding(2, 0, 2, 0);
            labelResult_KDS.Name = "labelResult_KDS";
            labelResult_KDS.Size = new Size(63, 15);
            labelResult_KDS.TabIndex = 0;
            labelResult_KDS.Text = "Результат:";
            // 
            // buttonHelp_KDS
            // 
            buttonHelp_KDS.Location = new Point(530, 230);
            buttonHelp_KDS.Margin = new Padding(2, 2, 2, 2);
            buttonHelp_KDS.Name = "buttonHelp_KDS";
            buttonHelp_KDS.Size = new Size(117, 31);
            buttonHelp_KDS.TabIndex = 1;
            buttonHelp_KDS.Text = "?";
            buttonHelp_KDS.UseVisualStyleBackColor = true;
            buttonHelp_KDS.Click += buttonHelp_KDS_Click;
            // 
            // buttonDone_KDS
            // 
            buttonDone_KDS.Location = new Point(651, 230);
            buttonDone_KDS.Margin = new Padding(2, 2, 2, 2);
            buttonDone_KDS.Name = "buttonDone_KDS";
            buttonDone_KDS.Size = new Size(183, 31);
            buttonDone_KDS.TabIndex = 2;
            buttonDone_KDS.Text = "Выполнить";
            buttonDone_KDS.UseVisualStyleBackColor = true;
            buttonDone_KDS.Click += buttonDone_KDS_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 268);
            Controls.Add(buttonDone_KDS);
            Controls.Add(buttonHelp_KDS);
            Controls.Add(groupBoxResult_KDS);
            Controls.Add(groupBoxTask_KDS);
            Margin = new Padding(2, 2, 2, 2);
            MaximizeBox = false;
            Name = "FormMain";
            Text = "Спринт 6 | Таск 3 | Вариант 9 | Косяков Д. С.";
            Load += FormMain_Load;
            Click += buttonHelp_KDS_Click;
            groupBoxTask_KDS.ResumeLayout(false);
            groupBoxTask_KDS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_KDS).EndInit();
            groupBoxResult_KDS.ResumeLayout(false);
            groupBoxResult_KDS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_KDS).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_KDS;
        private TextBox textBoxTask_KDS;
        private GroupBox groupBoxResult_KDS;
        private Label labelResult_KDS;
        private Button buttonHelp_KDS;
        private Button buttonDone_KDS;
        private DataGridView dataGridViewMatrix_KDS;
        private DataGridView dataGridViewResult_KDS;
    }
}