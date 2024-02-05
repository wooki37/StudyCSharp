using System;

namespace ThisIsCSharpExam.Ch._06.MethodExam
{
    class LocalFunction
    {
        public void Main()
        {
            Console.WriteLine(ToLowerString("Hello!"));
            Console.WriteLine(ToLowerString("Good Morning~"));
            Console.WriteLine(ToLowerString("This is C#"));
        }
        static string ToLowerString(string input)   // 메소드 선언
        {
            var arr = input.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = ToLowerChar(i);
            }
            char ToLowerChar(int i) // 로컬 함수 선언
            {
                // ToLowerString() 메소드의 지역변수 arr을 사용합니다.
                // 로컬 함수는 자신이 속한 메소드의 지역 변수를 자유롭게 읽고, 쓰기 가능
                if (arr[i] < 65 || arr[i] > 90) // A ~ Z의 ASCII 값 : 65 ~ 90
                    return arr[i];
                else // a ~ z의 ASCII 값 : 97 ~ 122
                    return (char)(arr[i] + 32);
            }
            return new string(arr);
        }
    }
}
