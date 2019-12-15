using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_tutorial.Chapters._5
{
    class Codes : CodesClass
    {
        public Codes(int arg) : base(arg)
        {
        }

        public override void RunCode(int arg)
        {
            switch(arg)
            {
                case 149:
                    {
                        Console.Write("숫자를 입력하세요 : ");

                        string input149 = Console.ReadLine();
                        int number142 = Int32.Parse(input149);

                        if (number142 < 0)
                            Console.WriteLine("음수");
                        else if (number142 > 0)
                            Console.WriteLine("양수");
                        else
                            Console.WriteLine("0");

                        if (number142 % 2 == 0)
                            Console.WriteLine("짝수");
                        else
                            Console.WriteLine("홀수");
                    }
                    break;

                case 151:
                    {
                        Console.Write("숫자를 입력하세요 : ");

                        string input151 = Console.ReadLine();
                        int number151 = Convert.ToInt32(input151);

                        if(number151 > 0)
                        {
                            if (number151 % 2 == 0)
                                Console.WriteLine("0보다 큰 짝수.");
                            else
                                Console.WriteLine("0보다 큰 홀수.");
                        }
                        else
                        {
                            Console.WriteLine("0보다 작거나 같은 수.");
                        }
                    }
                    break;

                case 154:
                    {
                        Console.Write("요일을 입력하세요.(일,월,화,수,목,금,토) : ");
                        string day154 = Console.ReadLine();

                        switch(day154)
                        {
                            case "일":
                                Console.WriteLine("Sunday");
                                break;

                            case "월":
                                Console.WriteLine("Monday");
                                break;

                            case "화":
                                Console.WriteLine("Tuesday");
                                break;

                            case "수":
                                Console.WriteLine("Wednesday");
                                break;

                            case "목":
                                Console.WriteLine("Thursday");
                                break;

                            case "금":
                                Console.WriteLine("Friday");
                                break;

                            case "토":
                                Console.WriteLine("Saturday");
                                break;

                            default:
                                Console.WriteLine($"{day154}는(은) 요일이 아닙니다.");
                                break;
                        }
                    }
                    break;

                case 156:
                    {
                        object obj156 = null;

                        string s156 = Console.ReadLine();
                        if (int.TryParse(s156, out int out_i))
                            obj156 = out_i;
                        else if (float.TryParse(s156, out float out_f))
                            obj156 = out_f;
                        else
                            obj156 = s156;

                        switch(obj156)
                        {
                            case int i156:
                                Console.WriteLine($"{i156}는 int 형식입니다.");
                                break;

                            case float f156:
                                Console.WriteLine($"{f156}는 float 형식입니다.");
                                break;

                            default:
                                Console.WriteLine($"{obj156}는 모르는 형식입니다.");
                                break;
                        }
                    }
                    break;

                case 160:
                    {
                        int i160 = 10;

                        while(i160 > 0)
                        {
                            Console.WriteLine($"i : {i160--}");
                        }
                    }
                    break;

                case 163:
                    {
                        int i163 = 10;

                        do
                        {
                            Console.WriteLine("a) i : {0}", i163--);
                        }
                        while (i163 > 0);

                        do
                        {
                            Console.WriteLine("b) i : {0}", i163--);
                        }
                        while (i163 > 0);
                    }
                    break;

                case 165:
                    {
                        for(int i165 = 0; i165 < 5; i165++)
                        {
                            Console.WriteLine(i165);
                        }
                    }
                    break;

                case 166:
                    {
                        for(int i166 = 0; i166<5; i166++)
                        {
                            for(int j166 = 0; j166 <= i166; j166++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine();
                        }
                    }
                    break;

                case 168:
                    {
                        int[] arr168 = new int[] { 0, 1, 2, 3, 4 };

                        foreach (int a168 in arr168)
                        {
                            Console.WriteLine(a168);
                        }
                    }
                    break;

                case 170:
                    {
                        int i170 = 0;
                        for (; ; )
                            Console.WriteLine(i170++);
                    }
                    break;

                case 171:
                    {
                        int i171 = 0;
                        while (true)
                            Console.WriteLine(i171++);
                    }
                    break;

                case 172:
                    {
                        while(true)
                        {
                            Console.Write("계속할까요?(예/아니오) : ");
                            string answer172 = Console.ReadLine();

                            if (answer172 == "아니오")
                                break;
                        }
                    }
                    break;

                case 174:
                    {
                        for(int i174 = 0; i174 < 10; i174++)
                        {
                            if (i174 % 2 == 0)
                                continue;

                            Console.WriteLine($"{i174} : 홀수");
                        }
                    }
                    break;

                case 176:
                    {
                        Console.Write("종료 조건(숫자)을 입력하세요 : ");

                        string input176 = Console.ReadLine();

                        int input_number176 = Convert.ToInt32(input176);

                        int exit_number176 = 0;

                        for (int i176 = 0; i176<2; i176++)
                        {
                            for(int j176 = 0; j176<2; j176++)
                            {
                                for (int k176 = 0; k176<3; k176++)
                                {
                                    if (exit_number176++ == input_number176)
                                        goto EXIT_FOR;

                                    Console.WriteLine(exit_number176);
                                }
                            }
                        }

                        goto EXIT_PROGRAM;

                    EXIT_FOR:
                        Console.WriteLine("\nExit nested for...");

                    EXIT_PROGRAM:
                        Console.WriteLine("Exit program...");
                    }
                    break;
            }
        }
    }
}
