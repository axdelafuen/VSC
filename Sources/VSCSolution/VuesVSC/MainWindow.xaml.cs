﻿using BibliothequeClassesVSC;
using System.Linq;
using System.Media;
using System.Windows;

namespace VuesVSC
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Manager Mgr => (App.Current as App).Manager;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Mgr.StatsSelectionne = Mgr.ArmeSélectionné.stats.ToList();
            contentControl.Content = new UCTypesArmes();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            contentControl.Content = new UCMainPage();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Mgr.StatsSelectionne=Mgr.PersonnageSelectionne.stats.ToList();
            contentControl.Content = new UCPersonnages();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            SystemSounds.Hand.Play();
            contentControl.Content = new UCProfil();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            contentControl.Content = new UCListe();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            contentControl.Content = new UCListe();
        }

        private void UCMainPage_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
