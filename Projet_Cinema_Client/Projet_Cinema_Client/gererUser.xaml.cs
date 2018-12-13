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
    /// Interaction logic for gererUser.xaml
    /// </summary>
    public partial class gererUser : UserControl
    {
        public gererUser()
        {
            InitializeComponent();
            ServiceRStaff.Staff s = new ServiceRStaff.Staff();
            ServiceRStaff.StaffServiceClient client = new ServiceRStaff.StaffServiceClient();

            List<ServiceRStaff.Staff> l = new List<ServiceRStaff.Staff>();
            l = client.get_list_staff().ToList();
            cb_staff.ItemsSource = l;
            cb_staff.DisplayMemberPath = "StaffFirstName";
        }

        private void b_modifier_Click(object sender, RoutedEventArgs e)
        {
            modifier_user u = new modifier_user();
            grid_gerer_user.Children.Clear();
            grid_gerer_user.Children.Add(u);
        }

        private void b_lister_users_Click(object sender, RoutedEventArgs e)
        {
            ListerUsers u = new ListerUsers();
            grid_gerer_user.Children.Clear();
            grid_gerer_user.Children.Add(u);

        }

        private void image2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ajouter_user u = new ajouter_user();
            grid_gerer_user.Children.Clear();
            grid_gerer_user.Children.Add(u);

        }

        private void cb_staff_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ServiceRStaff.Staff s = (ServiceRStaff.Staff)cb_staff.SelectedItem;
            l_firstname.Content = s.StaffFirstName;
            l_username.Content = s.StaffUsername;
            l_lastName.Content = s.StaffLastName;
        }
    }
}
