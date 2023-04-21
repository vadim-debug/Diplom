using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom
{
    public class Task
    {
        public int ID { get; set; }
        public string Info { get; set; }           
        public string Date { get; set; }
        public int User_Id { get; set; }
        public int Priority_Id { get; set; }
        public int TaskType_Id { get; set; }

        public virtual User User { get; set; }  
       
        public virtual Priority Priority { get; set; }

        public virtual TaskType TaskType { get; set; }
        public Task() { }

        public Task( string Info, string Date, int User_Id, int Priority_Id, int TaskType_Id)
        {
            
            this.Info = Info;
            this.Date = Date;
            this.User_Id = User_Id;
            this.Priority_Id = Priority_Id;
            this.TaskType_Id = TaskType_Id;
        }
    }
}
