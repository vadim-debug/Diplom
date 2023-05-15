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
    /// Логика взаимодействия для RegPage.xaml
    /// </summary>
    public partial class RegPage : Page
    {
        AppContext db = new AppContext();
        public RegPage()
        {
            InitializeComponent();
        }

        private void Regbtn_Click(object sender, RoutedEventArgs e)
        {
            string Login = txtLogin.Text;
            string Pass = txtPass1.Text;
            string Pass2 = txtPass2.Text;
            User user = new User(Login,Pass,1);
            if (Pass==Pass2)
            {
                db.Users.Add(user);
                db.SaveChanges();
                MessageBox.Show("Успешно");
                NavigationService.Navigate(new AuthPage());
            }
           
            else
            {
                MessageBox.Show("Пароли не совпадают");
            }
            
        }

        private void BtnToAuth_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AuthPage());
        }

      

    }
}
