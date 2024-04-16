using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharpExam.Ch._10.ArrayExam
{
    class Indexer
    {
        private int[] array;

        public Indexer()
        {
            array = new int[3];
        }
        public int this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                if (index >= array.Length)
                {
                    Array.Resize<int>(ref array, index + 1);
                    Console.WriteLine($"Array Resized : {array.Length}");
                }
                array[index] = value;
            }
        }
        public int Length
        {
            get
            {
                return array.Length;
            }
        }

        public void Main()
        {
            Indexer index = new Indexer();
            for (int i = 0; i < 5; i++)
            {
                index[i] = i;   // 배열을 다루듯 인덱스를 통해 데이터를 입력합니다.
            }
            for (int i = 0; i < index.Length; i++)
            {
                Console.WriteLine(index[i]);    // 데이터를 얻어올 때도 인덱스를 이용합니다.
            }
        }
    }
}
