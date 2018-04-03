using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TelSysteem;
namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Vereniging Vereniging1 = new Vereniging("");
        Team Team1 = new Team("","");
        DatabaseAcces Data = new DatabaseAcces();
        List<Speler> SpelerList1 = new List<Speler>();
        List<Speler> SpelerList2 = new List<Speler>();
        public MainWindow()
        {
            InitializeComponent();
            AddVereniging(Dropdown_Vereniging1);
            AddVereniging(Dropdown_Vereniging2);
        }
        public void AddTeam(string vereniging, ComboBox dropdowm)
        {
            List<Team> Teams = new List<Team>(); Teams = Team1.GetTeams(vereniging);
            foreach (var Team in Teams)
            {
                dropdowm.Items.Add(Team.Naam);
            }
        }
        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Vereniging1.Naam = Dropdown_Vereniging2.SelectedItem.ToString();
            AddTeam(Dropdown_Vereniging2.SelectedItem.ToString(), Dropdown_Team2);
        }
        public void AddVereniging(ComboBox Dropdownbox)
        {
            List<Vereniging> verenigingen = new List<Vereniging>();
            verenigingen = Vereniging1.FindVereniging();
            foreach (Vereniging vereniging in verenigingen)
            {
                Dropdownbox.Items.Add(vereniging.Naam);
            }
        }
    }
}
