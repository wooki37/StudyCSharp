using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter17_2
{
    class MenuItem
    {
        public delegate void MenuKeyPressDelegate(object sender, MenuArgs args);
        public string MenuChar { get; set; }
        public string MenuTitle { get; set; }
        public MenuKeyPressDelegate KeyPressDelegate { get; set; }  // func(sender, args)
    
    public MenuItem(string menu_char, string menu_title, MenuKeyPressDelegate dele)
    {
        MenuChar = menu_char;
        MenuTitle = menu_title;
        KeyPressDelegate = dele;
    }
        public MenuItem() : this(null, null, null)
        {
        }
    }
}
