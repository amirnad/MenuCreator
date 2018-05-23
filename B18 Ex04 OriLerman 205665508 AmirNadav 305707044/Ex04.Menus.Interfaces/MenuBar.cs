namespace Ex04.Menus.Interfaces
{
    public abstract class MenuBar
    {
        private readonly string r_ButtonName;
        protected SubMenu m_ButtonParent;

        public MenuBar(string i_Name, SubMenu i_Parent)
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
