using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom
{
    public class Priority
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Priority() { }

        public Priority(string Name) 
        {
            this.Name = Name;
        }
    }
  
}
