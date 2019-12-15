using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_tutorial.Chapters._4
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
                case 119:
                    {
                        int a119 = 111 + 222;
                        Console.WriteLine($"a : {a119}");

                        int b119 = a119 - 100;
                        Console.WriteLine($"b : {b119}");

                        int c119 = b119 * 10;
                        Console.WriteLine($"c : {c119}");

                        double d119 = c119 / 6.3;
                        Console.WriteLine($"d : {d119}");

                        Console.WriteLine($"22 / 7 = {22 / 7}({22 % 7})");
                    }
                    break;

                case 121:
                    {
                        int a121 = 10;
                        Console.WriteLine(a121++);
                        Console.WriteLine(++a121);

                        Console.WriteLine(a121--);
                        Console.WriteLine(--a121);
                    }
                    break;

                case 123:
                    {
                        string result123 = "123" + "456";
                        Console.WriteLine(result123);

                        result123 = "Hello" + " " + "World!";
                        Console.WriteLine(result123);
                    }
                    break;

                case 124:
                    {
                        Console.WriteLine($"3 > 4 : {3 > 4}");
                        Console.WriteLine($"3 >= 4 : {3 >= 4}");
                        Console.WriteLine($"3 < 4 : {3 < 4}");
                        Console.WriteLine($"3 <= 4 : {3 <= 4}");
                        Console.WriteLine($"3 == 4 : {3 == 4}");
                        Console.WriteLine($"3 != 4 : {3 != 4}");
                    }
                    break;

                case 126:
                    {
                        Console.WriteLine("Testing && ... ");
                        Console.WriteLine($"1 > 0 && 4 < 5 : {1 > 0 && 4 < 5}");
                        Console.WriteLine($"1 > 0 && 4 > 5 : {1 > 0 && 4 > 5}");
                        Console.WriteLine($"1 == 0 && 4 > 5 : {1 == 0 && 4 > 5}");
                        Console.WriteLine($"1 == 0 && 4 < 5 : {1 == 0 && 4 < 5}");

                        Console.WriteLine("\nTesting || ... ");
                        Console.WriteLine($"1 > 0 || 4 < 5 : {1 == 0 || 4 < 5}");
                        Console.WriteLine($"1 > 0 || 4 > 5 : {1 == 0 || 4 > 5}");
                        Console.WriteLine($"1 == 0 || 4 > 5 : {1 == 0 || 4 > 5}");
                        Console.WriteLine($"1 == 0 || 4 < 5 : {1 == 0 || 4 < 5}");

                        Console.WriteLine("\nTesting ! ...");
                        Console.WriteLine($"!True : {!true}");
                        Console.WriteLine($"!False : {!false}");
                    }
                    break;

                case 128:
                    {
                        string result128 = (10 % 2) == 0 ? "짝수" : "홀수";

                        Console.WriteLine(result128);
                    }
                    break;

                case 130:
                    {
                        ArrayList a130 = null;
                        a130?.Add("야구");    // a130?.이 null을 반환하므로 Add() 메소드는 호출되지 않음
                        a130?.Add("축구");
                        Console.WriteLine($"Count : {a130?.Count}");
                        Console.WriteLine($"{a130?[0]}");
                        Console.WriteLine($"{a130?[1]}");

                        a130 = new ArrayList();
                        a130?.Add("야구");
                        a130?.Add("축구");
                        Console.WriteLine($"Count : {a130?.Count}");
                        Console.WriteLine($"{a130?[0]}");
                        Console.WriteLine($"{a130?[1]}");
                    }
                    break;

                case 134:
                    {
                        Console.WriteLine("Testing << ...");

                        int a134 = 1;
                        Console.WriteLine("a        : {0:D5} (0x{0:X8})", a134);
                        Console.WriteLine("a << 1   : {0:D5} (0x{0:X8})", a134 << 1);
                        Console.WriteLine("a << 2   : {0:D5} (0x{0:X8})", a134 << 2);
                        Console.WriteLine("a << 5   : {0:D5} (0x{0:X8})", a134 << 5);

                        Console.WriteLine("\nTesting >>...");

                        int b134 = 255;
                        Console.WriteLine("b        : {0:D5} (0x{0:X8})", b134);
                        Console.WriteLine("b >> 1   : {0:D5} (0x{0:X8})", b134 >> 1);
                        Console.WriteLine("b >> 2   : {0:D5} (0x{0:X8})", b134 >> 2);
                        Console.WriteLine("b >> 5   : {0:D5} (0x{0:X8})", b134 >> 5);

                        Console.WriteLine("\nTesting >> 2...");

                        int c134 = -255;
                        Console.WriteLine("c        : {0:D5} (0x{0:X8})", c134);
                        Console.WriteLine("c >> 1   : {0:D5} (0x{0:X8})", c134 >> 1);
                        Console.WriteLine("c >> 2   : {0:D5} (0x{0:X8})", c134 >> 2);
                        Console.WriteLine("c >> 5   : {0:D5} (0x{0:X8})", c134 >> 5);
                    }
                    break;

                case 138:
                    {
                        int a138 = 9;
                        int b138 = 10;

                        Console.WriteLine($"{a138} & {b138} : {a138 & b138}");
                        Console.WriteLine($"{a138} | {b138} : {a138 | b138}");
                        Console.WriteLine($"{a138} ^ {b138} : {a138 ^ b138}");

                        int c138 = 255;
                        Console.WriteLine("~{0}(0x{0:X8}) : {1}(0x{1:X8})", c138, ~c138);
                    }
                    break;

                case 140:
                    {
                        int a140;
                        a140 = 100;
                        Console.WriteLine($"a = 100 : {a140}");
                        a140 += 90;
                        Console.WriteLine($"a += 90 : {a140}");
                        a140 -= 80;
                        Console.WriteLine($"a -= 80 : {a140}");
                        a140 *= 70;
                        Console.WriteLine($"a *= 70 : {a140}");
                        a140 /= 60;
                        Console.WriteLine($"a /= 60 : {a140}");
                        a140 %= 50;
                        Console.WriteLine($"a %= 50 : {a140}");
                        a140 &= 40;
                        Console.WriteLine($"a &= 40 : {a140}");
                        a140 |= 30;
                        Console.WriteLine($"a |= 30 : {a140}");
                        a140 ^= 20;
                        Console.WriteLine($"a ^= 20 : {a140}");
                        a140 <<= 10;
                        Console.WriteLine($"a <<= 10 : {a140}");
                        a140 >>= 1;
                        Console.WriteLine($"a >>= 1 : {a140}");
                    }
                    break;

                case 142:
                    {
                        int? num142 = null;
                        Console.WriteLine($"{num142 ?? 0}");

                        num142 = 99;
                        Console.WriteLine($"{num142 ?? 0}");

                        string str142 = null;
                        Console.WriteLine($"{str142 ?? "Default"}");

                        str142 = "Specific";
                        Console.WriteLine($"{str142 ?? "Default"}");
                    }
                    break;
            }
        }
    }
}
