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

namespace Hfdstk6.Collections.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        List<string> vaarders;
        private void btnKaaprenVaarders_Click(object sender, RoutedEventArgs e)
        {
            string kaaprenVaarders;
            vaarders = new List<string>();
            vaarders.Add("Jan");
            vaarders.Add("Piet");
            vaarders.Add("Joris");
            vaarders.Add("Korneel");

            kaaprenVaarders = vaarders[0] + ", " + vaarders[1] + ", " + vaarders[2] + " en " + vaarders[3] 
                + "\nDie hebben baarden, zij varen mee.";
            MessageBox.Show(kaaprenVaarders, "Niet gesorteerd");

            vaarders.Sort();
            kaaprenVaarders = vaarders[0] + ", " + vaarders[1] + ", " + vaarders[2] + " en " + vaarders[3] 
                + "\nDie hebben baarden, zij varen mee.";
            MessageBox.Show(kaaprenVaarders, "Gesorteerd");

            lstVaarders.ItemsSource = vaarders;
        }

        private void lstVaarders_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lblPositie.Content = "";
            if(lstVaarders.SelectedIndex > -1)
            if(lstVaarders.SelectedItem != null)
            {
                string zoekVaarder = (string)lstVaarders.SelectedItem;
                int positie = vaarders.FindIndex(zoek => zoek == zoekVaarder);
                lblPositie.Content = $"{zoekVaarder} gevonden op positie {positie}";
            }
        }

        private void btnVrienden_Click(object sender, RoutedEventArgs e)
        {
            Dictionary<string, int> vrienden = new Dictionary<string, int>();

            vrienden.Add("Emmanuel", 40);
            vrienden.Add("Angela", 42);
            vrienden.Add("Donald", 25);

            string output = "";
            output += "De leeftijd van Emmanuel is " + vrienden["Emmanuel"] + "\n";
            output += "De tweede vriend(in) in de rij is " + vrienden.Keys.ElementAt(1) ;
            lblVrienden.Content = output;
        }

        Dictionary<string, string> landen;
        private void btnLanden_Click(object sender, RoutedEventArgs e)
        {
            landen = new Dictionary<string, string>();

            landen.Add("Belgium", "Brussels");
            landen.Add("Germany", "Berlin");
            landen.Add("France", "Paris");
            landen.Add("Spain", "Madrid");
            landen.Add("Italy", "Rome");
            landen.Add("Norway", "Oslo");
            landen.Add("UK", "London");
            landen.Add("Ireland", "Dublin");

            cmbLanden.ItemsSource = landen.Keys;
        }

        private void cmbLanden_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lblHoofdstad.Content = "";
            if(cmbLanden.SelectedItem != null)
            {
                string zoekLand = (string)cmbLanden.SelectedItem;
                lblHoofdstad.Content = landen[zoekLand];
            }
        }
    }
}
