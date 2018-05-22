using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    class VersionBridge : Interfaces.IActionButtonListener
    {
        public void ExecuteAction()
        {
            VersionShower versionObj = new VersionShower();
            versionObj.ShowVersion();
        }
    }
    class CapitalsBridge : Interfaces.IActionButtonListener
    {
        public void ExecuteAction()
        {
            Capitals capitalsObj = new Capitals();
            capitalsObj.CapitalLettersProcess();
        }
    }
}
