using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_tutorial.Chapters.A
{
    class Codes : CodesClass
    {
        public Codes(int arg) : base(arg)
        {
        }

        public override void RunCode(int arg)
        {
            switch (arg)
            {
                case 98:
                    string greeting = "Good Morning";

                    Console.WriteLine(greeting);
                    Console.WriteLine();

                    // IndexOf() : 현재 문자열 내에서 찾고자 하는 지정된 문자 또는 문자열의 위치를 찾습니다.
                    Console.WriteLine("IndexOf 'Good' : {0}", greeting.IndexOf("Good"));
                    Console.WriteLine("IndexOf 'o' : {0}", greeting.IndexOf('o'));

                    // LastIndexOf() : 현재 문자열 내에서 찾고자 하는 지정된 문자 또는 문자열의 마지막 위치를 찾습니다.
                    Console.WriteLine("LastIndexOf 'Good' : {0}", greeting.LastIndexOf("Good"));
                    Console.WriteLine("LastIndexOf 'o' : {0}", greeting.LastIndexOf("o"));

                    // StartsWith() : 현재 문자열이 지정된 문자열로 시작하는지를 평가합니다.
                    Console.WriteLine("StartsWith 'Good' : {0}", greeting.StartsWith("Good"));
                    Console.WriteLine("StartsWith 'Morning' : {0}", greeting.StartsWith("Morning"));

                    // EndsWith() : 현재 문자열이 지정된 문자열로 끝나는지를 평가합니다.
                    Console.WriteLine("EndsWith 'Good' : {0}", greeting.EndsWith("Good"));
                    Console.WriteLine("EndsWith 'Morning' : {0}", greeting.EndsWith("Morning"));

                    // Contains() : 현재 문자열이 지정된 문자열을 포함하는지를 평가합니다.
                    Console.WriteLine("Contains 'Evening' : {0}", greeting.Contains("Evening"));
                    Console.WriteLine("Contains 'Morning' : {0}", greeting.Contains("Morning"));

                    // Replace() : 현재 문자열에서 지정된 문자열이 다른 지정된 문자열로 모두 바뀐 새 문자열을 반환합니다.
                    Console.WriteLine("Replaced 'Morning' with 'Evening' : {0}",
                        greeting.Replace("Morning", "Evening"));
                    break;
            }
        }
    }
}
