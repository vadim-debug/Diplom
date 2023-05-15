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

namespace Diplom
{
    /// <summary>
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        public AuthPage()
        {
            InitializeComponent();
        }

        private void BtnAuth_Click(object sender, RoutedEventArgs e)
        {
            string login = txtLogin.Text;
            string pass = txtPass.Text;

            User AuthUser = null;
            using (AppContext db = new AppContext()) 
            {
                AuthUser = db.Users.Where(b => b.Login == login && b.Password == pass).FirstOrDefault();
            }
            if (AuthUser!=null)
                
            {
                int Role = AuthUser.Role_Id;
                
                NavigationService.Navigate(new MainTasks(Role));
            }
            else
            {
                MessageBox.Show("Проверьте введённые данные");
            }

        }

        private void BtnToRegPage_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegPage());
        }

        private void BtnGuest_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainTasks(1));
        }
    }
}
