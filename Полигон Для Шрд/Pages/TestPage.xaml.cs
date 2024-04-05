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
    /// Логика взаимодействия для TestPage.xaml
    /// </summary>
    public partial class TestPage : Page
    {
        public TestPage()
        {
            InitializeComponent();
            ApplicationContext db = new ApplicationContext();
            var tasks = db.Tasks.ToList();
            foreach(Tasks t in tasks)
            {
                textBlockNumberOfTask.Text = t.TaskId.ToString();
                textBlockTaskName.Text = t.Task; 
            }
        }
    }
}
