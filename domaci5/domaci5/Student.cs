using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Domaci5
{
    internal class Student
    {
        private int id;
        private string ime;
        private string prezime;
        private string indeks;
        private string smer;
        private float prosek;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Ime
        {
            get { return ime; } 
            set 
            {
                if (value == "") 
                {
                    throw new Exception("Morate uneti ime ucenika!!!");
                }
                else
                {
                    ime = value;
                }
            }
        }

        public string Prezime
        {
            get { return prezime; }
            set
            {
                if (value == "")
                {
                    throw new Exception("Morate uneti prezime ucenika!!!");
                }
                else
                {
                    prezime = value;
                }
            }
        }

        public string Indeks
        {
            get { return indeks; }
            set
            {
                if (value == "")
                {
                    throw new Exception("Morate uneti broj indeksa ucenika!!!");
                }
                else
                {
                    indeks = value;
                }
            }
        }

        public string Smer
        {
            get { return smer; }
            set
            {
                if (value == "")
                {
                    throw new Exception("Morate uneti smer ucenika!!!");
                }
                else
                {
                    smer = value;
                }
            }
        }

        public float Prosek
        {
            get { return prosek; }
            set
            {
                if (value < 6 || value > 10)
                {
                    throw new Exception("Prosek mora biti izmedju 6 i 10!!!");
                }
                else
                {
                    prosek = value;
                }
            }
        }

        private string _connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\StudentDB.mdf;Integrated Security=True";

        public void dodajStudenta()
        {
            string insertSql = "INSERT INTO T_STUDENT " +
                "(BrojIndeksa, Ime, Prezime, Smer, Prosek) VALUES " +
                "(@BrojIndeksa, @Ime, @Prezime, @Smer, @Prosek)";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandText = insertSql;
                command.Parameters.Add(new SqlParameter("@BrojIndeksa", Indeks));
                command.Parameters.Add(new SqlParameter("@Ime", Ime));
                command.Parameters.Add(new SqlParameter("@Prezime", Prezime));
                command.Parameters.Add(new SqlParameter("@Smer", Smer));
                command.Parameters.Add(new SqlParameter("@Prosek", Prosek));
                connection.Open();
                command.ExecuteNonQuery();
            }

        }

        public void azurirajStudenta()
        {
            string updateSql =
                "UPDATE T_STUDENT " +
                "SET BrojIndeksa = @BrojIndeksa, Ime= @Ime, Prezime = @Prezime, " +
                "Smer = @Smer, Prosek = @Prosek " +
                "WHERE StudentId = @StudentId;";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandText = updateSql;
                command.Parameters.Add(new SqlParameter("@StudentId", ID));
                command.Parameters.Add(new SqlParameter("@BrojIndeksa", Indeks));
                command.Parameters.Add(new SqlParameter("@Ime", Ime));
                command.Parameters.Add(new SqlParameter("@Prezime", Prezime));
                command.Parameters.Add(new SqlParameter("@Smer", Smer));
                command.Parameters.Add(new SqlParameter("@Prosek", Prosek));
                connection.Open();
                command.ExecuteNonQuery();
            }

        }

        public void obrisiStudenta()
        {
            string deleteSql =
                "DELETE FROM T_STUDENT WHERE StudentId = @StudentId;";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandText = deleteSql;
                command.Parameters.Add(new SqlParameter("@StudentId", ID));
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public List<Student> ucitajStudente()
        {
            List<Student> students = new List<Student>();
            string queryString =
                "SELECT * FROM T_STUDENT;";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandText = queryString;
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    Student stud;
                    while (reader.Read())
                    {
                        stud = new Student();
                        stud.ID = Int32.Parse(reader["StudentId"].ToString());
                        stud.Indeks = reader["BrojIndeksa"].ToString();
                        stud.Ime = reader["Ime"].ToString();
                        stud.Prezime = reader["Prezime"].ToString();
                        stud.Smer = reader["Smer"].ToString();
                        stud.prosek = Single.Parse(reader["Prosek"].ToString());
                        students.Add(stud);
                    }
                }
            }
            return students;
        }


    }
}
