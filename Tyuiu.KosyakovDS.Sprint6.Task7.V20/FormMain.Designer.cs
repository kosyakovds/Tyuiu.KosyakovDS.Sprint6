namespace Tyuiu.KosyakovDS.Sprint6.Task7.V20
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelTask_KDS = new Panel();
            groupBoxTask_KDS = new GroupBox();
            textBoxTask_KDS = new TextBox();
            panelLeft_KDS = new Panel();
            groupBoxInPut_KDS = new GroupBox();
            dataGridViewIn_KDS = new DataGridView();
            panelRight_KDS = new Panel();
            groupBoxOutPut_KDS = new GroupBox();
            dataGridViewOut_KDS = new DataGridView();
            splitterWork_KDS = new Splitter();
            buttonOpenFile_KDS = new Button();
            buttonDone_KDS = new Button();
            buttonSaveFile_KDS = new Button();
            panelButtons_KDS = new Panel();
            buttonHelp_KDS = new Button();
            openFileDialogTask_KDS = new OpenFileDialog();
            toolTipButton_KDS = new ToolTip(components);
            saveFileDialogMatrix_KDS = new SaveFileDialog();
            panelTask_KDS.SuspendLayout();
            groupBoxTask_KDS.SuspendLayout();
            panelLeft_KDS.SuspendLayout();
            groupBoxInPut_KDS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_KDS).BeginInit();
            panelRight_KDS.SuspendLayout();
            groupBoxOutPut_KDS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_KDS).BeginInit();
            panelButtons_KDS.SuspendLayout();
            SuspendLayout();
            // 
            // panelTask_KDS
            // 
            panelTask_KDS.Controls.Add(groupBoxTask_KDS);
            panelTask_KDS.Dock = DockStyle.Top;
            panelTask_KDS.Location = new Point(0, 76);
            panelTask_KDS.Margin = new Padding(2, 2, 2, 2);
            panelTask_KDS.Name = "panelTask_KDS";
            panelTask_KDS.Size = new Size(916, 80);
            panelTask_KDS.TabIndex = 1;
            // 
            // groupBoxTask_KDS
            // 
            groupBoxTask_KDS.Controls.Add(textBoxTask_KDS);
            groupBoxTask_KDS.Dock = DockStyle.Fill;
            groupBoxTask_KDS.Location = new Point(0, 0);
            groupBoxTask_KDS.Margin = new Padding(2, 2, 2, 2);
            groupBoxTask_KDS.Name = "groupBoxTask_KDS";
            groupBoxTask_KDS.Padding = new Padding(2, 2, 2, 2);
            groupBoxTask_KDS.Size = new Size(916, 80);
            groupBoxTask_KDS.TabIndex = 0;
            groupBoxTask_KDS.TabStop = false;
            groupBoxTask_KDS.Text = "Условие:";
            // 
            // textBoxTask_KDS
            // 
            textBoxTask_KDS.Dock = DockStyle.Fill;
            textBoxTask_KDS.Location = new Point(2, 18);
            textBoxTask_KDS.Margin = new Padding(2, 2, 2, 2);
            textBoxTask_KDS.Multiline = true;
            textBoxTask_KDS.Name = "textBoxTask_KDS";
            textBoxTask_KDS.ReadOnly = true;
            textBoxTask_KDS.Size = new Size(912, 60);
            textBoxTask_KDS.TabIndex = 0;
            textBoxTask_KDS.Text = resources.GetString("textBoxTask_KDS.Text");
            // 
            // panelLeft_KDS
            // 
            panelLeft_KDS.BackColor = SystemColors.Control;
            panelLeft_KDS.Controls.Add(groupBoxInPut_KDS);
            panelLeft_KDS.Dock = DockStyle.Left;
            panelLeft_KDS.Location = new Point(0, 156);
            panelLeft_KDS.Margin = new Padding(2, 2, 2, 2);
            panelLeft_KDS.Name = "panelLeft_KDS";
            panelLeft_KDS.Size = new Size(454, 228);
            panelLeft_KDS.TabIndex = 2;
            // 
            // groupBoxInPut_KDS
            // 
            groupBoxInPut_KDS.Controls.Add(dataGridViewIn_KDS);
            groupBoxInPut_KDS.Dock = DockStyle.Fill;
            groupBoxInPut_KDS.Location = new Point(0, 0);
            groupBoxInPut_KDS.Margin = new Padding(7, 6, 7, 6);
            groupBoxInPut_KDS.Name = "groupBoxInPut_KDS";
            groupBoxInPut_KDS.Padding = new Padding(2, 2, 2, 2);
            groupBoxInPut_KDS.Size = new Size(454, 228);
            groupBoxInPut_KDS.TabIndex = 0;
            groupBoxInPut_KDS.TabStop = false;
            groupBoxInPut_KDS.Text = "Ввод:";
            // 
            // dataGridViewIn_KDS
            // 
            dataGridViewIn_KDS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIn_KDS.ColumnHeadersVisible = false;
            dataGridViewIn_KDS.Dock = DockStyle.Fill;
            dataGridViewIn_KDS.Location = new Point(2, 18);
            dataGridViewIn_KDS.Margin = new Padding(2, 2, 2, 2);
            dataGridViewIn_KDS.Name = "dataGridViewIn_KDS";
            dataGridViewIn_KDS.RowHeadersVisible = false;
            dataGridViewIn_KDS.RowHeadersWidth = 62;
            dataGridViewIn_KDS.Size = new Size(450, 208);
            dataGridViewIn_KDS.TabIndex = 0;
            // 
            // panelRight_KDS
            // 
            panelRight_KDS.BackColor = SystemColors.Control;
            panelRight_KDS.Controls.Add(groupBoxOutPut_KDS);
            panelRight_KDS.Dock = DockStyle.Fill;
            panelRight_KDS.Location = new Point(454, 156);
            panelRight_KDS.Margin = new Padding(2, 2, 2, 2);
            panelRight_KDS.Name = "panelRight_KDS";
            panelRight_KDS.Size = new Size(462, 228);
            panelRight_KDS.TabIndex = 3;
            // 
            // groupBoxOutPut_KDS
            // 
            groupBoxOutPut_KDS.Controls.Add(dataGridViewOut_KDS);
            groupBoxOutPut_KDS.Dock = DockStyle.Fill;
            groupBoxOutPut_KDS.Location = new Point(0, 0);
            groupBoxOutPut_KDS.Margin = new Padding(2, 2, 2, 2);
            groupBoxOutPut_KDS.Name = "groupBoxOutPut_KDS";
            groupBoxOutPut_KDS.Padding = new Padding(2, 2, 2, 2);
            groupBoxOutPut_KDS.Size = new Size(462, 228);
            groupBoxOutPut_KDS.TabIndex = 0;
            groupBoxOutPut_KDS.TabStop = false;
            groupBoxOutPut_KDS.Text = "Вывод:";
            // 
            // dataGridViewOut_KDS
            // 
            dataGridViewOut_KDS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut_KDS.ColumnHeadersVisible = false;
            dataGridViewOut_KDS.Dock = DockStyle.Fill;
            dataGridViewOut_KDS.Location = new Point(2, 18);
            dataGridViewOut_KDS.Margin = new Padding(2, 2, 2, 2);
            dataGridViewOut_KDS.Name = "dataGridViewOut_KDS";
            dataGridViewOut_KDS.RowHeadersVisible = false;
            dataGridViewOut_KDS.RowHeadersWidth = 62;
            dataGridViewOut_KDS.Size = new Size(458, 208);
            dataGridViewOut_KDS.TabIndex = 0;
            // 
            // splitterWork_KDS
            // 
            splitterWork_KDS.Location = new Point(454, 156);
            splitterWork_KDS.Margin = new Padding(2, 2, 2, 2);
            splitterWork_KDS.Name = "splitterWork_KDS";
            splitterWork_KDS.Size = new Size(3, 228);
            splitterWork_KDS.TabIndex = 4;
            splitterWork_KDS.TabStop = false;
            // 
            // buttonOpenFile_KDS
            // 
            buttonOpenFile_KDS.Image = (Image)resources.GetObject("buttonOpenFile_KDS.Image");
            buttonOpenFile_KDS.Location = new Point(8, 7);
            buttonOpenFile_KDS.Margin = new Padding(2, 2, 2, 2);
            buttonOpenFile_KDS.Name = "buttonOpenFile_KDS";
            buttonOpenFile_KDS.Size = new Size(109, 65);
            buttonOpenFile_KDS.TabIndex = 0;
            toolTipButton_KDS.SetToolTip(buttonOpenFile_KDS, "Открыть файл для обработки данных в форме CSV\r\n");
            buttonOpenFile_KDS.UseVisualStyleBackColor = true;
            buttonOpenFile_KDS.Click += buttonOpenFile_KDS_Click;
            buttonOpenFile_KDS.MouseEnter += buttonOpenFile_KDS_MouseEnter;
            // 
            // buttonDone_KDS
            // 
            buttonDone_KDS.Enabled = false;
            buttonDone_KDS.Image = Properties.Resources.page_white_go;
            buttonDone_KDS.Location = new Point(122, 7);
            buttonDone_KDS.Margin = new Padding(2, 2, 2, 2);
            buttonDone_KDS.Name = "buttonDone_KDS";
            buttonDone_KDS.Size = new Size(109, 65);
            buttonDone_KDS.TabIndex = 1;
            toolTipButton_KDS.SetToolTip(buttonDone_KDS, "Выполнить обработку данных");
            buttonDone_KDS.UseVisualStyleBackColor = true;
            buttonDone_KDS.Click += buttonDone_KDS_Click;
            buttonDone_KDS.MouseEnter += buttonDone_KDS_MouseEnter;
            // 
            // buttonSaveFile_KDS
            // 
            buttonSaveFile_KDS.Enabled = false;
            buttonSaveFile_KDS.Image = (Image)resources.GetObject("buttonSaveFile_KDS.Image");
            buttonSaveFile_KDS.Location = new Point(235, 7);
            buttonSaveFile_KDS.Margin = new Padding(2, 2, 2, 2);
            buttonSaveFile_KDS.Name = "buttonSaveFile_KDS";
            buttonSaveFile_KDS.Size = new Size(109, 65);
            buttonSaveFile_KDS.TabIndex = 2;
            toolTipButton_KDS.SetToolTip(buttonSaveFile_KDS, "Сохранить обработанные данные в файл в формате CSV");
            buttonSaveFile_KDS.UseVisualStyleBackColor = true;
            buttonSaveFile_KDS.Click += buttonSaveFile_KDS_Click;
            buttonSaveFile_KDS.MouseEnter += buttonSaveFile_KDS_MouseEnter;
            // 
            // panelButtons_KDS
            // 
            panelButtons_KDS.Controls.Add(buttonHelp_KDS);
            panelButtons_KDS.Controls.Add(buttonSaveFile_KDS);
            panelButtons_KDS.Controls.Add(buttonDone_KDS);
            panelButtons_KDS.Controls.Add(buttonOpenFile_KDS);
            panelButtons_KDS.Dock = DockStyle.Top;
            panelButtons_KDS.Location = new Point(0, 0);
            panelButtons_KDS.Margin = new Padding(2, 2, 2, 2);
            panelButtons_KDS.Name = "panelButtons_KDS";
            panelButtons_KDS.Size = new Size(916, 76);
            panelButtons_KDS.TabIndex = 0;
            // 
            // buttonHelp_KDS
            // 
            buttonHelp_KDS.Image = (Image)resources.GetObject("buttonHelp_KDS.Image");
            buttonHelp_KDS.Location = new Point(799, 7);
            buttonHelp_KDS.Margin = new Padding(2, 2, 2, 2);
            buttonHelp_KDS.Name = "buttonHelp_KDS";
            buttonHelp_KDS.Size = new Size(109, 65);
            buttonHelp_KDS.TabIndex = 3;
            toolTipButton_KDS.SetToolTip(buttonHelp_KDS, "Сведение о программе");
            buttonHelp_KDS.UseVisualStyleBackColor = true;
            buttonHelp_KDS.Click += buttonHelp_KDS_Click;
            buttonHelp_KDS.MouseEnter += buttonHelp_KDS_MouseEnter;
            // 
            // openFileDialogTask_KDS
            // 
            openFileDialogTask_KDS.FileName = "openFileDialog1";
            // 
            // toolTipButton_KDS
            // 
            toolTipButton_KDS.ForeColor = SystemColors.HotTrack;
            toolTipButton_KDS.IsBalloon = true;
            toolTipButton_KDS.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(916, 384);
            Controls.Add(splitterWork_KDS);
            Controls.Add(panelRight_KDS);
            Controls.Add(panelLeft_KDS);
            Controls.Add(panelTask_KDS);
            Controls.Add(panelButtons_KDS);
            Margin = new Padding(2, 2, 2, 2);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 7 | Вариант 20 | Косяков Д. С.";
            panelTask_KDS.ResumeLayout(false);
            groupBoxTask_KDS.ResumeLayout(false);
            groupBoxTask_KDS.PerformLayout();
            panelLeft_KDS.ResumeLayout(false);
            groupBoxInPut_KDS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_KDS).EndInit();
            panelRight_KDS.ResumeLayout(false);
            groupBoxOutPut_KDS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_KDS).EndInit();
            panelButtons_KDS.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTask_KDS;
        private Panel panelLeft_KDS;
        private Panel panelRight_KDS;
        private Splitter splitterWork_KDS;
        private GroupBox groupBoxTask_KDS;
        private TextBox textBoxTask_KDS;
        private GroupBox groupBoxInPut_KDS;
        private DataGridView dataGridViewIn_KDS;
        private GroupBox groupBoxOutPut_KDS;
        private DataGridView dataGridViewOut_KDS;
        private Button buttonOpenFile_KDS;
        private Button buttonDone_KDS;
        private Button buttonSaveFile_KDS;
        private Panel panelButtons_KDS;
        private Button buttonHelp_KDS;
        private OpenFileDialog openFileDialogTask_KDS;
        private ToolTip toolTipButton_KDS;
        private SaveFileDialog saveFileDialogMatrix_KDS;
    }
}