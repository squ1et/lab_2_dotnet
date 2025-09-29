namespace lab_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void oneDimArrayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OneDimForm f = new OneDimForm();
            f.Show();
            this.Hide();
        }

        private void twoDimArrayToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            TwoDimForm f = new TwoDimForm();
            f.Show();
            this.Hide();   
        }
    }
}
