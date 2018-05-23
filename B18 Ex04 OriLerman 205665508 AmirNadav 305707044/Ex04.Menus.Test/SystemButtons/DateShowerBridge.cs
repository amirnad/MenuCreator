using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    public class DateShowerBridge : Interfaces.IActionButtonListener
    {
        public void ExecuteAction()
        {
            SystemFunctionality dateObj = new SystemFunctionality();
            dateObj.showDate();
        }
    }
}
