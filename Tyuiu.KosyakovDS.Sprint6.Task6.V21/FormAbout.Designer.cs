namespace Tyuiu.KosyakovDS.Sprint6.Task6.V21
{
    partial class FormAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            pictureBoxAvatar_KDS = new PictureBox();
            textBoxInfo_KDS = new TextBox();
            buttonOk_KDS = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_KDS).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxAvatar_KDS
            // 
            pictureBoxAvatar_KDS.Image = (Image)resources.GetObject("pictureBoxAvatar_KDS.Image");
            pictureBoxAvatar_KDS.Location = new Point(18, 14);
            pictureBoxAvatar_KDS.Margin = new Padding(2, 2, 2, 2);
            pictureBoxAvatar_KDS.Name = "pictureBoxAvatar_KDS";
            pictureBoxAvatar_KDS.Size = new Size(189, 169);
            pictureBoxAvatar_KDS.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxAvatar_KDS.TabIndex = 0;
            pictureBoxAvatar_KDS.TabStop = false;
            // 
            // textBoxInfo_KDS
            // 
            textBoxInfo_KDS.BorderStyle = BorderStyle.None;
            textBoxInfo_KDS.Location = new Point(225, 14);
            textBoxInfo_KDS.Margin = new Padding(2, 2, 2, 2);
            textBoxInfo_KDS.Multiline = true;
            textBoxInfo_KDS.Name = "textBoxInfo_KDS";
            textBoxInfo_KDS.ReadOnly = true;
            textBoxInfo_KDS.Size = new Size(334, 146);
            textBoxInfo_KDS.TabIndex = 1;
            textBoxInfo_KDS.Text = resources.GetString("textBoxInfo_KDS.Text");
            // 
            // buttonOk_KDS
            // 
            buttonOk_KDS.Location = new Point(479, 174);
            buttonOk_KDS.Margin = new Padding(2, 2, 2, 2);
            buttonOk_KDS.Name = "buttonOk_KDS";
            buttonOk_KDS.Size = new Size(78, 20);
            buttonOk_KDS.TabIndex = 2;
            buttonOk_KDS.Text = "Ok";
            buttonOk_KDS.UseVisualStyleBackColor = true;
            buttonOk_KDS.Click += buttonOk_KDS_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 202);
            Controls.Add(buttonOk_KDS);
            Controls.Add(textBoxInfo_KDS);
            Controls.Add(pictureBoxAvatar_KDS);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2, 2, 2, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_KDS).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxAvatar_KDS;
        private TextBox textBoxInfo_KDS;
        private Button buttonOk_KDS;
    }
}