using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom
{
    public class Data
    {
       public int CheckData(string Info, string Date, int User,int priority,int TType) 
        {
            if (Info != "" && Date != "" && User != -1 && priority != -1 && TType != -1 && Info.Length >5)
            {
                return 1;
            }
             else 
            { return 0; }
        }
    }
}
