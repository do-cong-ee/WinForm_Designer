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
            grpBar = new GroupBox();
            pgdummy = new ProgressBar();
            tbDummy = new TrackBar();
            grpForm = new GroupBox();
            btnMsgBox = new Button();
            btnModaless = new Button();
            btnModal = new Button();
            grpTreeList = new GroupBox();
            btnAddChild = new Button();
            btnAddRoot = new Button();
            lvDummy = new ListView();
            tvDummy = new TreeView();
            GroupBox.SuspendLayout();
            grpBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbDummy).BeginInit();
            grpForm.SuspendLayout();
            grpTreeList.SuspendLayout();
            SuspendLayout();
            // 
            // GroupBox
            // 
            GroupBox.Controls.Add(txtSampleText);
            GroupBox.Controls.Add(chkItalic);
            GroupBox.Controls.Add(chkBold);
            GroupBox.Controls.Add(cboBox);
            GroupBox.Controls.Add(lblFont);
            GroupBox.Location = new Point(50, 22);
            GroupBox.Name = "GroupBox";
            GroupBox.Size = new Size(680, 205);
            GroupBox.TabIndex = 0;
            GroupBox.TabStop = false;
            GroupBox.Text = "ComboBox, CheckBox, TextBox";
            // 
            // txtSampleText
            // 
            txtSampleText.Location = new Point(34, 153);
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
            // grpBar
            // 
            grpBar.Controls.Add(pgdummy);
            grpBar.Controls.Add(tbDummy);
            grpBar.Location = new Point(50, 255);
            grpBar.Name = "grpBar";
            grpBar.Size = new Size(680, 204);
            grpBar.TabIndex = 5;
            grpBar.TabStop = false;
            grpBar.Text = "TrackBar && PrograssBar";
            grpBar.Enter += groupBox1_Enter;
            // 
            // pgdummy
            // 
            pgdummy.Location = new Point(34, 134);
            pgdummy.Maximum = 20;
            pgdummy.Name = "pgdummy";
            pgdummy.Size = new Size(577, 47);
            pgdummy.TabIndex = 1;
            // 
            // tbDummy
            // 
            tbDummy.Location = new Point(33, 38);
            tbDummy.Maximum = 20;
            tbDummy.Name = "tbDummy";
            tbDummy.Size = new Size(575, 90);
            tbDummy.TabIndex = 0;
            tbDummy.Scroll += tbDummy_Scroll;
            // 
            // grpForm
            // 
            grpForm.Controls.Add(btnMsgBox);
            grpForm.Controls.Add(btnModaless);
            grpForm.Controls.Add(btnModal);
            grpForm.Location = new Point(73, 508);
            grpForm.Name = "grpForm";
            grpForm.Size = new Size(649, 134);
            grpForm.TabIndex = 6;
            grpForm.TabStop = false;
            grpForm.Text = "Modal & Modaless";
            grpForm.Enter += groupBox1_Enter_1;
            // 
            // btnMsgBox
            // 
            btnMsgBox.Location = new Point(359, 55);
            btnMsgBox.Name = "btnMsgBox";
            btnMsgBox.Size = new Size(243, 53);
            btnMsgBox.TabIndex = 2;
            btnMsgBox.Text = "MassageBox";
            btnMsgBox.UseVisualStyleBackColor = true;
            btnMsgBox.Click += btnMsgBox_Click;
            // 
            // btnModaless
            // 
            btnModaless.Location = new Point(193, 55);
            btnModaless.Name = "btnModaless";
            btnModaless.Size = new Size(160, 53);
            btnModaless.TabIndex = 1;
            btnModaless.Text = "Modaless";
            btnModaless.UseVisualStyleBackColor = true;
            btnModaless.Click += btnModaless_Click;
            // 
            // btnModal
            // 
            btnModal.Location = new Point(27, 55);
            btnModal.Name = "btnModal";
            btnModal.Size = new Size(160, 53);
            btnModal.TabIndex = 0;
            btnModal.Text = "Modal";
            btnModal.UseVisualStyleBackColor = true;
            btnModal.Click += btnModal_Click;
            // 
            // grpTreeList
            // 
            grpTreeList.Controls.Add(btnAddChild);
            grpTreeList.Controls.Add(btnAddRoot);
            grpTreeList.Controls.Add(lvDummy);
            grpTreeList.Controls.Add(tvDummy);
            grpTreeList.Location = new Point(77, 715);
            grpTreeList.Name = "grpTreeList";
            grpTreeList.Size = new Size(647, 352);
            grpTreeList.TabIndex = 7;
            grpTreeList.TabStop = false;
            grpTreeList.Text = "TreeView & ListView";
            // 
            // btnAddChild
            // 
            btnAddChild.Location = new Point(189, 278);
            btnAddChild.Name = "btnAddChild";
            btnAddChild.Size = new Size(155, 55);
            btnAddChild.TabIndex = 3;
            btnAddChild.Text = "자식추가";
            btnAddChild.UseVisualStyleBackColor = true;
            btnAddChild.Click += btnAddChild_Click;
            // 
            // btnAddRoot
            // 
            btnAddRoot.Location = new Point(21, 278);
            btnAddRoot.Name = "btnAddRoot";
            btnAddRoot.Size = new Size(157, 55);
            btnAddRoot.TabIndex = 2;
            btnAddRoot.Text = "루트 추가";
            btnAddRoot.UseVisualStyleBackColor = true;
            btnAddRoot.Click += btnAddRoot_Click;
            // 
            // lvDummy
            // 
            lvDummy.Location = new Point(317, 51);
            lvDummy.Name = "lvDummy";
            lvDummy.Size = new Size(297, 207);
            lvDummy.TabIndex = 1;
            lvDummy.UseCompatibleStateImageBehavior = false;
            lvDummy.View = View.Details;
            // 
            // tvDummy
            // 
            tvDummy.Location = new Point(25, 51);
            tvDummy.Name = "tvDummy";
            tvDummy.Size = new Size(260, 203);
            tvDummy.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(791, 1120);
            Controls.Add(grpTreeList);
            Controls.Add(grpForm);
            Controls.Add(grpBar);
            Controls.Add(GroupBox);
            Name = "Form1";
            Text = "이잉기";
            Load += Form1_Load;
            GroupBox.ResumeLayout(false);
            GroupBox.PerformLayout();
            grpBar.ResumeLayout(false);
            grpBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbDummy).EndInit();
            grpForm.ResumeLayout(false);
            grpTreeList.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GroupBox;
        private CheckBox chkBold;
        private ComboBox cboBox;
        private Label lblFont;
        private TextBox txtSampleText;
        private CheckBox chkItalic;
        private GroupBox grpBar;
        private ProgressBar pgdummy;
        private TrackBar tbDummy;
        private GroupBox grpForm;
        private Button btnModal;
        private Button btnMsgBox;
        private Button btnModaless;
        private GroupBox grpTreeList;
        private Button btnAddRoot;
        private ListView lvDummy;
        private TreeView tvDummy;
        private Button btnAddChild;
    }
}
