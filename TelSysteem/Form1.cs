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
    public partial class Form1 : Form
    {
        Vereniging vereniging = new Vereniging("");
        Team team = new Team();
        Vereniging Vereniging1 = new Vereniging("");
        DatabaseAcces Data = new DatabaseAcces();
      List<Speler> SpelerList1 = new List<Speler>();
      List<Speler> SpelerList2 = new List<Speler>();

        public Form1()
        {
            InitializeComponent();
            AddVereniging(Dropdown_Vereniging1);
            AddVereniging(Dropdown_Vereniging2);
        }

        public void AddVereniging(ComboBox Dropdownbox)
        {
            List<Vereniging> verenigingen = new List<Vereniging>();
            verenigingen = vereniging.FindVereniging();
            foreach(Vereniging vereniging in verenigingen)
            {
                Dropdownbox.Items.Add(vereniging.Naam);
            }
        }
        public void AddTeam(string vereniging, ComboBox dropdowm)
        {
            List<Team> Teams = new List<Team>(); Teams = team.GetTeams(vereniging);
            foreach(var Team in Teams)
            {
                dropdowm.Items.Add(Team.Naam);
            }
        }
        private void Dropdown_Vereniging1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Vereniging1.Naam = Dropdown_Vereniging1.SelectedItem.ToString();
            AddTeam(Dropdown_Vereniging1.SelectedItem.ToString(), Dropdown_Team1);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Dropdown_Team1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            List<string> info = new List<string>();
            Team Team1 = Team.GetTeams1(Dropdown_Team1.SelectedItem.ToString());
            SpelerList1 = Speler.GetSpelers(Team1.TeamID.ToString());

        }

        private void Dropdown_Vereniging2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Vereniging1.Naam = Dropdown_Vereniging2.SelectedItem.ToString();
            AddTeam(Dropdown_Vereniging2.SelectedItem.ToString(), Dropdown_Team2);
        }

        private void Dropdow_Team2_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> info = new List<string>();
            Team Team1 = Team.GetTeams1(Dropdown_Team2.SelectedItem.ToString());
            SpelerList2 = Speler.GetSpelers(Team1.TeamID.ToString());
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            var myform = new Form2(SpelerList1, SpelerList2);
            myform.Show();
            var myform1 = new Form1();
            this.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
