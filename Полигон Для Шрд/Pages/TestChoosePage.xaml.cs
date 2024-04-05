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
using Полигон_Для_Шрд.Classes;

namespace Полигон_Для_Шрд.Pages
{
    /// <summary>
    /// Логика взаимодействия для TestChoosePage.xaml
    /// </summary>
    public partial class TestChoosePage : Page
    {
        public TestChoosePage()
        {
            InitializeComponent();
        }

        private void btnTest3_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnTest2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnTest1_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.frame.Navigate(new TestPage());
        }
    }
}
