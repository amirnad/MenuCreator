﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    class TimeShower
    {
        public void showTime()
        {
            Console.WriteLine(DateTime.Now.ToShortTimeString());
        }
    }
    class DateShower
    {
        public void showDate()
        {
            Console.WriteLine(DateTime.Now.Date.ToShortDateString());
        }
    }
}
