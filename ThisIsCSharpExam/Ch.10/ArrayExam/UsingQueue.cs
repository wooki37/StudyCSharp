using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharpExam.Ch._10.ArrayExam
{
    class UsingQueue
    {
        public void Main()
        {
            Queue que = new Queue();
            que.Enqueue(1);
            que.Enqueue(2);
            que.Enqueue(3);
            que.Enqueue(4);
            que.Enqueue(5);

            while(que.Count > 0)
            {
                Console.WriteLine(que.Dequeue());
            }
        }
    }
}
