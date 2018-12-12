using Projet_Cinema_Client.ServiceReference4;
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
    /// Interaction logic for ajouter_category.xaml
    /// </summary>
    public partial class ajouter_category : UserControl
    {
        public ajouter_category()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            ServiceReference4.Category c = new ServiceReference4.Category();
            CategoryServiceClient client = new CategoryServiceClient();
            client.Add(c);
        }
    }
}
