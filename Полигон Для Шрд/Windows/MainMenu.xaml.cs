using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using Полигон_Для_Шрд.Windows;

namespace Полигон_Для_Шрд.Windows
{
    /// <summary>
    /// Логика взаимодействия для MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Window
    {
        public MainMenu()
        {
            InitializeComponent();
            User user = new User();
            user = UserSave.userSave;
            
            this.DataContext = user;
        }

        private void btnMainWindowToTaskWindow_Click(object sender, RoutedEventArgs e)
        {
            TaksWindow taksWindow = new TaksWindow();
            taksWindow.Show();
            this.Close();
        }

        private void NavigateToProfile_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
