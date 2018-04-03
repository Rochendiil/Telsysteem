using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TelSysteem
{
   public class DatabaseAcces
    {
        //Fields
        private string applicationpath = AppDomain.CurrentDomain.BaseDirectory;
        private string connectstring;

        public DatabaseAcces()
        {
            connectstring = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =" + applicationpath + "Database1.mdf;Integrated Security=True";
        }

        //Methods
        public List<string> Columnrequest(string column, string table)
        {
            List<string> info = new List<string>();
            SqlConnection sqlconn = new SqlConnection(connectstring);
            sqlconn.Open();
            string query = "SELECT " + column + " FROM " + table;
            SqlCommand cmd = new SqlCommand(query, sqlconn);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read()) info.Add(Convert.ToString(reader[column]));
                sqlconn.Close();
                return info;
            }
        }
        public List<string> WhereRequest(string column, string table, string where, string equalswhat)
        {
            List<string> infowhere = new List<string>();
            SqlConnection sqlconn = new SqlConnection(connectstring);
            sqlconn.Open();
            string query = "SELECT * FROM " + table + " WHERE " + where + "=" + "\'" + equalswhat + "\'";
            SqlCommand cmd = new SqlCommand(query, sqlconn);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read()) infowhere.Add(Convert.ToString(reader[column]));
                sqlconn.Close();
                return infowhere;
            }
        }
        public List<Team> WhereTeamRequest(string column, string table, string where, string equalswhat)
        {
            List<Team> infowhere = new List<Team>();
            SqlConnection sqlconn = new SqlConnection(connectstring);
            string Naam = "";
            string Vereneging1 = "";
            sqlconn.Open();
            string query = "SELECT * FROM " + table + " WHERE " + where + "=" + "\'" + equalswhat + "\'";
            SqlCommand cmd = new SqlCommand(query, sqlconn);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Naam = Convert.ToString(reader["Naam"]);
                    Vereneging1 = Convert.ToString(reader["VerenigingIDFK"]);
                    Team Team1 = new Team(Naam, Vereneging1);
                    infowhere.Add(Team1);
                }
                sqlconn.Close();
                return infowhere;
            }
        }
        public int WhereRequestInner(string column, string table, string where, string equalswhat)
        {
            int infowhere = 12;
            SqlConnection sqlconn = new SqlConnection(connectstring);
            sqlconn.Open();
            string query = "SELECT * FROM " + table + " WHERE " + where + "=" + "\'" + equalswhat + "\'";
            SqlCommand cmd = new SqlCommand(query, sqlconn);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                infowhere = Convert.ToInt32(reader[column]);
                sqlconn.Close();
                return infowhere;
            }
        }

        public List<Speler> SelectSpelers(string table, string where, string equalswhat)
        {
            SqlConnection sqlconn = new SqlConnection(connectstring);
            sqlconn.Open();
            int ID = 0;
            int Rugnummer = 0;
            List<Speler> Info = new List<Speler>();
            string query = "SELECT * FROM " + table + " WHERE " + where + "=" + "\'" + equalswhat + "\'";
            SqlCommand cmd = new SqlCommand(query, sqlconn);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    ID = Convert.ToInt32(reader["SpelerID"]);
                    Rugnummer = Convert.ToInt32(reader["Rugnummer"]);
                    Speler Speler1 = new Speler(ID, Rugnummer);
                    Info.Add(Speler1);
                }
                sqlconn.Close();
                return Info;
            }
        }
        public List<Vereniging> GetVereniging(string table)
        {
            SqlConnection sqlconn = new SqlConnection(connectstring);
            sqlconn.Open();
            string Naam = "";
            List<Vereniging> Info = new List<Vereniging>();
            string query = "SELECT * FROM " + table;
            SqlCommand cmd = new SqlCommand(query, sqlconn);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Naam = Convert.ToString(reader["VerenigingID"]);
                    Vereniging vereniging = new Vereniging(Naam);
                    Info.Add(vereniging);
                }
                sqlconn.Close();
                return Info;
            }
        }
        public int Getlidbyid(string where, string equalswhat)
        {
            SqlConnection sqlconn = new SqlConnection(connectstring);
            sqlconn.Open();
            int ID = 0;
            string query = "SELECT * FROM Speler WHERE " + where + "=" + "\'" + equalswhat + "\'";
            SqlCommand cmd = new SqlCommand(query, sqlconn);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    ID = Convert.ToInt32(reader["LidIDFK"]);
                }
                sqlconn.Close();
                return ID;
            }
        }
        public Lid getinfoLid(string where, string equalswhat)
        {
            SqlConnection sqlconn = new SqlConnection(connectstring);
            sqlconn.Open();
            List<Lid> info = new List<Lid>();
            string query = "SELECT * FROM Lid WHERE " + where + "=" + "\'" + equalswhat + "\'";
            SqlCommand cmd = new SqlCommand(query, sqlconn);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                string Naam = "";
                string Nevobonummer = "";
                int LidNummer = 0;
                while (reader.Read())
                {
                    Naam = reader["Naam"].ToString();
                    Nevobonummer = reader["Nevobonummer"].ToString();
                    LidNummer = Convert.ToInt32(reader["LidID"]);
                }
                Lid lid1 = new Lid(Naam, Nevobonummer, LidNummer);
                sqlconn.Close();
                return lid1;
            }
        }
        public int getrugnummer(string where, string equalswhat)
        {
            SqlConnection sqlconn = new SqlConnection(connectstring);
            sqlconn.Open();
            int rugnummer = 0;
            string query = "SELECT * FROM Speler WHERE " + where + "=" + "\'" + equalswhat + "\'";
            SqlCommand cmd = new SqlCommand(query, sqlconn);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    rugnummer = Convert.ToInt32(reader["Rugnummer"]);
                }
                sqlconn.Close();
                return rugnummer;
            }
        }
    }
}
