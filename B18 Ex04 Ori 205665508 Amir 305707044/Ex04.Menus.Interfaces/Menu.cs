using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class Menu 
    {
        private SubMenu m_MainMenu;

        public Menu(string o_Name, SubMenu o_Parent)
        {
            m_MainMenu = new SubMenu(o_Name, o_Parent);
        }
        public void ShowMenu()
        {
            Console.Clear();
            m_MainMenu.ExecuteMenuButton();
        }


    }
}
