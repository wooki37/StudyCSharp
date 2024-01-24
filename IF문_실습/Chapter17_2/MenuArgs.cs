using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter17_2
{
     class MenuArgs
    {
    }
    class MenuKeyPressArgs : MenuArgs
    {
        public string MenuChar { get; set; }
        public MenuKeyPressArgs(string menu_char)
        {
            MenuChar = menu_char;
        }
    }
}
