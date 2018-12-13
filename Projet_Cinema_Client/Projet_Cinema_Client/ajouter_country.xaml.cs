using Projet_Cinema_Client.ServiceReference6;
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
    /// Interaction logic for ajouter_country.xaml
    /// </summary>
    public partial class ajouter_country : UserControl
    {
        public ajouter_country()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            ServiceReference6.Country c = new ServiceReference6.Country();
            CountryServiceClient client = new CountryServiceClient();
            c.CountryLastUpdate = DateTime.Now;
            c.CountryName = name.Text;
            client.Add(c);
        }
    }
}
