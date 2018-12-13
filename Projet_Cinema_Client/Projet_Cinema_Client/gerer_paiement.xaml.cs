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
    /// Interaction logic for gerer_paiement.xaml
    /// </summary>
    public partial class gerer_paiement : UserControl
    {
        public gerer_paiement()
        {
            InitializeComponent();
        }

        private void journalier_Click(object sender, RoutedEventArgs e)
        {
            g.Children.Clear();
            lister_paiements u = new lister_paiements();
            u.type.Content = "journaliers";
            g.Children.Add(u);
        }

        private void mensuel_Click(object sender, RoutedEventArgs e)
        {
            g.Children.Clear();
            lister_paiements u = new lister_paiements();
            u.type.Content = "mensuels";
            g.Children.Add(u);
        }

        private void interval_Click(object sender, RoutedEventArgs e)
        {
            g.Children.Clear();
            lister_paiements u = new lister_paiements();
            u.type.Content = "par intervalle de dates";
            g.Children.Add(u);
        }

        private void modifier_Click(object sender, RoutedEventArgs e)
        {
            g.Children.Clear();
            modifier_paiement u = new modifier_paiement();
            g.Children.Add(u);
        }

        private void nouveau_Click(object sender, RoutedEventArgs e)
        {
            g.Children.Clear();
            Add_paiement u = new Add_paiement();
            g.Children.Add(u);
        }

        private void payment_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
