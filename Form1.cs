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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void tbDummy_Scroll(object sender, EventArgs e)
        {
            pgdummy.Value = tbDummy.Value;
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnModal_Click(object sender, EventArgs e)
        {
            Form frm = new Form();
            frm.Text = "Modal Form";
            frm.Width = 300;
            frm.Height = 100;
            frm.BackColor = Color.Red;
            frm.ShowDialog(); // modal Ã¢À» ¶ç¿î´Ù
        }

        private void btnModaless_Click(object sender, EventArgs e)
        {
            Form frm = new Form();
            frm.Text = "Modal Form";
            frm.Width = 300;
            frm.Height = 100;
            frm.BackColor = Color.Red;
            frm.Show();//modaless Ã¢À» ¶ç¿î´Ù.
        }
        
        private void btnMsgBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtSampleText.Text, "MessageBox Test", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }
    }
}
