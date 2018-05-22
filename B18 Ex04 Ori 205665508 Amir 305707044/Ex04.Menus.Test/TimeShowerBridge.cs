using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    class TimeShowerBridge : Interfaces.IActionButtonListener
    {
        public void ExecuteAction()
        {
            TimeShower timeObj = new TimeShower();
            timeObj.showTime();
        }
    }
}
