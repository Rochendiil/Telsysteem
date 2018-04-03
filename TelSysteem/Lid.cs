using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelSysteem
{
   public class Lid
    {
        public string Naam;
        public string NevoboNummer;
        public int LidNummer;

        public Lid(string Naam, string NevoboNummer, int LidNummer)
        {
            this.Naam = Naam;
            this.NevoboNummer = NevoboNummer;
            this.LidNummer = LidNummer;
        }
    }
}
