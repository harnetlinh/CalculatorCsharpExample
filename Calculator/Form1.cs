namespace Calculator
{
    public partial class Form1 : Form
    {
        int numA;
        int numB;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            if (tbNumA.Text == "" || tbNumB.Text == "")
            {
                MessageBox.Show("Ban phai nhap A va B");
                return;
            }
            numA = Convert.ToInt32(tbNumA.Text);
            numB = Convert.ToInt32(tbNumB.Text);
            int numC = numA + numB;
            tbNumC.Text = numC.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbNumA.Text = "";
            tbNumB.Text = "";
            tbNumC.Text = "";
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            //TODO: finish it
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            //TODO: finish it
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            //TODO: finish it
        }
    }
}