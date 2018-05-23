using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    public class CapitalsBridge : Interfaces.IActionButtonListener
    {
        public void ExecuteAction()
        {
            SystemFunctionality capitalsObj = new SystemFunctionality();
            capitalsObj.CapitalLettersProcess();
        }
    }
}
