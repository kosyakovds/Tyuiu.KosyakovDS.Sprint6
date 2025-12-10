namespace Tyuiu.KosyakovDS.Sprint6.Task6.V21
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
            panelTop_KDS = new Panel();
            buttonHelp_KDS = new Button();
            buttonDone_KDS = new Button();
            buttonOpenFile_KDS = new Button();
            panelTask_KDS = new Panel();
            groupBoxTask_KDS = new GroupBox();
            textBoxTask_KDS = new TextBox();
            panelLeft_KDS = new Panel();
            groupBoxInPut_KDS = new GroupBox();
            textBoxLoadFromFile_KDS = new TextBox();
            panelRight_KDS = new Panel();
            groupBoxOutPut_KDS = new GroupBox();
            textBoxResult_KDS = new TextBox();
            splitterWork_KDS = new Splitter();
            openFileDialogTask_KDS = new OpenFileDialog();
            toolTipInfo_KDS = new ToolTip(components);
            panelTop_KDS.SuspendLayout();
            panelTask_KDS.SuspendLayout();
            groupBoxTask_KDS.SuspendLayout();
            panelLeft_KDS.SuspendLayout();
            groupBoxInPut_KDS.SuspendLayout();
            panelRight_KDS.SuspendLayout();
            groupBoxOutPut_KDS.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop_KDS
            // 
            panelTop_KDS.Controls.Add(buttonHelp_KDS);
            panelTop_KDS.Controls.Add(buttonDone_KDS);
            panelTop_KDS.Controls.Add(buttonOpenFile_KDS);
            panelTop_KDS.Dock = DockStyle.Top;
            panelTop_KDS.Location = new Point(0, 0);
            panelTop_KDS.Margin = new Padding(2, 2, 2, 2);
            panelTop_KDS.Name = "panelTop_KDS";
            panelTop_KDS.Size = new Size(908, 64);
            panelTop_KDS.TabIndex = 0;
            // 
            // buttonHelp_KDS
            // 
            buttonHelp_KDS.Image = (Image)resources.GetObject("buttonHelp_KDS.Image");
            buttonHelp_KDS.Location = new Point(788, 7);
            buttonHelp_KDS.Margin = new Padding(2, 2, 2, 2);
            buttonHelp_KDS.Name = "buttonHelp_KDS";
            buttonHelp_KDS.Size = new Size(111, 53);
            buttonHelp_KDS.TabIndex = 2;
            toolTipInfo_KDS.SetToolTip(buttonHelp_KDS, "Сведение о программе");
            buttonHelp_KDS.UseVisualStyleBackColor = true;
            buttonHelp_KDS.Click += buttonHelp_KDS_Click;
            // 
            // buttonDone_KDS
            // 
            buttonDone_KDS.Enabled = false;
            buttonDone_KDS.Image = (Image)resources.GetObject("buttonDone_KDS.Image");
            buttonDone_KDS.Location = new Point(125, 7);
            buttonDone_KDS.Margin = new Padding(2, 2, 2, 2);
            buttonDone_KDS.Name = "buttonDone_KDS";
            buttonDone_KDS.Size = new Size(111, 53);
            buttonDone_KDS.TabIndex = 1;
            toolTipInfo_KDS.SetToolTip(buttonDone_KDS, "Производит поиск в файле вхождения символа \"g\"\r\nи конкатенирует слова в которых находится символ");
            buttonDone_KDS.UseVisualStyleBackColor = true;
            buttonDone_KDS.Click += buttonDone_KDS_Click;
            // 
            // buttonOpenFile_KDS
            // 
            buttonOpenFile_KDS.Image = (Image)resources.GetObject("buttonOpenFile_KDS.Image");
            buttonOpenFile_KDS.Location = new Point(9, 7);
            buttonOpenFile_KDS.Margin = new Padding(2, 2, 2, 2);
            buttonOpenFile_KDS.Name = "buttonOpenFile_KDS";
            buttonOpenFile_KDS.Size = new Size(111, 53);
            buttonOpenFile_KDS.TabIndex = 0;
            toolTipInfo_KDS.SetToolTip(buttonOpenFile_KDS, "Открыть файл\r\nВыберите нужный файл для обработки");
            buttonOpenFile_KDS.UseVisualStyleBackColor = true;
            buttonOpenFile_KDS.Click += buttonOpenFile_KDS_Click;
            // 
            // panelTask_KDS
            // 
            panelTask_KDS.Controls.Add(groupBoxTask_KDS);
            panelTask_KDS.Dock = DockStyle.Top;
            panelTask_KDS.Location = new Point(0, 64);
            panelTask_KDS.Margin = new Padding(2, 2, 2, 2);
            panelTask_KDS.Name = "panelTask_KDS";
            panelTask_KDS.Size = new Size(908, 67);
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
            groupBoxTask_KDS.Size = new Size(908, 67);
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
            textBoxTask_KDS.Size = new Size(904, 47);
            textBoxTask_KDS.TabIndex = 0;
            textBoxTask_KDS.Text = resources.GetString("textBoxTask_KDS.Text");
            // 
            // panelLeft_KDS
            // 
            panelLeft_KDS.Controls.Add(groupBoxInPut_KDS);
            panelLeft_KDS.Dock = DockStyle.Left;
            panelLeft_KDS.Location = new Point(0, 131);
            panelLeft_KDS.Margin = new Padding(2, 2, 2, 2);
            panelLeft_KDS.Name = "panelLeft_KDS";
            panelLeft_KDS.Size = new Size(481, 213);
            panelLeft_KDS.TabIndex = 2;
            // 
            // groupBoxInPut_KDS
            // 
            groupBoxInPut_KDS.Controls.Add(textBoxLoadFromFile_KDS);
            groupBoxInPut_KDS.Dock = DockStyle.Fill;
            groupBoxInPut_KDS.Location = new Point(0, 0);
            groupBoxInPut_KDS.Margin = new Padding(2, 2, 2, 2);
            groupBoxInPut_KDS.Name = "groupBoxInPut_KDS";
            groupBoxInPut_KDS.Padding = new Padding(2, 2, 2, 2);
            groupBoxInPut_KDS.Size = new Size(481, 213);
            groupBoxInPut_KDS.TabIndex = 0;
            groupBoxInPut_KDS.TabStop = false;
            groupBoxInPut_KDS.Text = "Ввод:";
            // 
            // textBoxLoadFromFile_KDS
            // 
            textBoxLoadFromFile_KDS.Dock = DockStyle.Fill;
            textBoxLoadFromFile_KDS.Location = new Point(2, 18);
            textBoxLoadFromFile_KDS.Margin = new Padding(2, 2, 2, 2);
            textBoxLoadFromFile_KDS.Multiline = true;
            textBoxLoadFromFile_KDS.Name = "textBoxLoadFromFile_KDS";
            textBoxLoadFromFile_KDS.ReadOnly = true;
            textBoxLoadFromFile_KDS.ScrollBars = ScrollBars.Vertical;
            textBoxLoadFromFile_KDS.Size = new Size(477, 193);
            textBoxLoadFromFile_KDS.TabIndex = 0;
            // 
            // panelRight_KDS
            // 
            panelRight_KDS.Controls.Add(groupBoxOutPut_KDS);
            panelRight_KDS.Dock = DockStyle.Fill;
            panelRight_KDS.Location = new Point(481, 131);
            panelRight_KDS.Margin = new Padding(2, 2, 2, 2);
            panelRight_KDS.Name = "panelRight_KDS";
            panelRight_KDS.Size = new Size(427, 213);
            panelRight_KDS.TabIndex = 3;
            // 
            // groupBoxOutPut_KDS
            // 
            groupBoxOutPut_KDS.Controls.Add(textBoxResult_KDS);
            groupBoxOutPut_KDS.Dock = DockStyle.Fill;
            groupBoxOutPut_KDS.Location = new Point(0, 0);
            groupBoxOutPut_KDS.Margin = new Padding(2, 2, 2, 2);
            groupBoxOutPut_KDS.Name = "groupBoxOutPut_KDS";
            groupBoxOutPut_KDS.Padding = new Padding(2, 2, 2, 2);
            groupBoxOutPut_KDS.Size = new Size(427, 213);
            groupBoxOutPut_KDS.TabIndex = 0;
            groupBoxOutPut_KDS.TabStop = false;
            groupBoxOutPut_KDS.Text = "Вывод:";
            // 
            // textBoxResult_KDS
            // 
            textBoxResult_KDS.Dock = DockStyle.Fill;
            textBoxResult_KDS.Location = new Point(2, 18);
            textBoxResult_KDS.Margin = new Padding(2, 2, 2, 2);
            textBoxResult_KDS.Multiline = true;
            textBoxResult_KDS.Name = "textBoxResult_KDS";
            textBoxResult_KDS.ReadOnly = true;
            textBoxResult_KDS.ScrollBars = ScrollBars.Vertical;
            textBoxResult_KDS.Size = new Size(423, 193);
            textBoxResult_KDS.TabIndex = 1;
            // 
            // splitterWork_KDS
            // 
            splitterWork_KDS.Location = new Point(481, 131);
            splitterWork_KDS.Margin = new Padding(2, 2, 2, 2);
            splitterWork_KDS.Name = "splitterWork_KDS";
            splitterWork_KDS.Size = new Size(3, 213);
            splitterWork_KDS.TabIndex = 4;
            splitterWork_KDS.TabStop = false;
            // 
            // openFileDialogTask_KDS
            // 
            openFileDialogTask_KDS.FileName = "openFileDialog1";
            // 
            // toolTipInfo_KDS
            // 
            toolTipInfo_KDS.ToolTipIcon = ToolTipIcon.Info;
            toolTipInfo_KDS.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(908, 344);
            Controls.Add(splitterWork_KDS);
            Controls.Add(panelRight_KDS);
            Controls.Add(panelLeft_KDS);
            Controls.Add(panelTask_KDS);
            Controls.Add(panelTop_KDS);
            Margin = new Padding(2, 2, 2, 2);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 6 | Вариант 21 | Косяков Д. С.";
            panelTop_KDS.ResumeLayout(false);
            panelTask_KDS.ResumeLayout(false);
            groupBoxTask_KDS.ResumeLayout(false);
            groupBoxTask_KDS.PerformLayout();
            panelLeft_KDS.ResumeLayout(false);
            groupBoxInPut_KDS.ResumeLayout(false);
            groupBoxInPut_KDS.PerformLayout();
            panelRight_KDS.ResumeLayout(false);
            groupBoxOutPut_KDS.ResumeLayout(false);
            groupBoxOutPut_KDS.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop_KDS;
        private Panel panelTask_KDS;
        private Panel panelLeft_KDS;
        private Panel panelRight_KDS;
        private Splitter splitterWork_KDS;
        private GroupBox groupBoxTask_KDS;
        private TextBox textBoxTask_KDS;
        private GroupBox groupBoxInPut_KDS;
        private GroupBox groupBoxOutPut_KDS;
        private TextBox textBoxLoadFromFile_KDS;
        private TextBox textBoxResult_KDS;
        private Button buttonOpenFile_KDS;
        private Button buttonHelp_KDS;
        private Button buttonDone_KDS;
        private OpenFileDialog openFileDialogTask_KDS;
        private ToolTip toolTipInfo_KDS;
    }
}