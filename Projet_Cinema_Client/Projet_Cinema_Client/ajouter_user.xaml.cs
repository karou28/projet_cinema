using Microsoft.Win32;
using Projet_Cinema_Client.ServiceReference1;
using Projet_Cinema_Client.ServiceReference13;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for ajouter_user.xaml
    /// </summary>
    public partial class ajouter_user : UserControl
    {
        public byte[] b;
        public ajouter_user()
        {
            InitializeComponent();
            ServiceReference2.Address a = new ServiceReference2.Address();
            ServiceReference2.AddressServiceClient client = new ServiceReference2.AddressServiceClient();
            List<ServiceReference2.Address> li = new List<ServiceReference2.Address>();
            li = client.get_list_address().ToList();
            addressem.ItemsSource = li;
            addressem.DisplayMemberPath = "AddressName";

            ServiceReference14.Store s = new ServiceReference14.Store();
            ServiceReference14.StoreServiceClient client1 = new ServiceReference14.StoreServiceClient();
            List<ServiceReference14.Store> ls = client1.get_list_store().ToList();
            Storem.ItemsSource = ls;
            Storem.DisplayMemberPath = "StoreName";

        }

        private void label1_Click(object sender, RoutedEventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            
                openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "*.png|*.jpg";
               
                openFileDialog.RestoreDirectory = true;

                if ((bool)openFileDialog.ShowDialog())
                {
                    //Get the path of specified file
                    String filePath = openFileDialog.FileName;
                img.Text = filePath;
                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    String fileContent = reader.ReadToEnd();
                     b = System.Text.Encoding.ASCII.GetBytes("MA CHAINE");
                }
                }
            

        }

        private void valider_Click(object sender, RoutedEventArgs e)
        {
            ServiceReference13.Staff s = new ServiceReference13.Staff();
            StaffServiceClient client = new StaffServiceClient();
            s.StaffUsername = usernamem.Text;
            s.StaffFirstName = prenomm.Text;
            s.StaffLastName = nomm.Text;
            s.StaffLastUpdate = DateTime.Now;
            s.StaffEmail = emailm.Text;
            s.StaffPassword = passwordBox.Text;
            s.StaffPicture = b;
            s.AddressId = ((ServiceReference14.Address)addressem.SelectedItem).AddressId;
            s.StoreId = ((ServiceReference13.Store)Storem.SelectedItem).StoreId;
            client.Add(s);
            
        }
    }
}
