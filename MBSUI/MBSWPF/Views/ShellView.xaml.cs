﻿using MBSWPF.ViewModels;
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
using System.Windows.Shapes;
using MBSLibrary;

namespace MBSWPF.Views
{
    /// <summary>
    /// Interaction logic for ShellView.xaml
    /// </summary>
    public partial class ShellView : Window
    {
        public ShellView()
        {
            InitializeComponent();

            //For this we can either do a .Visibility or .IsEnabled depends on the look.
            //Should possibly consult Norris on the look Maybe.
            if (ActiveAccount.activeEmployee.IsManager == false)
            {
                LoadManagerView.Visibility = Visibility.Hidden;
            }
            else 
            {
                LoadManagerView.Visibility = Visibility.Visible; 
            }

        }

        private void MenuItemExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }


    }
}