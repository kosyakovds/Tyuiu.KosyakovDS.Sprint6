namespace Tyuiu.KosyakovDS.Sprint6.Task1.V23
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
            textBoxResult_KDS = new TextBox();
            textBoxStartValue_KDS = new TextBox();
            textBoxTask_KDS = new TextBox();
            pictureBoxFormula_KDS = new PictureBox();
            buttonHelp_KDS = new Button();
            buttonDone_KDS = new Button();
            labelTask_KDS = new Label();
            groupBoxInput_KDS = new GroupBox();
            textBoxStopValue_KDS = new TextBox();
            labelStopValue_KDS = new Label();
            labelStartValue_KDS = new Label();
            groupBoxOutput_KDS = new GroupBox();
            labelResult_KDS = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_KDS).BeginInit();
            groupBoxInput_KDS.SuspendLayout();
            groupBoxOutput_KDS.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxResult_KDS
            // 
            textBoxResult_KDS.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult_KDS.Location = new Point(14, 35);
            textBoxResult_KDS.Margin = new Padding(2);
            textBoxResult_KDS.Multiline = true;
            textBoxResult_KDS.Name = "textBoxResult_KDS";
            textBoxResult_KDS.ReadOnly = true;
            textBoxResult_KDS.ScrollBars = ScrollBars.Vertical;
            textBoxResult_KDS.Size = new Size(222, 368);
            textBoxResult_KDS.TabIndex = 0;
            // 
            // textBoxStartValue_KDS
            // 
            textBoxStartValue_KDS.Location = new Point(11, 76);
            textBoxStartValue_KDS.Margin = new Padding(2);
            textBoxStartValue_KDS.Name = "textBoxStartValue_KDS";
            textBoxStartValue_KDS.Size = new Size(90, 23);
            textBoxStartValue_KDS.TabIndex = 1;
            // 
            // textBoxTask_KDS
            // 
            textBoxTask_KDS.Location = new Point(17, 14);
            textBoxTask_KDS.Margin = new Padding(2);
            textBoxTask_KDS.Multiline = true;
            textBoxTask_KDS.Name = "textBoxTask_KDS";
            textBoxTask_KDS.ReadOnly = true;
            textBoxTask_KDS.Size = new Size(400, 250);
            textBoxTask_KDS.TabIndex = 2;
            textBoxTask_KDS.Text = "  \r\nПротабулировать функцию на заданном диапазоне.\r\nРезультат вывести в виде таблицы.\r\n";
            // 
            // pictureBoxFormula_KDS
            // 
            pictureBoxFormula_KDS.Location = new Point(28, 73);
            pictureBoxFormula_KDS.Margin = new Padding(2);
            pictureBoxFormula_KDS.Name = "pictureBoxFormula_KDS";
            pictureBoxFormula_KDS.Size = new Size(130, 64);
            pictureBoxFormula_KDS.TabIndex = 3;
            pictureBoxFormula_KDS.TabStop = false;
            // 
            // buttonHelp_KDS
            // 
            buttonHelp_KDS.FlatStyle = FlatStyle.Flat;
            buttonHelp_KDS.Location = new Point(17, 378);
            buttonHelp_KDS.Margin = new Padding(2);
            buttonHelp_KDS.Name = "buttonHelp_KDS";
            buttonHelp_KDS.Size = new Size(89, 43);
            buttonHelp_KDS.TabIndex = 4;
            buttonHelp_KDS.Text = "?";
            buttonHelp_KDS.UseVisualStyleBackColor = true;
            buttonHelp_KDS.Click += buttonHelp_KDS_Click;
            // 
            // buttonDone_KDS
            // 
            buttonDone_KDS.Location = new Point(121, 378);
            buttonDone_KDS.Margin = new Padding(2);
            buttonDone_KDS.Name = "buttonDone_KDS";
            buttonDone_KDS.Size = new Size(131, 43);
            buttonDone_KDS.TabIndex = 5;
            buttonDone_KDS.Text = "Выполнить";
            buttonDone_KDS.UseVisualStyleBackColor = true;
            buttonDone_KDS.Click += buttonDone_KDS_Click;
            // 
            // labelTask_KDS
            // 
            labelTask_KDS.AutoSize = true;
            labelTask_KDS.Location = new Point(28, 5);
            labelTask_KDS.Margin = new Padding(2, 0, 2, 0);
            labelTask_KDS.Name = "labelTask_KDS";
            labelTask_KDS.Size = new Size(53, 15);
            labelTask_KDS.TabIndex = 6;
            labelTask_KDS.Text = "Условие";
            // 
            // groupBoxInput_KDS
            // 
            groupBoxInput_KDS.Controls.Add(textBoxStopValue_KDS);
            groupBoxInput_KDS.Controls.Add(labelStopValue_KDS);
            groupBoxInput_KDS.Controls.Add(labelStartValue_KDS);
            groupBoxInput_KDS.Controls.Add(textBoxStartValue_KDS);
            groupBoxInput_KDS.Location = new Point(17, 268);
            groupBoxInput_KDS.Margin = new Padding(2);
            groupBoxInput_KDS.Name = "groupBoxInput_KDS";
            groupBoxInput_KDS.Padding = new Padding(2);
            groupBoxInput_KDS.Size = new Size(310, 106);
            groupBoxInput_KDS.TabIndex = 7;
            groupBoxInput_KDS.TabStop = false;
            groupBoxInput_KDS.Text = "Ввод:";
            // 
            // textBoxStopValue_KDS
            // 
            textBoxStopValue_KDS.Location = new Point(136, 76);
            textBoxStopValue_KDS.Name = "textBoxStopValue_KDS";
            textBoxStopValue_KDS.Size = new Size(90, 23);
            textBoxStopValue_KDS.TabIndex = 4;
            // 
            // labelStopValue_KDS
            // 
            labelStopValue_KDS.AutoSize = true;
            labelStopValue_KDS.Location = new Point(136, 53);
            labelStopValue_KDS.Name = "labelStopValue_KDS";
            labelStopValue_KDS.Size = new Size(75, 15);
            labelStopValue_KDS.TabIndex = 3;
            labelStopValue_KDS.Text = "Конец шага:";
            // 
            // labelStartValue_KDS
            // 
            labelStartValue_KDS.AutoSize = true;
            labelStartValue_KDS.Location = new Point(11, 53);
            labelStartValue_KDS.Margin = new Padding(2, 0, 2, 0);
            labelStartValue_KDS.Name = "labelStartValue_KDS";
            labelStartValue_KDS.Size = new Size(83, 15);
            labelStartValue_KDS.TabIndex = 2;
            labelStartValue_KDS.Text = "Начало шага:";
            // 
            // groupBoxOutput_KDS
            // 
            groupBoxOutput_KDS.Controls.Add(labelResult_KDS);
            groupBoxOutput_KDS.Controls.Add(textBoxResult_KDS);
            groupBoxOutput_KDS.Location = new Point(421, 5);
            groupBoxOutput_KDS.Margin = new Padding(2);
            groupBoxOutput_KDS.Name = "groupBoxOutput_KDS";
            groupBoxOutput_KDS.Padding = new Padding(2);
            groupBoxOutput_KDS.Size = new Size(253, 407);
            groupBoxOutput_KDS.TabIndex = 8;
            groupBoxOutput_KDS.TabStop = false;
            groupBoxOutput_KDS.Text = "Вывод:";
            // 
            // labelResult_KDS
            // 
            labelResult_KDS.AutoSize = true;
            labelResult_KDS.Location = new Point(4, 18);
            labelResult_KDS.Margin = new Padding(2, 0, 2, 0);
            labelResult_KDS.Name = "labelResult_KDS";
            labelResult_KDS.Size = new Size(63, 15);
            labelResult_KDS.TabIndex = 9;
            labelResult_KDS.Text = "Результат:";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 434);
            Controls.Add(groupBoxOutput_KDS);
            Controls.Add(groupBoxInput_KDS);
            Controls.Add(labelTask_KDS);
            Controls.Add(buttonDone_KDS);
            Controls.Add(buttonHelp_KDS);
            Controls.Add(pictureBoxFormula_KDS);
            Controls.Add(textBoxTask_KDS);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 1 | Вариант 23 | Косяков Д.С.";
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_KDS).EndInit();
            groupBoxInput_KDS.ResumeLayout(false);
            groupBoxInput_KDS.PerformLayout();
            groupBoxOutput_KDS.ResumeLayout(false);
            groupBoxOutput_KDS.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxResult_KDS;
        private TextBox textBoxStartValue_KDS;
        private TextBox textBoxTask_KDS;
        private PictureBox pictureBoxFormula_KDS;
        private Button buttonHelp_KDS;
        private Button buttonDone_KDS;
        private Label labelTask_KDS;
        private GroupBox groupBoxInput_KDS;
        private GroupBox groupBoxOutput_KDS;
        private Label labelStartValue_KDS;
        private Label labelResult_KDS;
        private Label labelStopValue_KDS;
        private TextBox textBoxStopValue_KDS;
    }
}
