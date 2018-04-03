using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelSysteem
{
    public partial class Form2 : Form
    {
        DatabaseAcces data = new DatabaseAcces();
        public Form2(List<Speler> Team1, List<Speler> Team2)
        {
            InitializeComponent();
            Getlid(Team1, listView_team1);
            Getlid(Team2, listView_team2);

        }
        public void Getlid(List<Speler> team, ListView listview)
        {
            List<int> SpelerID = new List<int>();
            SpelerID = Speler.GetSpelerID(team);
            List<int> ledenID = new List<int>();
            foreach (int item in SpelerID)
            {
                ledenID.Add(data.Getlidbyid("SpelerID", item.ToString()));
            }
            getinfo(ledenID, listview);

        }
        public void getinfo(List<int> ID, ListView list)
        {

            List<Lid> leden = new List<Lid>();
            foreach (int item in ID)
            {
                leden.Add(data.getinfoLid("LidID", item.ToString()));
            }
            foreach (Lid item in leden)
            {
                int Rugnummer = 0;
                DatabaseAcces data = new DatabaseAcces();
                string[] row1 = { item.Naam, item.NevoboNummer };
                Rugnummer = data.getrugnummer("lidIDFK", item.LidNummer.ToString());
                list.Items.Add(Rugnummer.ToString()).SubItems.AddRange(row1);
            }

        }
        private void Showspelers(List<Speler> team, ListView listview)
        {
            List<int> IDs = new List<int>();
            IDs = Speler.GetSpelerID(team);
            foreach (int id in IDs)
            {
                listview.Items.Add(id.ToString());
            }
        }

        private void button_Next_Click(object sender, EventArgs e)
        {
            List<int> rugnummers1 = new List<int>();
            for (int i = 0; i < listView_team1.Items.Count ; i++)
            {
                rugnummers1.Add(Convert.ToInt32(listView_team1.Items[i].Text));
            }
            List<int> rugnummers2 = new List<int>();
            for (int i = 0; i < listView_team2.Items.Count; i++)
            {
                rugnummers2.Add(Convert.ToInt32(listView_team2.Items[i].Text));
            }
            var myform = new Form3(rugnummers1, rugnummers2);
            myform.Show();
            this.Visible = false;
        }
    }
}
