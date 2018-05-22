using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ex04.Menus.Delegates
{
    public class FinalButton : MenuBar
    {
        public event Action OptionSelectedEventHandler;

        public FinalButton(string o_Name, SubMenu o_Parent) : base(o_Name, o_Parent)
        {
        }

        public override void ExecuteMenuButton()
        {
            menuOption_OptionSelectedEventHandler();
        }

        private void menuOption_OptionSelectedEventHandler()
        {
            Console.Clear();
            OnSelected();
            Thread.Sleep(500);
            Console.Clear();
            m_ButtonParent.ExecuteMenuButton();
        }

        private void OnSelected()
        {
            if (OptionSelectedEventHandler != null)
            {
                OptionSelectedEventHandler.Invoke();
            }
            else
            {
                throw new Exception("There are no callbacks!");
            }
        }
    }
}
