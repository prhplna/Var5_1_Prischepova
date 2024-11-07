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

namespace Var5_1_Prischepova.PageAdmin
{
    /// <summary>
    /// Логика взаимодействия для WindowLogin.xaml
    /// </summary>
    public partial class WindowLogin : Window
    {
        private const string DefaultPassword = "0000";

        public WindowLogin()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            var LogWin = Window.GetWindow(this);
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            ApplicationData.AppFrame.FrameMain.Navigate(new PageMain.PageService());
            LogWin.Close();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            string Code = psbPassword.Password;
            if (string.IsNullOrEmpty(Code))
            {
                MessageBox.Show("Поле не заполнено!");
            }
            else if (Code != DefaultPassword)
            {
                MessageBox.Show("Неверный код!");
            }
            else
            {
                // Закрываем текущее окно
                var LogWin = Window.GetWindow(this);
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                ApplicationData.AppFrame.FrameMain.Navigate(new PageAdmin.PageAdminMenu());
                LogWin.Close();
            }
        }
    }
}
