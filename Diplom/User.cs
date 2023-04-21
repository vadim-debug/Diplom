using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom
{
    public class User
    {
        public int ID { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int Role_Id { get; set; }    

        public virtual Role Role { get; set; }
        public User()
        {

        }   
            
        public User( string Login, string Password,int Role_Id)
        {
           
            this.Login = Login;
            this.Password = Password;
            this.Role_Id = Role_Id;    
        }
    }
}
