using CarMechanik.com.vkirillov.carmechanik.dataprovider;
using CarMechanik.com.vkirillov.carmechanik.obj;
using CarMechanik.com.vkirillov.carmechanik.wpf;
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

namespace CarMechanik
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IDataProvider dataProvider = DataProviderManager.GetDataProvider();

        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            string login = LoginBox.Text;
            string password = PasswordBox.Text;

            if(login.Length < 3)
            {
                MessageBox.Show("Логин не может быть пустым или меньше 3 символов");
                return;
            }
            if(password.Length < 3)
            {
                MessageBox.Show("Пароль не может быть пустым или меньше 3 символов");
                return;
            }


            Staff staff = await dataProvider.Login(login, password);
            if(staff != null)
            {
                ServiseWindow window = new ServiseWindow();
                window.Show();
                this.Close();
            }
            else MessageBox.Show("Неверный логин или пароль!");
        }
    }
}
