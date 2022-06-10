﻿using BibliothequeClassesVSC;
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

namespace VuesVSC
{
    /// <summary>
    /// Interaction logic for UCArmesPassives.xaml
    /// </summary>
    public partial class UCArmesPassives : UserControl
    {
        public Manager Mgr => (App.Current as App).Manager;
        public Navigator Nav => (App.Current as App).Navigator;
        public UCArmesPassives()
        {
            InitializeComponent();
            DataContext = Mgr;
            if (Mgr.ArmeSélectionné as ArmePassive == default)
            {
                Mgr.ArmeSélectionné = Mgr.LesArmesPassives[0];
            }
            Mgr.StatsSelectionne = Mgr.ArmeSélectionné.stats.ToList();
        }

        private void lBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Mgr.ArmeSélectionné = e.AddedItems[0] as Arme;
            Mgr.StatsSelectionne = Mgr.ArmeSélectionné.stats.ToList();
        }

        private void Active_Click(object sender, RoutedEventArgs e)
        {
            Mgr.ArmeSélectionné = (Mgr.ArmeSélectionné as ArmePassive).ArmeAct;
            Nav.NavigateTo(Navigator.PART_ARMES, Navigator.PART_ACT);
        }

        private void Amelio_Click(object sender, RoutedEventArgs e)
        {
            Mgr.ArmeSélectionné = (Mgr.ArmeSélectionné as ArmePassive).Amelioration;
            Nav.NavigateTo(Navigator.PART_ARMES, Navigator.PART_AMELIO);
        }
    }
}