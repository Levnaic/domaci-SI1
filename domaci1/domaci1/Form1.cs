namespace domaci1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string course = txtCourse.Text;
            string yearOfStudy = cbxYearOfStudy.SelectedItem.ToString();
            int day = dtDateOfBirth.Value.Day;
            int month = dtDateOfBirth.Value.Month;
            int year = dtDateOfBirth.Value.Year;
            string gender = "";

            if (rbMale.Checked)
            {
                gender = rbMale.Text;
            }
            else
            {
                gender = rbWoman.Text;
            }

            MessageBox.Show("Student: " + firstName + " " + lastName + "\n" +
        "Godina rodjenja: " + year + "\n" +
        "Pol: " + gender + "\n" +
        "Godina studija: " + yearOfStudy + "\n" +
        "Smer: " + course);
        }

    }
}
}