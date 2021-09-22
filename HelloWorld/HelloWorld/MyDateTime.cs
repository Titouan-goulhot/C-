using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class MyDateTime : IDateTime
    {
        public DayOfWeek DayOfWeek { get; set; }

        public int Hour { get; set; }
        public MyDateTime()
        {
            DayOfWeek = DateTime.Now.DayOfWeek;;
            Hour = DateTime.Now.Hour;
        }

        public string HelloMessage { get; set; }


    }
}

