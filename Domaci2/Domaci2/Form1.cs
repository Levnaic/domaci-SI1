namespace Domaci2
{
    public partial class racunanjeTrougla : Form
    {
        public racunanjeTrougla()
        {
            InitializeComponent();
        }

        private void rbRaznostranicni_CheckedChanged(object sender, EventArgs e)
        {
            txtA.Enabled = true;
            txtB.Enabled = true;
            txtC.Enabled = true;

            lblA.Enabled = true;
            lblB.Enabled = true;
            lblC.Enabled = true;

            lblA.Text = "Stranica A";
            lblB.Text = "Stranica B";
            lblC.Text = "Stranica C";

        }

        private void rbJednakokraki_CheckedChanged(object sender, EventArgs e)
        {
            txtA.Enabled = true;
            txtB.Enabled = true;
            txtC.Enabled = false;

            lblA.Enabled = true;
            lblB.Enabled = true;
            lblC.Enabled = false;

            lblA.Text = "Stranica A";
            lblB.Text = "Stranice B i C";
            lblC.Text = "Stranica C";

        }

        private void rbJednakostranicni_CheckedChanged(object sender, EventArgs e)
        {
            txtA.Enabled = true;
            txtB.Enabled = false;
            txtC.Enabled = false;

            lblA.Enabled = true;
            lblB.Enabled = false;
            lblC.Enabled = false;

            lblA.Text = "Stranice A, B i C";
            lblB.Text = "Stranica B";
            lblC.Text = "Stranica C";

        }

        private void btnRacunaj_Click(object sender, EventArgs e)
        {
            if (rbRaznostranicni.Checked) 
            {
                Raznostranicni r = new Raznostranicni(Convert.ToDouble(txtA.Text), Convert.ToDouble(txtB.Text), Convert.ToDouble(txtC.Text));
                MessageBox.Show("Obim: " + r.Obim() + "\n" + "Povrsina: " + r.Povrsina());
            }
            else if(rbJednakokraki.Checked)
            {
                Jednakokraki jk = new Jednakokraki(Convert.ToDouble(txtA.Text), Convert.ToDouble(txtB.Text));
                MessageBox.Show("Obim: " + jk.Obim() + "\n" + "Povrsina: " + jk.Povrsina());
            }
            else if (rbJednakostranicni.Checked)
            {
                Jednakostranicni js = new Jednakostranicni(Convert.ToDouble(txtA.Text));
                MessageBox.Show("Obim: " + js.Obim() + "\n" + "Povrsina: " + js.Povrsina());
            }
            else
            {
                MessageBox.Show("Morate izabrati trougao!!");
            }

        }
    }
}