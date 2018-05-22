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
        public event Action Selected; 

        public FinalButton(string o_Name, SubMenu o_Parent) :base(o_Name, o_Parent)
        {
        }

        public override void ExecuteMenuButton()
        {
            Console.Clear();
            OnSelected();
            Thread.Sleep(500);
            Console.Clear();
            m_ButtonParent.ExecuteMenuButton();
        }
        private void OnSelected()
        {
            if (Selected!= null)
            {
                Selected.Invoke();
            }
            else
            {
                throw new Exception("There are no callbacks!");
            }
        }
    }
}
