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

namespace Var5_1_Prischepova.PageAdmin
{
    /// <summary>
    /// Логика взаимодействия для PageAdminMenu.xaml
    /// </summary>
    public partial class PageAdminMenu : Page
    {
        public PageAdminMenu()
        {
            InitializeComponent();
        }

        private void BtnExamEdit_Click(object sender, RoutedEventArgs e)
        {
        }

        private void BtnLessForStudentEdit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnLessForAdultsEdit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnWithTeacherEdit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnOnlineEdit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnMovieClubEdit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnBackk_Click(object sender, RoutedEventArgs e)
        {
            var Admin = Window.GetWindow(this);
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            ApplicationData.AppFrame.FrameMain.Navigate(new PageMain.PageService());
            Admin.Close();
        }
    }
}
