using Projet_Cinema_Client.ServiceReference8;
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
    /// Interaction logic for ajouter_film.xaml
    /// </summary>
    public partial class ajouter_film : UserControl
    {
        public ajouter_film()
        {
            InitializeComponent();

            
            ServiceReference1.LanguageServiceClient client = new ServiceReference1.LanguageServiceClient();
            List<ServiceReference1.Language> li = new List<ServiceReference1.Language>();
            li = client.get_list_language().ToList();
            language.ItemsSource = li;
            language.DisplayMemberPath = "LanguageName";
             
        }

        private void valider_Click(object sender, RoutedEventArgs e)
        {
            Film f = new Film();
            FilmServiceClient client = new ServiceReference8.FilmServiceClient();
            f.FilmDescription = description.Text;
            f.FilmLastUpdate = DateTime.Now;
            f.FilmLength = int.Parse(length.Text);
            f.FilmOriginalLanguageId =((ServiceReference1.Language)originallanguage.SelectedItem).LanguageId;
            f.FilmRate = rate.Text;
            f.FilmReleaseYear = release.Text;
            f.FilmRentalDuration = int.Parse(duration.Text);
            f.FilmRentalRate = int.Parse(rentalrate.Text);
            f.FilmReplacementCost = int.Parse(replacementCost.Text);
            f.FilmSpecialFeatures = features.Text;
            f.FilmTitle = title.Text;
            f.Language = (Language)language.SelectedItem;
            client.Add(f);

        }
    }
}
