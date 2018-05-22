using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus;

namespace Ex04.Menus.Test
{

    public class interfacesTest
    {

        public static void RunInterFaceTest()
        {
            Interfaces.Menu mainMenu = new Interfaces.Menu("main");

            Interfaces.SubMenu timeAndDate = new Interfaces.SubMenu("show Time/Date", mainMenu);
            Interfaces.SubMenu versionAndCapitals = new Interfaces.SubMenu("version and capitals", mainMenu);

            Interfaces.FinalButton showTime = new Interfaces.FinalButton("show time", timeAndDate, new TimeShowerBridge());
            Interfaces.FinalButton showDate = new Interfaces.FinalButton("show Date", timeAndDate, new DateShowerBridge());

            Interfaces.FinalButton showVersion = new Interfaces.FinalButton("show version", versionAndCapitals, new VersionBridge());
            Interfaces.FinalButton CapitalLettersCount = new Interfaces.FinalButton("Count capitals", versionAndCapitals, new CapitalsBridge());

            mainMenu.AddMenuButton(timeAndDate);
            mainMenu.AddMenuButton(versionAndCapitals);

            timeAndDate.AddMenuButton(showTime);
            timeAndDate.AddMenuButton(showDate);

            versionAndCapitals.AddMenuButton(showVersion);
            versionAndCapitals.AddMenuButton(CapitalLettersCount);


            mainMenu.ShowMenu();
        }
    }
}
