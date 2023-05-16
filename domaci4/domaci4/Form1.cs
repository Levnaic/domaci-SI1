namespace domaci4
{
    public partial class Form1 : Form
    {
        List<Profesori> profesori= new List<Profesori>();
        public Form1()
        {
            InitializeComponent();
            dgProfesori.Columns.Add("imeProfesora", "Ime");
            dgProfesori.Columns.Add("prezimeProfesora", "Prezime");
            dgProfesori.Columns.Add("zvanje", "Zvanje Profesora");
            dgProfesori.Columns.Add("katedra", "Katedra Profesora");
        
            dgProfesori.AllowUserToAddRows= false;
            dgProfesori.AllowUserToDeleteRows= false;
            dgProfesori.ReadOnly=true;
        }

        private void popuniTabelu()
        {
            dgProfesori.Rows.Clear();
            if(profesori.Count > 0 )
            {
                foreach(Profesori prof in profesori)
                {
                    dgProfesori.Rows.Add(prof.Ime, prof.Prezime, prof.Zvanje, prof.Katedra);
                }
            }
        }

        private void ponistiUnos()
        {
            txtIme.Text = "";
            txtPrezime.Text = "";
            txtZvanje.Text = "";
            txtKatedra.Text = "";
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                Profesori prof= new Profesori();
                prof.Ime = txtIme.Text;
                prof.Prezime = txtPrezime.Text;
                prof.Zvanje = txtZvanje.Text;
                prof.Katedra = txtKatedra.Text;

                profesori.Add(prof);

                popuniTabelu();
                ponistiUnos();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}