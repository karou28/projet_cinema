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
    /// Interaction logic for lister_paiements.xaml
    /// </summary>
    public partial class lister_paiements : UserControl
    {
        public lister_paiements()
        {
            InitializeComponent();
        }

        private void retour_Click(object sender, RoutedEventArgs e)
        {
            g.Children.Clear();
            gerer_paiement u = new gerer_paiement();
            g.Children.Add(u);
        }
    }
}
