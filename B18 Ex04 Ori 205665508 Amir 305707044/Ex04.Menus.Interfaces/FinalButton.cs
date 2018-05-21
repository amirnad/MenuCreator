using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class FinalButton : MenuBar
    {
        private readonly IActionButtonListener r_ActionListener;

        public FinalButton(string o_Name, SubMenu o_Parent, IActionButtonListener i_Listener) :base(o_Name, o_Parent)
        {
            r_ActionListener = i_Listener;
        }

        public override void ExecuteMenuButton()
        {
            Console.Clear();
            r_ActionListener.ExecuteAction();
            
        }
    }
}
