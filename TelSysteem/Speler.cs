using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelSysteem
{
    public class Speler:Lid
    {
        private  int SpelerID { get; set; }
        private int RugNummer { get; set; }
        //Constructor


        public Speler(int SpelerID, int RugNummer) : base("", "", 0)
        {    
            this.SpelerID = SpelerID;
            this.RugNummer = RugNummer;

        }
        //Methods
        public static List<Speler> GetSpelers(string TeamID)
        {
            DatabaseAcces Data = new DatabaseAcces();
            List<Speler> info1 = new List<Speler>();
            Team Team1 = new Team();
            info1 = Data.SelectSpelers("Speler", "TeamIDFK", TeamID);
            return info1;
        }
        public static List<int> GetSpelerID(List<Speler> Persoon)
        {
            List<int> info = new List<int>();
            foreach (Speler item in Persoon)
            {
               info.Add(item.SpelerID);
            }
            return info;
        }
    }
}
