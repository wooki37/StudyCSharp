using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter17_2
{
    public class Exam17_2
    {
        ConsoleMenu Menu;
        public Exam17_2()
        {
            Menu = new ConsoleMenu();
        }
        public void Run()
        {
            // 1. Menu1 "1", "Menu1", Delegate
            // 2. Menu2
            // ...
            // q. 종료
            // 1
            CreateMenu();
            while(true)
            {
                Menu.Show();
                Menu.Read();
            }
        }

        private void CreateMenu()
        {
            Menu.MenuList.Add(new MenuItem("1", "Menu_Title_1", Menu_1_Callback));
            Menu.MenuList.Add(new MenuItem("2", "Menu_Title_2", Menu_1_Callback));
            Menu.MenuList.Add(new MenuItem("q", "프로그램 종료", Quit_Callback));
        }

        private void Quit_Callback(object sender, MenuArgs args)
        {
            Environment.Exit(0);
            Console.WriteLine($"Menu_1_Callbakc() 호출됨! sender={sender.ToString()} args = {((MenuKeyPressArgs)args).MenuChar}");
            Console.WriteLine("bye...");
        }

        private void Menu_1_Callback(object sender, MenuArgs args)
        {
            Console.WriteLine($"Menu_1_Callbakc() 호출됨! sender={sender.ToString()} args = {((MenuKeyPressArgs)args).MenuChar}");
        }
        private void Menu_2_Callback(object sender, MenuArgs args)
        {
            Console.WriteLine($"Menu_2_Callbakc() 호출됨! sender={sender.ToString()} args = {((MenuKeyPressArgs)args).MenuChar}");
        }
    }
}
