using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus;

namespace Ex04.Menus.Test
{

    class interfacesTest
    {
        public static void Main()
        {
            RunTest();
        }
        public static void RunTest()
        {
            Interfaces.Menu mainMenu = new Interfaces.Menu("main");
            Interfaces.SubMenu sub0 = new Interfaces.SubMenu("sub0", mainMenu);
            Interfaces.FinalButton fb = new Interfaces.FinalButton("show time", mainMenu, new TimeShowerBridge());
            mainMenu.AddMenuButton(sub0);
            mainMenu.AddMenuButton(fb);

            mainMenu.ShowMenu();
        }
    }
}
