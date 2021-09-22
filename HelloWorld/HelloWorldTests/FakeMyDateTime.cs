using HelloWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Tests
{
    public class FakeMyDateTime: IDateTime
    {
       public  DayOfWeek DayOfWeek { get; set; }

        public int Hour { get; set; }
        public FakeMyDateTime( DayOfWeek dayOfWeek, int hour)
        {
            DayOfWeek = dayOfWeek;
            Hour = hour;

            
        }


    }
}
