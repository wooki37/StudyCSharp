using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter17_3
{
    public class Exam17_3
    {
        ConsoleMenu Menu;
        public Exam17_3()
        {
            Menu = new ConsoleMenu();
        }
        public void Run()
        {
            CreateMenu();
            while (true)
            {
                Menu.Show();
                Menu.Read();
            }
        }

        private void CreateMenu()
        {
            MenuItem item = new MenuItem("1", "MenuTitle_1");
            item.MenuKeyPressEventHandler += Menu_1_Callback;
            Menu.MenuList.Add(item);

            item = new MenuItem("2", "MenuTitle_2");
            item.MenuKeyPressEventHandler += Menu_2_Callback;
            Menu.MenuList.Add(item);

            item = new MenuItem("q", "프로그램 종료");
            Menu.MenuList.Add(item);
            item.MenuKeyPressEventHandler += Quit_Callback;
        }

        private void Quit_Callback(object sender, EventArgs args)
        {
            
            Console.WriteLine($"Menu_1_Callbakc() 호출됨! sender={sender.ToString()} args = {((MenuKeyPressArgs)args).MenuChar}");
            Console.WriteLine("bye...");
            Environment.Exit(0);
        }

        private void Menu_1_Callback(object sender, EventArgs args)
        {
            Console.WriteLine($"Menu_1_Callbakc() 호출됨! sender={sender.ToString()} args = {((MenuKeyPressArgs)args).MenuChar}");
        }
        private void Menu_2_Callback(object sender, EventArgs args)
        {
            Console.WriteLine($"Menu_2_Callbakc() 호출됨! sender={sender.ToString()} args = {((MenuKeyPressArgs)args).MenuChar}");
        }
    }
}
