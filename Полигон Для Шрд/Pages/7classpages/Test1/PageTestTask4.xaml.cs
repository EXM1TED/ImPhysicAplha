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

namespace Полигон_Для_Шрд.Pages._7classpages.Test1
{
    /// <summary>
    /// Логика взаимодействия для PageTestTask4.xaml
    /// </summary>
    public partial class PageTestTask4 : Page
    {
        public PageTestTask4()
        {
            InitializeComponent();
        }
        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            if (this.NavigationService.CanGoForward)
            {
                this.NavigationService.GoForward();
            }
            else
            {
                NavigationService.Navigate(new PageTestTask5());
            }
        }

        private void btnReturn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
