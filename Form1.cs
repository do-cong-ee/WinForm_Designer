namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var Fonts = FontFamily.Families;
            foreach (FontFamily font in Fonts)
            {
                cboBox.Items.Add(font.Name);
            }
        }

        void ChangeFont()
        {
            if (cboBox.SelectedIndex < 0)
                return;
            FontStyle style = FontStyle.Regular;

            if (chkBold.Checked)
                style |= FontStyle.Bold;
            if (chkItalic.Checked)
                style |= FontStyle.Italic;

            txtSampleText.Font =
                new Font((string)cboBox.SelectedItem, 10, style);
        }

        private void cboFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void cboBold_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void chkItalic_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }
    }
}
