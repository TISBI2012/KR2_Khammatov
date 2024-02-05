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
using WpfApp1;

namespace WpfApp1.Pages
{
    /// <summary>
    /// Логика взаимодействия для CliendAddPage.xaml
    /// </summary>
    public partial class CliendAddPage : Page
    {
        public CliendAddPage()
        {
            InitializeComponent();
        }

        private void AddClienWorkBT_Click(object sender, RoutedEventArgs e)
        {
            var employee = new Employee();
            employee.full_name = fullnameTb.Text;
            employee.address = addressTb.Text;
            employee.phone = phoneTb.Text;
            employee.technology_stack = tecnologyTb.Text;
            employee.duties = dutiesTb.Text;
            employee.department_id = Convert.ToInt32(departamentTb);
            employee.rate = Convert.ToInt32(rateTb);
            employee.login = loginTb.Text;
            employee.passport = passportTb.Text;



        }
    }
}
