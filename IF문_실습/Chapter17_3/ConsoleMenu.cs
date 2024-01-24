using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter17_3
{
    class ConsoleMenu
    {
        public List<MenuItem> MenuList { get; set; }
        public ConsoleMenu()
        {
            MenuList = new List<MenuItem>();
        }
        public void Show()
        {
            foreach (MenuItem item in MenuList)
                Console.WriteLine($"{item.MenuChar}.{item.MenuTitle}");
        }
        public void Read()
        {
            Console.WriteLine("메뉴선택: ");
            string retVal = Console.ReadLine();
            foreach (MenuItem item in MenuList)
            {
                if (item.MenuChar == retVal)
                    item.CallEvent(this, retVal);
            }
        }
    }
}
