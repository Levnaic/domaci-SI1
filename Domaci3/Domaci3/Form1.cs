namespace Domaci3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String CalTotal;
        int num1;
        int num2;
        string optional;
        int result;

        private void btn1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn9.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn0.Text;
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            optional = "+";
            num1 = int.Parse(txtDisplay.Text);

            txtDisplay.Text = ("");
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            optional = "-";
            num1 = int.Parse(txtDisplay.Text);

            txtDisplay.Text = ("");
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            optional = "/";
            num1 = int.Parse(txtDisplay.Text);

            txtDisplay.Text = ("");
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            optional = "*";
            num1 = int.Parse(txtDisplay.Text);

            txtDisplay.Text = ("");
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            optional = "sqrt";
            num1 = int.Parse(txtDisplay.Text);

            txtDisplay.Text = ("");
        }

        private void btnSqr_Click(object sender, EventArgs e)
        {
            optional = "sqr";
            num1 = int.Parse(txtDisplay.Text);

            txtDisplay.Text = ("");
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            optional = "r";
            num1 = int.Parse(txtDisplay.Text);

            txtDisplay.Text = ("");
        }
    }
}