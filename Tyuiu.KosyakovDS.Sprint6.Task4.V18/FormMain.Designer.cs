namespace Tyuiu.KosyakovDS.Sprint6.Task4.V18
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            groupBoxTask_KDS = new GroupBox();
            textBoxTask_KDS = new TextBox();
            groupBoxInPutData_KDS = new GroupBox();
            labelStopStep_KDS = new Label();
            labelStartStep_KDS = new Label();
            textBoxStopStep_KDS = new TextBox();
            textBoxStartStep_KDS = new TextBox();
            buttonDone_KDS = new Button();
            buttonSave_KDS = new Button();
            buttonHelp_KDS = new Button();
            groupBoxOutPutData_KDS = new GroupBox();
            textBoxResult_KDS = new TextBox();
            chartFunction_KDS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelTop_KDS = new Panel();
            panelLeft_KDS = new Panel();
            panelRight_KDS = new Panel();
            groupBoxTask_KDS.SuspendLayout();
            groupBoxInPutData_KDS.SuspendLayout();
            groupBoxOutPutData_KDS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_KDS).BeginInit();
            panelTop_KDS.SuspendLayout();
            panelLeft_KDS.SuspendLayout();
            panelRight_KDS.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_KDS
            // 
            groupBoxTask_KDS.Controls.Add(textBoxTask_KDS);
            groupBoxTask_KDS.Location = new Point(9, 5);
            groupBoxTask_KDS.Name = "groupBoxTask_KDS";
            groupBoxTask_KDS.Size = new Size(447, 123);
            groupBoxTask_KDS.TabIndex = 0;
            groupBoxTask_KDS.TabStop = false;
            groupBoxTask_KDS.Text = "Условие:";
            // 
            // textBoxTask_KDS
            // 
            textBoxTask_KDS.Location = new Point(6, 22);
            textBoxTask_KDS.Multiline = true;
            textBoxTask_KDS.Name = "textBoxTask_KDS";
            textBoxTask_KDS.Size = new Size(435, 95);
            textBoxTask_KDS.TabIndex = 0;
            textBoxTask_KDS.Text = "Протабулировать функцию от -5 до 5. Результат вывести в textBox. Построить график функции и сохранить в файл OutPutFileTask.txt по нажатию кнопки\r\n\r\n\r\n";
            // 
            // groupBoxInPutData_KDS
            // 
            groupBoxInPutData_KDS.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxInPutData_KDS.Controls.Add(labelStopStep_KDS);
            groupBoxInPutData_KDS.Controls.Add(labelStartStep_KDS);
            groupBoxInPutData_KDS.Controls.Add(textBoxStopStep_KDS);
            groupBoxInPutData_KDS.Controls.Add(textBoxStartStep_KDS);
            groupBoxInPutData_KDS.Location = new Point(462, 5);
            groupBoxInPutData_KDS.Name = "groupBoxInPutData_KDS";
            groupBoxInPutData_KDS.Size = new Size(348, 123);
            groupBoxInPutData_KDS.TabIndex = 1;
            groupBoxInPutData_KDS.TabStop = false;
            groupBoxInPutData_KDS.Text = "Ввод данных:";
            // 
            // labelStopStep_KDS
            // 
            labelStopStep_KDS.AutoSize = true;
            labelStopStep_KDS.Location = new Point(6, 68);
            labelStopStep_KDS.Name = "labelStopStep_KDS";
            labelStopStep_KDS.Size = new Size(75, 15);
            labelStopStep_KDS.TabIndex = 1;
            labelStopStep_KDS.Text = "Конец шага:";
            // 
            // labelStartStep_KDS
            // 
            labelStartStep_KDS.AutoSize = true;
            labelStartStep_KDS.Location = new Point(6, 25);
            labelStartStep_KDS.Name = "labelStartStep_KDS";
            labelStartStep_KDS.Size = new Size(83, 15);
            labelStartStep_KDS.TabIndex = 1;
            labelStartStep_KDS.Text = "Начало шага:";
            // 
            // textBoxStopStep_KDS
            // 
            textBoxStopStep_KDS.Location = new Point(6, 86);
            textBoxStopStep_KDS.Name = "textBoxStopStep_KDS";
            textBoxStopStep_KDS.Size = new Size(336, 23);
            textBoxStopStep_KDS.TabIndex = 0;
            // 
            // textBoxStartStep_KDS
            // 
            textBoxStartStep_KDS.Location = new Point(6, 43);
            textBoxStartStep_KDS.Name = "textBoxStartStep_KDS";
            textBoxStartStep_KDS.Size = new Size(336, 23);
            textBoxStartStep_KDS.TabIndex = 0;
            // 
            // buttonDone_KDS
            // 
            buttonDone_KDS.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonDone_KDS.BackColor = Color.Green;
            buttonDone_KDS.Location = new Point(816, 12);
            buttonDone_KDS.Name = "buttonDone_KDS";
            buttonDone_KDS.Size = new Size(231, 35);
            buttonDone_KDS.TabIndex = 2;
            buttonDone_KDS.Text = "Выполнить";
            buttonDone_KDS.UseVisualStyleBackColor = false;
            buttonDone_KDS.Click += buttonDone_KDS_Click;
            // 
            // buttonSave_KDS
            // 
            buttonSave_KDS.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSave_KDS.BackColor = Color.RoyalBlue;
            buttonSave_KDS.Location = new Point(816, 53);
            buttonSave_KDS.Name = "buttonSave_KDS";
            buttonSave_KDS.Size = new Size(231, 35);
            buttonSave_KDS.TabIndex = 3;
            buttonSave_KDS.Text = "Сохранить";
            buttonSave_KDS.UseVisualStyleBackColor = false;
            buttonSave_KDS.Click += buttonSave_KDS_Click;
            // 
            // buttonHelp_KDS
            // 
            buttonHelp_KDS.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_KDS.BackColor = Color.IndianRed;
            buttonHelp_KDS.Location = new Point(816, 94);
            buttonHelp_KDS.Name = "buttonHelp_KDS";
            buttonHelp_KDS.Size = new Size(231, 34);
            buttonHelp_KDS.TabIndex = 4;
            buttonHelp_KDS.Text = "Справка";
            buttonHelp_KDS.UseVisualStyleBackColor = false;
            buttonHelp_KDS.Click += buttonHelp_KDS_Click;
            // 
            // groupBoxOutPutData_KDS
            // 
            groupBoxOutPutData_KDS.BackColor = Color.LightSalmon;
            groupBoxOutPutData_KDS.Controls.Add(textBoxResult_KDS);
            groupBoxOutPutData_KDS.Dock = DockStyle.Fill;
            groupBoxOutPutData_KDS.Location = new Point(5, 5);
            groupBoxOutPutData_KDS.Name = "groupBoxOutPutData_KDS";
            groupBoxOutPutData_KDS.Padding = new Padding(5);
            groupBoxOutPutData_KDS.Size = new Size(210, 430);
            groupBoxOutPutData_KDS.TabIndex = 5;
            groupBoxOutPutData_KDS.TabStop = false;
            groupBoxOutPutData_KDS.Text = "Вывод:";
            // 
            // textBoxResult_KDS
            // 
            textBoxResult_KDS.Dock = DockStyle.Fill;
            textBoxResult_KDS.Location = new Point(5, 21);
            textBoxResult_KDS.Multiline = true;
            textBoxResult_KDS.Name = "textBoxResult_KDS";
            textBoxResult_KDS.Size = new Size(200, 404);
            textBoxResult_KDS.TabIndex = 0;
            // 
            // chartFunction_KDS
            // 
            chartFunction_KDS.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chartArea2.Name = "ChartArea1";
            chartFunction_KDS.ChartAreas.Add(chartArea2);
            chartFunction_KDS.Location = new Point(6, 6);
            chartFunction_KDS.Name = "chartFunction_KDS";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Name = "Series1";
            chartFunction_KDS.Series.Add(series2);
            chartFunction_KDS.Size = new Size(812, 424);
            chartFunction_KDS.TabIndex = 6;
            chartFunction_KDS.Text = "chart1";
            title2.Font = new Font("MS Reference Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            title2.Name = "Title1";
            title2.Text = "График функции";
            chartFunction_KDS.Titles.Add(title2);
            // 
            // panelTop_KDS
            // 
            panelTop_KDS.BackColor = Color.LightSalmon;
            panelTop_KDS.Controls.Add(buttonHelp_KDS);
            panelTop_KDS.Controls.Add(buttonDone_KDS);
            panelTop_KDS.Controls.Add(groupBoxInPutData_KDS);
            panelTop_KDS.Controls.Add(groupBoxTask_KDS);
            panelTop_KDS.Controls.Add(buttonSave_KDS);
            panelTop_KDS.Dock = DockStyle.Top;
            panelTop_KDS.Location = new Point(0, 0);
            panelTop_KDS.Name = "panelTop_KDS";
            panelTop_KDS.Padding = new Padding(5);
            panelTop_KDS.Size = new Size(1050, 153);
            panelTop_KDS.TabIndex = 7;
            // 
            // panelLeft_KDS
            // 
            panelLeft_KDS.BackColor = Color.LightSalmon;
            panelLeft_KDS.Controls.Add(groupBoxOutPutData_KDS);
            panelLeft_KDS.Dock = DockStyle.Left;
            panelLeft_KDS.Location = new Point(0, 153);
            panelLeft_KDS.Name = "panelLeft_KDS";
            panelLeft_KDS.Padding = new Padding(5);
            panelLeft_KDS.Size = new Size(220, 440);
            panelLeft_KDS.TabIndex = 8;
            // 
            // panelRight_KDS
            // 
            panelRight_KDS.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelRight_KDS.BackColor = Color.Bisque;
            panelRight_KDS.Controls.Add(chartFunction_KDS);
            panelRight_KDS.Location = new Point(220, 153);
            panelRight_KDS.Name = "panelRight_KDS";
            panelRight_KDS.Size = new Size(830, 440);
            panelRight_KDS.TabIndex = 9;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 593);
            Controls.Add(panelRight_KDS);
            Controls.Add(panelLeft_KDS);
            Controls.Add(panelTop_KDS);
            Name = "FormMain";
            Text = "Form1";
            groupBoxTask_KDS.ResumeLayout(false);
            groupBoxTask_KDS.PerformLayout();
            groupBoxInPutData_KDS.ResumeLayout(false);
            groupBoxInPutData_KDS.PerformLayout();
            groupBoxOutPutData_KDS.ResumeLayout(false);
            groupBoxOutPutData_KDS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_KDS).EndInit();
            panelTop_KDS.ResumeLayout(false);
            panelLeft_KDS.ResumeLayout(false);
            panelRight_KDS.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_KDS;
        private GroupBox groupBoxInPutData_KDS;
        private Button buttonDone_KDS;
        private Button buttonSave_KDS;
        private Button buttonHelp_KDS;
        private GroupBox groupBoxOutPutData_KDS;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_KDS;
        private Panel panelTop_KDS;
        private Panel panelLeft_KDS;
        private Panel panelRight_KDS;
        private TextBox textBoxResult_KDS;
        private TextBox textBoxTask_KDS;
        private Label labelStopStep_KDS;
        private Label labelStartStep_KDS;
        private TextBox textBoxStopStep_KDS;
        private TextBox textBoxStartStep_KDS;
    }
}
