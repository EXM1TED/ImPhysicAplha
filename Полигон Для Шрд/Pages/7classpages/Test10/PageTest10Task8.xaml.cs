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
using Полигон_Для_Шрд.Classes;

namespace Полигон_Для_Шрд.Pages._7classpages.Test10
{
    /// <summary>
    /// Логика взаимодействия для PageTest10Task8.xaml
    /// </summary>
    public partial class PageTest10Task8 : Page
    {
        public PageTest10Task8()
        {
            InitializeComponent();
        }
        private void btnCompleteTest_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new TestCompletePage());
        }

        private void btnReturn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
