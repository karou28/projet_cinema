using Projet_Cinema_Client.ServiceReference1;
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
    /// Interaction logic for ajouter_language.xaml
    /// </summary>
    public partial class ajouter_language : UserControl
    {
        public ajouter_language()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            ServiceReference1.Language l = new Language();
            l.LanguageName = name.Text;
            l.LanguageLastUpdate = DateTime.Now;
            ServiceReference1.LanguageServiceClient client = new ServiceReference1.LanguageServiceClient();
            client.Add(l);
        }
    }
}
