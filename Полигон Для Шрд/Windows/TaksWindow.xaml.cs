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
using Полигон_Для_Шрд.Classes;
using Полигон_Для_Шрд.Pages;

namespace Полигон_Для_Шрд.Windows
{
    /// <summary>
    /// Логика взаимодействия для TaksWindow.xaml
    /// </summary>
    public partial class TaksWindow : Window
    {
        public TaksWindow()
        {
            InitializeComponent();
            User user = new User();
            user = UserSave.userSave;
            this.DataContext = user;

            FrameClass.frame = PageOfTests;
            FrameClass.frame.Navigate(new TestChoosePage());
        }

        private void btnTest3_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnTest2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnTest1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnReturnTaskWindowToMainWindow_Click(object sender, RoutedEventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            Window taksWidnow = Window.GetWindow(this);
            taksWidnow.Close();
        }

        private void NavigateToProfile_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnReturnTaskWindowToMainWindow_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
