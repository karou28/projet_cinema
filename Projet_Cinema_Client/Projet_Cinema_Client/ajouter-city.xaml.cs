using Projet_Cinema_Client.ServiceReference10;
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

namespace Projet_Cinema_Client
{
    /// <summary>
    /// Interaction logic for ajouter_city.xaml
    /// </summary>
    public partial class ajouter_city : UserControl
    {
        public ajouter_city()
        {
            InitializeComponent();
            ServiceReference6.Country c = new ServiceReference6.Country();
            ServiceReference6.CountryServiceClient client = new ServiceReference6.CountryServiceClient();
            List<ServiceReference6.Country> l= client.get_list_country().ToList();
            country.ItemsSource = l;
            country.DisplayMemberPath = "CountryName";
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            ServiceReference15.City c = new ServiceReference15.City();
            ServiceReference15.CityServiceClient client = new ServiceReference15.CityServiceClient();
            c.CityLastUpdate = DateTime.Now;
            c.CityName = name.Text;
            c.CountryId = ((ServiceReference6.Country)country.SelectedItem).CountryId;
            client.Add(c);
        }
    }
}
