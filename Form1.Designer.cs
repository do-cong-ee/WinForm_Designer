namespace WinFormsApp2
{
    partial class Form1
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
            GroupBox = new GroupBox();
            txtSampleText = new TextBox();
            chkItalic = new CheckBox();
            chkBold = new CheckBox();
            cboBox = new ComboBox();
            lblFont = new Label();
            GroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // GroupBox
            // 
            GroupBox.Controls.Add(txtSampleText);
            GroupBox.Controls.Add(chkItalic);
            GroupBox.Controls.Add(chkBold);
            GroupBox.Controls.Add(cboBox);
            GroupBox.Controls.Add(lblFont);
            GroupBox.Location = new Point(53, 51);
            GroupBox.Name = "GroupBox";
            GroupBox.Size = new Size(680, 339);
            GroupBox.TabIndex = 0;
            GroupBox.TabStop = false;
            GroupBox.Text = "ComboBox, CheckBox, TextBox";
            // 
            // txtSampleText
            // 
            txtSampleText.Location = new Point(47, 181);
            txtSampleText.Name = "txtSampleText";
            txtSampleText.Size = new Size(591, 39);
            txtSampleText.TabIndex = 4;
            txtSampleText.Text = "Hello C#";
            // 
            // chkItalic
            // 
            chkItalic.AutoSize = true;
            chkItalic.Font = new Font("맑은 고딕 Semilight", 9F, FontStyle.Italic, GraphicsUnit.Point, 129);
            chkItalic.Location = new Point(507, 87);
            chkItalic.Name = "chkItalic";
            chkItalic.Size = new Size(118, 36);
            chkItalic.TabIndex = 3;
            chkItalic.Text = "이탤릭";
            chkItalic.UseVisualStyleBackColor = true;
            chkItalic.CheckedChanged += chkItalic_CheckedChanged;
            // 
            // chkBold
            // 
            chkBold.AutoSize = true;
            chkBold.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            chkBold.Location = new Point(407, 87);
            chkBold.Name = "chkBold";
            chkBold.Size = new Size(94, 36);
            chkBold.TabIndex = 2;
            chkBold.Text = "굵게";
            chkBold.UseVisualStyleBackColor = true;
            chkBold.CheckedChanged += cboBold_CheckedChanged;
            // 
            // cboBox
            // 
            cboBox.FormattingEnabled = true;
            cboBox.Location = new Point(119, 87);
            cboBox.Name = "cboBox";
            cboBox.Size = new Size(252, 40);
            cboBox.TabIndex = 1;
            cboBox.SelectedIndexChanged += cboFont_SelectedIndexChanged;
            // 
            // lblFont
            // 
            lblFont.AutoSize = true;
            lblFont.Location = new Point(33, 93);
            lblFont.Name = "lblFont";
            lblFont.Size = new Size(62, 32);
            lblFont.TabIndex = 0;
            lblFont.Text = "Font";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(GroupBox);
            Name = "Form1";
            Text = "이잉기";
            Load += Form1_Load;
            GroupBox.ResumeLayout(false);
            GroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GroupBox;
        private CheckBox chkBold;
        private ComboBox cboBox;
        private Label lblFont;
        private TextBox txtSampleText;
        private CheckBox chkItalic;
    }
}
