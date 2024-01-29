using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharpExam.Ch._04.NullConditionalOperator
{
    class NullConditionalOperatorExam
    {
        public void Main() {
            ArrayList a = null;
            a?.Add("야구");   // a?.가 null을 반환하므로 Add() 메소드는 호출되지 않음
            a?.Add("축구");
            // a?.가 null을 반환하므로 'Count:'외에는 아무것도 출력하지 않습니다.
            Console.WriteLine($"Count : {a?.Count}");
            Console.WriteLine($"{a?[0]}");
            Console.WriteLine($"{a?[1]}");

            a = new ArrayList();    // a는 이제 더 이상 null이 아닙니다.
            a?.Add("야구");
            a?.Add("축구");
            Console.WriteLine($"Count : {a?.Count}");
            Console.WriteLine($"{a?[0]}");
            Console.WriteLine($"{a?[1]}");
        }
    }
}
