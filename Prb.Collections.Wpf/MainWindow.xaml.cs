using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Hfdstk6.Collections.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> sailors;
        Dictionary<string, string> countries;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnSailors_Click(object sender, RoutedEventArgs e)
        {
            string sailorText;
            sailors = new List<string>();
            sailors.Add("Jan");
            sailors.Add("Piet");
            sailors.Add("Joris");
            sailors.Add("Korneel");

            sailorText = sailors[0] + ", " + sailors[1] + ", " + sailors[2] + " en " + sailors[3] 
                + "\nDie hebben baarden, zij varen mee.";
            MessageBox.Show(sailorText, "Niet gesorteerd");

            sailors.Sort();
            sailorText = sailors[0] + ", " + sailors[1] + ", " + sailors[2] + " en " + sailors[3] 
                + "\nDie hebben baarden, zij varen mee.";
            MessageBox.Show(sailorText, "Gesorteerd");

            lstSailors.ItemsSource = sailors;
        }

        private void LstSailors_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lblPosition.Content = "";
            //if(lstSailors.SelectedIndex > -1)
            if(lstSailors.SelectedItem != null)
            {
                string selectedSailor = (string)lstSailors.SelectedItem;
                int position = sailors.IndexOf(selectedSailor);
                lblPosition.Content = $"{selectedSailor} gevonden op positie {position}";
            }
        }

        private void BtnFriends_Click(object sender, RoutedEventArgs e)
        {
            Dictionary<string, int> friends = new Dictionary<string, int>();

            friends.Add("Emmanuel", 40);
            friends.Add("Angela", 42);
            friends.Add("Donald", 25);

            string output = "";
            output += "De leeftijd van Emmanuel is " + friends["Emmanuel"] + "\n";
            output += "De tweede vriend(in) in de rij is " + friends.Keys.ElementAt(1) ;
            lblFriends.Content = output;
        }

        private void BtnCountries_Click(object sender, RoutedEventArgs e)
        {
            countries = new Dictionary<string, string>();

            countries.Add("Belgium", "Brussels");
            countries.Add("Germany", "Berlin");
            countries.Add("France", "Paris");
            countries.Add("Spain", "Madrid");
            countries.Add("Italy", "Rome");
            countries.Add("Norway", "Oslo");
            countries.Add("UK", "London");
            countries.Add("Ireland", "Dublin");

            cmbCountries.ItemsSource = countries.Keys;
        }

        private void CmbCountries_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lblCapital.Content = "";
            if(cmbCountries.SelectedItem != null)
            {
                string selectedCountry = (string)cmbCountries.SelectedItem;
                lblCapital.Content = countries[selectedCountry];
            }
        }
    }
}
