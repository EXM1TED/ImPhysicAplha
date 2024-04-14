using Microsoft.EntityFrameworkCore;
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
using Полигон_Для_Шрд.Windows;

namespace Полигон_Для_Шрд.Pages
{
    /// <summary>
    /// Логика взаимодействия для TestCompletePage.xaml
    /// </summary>
    public partial class TestCompletePage : Page
    {
        public TestCompletePage()
        {
            InitializeComponent();
            User user = new User();
            user = UserSave.userSave;
            ApplicationContext db = new ApplicationContext();
            db.Database.EnsureCreated();
            var results = db.ResultsOfTest.FromSqlRaw($"SELECT Id, User_Id, Name_of_test, Result FROM Results " +
                $"WHERE User_Id = '{user.UserId}' AND Name_of_test = 'Основы физики'").ToList();
            foreach ( var item in results)
            {
                txtBlockResult.Text = $"Ваш результат: {item.Result} из 8";
            }
        }

        private void btnGoMainMenu_Click(object sender, RoutedEventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            Window taskWindow = Window.GetWindow(this);
            taskWindow.Close();
        }
    }
}
