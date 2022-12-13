namespace doamci3
{
    public partial class Form1 : Form
    {

        int rezultat = 0;
        string operacija = "";
        bool priakazRezultata = false;


        public Form1()
        {
            InitializeComponent();
        }

        private void Buttons_Click(object sender, EventArgs e)
        {
            if (priakazRezultata) 
            {
                txtIspis.Text = ((Button)sender).Text;
                priakazRezultata = false;
            }
            else
            {
                txtIspis.AppendText(((Button)sender).Text);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void btnJed_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {

        }
    }
}