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
    /// Interaction logic for gerer_user.xaml
    /// </summary>
    public partial class gerer_user : UserControl
    {
        public gerer_user()
        {
            InitializeComponent();
        }

        

        private void paiement_Click_1(object sender, RoutedEventArgs e)
        {
            gerer_paiement u = new gerer_paiement();
            grid_sortie.Children.Clear();
            grid_sortie.Children.Add(u);
        }

        private void location_Click(object sender, RoutedEventArgs e)
        {
            gerer_location l = new gerer_location();
            grid_sortie.Children.Clear();
            grid_sortie.Children.Add(l);
        }

        private void user_Click(object sender, RoutedEventArgs e)
        {
            gererUser u = new Projet_Cinema_Client.gererUser();
            grid_sortie.Children.Clear();
            grid_sortie.Children.Add(u);
        }

        

        private void mot_de_passe_Click_1(object sender, RoutedEventArgs e)
        {
            modif_mot_passe m = new modif_mot_passe();
            grid_sortie.Children.Clear();
            grid_sortie.Children.Add(m);
        }

        private void visualiser_Click(object sender, RoutedEventArgs e)
        {

        }

        private void language_Click(object sender, RoutedEventArgs e)
        {
            ajouter_language u = new ajouter_language();
            grid_sortie.Children.Clear();
            grid_sortie.Children.Add(u);
        }

        private void Addresse_Click(object sender, RoutedEventArgs e)
        {
            ajouter_addresse u = new ajouter_addresse();
            grid_sortie.Children.Clear();
            grid_sortie.Children.Add(u);
        }

        private void Store_Click(object sender, RoutedEventArgs e)
        {
            ajouter_store u = new ajouter_store();
            grid_sortie.Children.Clear();
            grid_sortie.Children.Add(u);
        }

        private void Actor_Click(object sender, RoutedEventArgs e)
        {
            add_actor u = new add_actor();
            grid_sortie.Children.Clear();
            grid_sortie.Children.Add(u);
        }

        private void Film_Click(object sender, RoutedEventArgs e)
        {
            ajouter_film u = new ajouter_film();
            grid_sortie.Children.Clear();
            grid_sortie.Children.Add(u);
        }

        private void city_Click(object sender, RoutedEventArgs e)
        {
            ajouter_city u = new ajouter_city();
            grid_sortie.Children.Clear();
            grid_sortie.Children.Add(u);
        }

        private void category_Click(object sender, RoutedEventArgs e)
        {
            ajouter_category u = new ajouter_category();
            grid_sortie.Children.Clear();
            grid_sortie.Children.Add(u);
        }

        private void customer_Click(object sender, RoutedEventArgs e)
        {
            add_customer u = new add_customer();
            grid_sortie.Children.Clear();
            grid_sortie.Children.Add(u);
        }

        private void Country_Click(object sender, RoutedEventArgs e)
        {
            ajouter_country u = new ajouter_country();
            grid_sortie.Children.Clear();
            grid_sortie.Children.Add(u);
        }
    }
}
