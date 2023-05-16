namespace domaci6
{
    public partial class Form1 : Form
    {
        List<Predmet> predmetList = new List<Predmet>();
        string akcija = "";
        int indeksSelektovanog = -1;

        public Form1()
        {
            InitializeComponent();
            
            dgPredmeti.AllowUserToAddRows= false;
            dgPredmeti.AllowUserToDeleteRows= false;
            dgPredmeti.ReadOnly = true;
            dgPredmeti.AutoGenerateColumns= false;

            dgPredmeti.Columns.Add("ID", "ID");
            dgPredmeti.Columns["ID"].Visible= false;
        }
    }
}