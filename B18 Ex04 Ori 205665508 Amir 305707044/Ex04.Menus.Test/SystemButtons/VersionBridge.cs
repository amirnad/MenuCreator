using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    public class VersionBridge : Interfaces.IActionButtonListener
    {
        public void ExecuteAction()
        {
            SystemFunctionality versionObj = new SystemFunctionality();
            versionObj.ShowVersion();
        }
    }
}
