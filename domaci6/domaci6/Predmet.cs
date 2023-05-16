using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            //OVDE SI STAO
        }



    }
}
