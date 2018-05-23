using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class Menu : SubMenu
    {
        public Menu(string o_Name) : base(o_Name, null)
        {
        }
       
        public void ShowMenu()
        {
            Console.Clear();
            ExecuteMenuButton();
        }
    }
}
