using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
   public interface IDateTime
    {
         DayOfWeek DayOfWeek { get; set;}

        int Hour { get; set; }
    }

}
