using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Diplom
{
    class AppContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Priority> Priorities { get; set; }
        public DbSet<Role> Roles { get; set; }

        public DbSet<TaskType> TaskTypes { get; set; }
        
        public DbSet<Task> Tasks { get; set; }
        public AppContext() : base("DefaultConnection") { }
    }
}
