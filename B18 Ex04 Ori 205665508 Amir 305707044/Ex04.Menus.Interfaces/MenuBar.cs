namespace Ex04.Menus.Interfaces
{
    public class MenuBar
    {
        private readonly string r_ButtonName;
        protected MenuBar m_ButtonParent;

        public MenuBar(string i_Name, MenuBar i_Parent)
        {
            r_ButtonName = i_Name;
            m_ButtonParent = i_Parent;
        }

        public string ButtonName
        {
            get { return r_ButtonName; }
        }

        public abstract void ExecuteMenuButton();

    }
}
