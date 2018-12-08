﻿using System;
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
            grid_sortie.Children.Clear();
            f();


            


        }

        private void user_Click(object sender, RoutedEventArgs e)
        {
            grid_sortie.Children.Clear();
            grid_sortie.Children.Add(grid_gerer_user);
        }

        public void f()
        {
            grid_gerer_user.Width = 677;
            grid_gerer_user.Height = 600;
        }

        private void b_nouveau_Click(object sender, RoutedEventArgs e)
        {
            ajouter_user u = new ajouter_user();
            grid_sortie.Children.Clear();
            grid_sortie.Children.Add(u);
            
        }

        private void b_modifier_Click(object sender, RoutedEventArgs e)
        {
            modifier_user u = new modifier_user();
            grid_sortie.Children.Clear();
            grid_sortie.Children.Add(u);
        }

        private void mot_de_passe_Click(object sender, RoutedEventArgs e)
        {
            modif_mot_passe u = new modif_mot_passe();
            grid_sortie.Children.Clear();
            grid_sortie.Children.Add(u);
        }
    }
}
