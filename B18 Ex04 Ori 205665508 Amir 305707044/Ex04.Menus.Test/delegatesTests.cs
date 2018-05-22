using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    class delegatesTests
    {
        public static void runDelegatesTest()
        {
            TimeShower timeObj = new TimeShower();
            DateShower dateObj = new DateShower();
            VersionShower versionObj = new VersionShower();
            Capitals capitalsObj = new Capitals();

            Delegates.Menu mainMenu = new Delegates.Menu("main");
            Delegates.SubMenu timeAndDate = new Delegates.SubMenu("show Time/Date", mainMenu);
            Delegates.SubMenu versionAndCapitals = new Delegates.SubMenu("version and capitals", mainMenu);
            Delegates.FinalButton showTime = new Delegates.FinalButton("show time", timeAndDate);
            showTime.OnSelected += timeObj.showTime;

            Delegates.FinalButton showDate = new Delegates.FinalButton("show Date", timeAndDate);
            showDate.OnSelected += dateObj.showDate;

            Delegates.FinalButton showVersion = new Delegates.FinalButton("show version", versionAndCapitals);
            showVersion.OnSelected += versionObj.showVersion;

            Delegates.FinalButton CapitalLettersCount = new Delegates.FinalButton("Count capitals", versionAndCapitals);
            CapitalLettersCount.OnSelected += capitalsObj.capitalLettersProcess;

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
