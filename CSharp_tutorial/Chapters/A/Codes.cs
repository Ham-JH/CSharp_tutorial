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
                    {
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
                    }
                    break;

                case 100:
                    {
                        // ToLower() : 현재 문자열의 모든 대문자를 소문자로 바꾼 새 문자열을 반환합니다.
                        Console.WriteLine("Lower() : '{0}'", "ABC".ToLower());
                        // ToUpper() : 현재 문자열의 모든 소문자를 대문자로 바꾼 새 문자열을 반환합니다.
                        Console.WriteLine("ToUpper() : '{0}'", "abc".ToUpper());

                        // Insert() : 현재 문자열의 지정된 위치에 지정된 문자열이 삽입된 새 문자열을 반환합니다.
                        Console.WriteLine("Insert() : '{0}'", "Happy Friday!".Insert(5, " Sunny"));
                        // Remove() : 현재 문자열의 지정된 위치로부터 지정된 수만큼의 문자가 삭제된 새 문자열을 반환합니다.
                        Console.WriteLine("Remove() : '{0}'", "I Don't Love You".Remove(2, 6));

                        // Trim() : 현재 문자열의 앞/뒤에 있는 공백을 삭제한 새 문자열을 반환합니다.
                        Console.WriteLine("Trim() : '{0}'", " No Spaces ".Trim());
                        // TrimStart() : 현재 문자열의 앞에 있는 공백을 삭제한 새 문자열을 반환합니다.
                        Console.WriteLine("TrimStart() : '{0}'", " No Spaces ".TrimStart());
                        // TrimEnd() : 현재 문자열의 뒤에 있는 공백을 삭제한 뒤 새 문자열을 반환합니다.
                        Console.WriteLine("TrimEnd() : '{0}'", " No Spaces ".TrimEnd());
                    }
                    break;

                case 101:
                    {
                        string greeting101 = "Good morning";

                        // Split() : 현재 문자열을 지정된 문자를 기준으로 분리한 문자열의 배열을 반환합니다.
                        Console.WriteLine(greeting101.Substring(0, 5)); // "Good"
                        Console.WriteLine(greeting101.Substring(5));    // "morning"
                        Console.WriteLine();

                        // SubString() : 현재 문자열을 지정된 위치로부터 지정된 수만큼의 문자로 이루어진 새 문자열을 반환합니다.
                        string[] arr101 = greeting101.Split(
                            new string[] { " " }, StringSplitOptions.None);
                        Console.WriteLine("Word Count : {0}", arr101.Length);

                        foreach(string element101 in arr101)
                        {
                            Console.WriteLine("{0}", element101);
                        }

                    }
                    break;
            }
        }
    }
}
