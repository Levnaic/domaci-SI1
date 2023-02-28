namespace Domaci5
{
    public partial class Form1 : Form
    {
        // Lista u kojoj ce se nalaziti podaci o studentima
        List<Student> studentiList = new List<Student>();
        // Promenljiva koja cuva informaciju koja akcija je odabrana
        string akcija = "";
        // Promenljiva koja cuva indeks selektovanog reda
        int indeksSelektovanog = -1;


        // Konstruktor forme

        public Form1()
        {
            InitializeComponent();

            // Podesavanja DataGridView kontrole
            // Nije dozvoljeno korisniku da dodaje redove direktno u kontroli
            // vec samo kroz tekstualna polja
            dgStudenti.AllowUserToAddRows = false;
            // Nije dozvoljeno korisniku da brise redove sa podacima
            dgStudenti.AllowUserToDeleteRows = false;
            // Korisnik ne moze da menja sadrzaj u poljima, vec samo da ih cita
            dgStudenti.ReadOnly = true;
            // Ne zelimo da kontrola sama generise imena kolona, 
            // vec cemo to uraditi kroz kod
            dgStudenti.AutoGenerateColumns = false;

            // Dodajemo kolone u DataGridView kontrolu.
            // Naziv kolone je "ID". 
            // Tekst u zaglavlju je "ID", kolona nece biti vidljiva
            dgStudenti.Columns.Add("ID", "ID");
            dgStudenti.Columns["ID"].Visible = false;
            // Naziv kolone je "brojIndeksa". 
            // Tekst prikazan u zaglavlju je "Indeks"
            dgStudenti.Columns.Add("brojIndeksa", "Indeks");
            // Naziv kolone je "imeStudenta". 
            // Tekst prikazan u zaglavlju je "Ime"
            dgStudenti.Columns.Add("imeStudenta", "Ime");
            // Naziv kolone je "prezimeStudenta". 
            // Tekst prikazan u zaglavlju je "Prezime"
            dgStudenti.Columns.Add("prezimeStudenta", "Prezime");
            // Naziv kolone je "smer". 
            // Tekst prikazan u zaglavlju je "Smer"
            dgStudenti.Columns.Add("smer", "Smer");
            // Naziv kolone je "prosek". 
            // Tekst prikazan u zaglavlju je "Prosek"
            dgStudenti.Columns.Add("prosek", "Prosek");
            // Pozivamo pomocne metode koje ce kreirati odgovarajuci 
            // izgled komponenti na formi: tekstualnih polja i dugmica.
            txtDisabled();
            btnChangeEnabled();
            btnSubmitDisabled();

            // Ucitavaju se svi studenti koji se vec nalaze u bazi i 
            // prikazuju se u okviru DataGridView kontrole. 
            prikaziStudenteDGV();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // Pomocna metoda koja onemogucava upis u tekstualna polja
        private void txtDisabled()
        {
            txtBrojIndeksa.Enabled = false;
            txtIme.Enabled = false;
            txtPrezime.Enabled = false;
            txtSmer.Enabled = false;
            txtProsek.Enabled = false;
        }

        // Pomocna metoda koja omogucava upis u tekstualna polja
        private void txtEnabled()
        {
            txtBrojIndeksa.Enabled = true;
            txtIme.Enabled = true;
            txtPrezime.Enabled = true;
            txtSmer.Enabled = true;
            txtProsek.Enabled = true;
        }

        // Pomocna metoda koja onemogucava rad sa dugmicima dodaj, promeni i obrisi
        private void btnChangeDisabled()
        {
            btnDodaj.Enabled = false;
            btnPromeni.Enabled = false;
            btnObrisi.Enabled = false;
        }

        // Pomocna metoda koja omogucava rad sa dugmicima dodaj, promeni i obrisi
        private void btnChangeEnabled()
        {
            btnDodaj.Enabled = true;
            btnPromeni.Enabled = true;
            btnObrisi.Enabled = true;
        }

        // Pomocna metoda koja onemogucava rad sa dugmicima potvrdi i odustani
        private void btnSubmitDisabled()
        {
            btnPotvrdi.Enabled = false;
            btnOdustani.Enabled = false;
        }

        // Pomocna metoda koja omogucava rad sa dugmicima potvrdi i odustani
        private void btnSubmitEnabled()
        {
            btnPotvrdi.Enabled = true;
            btnOdustani.Enabled = true;
        }

        // Pomocna metoda koja ponistava unos u tekstualnim poljima
        private void ponistiUnosTxt()
        {
            txtBrojIndeksa.Text = "";
            txtIme.Text = "";
            txtPrezime.Text = "";
            txtSmer.Text = "";
            txtProsek.Text = "";
        }

        // Metoda koja prikazuje podatke o odabranom studentu (selektovanom redu) 
        // u tekstualnim poljima
        private void prikaziStudentaTxt()
        {
            int idSelektovanog = (int)dgStudenti.SelectedRows[0].Cells["ID"].Value;
            Student selektovaniStudent =
                studentiList.Where(x => x.ID == idSelektovanog).FirstOrDefault();
            if (selektovaniStudent != null)
            {
                txtBrojIndeksa.Text = selektovaniStudent.Indeks;
                txtIme.Text = selektovaniStudent.Ime;
                txtPrezime.Text = selektovaniStudent.Prezime;
                txtSmer.Text = selektovaniStudent.Smer;
                txtProsek.Text = selektovaniStudent.Prosek.ToString();
            }
        }

        // Metoda koja prikazuje podatke o svim studentima u DataGridView kontroli 
        private void prikaziStudenteDGV()
        {
            // Ucitavaju se podaci o svim studentima iz baze podataka
            studentiList = new Student().ucitajStudente();
            // Brisu se svi studenti koji su prikazani u DataGridView kontroli
            dgStudenti.Rows.Clear();
            // Prikazuju se podaci u DataGridView kontroli tako sto se dodaju
            // novi redovi, a zatim se u odgovarajuce celije upisuju vrednosti
            for (int i = 0; i < studentiList.Count; i++)
            {
                dgStudenti.Rows.Add();
                dgStudenti.Rows[i].Cells["ID"].Value =
                    studentiList[i].ID;
                dgStudenti.Rows[i].Cells["brojIndeksa"].Value =
                    studentiList[i].Indeks;
                dgStudenti.Rows[i].Cells["imeStudenta"].Value =
                    studentiList[i].Ime;
                dgStudenti.Rows[i].Cells["prezimeStudenta"].Value =
                    studentiList[i].Prezime;
                dgStudenti.Rows[i].Cells["smer"].Value =
                    studentiList[i].Smer;
                dgStudenti.Rows[i].Cells["prosek"].Value =
                    studentiList[i].Prosek;
            }
            // Ponistava se unos u tekstualnim poljima
            ponistiUnosTxt();
            // DataGridView podrazumevano selektuje prvi red prvu kolonu
            // sto za nas nije zeljeno ponasanje
            dgStudenti.CurrentCell = null;
            // Ukoliko ima podataka o studentima u bazi selektuj red i 
            // prikazi podatke o tom studentu u tekstulanim poljima
            if (studentiList.Count > 0)
            {
                if (indeksSelektovanog != -1)
                    dgStudenti.Rows[indeksSelektovanog].Selected = true;
                else
                    dgStudenti.Rows[0].Selected = true;
                prikaziStudentaTxt();
            }
        }

        // Obrada dogadjaja klika na dugme Dodaj
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            // Ponistava se unos u tekstualnim poljima
            ponistiUnosTxt();
            // Omogucava se unos u tekstualna polja
            txtEnabled();
            // Omogucava se klik na dugmice potvrdi i odustani, 
            // kako bi se zavrsilo dodavanje novog studenta
            btnSubmitEnabled();
            // Onemogucava se klik na dugmice dodaj, promeni i obrisi
            // dok se ne zavrsi trenutno dodavanje
            btnChangeDisabled();
            // Promenljiva akcija dobija vrednost "dodaj"
            akcija = "dodaj";
        }

        // Obrada dogadjaja klika na dugme Obrisi
        private void btnObrisi_Click(object sender, EventArgs e)
        {
            // Provera da li je neki red selektovan za brisanje
            // Ukoliko nije, korisnik se obavestava porukom
            if (dgStudenti.SelectedRows.Count > 0)
            {
                // Poruka korisniku kojom se od njega trazi da potvrdi brisanje
                if (MessageBox.Show("Da li zelite da obrisete odabranog studenta?",
                "Potvrda brisanja", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // Odredjuje se ID studenta kojeg je potrebno obrisati
                    int idSelektovanog = (int)dgStudenti.SelectedRows[0].Cells["ID"].Value;
                    // Na osnovu ID-a iz liste uzimamo odgovarajuceg studenta
                    Student selektovaniStudent = studentiList.Where(x => x.ID ==
                        idSelektovanog).FirstOrDefault();
                    // Brisanje studenta pomocu metode obrisiStudenta koja se 
                    // nalazi u klasi Student
                    if (selektovaniStudent != null)
                    {
                        selektovaniStudent.obrisiStudenta();
                    }
                    // Nakon brisanja, prikazuje se prvi red u DataGridView kontroli
                    indeksSelektovanog = -1;
                    // Prikaz preostalih studenata u DataGridView kontroli
                    prikaziStudenteDGV();
                }
            }
            else
            {
                MessageBox.Show("Nema podataka ili ni jedan red nije odabran!");
            }
        }

        // Obrada dogadjaja klika na dugme Promeni
        private void btnPromeni_Click(object sender, EventArgs e)
        {
            // Provera da li je neki red selektovan za promenu
            // Ukoliko nije, korisnik se obavestava porukom
            if (dgStudenti.SelectedRows.Count > 0)
            {
                // Omogucava se unos u tekstualna polja
                txtEnabled();
                // Omogucava se klik na dugmice potvrdi i odustani, 
                // kako bi se zavrsila promena studenta
                btnSubmitEnabled();
                // Onemogucava se klik na dugmice dodaj, promeni i obrisi
                // dok se ne zavrsi trenutna promena
                btnChangeDisabled();
                // Promenljiva akcija dobija vrednost "promeni"
                akcija = "promeni";
            }
            else
            {
                MessageBox.Show("Nema podataka ili ni jedan red nije odabran!");
            }
        }

        // Obrada dogadjaja klika na dugme Potvrdi
        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            try
            {
                // Ukoliko je akcija bila "promeni", vrsi se promena 
                // podataka o studentu
                if (akcija == "promeni")
                {
                    // Odredjuje se ID studenta kojeg je potrebno promeniti
                    int idSelektovanog = (int)dgStudenti.SelectedRows[0].Cells["ID"].Value;
                    // Na osnovu ID-a iz liste uzimamo odgovarajuceg studenta
                    Student selektovaniStudent = studentiList.Where(x => x.ID ==
                        idSelektovanog).FirstOrDefault();
                    // Menjaju se vrednosti za ime, prezime i indeks
                    if (selektovaniStudent != null)
                    {
                        selektovaniStudent.Indeks = txtBrojIndeksa.Text;
                        selektovaniStudent.Ime = txtIme.Text;
                        selektovaniStudent.Prezime = txtPrezime.Text;
                        selektovaniStudent.Smer = txtSmer.Text;
                        selektovaniStudent.Prosek = float.Parse(txtProsek.Text);
                        // Izmena podataka o studentu pomocu metode azurirajStudenta 
                        // koja se nalazi u klasi Student. 
                        selektovaniStudent.azurirajStudenta();
                        // Nakon izmene ostaje selektovan isti red
                        indeksSelektovanog = dgStudenti.SelectedRows[0].Index;
                    }
                }
                // Ukoliko je akcija bila "dodaj", vrsi se dodavanje 
                // novog studenta
                else if (akcija == "dodaj")
                {
                    // Kreira se nova instanca klase Student
                    Student stud = new Student();
                    // Postavljaju se vrednosti za ime, prezime i indeks
                    stud.Indeks = txtBrojIndeksa.Text;
                    stud.Ime = txtIme.Text;
                    stud.Prezime = txtPrezime.Text;
                    stud.Smer = txtSmer.Text;
                    stud.Prosek = float.Parse(txtProsek.Text);
                    // Dodavanje podataka o studentu pomocu metode dodajStudenta 
                    // koja se nalazi u klasi Student
                    stud.dodajStudenta();
                    // Nakon dodavanja, selektovan je poslednji red
                    indeksSelektovanog = dgStudenti.Rows.Count;
                }
                // Onemogucava se dalja promena sadrzaja u tekstualnim poljima
                txtDisabled();
                // Onemogucava se klik na dugmice potvrdi i odustani, 
                // sve dok se ponovo ne klikne na dodaj ili promeni
                btnSubmitDisabled();
                // Omogucava se klik na dugmice dodaj, promeni i obrisi
                btnChangeEnabled();
                // Promenljiva akcija dobija vrednost ""
                akcija = "";
                // Prikaz studenata u DataGridView kontroli
                prikaziStudenteDGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Obrada dogadjaja klika na dugme Odustani
        private void btnOdustani_Click(object sender, EventArgs e)
        {
            // Onemogucava se dalja promena sadrzaja u tekstualnim poljima
            txtDisabled();
            // Onemogucava se klik na dugmice potvrdi i odustani, 
            // sve dok se ponovo ne klikne na dodaj ili promeni
            btnSubmitDisabled();
            // Omogucava se klik na dugmice dodaj, promeni i obrisi
            btnChangeEnabled();
        }

        // Obrada dogadjaja klika na celiju u okviru DataGridView kontrole
        private void dgStudenti_CellClick(object sender,
            DataGridViewCellEventArgs e)
        {
            // Ukoliko postoji red na koji je kliknuto
            if (dgStudenti.CurrentRow != null)
            {
                // Selektuje se odabrani red
                dgStudenti.Rows[dgStudenti.CurrentRow.Index].Selected = true;
                // Vrsi se prikaz podataka iz selektovanog reda 
                // u tekstualnim poljima
                prikaziStudentaTxt();
            }
        }
    }
}
