using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace domaci6
{
    internal class Predmet
    {
        private int id;
        private string imePredmeta;
        private int brojCasova;
        private string profesor;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string ImePredmeta
        {
            get { return imePredmeta; }
            set
            {
                if (imePredmeta == "") throw new Exception("Morate uneti ime predmeta!!!");
                imePredmeta = value;
            }
        }

        public int BrojCasova
        {
            get { return brojCasova; }
            set
            {
                if (BrojCasova == 0) throw new Exception("Morate uneti broj casova!!!");
                brojCasova = value;
            }
        }

        public string Profesor
        {
            get { return profesor; }
            set
            {
                if (Profesor == null) throw new Exception("Morate uneti ime profesora!!!");
                profesor = value;
            }
        }

        private string _connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\ProfesorDB.mdf;Integrated Security=True";

        public void dodajPredmet()
        {
            string insertSql = "INSERT INTO T_PREDMET " +
                "(ImePredmeta, BrojCasova, ProfesorKojiPredaje) VALUES " +
                "(@ImePredmeta, @BrojCasova, @ProfesorKojiPredaje)";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandText = insertSql;
                command.Parameters.Add(new SqlParameter("@ImePredmeta", ImePredmeta));
                command.Parameters.Add(new SqlParameter("@BrojCasova", BrojCasova));
                command.Parameters.Add(new SqlParameter("@ProfesorKojiPredaje", Profesor));
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void azurirajPredmet()
        {
            string updateSql =
                "UPDATE T_PREDMET " +
                "SET ImePredmeta = @ImePredmeta, BrojCasova = @BrojCasova, ProfesorKojiPredaje = @ProfesorKojiPredaje " +
                "WHERE PredmetID = @PredmetId";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandText = updateSql;
                command.Parameters.Add(new SqlParameter("@PredmetId", ID));
                command.Parameters.Add(new SqlParameter("@ImePredmeta", ImePredmeta));
                command.Parameters.Add(new SqlParameter("@BrojCasova", BrojCasova));
                command.Parameters.Add(new SqlParameter("@ProfesorKojiPredaje", Profesor));
                connection.Open();
                command.ExecuteNonQuery();
            }

        }

        public void obrisiPredmet()
        {
            string deleteSql =
                "DELETE FROM T_PREDMET WHERE PredmetId = @PredmetId;";
            
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandText = deleteSql;
                command.Parameters.Add(new SqlParameter("@ProfesorId", ID));
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public List<Predmet> ucitajPredmete()
        {
            List<Predmet> predmeti = new List<Predmet>();
            string queryString =
                "SELECT * FROM T_PREDMET;";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandText = queryString;
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    Predmet pred;
                    while (reader.Read())
                    {
                        pred = new Predmet();
                        pred.ID = Int32.Parse(reader["PredmetId"].ToString());
                        pred.ImePredmeta = reader["ImePredmeta"].ToString();
                        pred.BrojCasova = Int32.Parse(reader["BrojCasova"].ToString());
                        pred.Profesor = reader["Profesor"].ToString();
                        predmeti.Add(pred);
                    }
                }
            }

            return predmeti;
        }



    }
}
