using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_tutorial.Chapters._6
{
    class Product197
    {
        private int price = 100;

        public ref int GetPrice()
        {
            return ref price;
        }

        public void PrintPrice()
        {
            Console.WriteLine($"Price :{price}");
        }
    }

    class Codes : CodesClass
    {
        public Codes(int arg) : base(arg)
        {
        }

        public override void RunCode(int arg)
        {
            switch(arg)
            {
                case 186:
                    {
                        int result186 = this.Plus186(3, 4);
                        Console.WriteLine(result186);

                        result186 = this.Minus186(5, 2);
                        Console.WriteLine(result186);
                    }
                    break;

                case 189:
                    {
                        Console.WriteLine($"10번째 피보나치 수 : {Fibonacci189(10)}");

                        PrintProfile189("", "123-4567");
                        PrintProfile189("박상현", "456-1230");
                    }
                    break;

                case 193:
                    {
                        int x193 = 3;
                        int y193 = 4;

                        Console.WriteLine($"x:{x193}, y:{y193}");

                        Swap193(x193, y193);

                        Console.WriteLine($"x:{x193}, y:{y193}");
                    }
                    break;

                case 195:
                    {
                        int x195 = 3;
                        int y195 = 4;

                        Console.WriteLine($"x:{x195}, y:{y195}");

                        Swap195(ref x195, ref y195);

                        Console.WriteLine($"x:{x195}, y:{y195}");
                    }
                    break;

                case 197:
                    {
                        Product197 carrot = new Product197();
                        ref int ref_local_price197 = ref carrot.GetPrice();
                        int normal_local_price197 = carrot.GetPrice();

                        carrot.PrintPrice();
                        Console.WriteLine($"Ref Local Price :{ref_local_price197}");
                        Console.WriteLine($"Normal Local Price :{normal_local_price197}");

                        ref_local_price197 = 200;

                        carrot.PrintPrice();
                        Console.WriteLine($"Ref Local Price :{ref_local_price197}");
                        Console.WriteLine($"Normal Local Price :{normal_local_price197}");
                    }
                    break;

                case 200:
                    {
                        int a200 = 20;
                        int b200 = 3;
                        // int c
                        // int d

                        Device200(a200, b200, out int c200, out int d200);

                        Console.WriteLine($"a:{a200}, b:{b200}, a/b:{c200}, a%b:{d200}");
                    }
                    break;

                case 203:
                    {
                        Console.WriteLine(Plus203(1, 2));
                        Console.WriteLine(Plus203(1, 2, 3));
                        Console.WriteLine(Plus203(1.0, 2.4));
                        Console.WriteLine(Plus203(1, 2.4));
                    }
                    break;

                case 205:
                    {
                        int sum = Sum205(3, 4, 5, 6, 7, 8, 9, 10);

                        Console.WriteLine($"Sum : {sum}");
                    }
                    break;

                case 207:
                    {
                        PrintProfile207(name: "박찬호", phone: "010-123-1234");
                        PrintProfile207(phone: "010-987-9876", name: "박지성");
                        PrintProfile207("박세리", "010-222-2222");
                        PrintProfile207("박상현", phone:"010-567-5678");
                    }
                    break;

                case 209:
                    {
                        PrintProfile209("태연");
                        PrintProfile209("윤아", "010-123-1234");
                        PrintProfile209(name:"유리");
                        PrintProfile209(name: "서현", phone: "010-789-7890");
                    }
                    break;

                case 212:
                    {
                        Console.WriteLine(ToLowerString212("Hello!"));
                        Console.WriteLine(ToLowerString212("Good Morning."));
                        Console.WriteLine(ToLowerString212("This is C#."));
                    }
                    break;
            }
        }

        public string ToLowerString212(string input)
        {
            var arr = input.ToCharArray();
            for(int i=0; i<arr.Length; i++)
            {
                arr[i] = ToLowerChar(i);
            }

            char ToLowerChar(int i)
            {
                if (arr[i] < 65 || arr[i] > 90)
                    return arr[i];
                else
                    return (char)(arr[i] + 32);
            }

            return new string(arr);
        }

        public void PrintProfile209(string name, string phone = "")
        {
            Console.WriteLine($"Name:{name}, Phone:{phone}");
        }

        public void PrintProfile207(string name, string phone)
        {
            Console.WriteLine($"Name:{name}, Phone:{phone}");
        }

        public int Sum205(params int[] args)
        {
            Console.Write("Summing... ");

            int sum = 0;

            for (int i=0; i<args.Length; i++)
            {
                if (i > 0)
                    Console.Write(", ");

                Console.Write(args[i]);

                sum += args[i];
            }
            Console.WriteLine();

            return sum;
        }

        public int Plus203(int a, int b)
        {
            Console.WriteLine("Calling int Plus(int,int)");
            return a + b;
        }

        public int Plus203(int a, int b, int c)
        {
            Console.WriteLine("Calling int Plus(int,int,int)");
            return a + b + c;
        }

        public double Plus203(double a, double b)
        {
            Console.WriteLine("Calling double Plus(double,double)");
            return a + b;
        }

        public double Plus203(int a, double b)
        {
            Console.WriteLine("calling double Plus(int,double)");
            return a + b;
        }

        public void Device200(int a, int b, out int quotient, out int remainder)
        {
            quotient = a / b;
            remainder = a % b;
        }

        public void Swap195(ref int a, ref int b)
        {
            int temp = b;
            b = a;
            a = temp;
        }

        public void Swap193(int a, int b)
        {
            int temp = b;
            b = a;
            a = temp;
        }

        public int Fibonacci189(int n)
        {
            if (n < 2)
            {
                Console.WriteLine();
                return n;
            }
            else
                Console.WriteLine(n);
                return Fibonacci189(n - 1) + Fibonacci189(n - 2);
        }

        void PrintProfile189(string name, string phone)
        {
            if(name == "")
            {
                Console.WriteLine("이름을 입력해주세요 : ");
                return;
            }

            Console.WriteLine($"Name:{name}, Phone:{phone}");
        }

        public int Plus186(int a, int b)
        {
            return a + b;
        }

        public int Minus186(int a, int b)
        {
            return a - b;
        }
    }
}
