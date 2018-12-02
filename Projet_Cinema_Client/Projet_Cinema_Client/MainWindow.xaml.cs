﻿using System;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow() {

            
              
            InitializeComponent();
            grid_sortie.Children.Clear();
            gerer_user.Width = 646;
            gerer_user.Height = 557;
            

        }

        private void Staff_gerer_Click(object sender, RoutedEventArgs e)
        {
            grid_sortie.Children.Clear();
            grid_sortie.Children.Add(gerer_user);

        }

        private void nouveau_Click(object sender, RoutedEventArgs e)
        {
            grid_sortie.Children.Clear();
            grid_sortie.Children.Add(grid_ajout_user);
        }
    }
}
