﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ex04.Menus.Delegates
{
    public class FinalButton : MenuBar
    {
        public event Action OnSelected; 

        public FinalButton(string o_Name, SubMenu o_Parent) :base(o_Name, o_Parent)
        {
        }

        public override void ExecuteMenuButton()
        {
            Console.Clear();
            OnSelected.Invoke();
            Thread.Sleep(500);
            Console.Clear();
            m_ButtonParent.ExecuteMenuButton();
        }
    }
}