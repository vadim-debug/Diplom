using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
    /// Логика взаимодействия для MainTasks.xaml
    /// </summary>
    public partial class MainTasks : Page
    {
        AppContext db = new AppContext();
        int role;
        public MainTasks(int Role)
        {
            InitializeComponent();
            role = Role;
            if (role == 1) 
            { 
             BtnAdd.Visibility = Visibility.Hidden;
             BtnRemove.Visibility = Visibility.Hidden;   
             BtnWorker.Visibility = Visibility.Hidden;   
            }

            List<Task> Tasks = db.Tasks.ToList();
            DTGridClient.ItemsSource = Tasks;
            cmbPriority.ItemsSource = db.Priorities.ToList();
        }

        private void AllTask_Click(object sender, RoutedEventArgs e)
        {
            cmbPriority.SelectedIndex = -1;
            txtWorker.Text = "";

            List<Task> Tasks = db.Tasks.ToList();
            DTGridClient.ItemsSource = Tasks;
        }

        private void btnTask1_Click(object sender, RoutedEventArgs e)
        {
            cmbPriority.SelectedIndex = -1;
            txtWorker.Text = "";
            List<Task> Tasks = db.Tasks.ToList();
            Tasks = Tasks.Where(d => d.TaskType_Id == 1).ToList();
            DTGridClient.ItemsSource = Tasks;
           
        }

        private void btnTask3_Click(object sender, RoutedEventArgs e)
        {
            cmbPriority.SelectedIndex = -1;
            txtWorker.Text = "";
            List<Task> Tasks = db.Tasks.ToList();
            Tasks = Tasks.Where(d => d.TaskType_Id == 3).ToList();
            DTGridClient.ItemsSource = Tasks;
            
        }

        private void btnTask2_Click(object sender, RoutedEventArgs e)
        {
            cmbPriority.SelectedIndex = -1;
            txtWorker.Text = "";
            List<Task> Tasks = db.Tasks.ToList();
            Tasks = Tasks.Where(d => d.TaskType_Id == 2).ToList();
            DTGridClient.ItemsSource = Tasks;
           
        }

        private void BtnRemove_Click(object sender, RoutedEventArgs e)
        {
            Task task = DTGridClient.SelectedItem as Task;
            if (task is null)
            {
                MessageBox.Show("Выберите элемент для удаления");
            }
            else
            {
                if (MessageBox.Show($"Вы точно хотите удалить элемент ?", "Внимание",
                    MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    try
                    {
                        db.Tasks.Remove(task);
                        db.SaveChanges();
                        MessageBox.Show("Данные удалены! ");
                        DTGridClient.ItemsSource = db.Tasks.ToList();

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message.ToString());
                    }
                }
            }
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddEdit());
        }

       

        private void cmbPriority_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Filter();
        }
        public void Filter() 
        {
            Priority CurrentPriority = cmbPriority.SelectedItem as Priority;
            List<Task> Persons = db.Tasks.ToList();
            Persons = Persons.Where(d => d.Priority == CurrentPriority).ToList();
            Persons = Persons.Where(d => d.Date.ToLower().Contains(txtWorker.Text.ToLower())).ToList();
            DTGridClient.ItemsSource = Persons;
        }

        private void txtWorker_TextChanged(object sender, TextChangedEventArgs e)
        {
            Filter();
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            List<Task> Tasks = db.Tasks.ToList();
            DTGridClient.ItemsSource = Tasks;
        }

        private void BtnWorker_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new WorkerPage());
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }
    }
}
