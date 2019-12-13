using System;
using System.Collections.Generic;
using System.Globalization;
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

                case 106:
                    {
                        string fmt106 = "{0, -20}{1,-15}{2,30}";

                        Console.WriteLine(fmt106, "Publisher", "Author", "Title");
                        Console.WriteLine(fmt106, "Marvel", "Stan Lee", "Iron Man");
                        Console.WriteLine(fmt106, "Hanbit", "Sanghyun Park", "C# 7.0 Programming");
                        Console.WriteLine(fmt106, "Prentice Hann", "K&R", "The C Programming Language");
                    }
                    break;

                case 108:
                    {
                        // D : 10진수
                        Console.WriteLine("10진수: {0:D}", 123);
                        Console.WriteLine("10진수: {0:D5}", 123);

                        // X : 16진수
                        Console.WriteLine("16진수: {0:X}", 0xFF1234);
                        Console.WriteLine("16진수: {0:X8}", 0xFF1234);

                        // N : 숫자
                        Console.WriteLine("숫자: {0:N}", 123456789);
                        Console.WriteLine("숫자: {0:N0}", 123456789); // 자릿수 0은 소숫점 이하를 제거함.

                        // F : 고정소수점
                        Console.WriteLine("고정소수점: {0:F}", 123.45);
                        Console.WriteLine("고정소수점: {0:F5}", 123.45);

                        // E : 공학용
                        Console.WriteLine("공학: {0:E}", 123.456789);
                    }
                    break;

                case 111:
                    {
                        DateTime dt111 = new DateTime(2018, 11, 3, 23, 18, 22);

                        Console.WriteLine("12시간 형식: {0:yyyy-MM-dd tt hh:mm:ss (ddd)}", dt111);
                        Console.WriteLine("12시간 형식: {0:yyyy-MM-dd tt hh:mm:ss (ddd)}", dt111);

                        CultureInfo ciKo111 = new CultureInfo("ko-KR");
                        Console.WriteLine();
                        Console.WriteLine(dt111.ToString("yyyy-MM-dd tt hh:mm:ss (ddd)", ciKo111));
                        Console.WriteLine(dt111.ToString("yyyy-MM-dd HH:mm:ss (dddd)", ciKo111));
                        Console.WriteLine(dt111.ToString(ciKo111));

                        CultureInfo ciEn111 = new CultureInfo("en-US");
                        Console.WriteLine();
                        Console.WriteLine(dt111.ToString("yyyy-MM-dd tt hh:mm:ss (ddd)", ciEn111));
                        Console.WriteLine(dt111.ToString("yyyy-MM-dd HH:mm:ss (ddd)", ciEn111));
                        Console.WriteLine(dt111.ToString(ciEn111));

                    }
                    break;

                case 114:
                    {
                        string name114 = "김튼튼";
                        int age114 = 23;
                        Console.WriteLine($"{name114,-10}, {age114:D3}");

                        name114 = "박날씬";
                        age114 = 30;
                        Console.WriteLine($"{name114}, {age114,-10:D3}");

                        name114 = "이비실";
                        age114 = 17;
                        Console.WriteLine($"{name114},{(age114 > 20 ? "성인" : "미성년자")}");
                    }
                    break;
            }
        }
    }
}
