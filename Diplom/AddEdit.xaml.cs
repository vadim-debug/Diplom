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
    /// Логика взаимодействия для AddEdit.xaml
    /// </summary>
    public partial class AddEdit : Page
    {
        AppContext db = new AppContext();
       
        public AddEdit()
        {
            InitializeComponent();
            CmbPriority.ItemsSource = db.Priorities.ToList();
            CmbUser.ItemsSource = db.Users.ToList();
            CmbTT.ItemsSource = db.TaskTypes.ToList();


        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            if (txtInfo.Text != "" && DateTask.Text != "" && CmbPriority.SelectedIndex != -1 && CmbTT.SelectedIndex != -1 && CmbUser.SelectedIndex != -1)
            {
                Priority Mypriority = null;

                using (AppContext db = new AppContext())
                {
                    Mypriority = db.Priorities.Where(b => b.Name == CmbPriority.Text).FirstOrDefault();
                }

                TaskType MyTT = null;

                using (AppContext db = new AppContext())
                {
                    MyTT = db.TaskTypes.Where(b => b.Name == CmbTT.Text).FirstOrDefault();
                }

                User MyUser = null;

                using (AppContext db = new AppContext())
                {
                    MyUser = db.Users.Where(b => b.Login == CmbUser.Text).FirstOrDefault();
                }
                // txtExample.Text = MyUser.ID.ToString();

                string info = txtInfo.Text;
                string Date = DateTask.Text;
                int Priority = Mypriority.ID;
                int tt = MyTT.ID;
                int user = MyUser.ID;
                Task task = new Task(info, Date, user, Priority, tt);
                db.Tasks.Add(task);
                db.SaveChanges();
                MessageBox.Show("Успешно");
                this.NavigationService.GoBack();
            }
            else
            {
                MessageBox.Show("Заполните все поля");
            }
        }


    }
}
