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
    /// Interaction logic for gerer_location.xaml
    /// </summary>
    public partial class gerer_location : UserControl
    {
        public gerer_location()
        {
            InitializeComponent();
        }

        private void nouveau_Click(object sender, RoutedEventArgs e)
        {
            add_location u = new add_location();
            this.g.Children.Clear();
            g.Children.Add(u);
        }

        private void modifier_Click(object sender, RoutedEventArgs e)
        {
            modifier_rental u = new modifier_rental();
            this.g.Children.Clear();
            g.Children.Add(u);
        }

      

        private void rendu_Click(object sender, RoutedEventArgs e)
        {
            lister_location u = new lister_location();
            this.g.Children.Clear();
            g.Children.Add(u);
            u.type.Content = "rendu";
        }

        private void depasse_Click(object sender, RoutedEventArgs e)
        {
            lister_location u = new lister_location();
            this.g.Children.Clear();
            g.Children.Add(u);
            u.type.Content = "dépassé";
        }

        private void en_cours_Click(object sender, RoutedEventArgs e)
        {
            lister_location u = new lister_location();
            this.g.Children.Clear();
            g.Children.Add(u);
            u.type.Content = "en cours";
        }

        private void modifier_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
