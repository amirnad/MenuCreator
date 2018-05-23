using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public class SubMenu : MenuBar
    {
        private const uint k_LeaveSubMenu = 0;
        private List<MenuBar> m_SubMenuOptions = new List<MenuBar>();

        public SubMenu(string o_Name, SubMenu o_Parent) : base(o_Name, o_Parent)
        {
        }

        public void AddMenuButton(MenuBar o_ButtonToAdd)
        {
            m_SubMenuOptions.Add(o_ButtonToAdd);
        }

        public override void ExecuteMenuButton()
        {
            uint userChoice;
            Console.Clear();
            showAllButtons();
            readUserChoice(out userChoice);
            executeChoice(userChoice);
        }

        private void readUserChoice(out uint o_UserChoice)
        {
            const string k_ChooseOptionMessage = "Please Choose One of The Options: ";
            const string k_InvalidChoiceMessage = "Please Enter a Valid Option!";
            bool doneReading = false;
            string userInput = string.Empty;

            Console.Write(k_ChooseOptionMessage);
            while (!doneReading)
            {
                userInput = Console.ReadLine();
                doneReading = checkInput(userInput);
                if (!doneReading)
                {
                    Console.WriteLine(k_InvalidChoiceMessage);
                }
            }

            o_UserChoice = uint.Parse(userInput);
        }

        private bool checkInput(string i_UserInput)
        {
            bool isInputLegal = false;
            uint userChoice;

            isInputLegal = uint.TryParse(i_UserInput, out userChoice);
            if (isInputLegal)
            {
                isInputLegal = userChoice >= k_LeaveSubMenu && userChoice <= m_SubMenuOptions.Count;
            }

            return isInputLegal;
        }

        private void executeChoice(uint i_UserChoice)
        {
            int realButton = (int)i_UserChoice - 1;
            if (i_UserChoice != k_LeaveSubMenu)
            {
                m_SubMenuOptions[realButton].ExecuteMenuButton();
            }
            else if (m_ButtonParent != null)
            {
                m_ButtonParent.ExecuteMenuButton();
            }
            else
            {
                exitInterfaceSubMenu();
            }
        }

        private void exitInterfaceSubMenu()
        {
            Console.Clear();
            Console.WriteLine("Leaving Interfaces Menu. BYE BYE!");
            System.Threading.Thread.Sleep(300);
            Console.Clear();
        }

        private void showAllButtons()
        {
            const string k_Border = "==========================";
            StringBuilder subMenuMessage = new StringBuilder();
            subMenuMessage.AppendFormat("{0}{1}{2}", ButtonName, Environment.NewLine, k_Border);
            Console.WriteLine(subMenuMessage);
            showSubButtons();
        }

        private void showSubButtons()
        {
            StringBuilder menuButtons = new StringBuilder();
            const string k_BackMessage = "0. Back";

            int menuOption;
            menuButtons.AppendFormat(k_BackMessage);
            menuButtons.AppendFormat(Environment.NewLine);
            foreach (MenuBar button in m_SubMenuOptions)
            {
                menuOption = m_SubMenuOptions.IndexOf(button);
                menuOption++;
                menuButtons.AppendFormat("{0}. {1}{2}", menuOption, button.ButtonName, Environment.NewLine);
            }

            Console.WriteLine(menuButtons);
        }
    }
}
