namespace Tyuiu.KosyakovDS.Sprint6.Task0.V26
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            textBoxResult_KDS = new TextBox();
            textBoxVarX_KDS = new TextBox();
            textBoxTask_KDS = new TextBox();
            pictureBoxFormula_KDS = new PictureBox();
            buttonHelp_KDS = new Button();
            buttonDone_KDS = new Button();
            labelTask_KDS = new Label();
            groupBoxInput_KDS = new GroupBox();
            labelX_KDS = new Label();
            groupBoxOutput_KDS = new GroupBox();
            labelResult_KDS = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_KDS).BeginInit();
            groupBoxInput_KDS.SuspendLayout();
            groupBoxOutput_KDS.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxResult_KDS
            // 
            textBoxResult_KDS.Location = new Point(17, 76);
            textBoxResult_KDS.Margin = new Padding(2);
            textBoxResult_KDS.Name = "textBoxResult_KDS";
            textBoxResult_KDS.ReadOnly = true;
            textBoxResult_KDS.Size = new Size(222, 23);
            textBoxResult_KDS.TabIndex = 0;
            // 
            // textBoxVarX_KDS
            // 
            textBoxVarX_KDS.Location = new Point(11, 76);
            textBoxVarX_KDS.Margin = new Padding(2);
            textBoxVarX_KDS.Name = "textBoxVarX_KDS";
            textBoxVarX_KDS.Size = new Size(224, 23);
            textBoxVarX_KDS.TabIndex = 1;
            textBoxVarX_KDS.KeyPress += textBoxVarX_KDS_KeyPress;
            // 
            // textBoxTask_KDS
            // 
            textBoxTask_KDS.Location = new Point(17, 14);
            textBoxTask_KDS.Margin = new Padding(2);
            textBoxTask_KDS.Multiline = true;
            textBoxTask_KDS.Name = "textBoxTask_KDS";
            textBoxTask_KDS.ReadOnly = true;
            textBoxTask_KDS.Size = new Size(527, 98);
            textBoxTask_KDS.TabIndex = 2;
            textBoxTask_KDS.Text = "  \r\n  Вычислить выражение по формуле";
            // 
            // pictureBoxFormula_KDS
            // 
            pictureBoxFormula_KDS.Image = (Image)resources.GetObject("pictureBoxFormula_KDS.Image");
            pictureBoxFormula_KDS.Location = new Point(398, 27);
            pictureBoxFormula_KDS.Margin = new Padding(2);
            pictureBoxFormula_KDS.Name = "pictureBoxFormula_KDS";
            pictureBoxFormula_KDS.Size = new Size(130, 64);
            pictureBoxFormula_KDS.TabIndex = 3;
            pictureBoxFormula_KDS.TabStop = false;
            // 
            // buttonHelp_KDS
            // 
            buttonHelp_KDS.FlatStyle = FlatStyle.Flat;
            buttonHelp_KDS.Location = new Point(398, 235);
            buttonHelp_KDS.Margin = new Padding(2);
            buttonHelp_KDS.Name = "buttonHelp_KDS";
            buttonHelp_KDS.Size = new Size(32, 28);
            buttonHelp_KDS.TabIndex = 4;
            buttonHelp_KDS.Text = "?";
            buttonHelp_KDS.UseVisualStyleBackColor = true;
            buttonHelp_KDS.Click += buttonHelp_KDS_Click;
            // 
            // buttonDone_KDS
            // 
            buttonDone_KDS.Location = new Point(434, 235);
            buttonDone_KDS.Margin = new Padding(2);
            buttonDone_KDS.Name = "buttonDone_KDS";
            buttonDone_KDS.Size = new Size(108, 28);
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
            groupBoxInput_KDS.Controls.Add(labelX_KDS);
            groupBoxInput_KDS.Controls.Add(textBoxVarX_KDS);
            groupBoxInput_KDS.Location = new Point(17, 126);
            groupBoxInput_KDS.Margin = new Padding(2);
            groupBoxInput_KDS.Name = "groupBoxInput_KDS";
            groupBoxInput_KDS.Padding = new Padding(2);
            groupBoxInput_KDS.Size = new Size(253, 106);
            groupBoxInput_KDS.TabIndex = 7;
            groupBoxInput_KDS.TabStop = false;
            groupBoxInput_KDS.Text = "Ввод:";
            // 
            // labelX_KDS
            // 
            labelX_KDS.AutoSize = true;
            labelX_KDS.Location = new Point(11, 53);
            labelX_KDS.Margin = new Padding(2, 0, 2, 0);
            labelX_KDS.Name = "labelX_KDS";
            labelX_KDS.Size = new Size(89, 15);
            labelX_KDS.TabIndex = 2;
            labelX_KDS.Text = "Переменная Х:";
            // 
            // groupBoxOutput_KDS
            // 
            groupBoxOutput_KDS.Controls.Add(labelResult_KDS);
            groupBoxOutput_KDS.Controls.Add(textBoxResult_KDS);
            groupBoxOutput_KDS.Location = new Point(290, 126);
            groupBoxOutput_KDS.Margin = new Padding(2);
            groupBoxOutput_KDS.Name = "groupBoxOutput_KDS";
            groupBoxOutput_KDS.Padding = new Padding(2);
            groupBoxOutput_KDS.Size = new Size(253, 106);
            groupBoxOutput_KDS.TabIndex = 8;
            groupBoxOutput_KDS.TabStop = false;
            groupBoxOutput_KDS.Text = "Вывод:";
            // 
            // labelResult_KDS
            // 
            labelResult_KDS.AutoSize = true;
            labelResult_KDS.Location = new Point(17, 53);
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
            ClientSize = new Size(560, 270);
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
            Text = "Спринт 6 | Таск 0 | Вариант 26 | Косяков Д.С.";
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
        private TextBox textBoxVarX_KDS;
        private TextBox textBoxTask_KDS;
        private PictureBox pictureBoxFormula_KDS;
        private Button buttonHelp_KDS;
        private Button buttonDone_KDS;
        private Label labelTask_KDS;
        private GroupBox groupBoxInput_KDS;
        private GroupBox groupBoxOutput_KDS;
        private Label labelX_KDS;
        private Label labelResult_KDS;
    }
}