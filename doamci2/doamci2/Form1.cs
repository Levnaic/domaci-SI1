namespace doamci2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtB.Enabled= false;
            txtC.Enabled= false;
            txtHa.Enabled= false;
        }

        private void radiobutton1_checkedchanged(object sender, eventargs e)
        {

        }

        private void radiobutton1_checkedchanged_1(object sender, eventargs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rbRaznostranicni_CheckedChanged(object sender, EventArgs e)
        {
            txtB.Enabled= true;
            txtC.Enabled= true;
            txtHa.Enabled= true;
        }

        private void rbJednakostranicni_CheckedChanged(Object sender, EventArgs e) 
        {
            txtB.Enabled = false;
            txtC.Enabled= false;
            txtHa.Enabled= false;
        }

        private void rbJednakokraki_CheckedChanged(Object sender, EventArgs e)
        {
            txtB.Enabled= true;
            txtC.Enabled = false;
            txtHa.Enabled= true; 
        }
    }
}