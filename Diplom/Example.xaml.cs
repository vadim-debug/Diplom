using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
    /// Логика взаимодействия для Example.xaml
    /// </summary>
    public partial class Example : Page
    {
        AppContext db = new AppContext();
        public Example()
        {
            InitializeComponent();

            List<Task> Tasks = db.Tasks.ToList();
            Tasks = Tasks.Where(d=>d.TaskType_Id==1).ToList();

            DTGridClient.ItemsSource = Tasks;
            //DTGridClient.ItemsSource = db.Tasks.ToList();
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            // DTGridClient.ItemsSource = db.Tasks.ToList();
           // DTGridClient.ItemsSource = Tasks;
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            //NavigationService.Navigate(new AddEdit((sender as Button).DataContext as Task));
        }

        private void Btn_Add_Click(object sender, RoutedEventArgs e)
        {
            //NavigationService.Navigate(new AddEdit(null));
        }
    }
}
