using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    public class delegatesTests
    {
        public static void runDelegatesTest()
        {
            SystemFunctionality allFunctionality = new SystemFunctionality();

            Delegates.Menu mainMenu = new Delegates.Menu("main");
            Delegates.SubMenu timeAndDate = new Delegates.SubMenu("show Time/Date", mainMenu);
            Delegates.SubMenu versionAndCapitals = new Delegates.SubMenu("version and capitals", mainMenu);
            Delegates.FinalButton showTime = new Delegates.FinalButton("show time", timeAndDate);
            showTime.OptionSelectedEventHandler += allFunctionality.showTime;

            Delegates.FinalButton showDate = new Delegates.FinalButton("show Date", timeAndDate);
            showDate.OptionSelectedEventHandler += allFunctionality.showDate;

            Delegates.FinalButton CapitalLettersCount = new Delegates.FinalButton("Count capitals", versionAndCapitals);
            CapitalLettersCount.OptionSelectedEventHandler += allFunctionality.CapitalLettersProcess;

            Delegates.FinalButton showVersion = new Delegates.FinalButton("show version", versionAndCapitals);
            showVersion.OptionSelectedEventHandler += allFunctionality.ShowVersion;

            mainMenu.AddMenuButton(timeAndDate);
            mainMenu.AddMenuButton(versionAndCapitals);

            timeAndDate.AddMenuButton(showTime);
            timeAndDate.AddMenuButton(showDate);

            versionAndCapitals.AddMenuButton(CapitalLettersCount);
            versionAndCapitals.AddMenuButton(showVersion);

            mainMenu.ShowMenu();
        }
    }
}
