using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharpExam.Ch._10.ArrayExam
{
    class Yield
    {
        int[] numbers = { 1, 2, 3, 4 };
        public IEnumerator GetEnumerator()
        { 
            yield return numbers[0];
            yield return numbers[1];
            yield return numbers[2];
            yield break;
            yield return numbers[3];
        }

        public void Main()
        {
            var obj = new Yield();
            foreach(int i in obj)
            {
                Console.WriteLine(i);
            }
        }
    }
}
