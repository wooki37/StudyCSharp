using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter17_3
{
    class MenuItem
    {
    public event EventHandler MenuKeyPressEventHandler;
    public string MenuChar { get; set; }
    public string MenuTitle { get; set; }
    public MenuItem(string menu_char, string menu_title)
    {
        MenuChar = menu_char;
        MenuTitle = menu_title;
    }
    public MenuItem() : this(null, null)
    {
    }
        public void CallEvent(object sender, string args)
        {
            if (MenuKeyPressEventHandler != null)
                MenuKeyPressEventHandler(sender, new MenuKeyPressArgs(args));

        }
}
}
