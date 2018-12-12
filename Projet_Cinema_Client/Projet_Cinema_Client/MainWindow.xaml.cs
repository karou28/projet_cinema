using Projet_Cinema_Client.ServiceReference1;
using Projet_Cinema_Client.ServiceRStaff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;


using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Projet_Cinema_Client
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
           
            InitializeComponent();
            accueil a = new Projet_Cinema_Client.accueil();
            xx.Children.Clear();
            xx.Children.Add(a);


        }
       

        





        
    }
}
