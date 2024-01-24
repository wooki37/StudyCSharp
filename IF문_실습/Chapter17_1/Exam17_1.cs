using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter17_1
{
    public class Exam17_1
    {
        delegate void MyDelegate(int val);
        delegate int MyDelegate1(int val);
        public void Run()
        {
            int a = 3;
            Console.WriteLine(a);
            Student st = new Student();
            st.Name = "홍길동";
            Console.WriteLine(st);

            //DelegateTest(3);
            MyDelegate dele = new MyDelegate(DelegateTest);
            MyDelegate1 dele1 = new MyDelegate1(DelegateTest1);
            dele(4);
        }
        private void DelegateTest(int myVal)
        {
            Console.WriteLine($"DelegateTest() called {myVal}");
        }
        private int DelegateTest1(int myVal)
        {
            return myVal + 1;
        }
    }
}
