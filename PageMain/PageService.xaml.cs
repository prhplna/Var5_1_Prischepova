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

namespace Var5_1_Prischepova.PageMain
{
    /// <summary>
    /// Логика взаимодействия для PageService.xaml
    /// </summary>
    public partial class PageService : Page
    {
        public PageService()
        {
            InitializeComponent();
        }

        private void BtnExam_Click(object sender, RoutedEventArgs e)
        {
            ApplicationData.AppFrame.FrameMain.Navigate(new PageMain.PageExams());
        }

        private void BtnLessForStudent_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnLessForAdults_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnWithTeacher_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnOnline_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnMovieClub_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnAdmin_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = Window.GetWindow(this);
            PageAdmin.WindowLogin LogWin = new PageAdmin.WindowLogin();
            LogWin.Show();
            mainWindow.Close();
        }
    }
}
