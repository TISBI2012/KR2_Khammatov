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
using WpfApp1.Pages;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            var user = App.DB.Employee.FirstOrDefault(x => x.login == UsernameTextBox.Text);

            if (user == null || user.password != PasswordTextBox.Password)
            {
                MessageBox.Show("Данные для входа неверны");
                return;
            }


           MainFrame.Navigate(new EmployeePage());

        }

        private void AdminBt_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new AdminLoginPage());
        }
    }
}
