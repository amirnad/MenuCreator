using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    public class TimeShowerBridge : Interfaces.IActionButtonListener
    {
        public void ExecuteAction()
        {
            SystemFunctionality timeObj = new SystemFunctionality();
            timeObj.showTime();
        }
    }
}
