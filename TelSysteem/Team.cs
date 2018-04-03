using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelSysteem
{
   public class Team
    {
        //fields
        public string Naam;
        public int AantalPunten;
        public int AantalSpelers;
        public int TeamID;
        public string Vereniging;

        //constructor
        public Team()
        {

        }
        public Team(string Naam, string Vereniging)
        {
            this.Naam = Naam;
            this.Vereniging = Vereniging;

        }

        //methods
        public static Team GetTeams1(string Teamnaam)
        {
            DatabaseAcces Data = new DatabaseAcces();
            List<string> info1 = new List<string>();
            List<string> info2 = new List<string>();
            Team Team1 = new Team();
            info1 = Data.WhereRequest("Naam", "Team", "Naam", Teamnaam);
            info2 = Data.WhereRequest("TeamID", "Team", "Naam", Teamnaam);
            Team1.Naam = info1[0];
            Team1.TeamID = Convert.ToInt32(info2[0]);
            return Team1;
        }
        public List<Team> GetTeams(string vereniging)
        {
            DatabaseAcces Data = new DatabaseAcces();
            List<Team> Teams = new List<Team>();
            Teams = Data.WhereTeamRequest("Naam", "Team", "VerenigingIDFK", vereniging);
            return Teams;
        }
        public int GetTeamID(string team)
        {
            DatabaseAcces Data = new DatabaseAcces();

            int Teams;
            Teams = Data.WhereRequestInner("TeamID", "Team", "Naam", team);
            return Teams;
        }
    }
}
