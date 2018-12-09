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
    /// Interaction logic for Add_paiement.xaml
    /// </summary>
    public partial class Add_paiement : UserControl
    {
        public Add_paiement()
        {
            InitializeComponent();
        }

        private void annuler_Click(object sender, RoutedEventArgs e)
        {
            gerer_paiement u = new gerer_paiement();
               this.g.Children.Clear();
           this.g.Children.Add(u);
        }
    }
}
