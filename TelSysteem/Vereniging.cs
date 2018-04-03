using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelSysteem
{
   public class Vereniging
    {
        //field
       public string Naam = "";

        //Constructors
        public Vereniging(string Naam)
        {
            this.Naam = Naam;

        }

        //Methods
        public List<Vereniging> FindVereniging()
        {
            DatabaseAcces Data = new DatabaseAcces();
            List<Vereniging> Verenigingen = new List<Vereniging>();
            Verenigingen = Data.GetVereniging("Vereniging");
            return Verenigingen;
        }
    }
}
