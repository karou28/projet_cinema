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
    /// Interaction logic for ajouter_addresse.xaml
    /// </summary>
    public partial class ajouter_addresse : UserControl
    {
        public ajouter_addresse()
        {
            InitializeComponent();
            
            ServiceReference23.CityServiceClient client = new ServiceReference23.CityServiceClient();

            List<ServiceReference23.City> l = new List<ServiceReference23.City>();

            try
            {
                l = client.get_list_cities().ToList();
            }
            catch (Exception e){ Console.WriteLine(e.Message); }
            if (l != null)
            {
                cityId.ItemsSource = l;
                cityId.DisplayMemberPath = "CityName";
            }
          
           
            
        }

        private void valider_Click(object sender, RoutedEventArgs e)
        {
            ServiceReference2.Address a = new ServiceReference2.Address();
            ServiceReference2.AddressServiceClient client = new ServiceReference2.AddressServiceClient();
            a.AddressDistrict = district.Text;
            a.AddressLastUpdate = DateTime.Now;
            a.AddressName = addressname.Text;
            a.AddressPostalCode = postalcode.Text;
            a.AddressPostalCode = phone.Text;
            client.Add(a);
        }
    }
}
