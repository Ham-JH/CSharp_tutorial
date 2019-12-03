using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_tutorial.Chapters._3
{
    class Codes : CodesClass
    {
        enum DialogResult82 { YES, NO, CANCEL, CONFIRM, OK }

        public Codes(int arg) : base(arg)
        {
        }

        public override void RunCode(int arg)
        {
            switch(arg)
            {
                case 48:
                    {
                        sbyte a48 = -10;
                        byte b48 = 40;

                        Console.WriteLine($"a={a48}, b={b48}");

                        short c48 = -30000;
                        ushort d48 = 60000;

                        Console.WriteLine($"c={c48}, d={d48}");

                        int e48 = -1000_0000;
                        uint f48 = 3_0000_0000;

                        Console.WriteLine($"e={e48}, f={f48}");

                        long g48 = -5000_0000_0000;
                        ulong h48 = 200_0000_0000_0000_0000;

                        Console.WriteLine($"g={g48}, h={h48}");
                    }
                    break;

                case 50:
                    {
                        byte a50 = 240;
                        Console.WriteLine($"a={a50}");

                        byte b50 = 0b1111_0000;     // 2진수 리터럴
                        Console.WriteLine($"b={b50}");

                        byte c50 = 0XF0;            // 16진수 리터럴
                        Console.WriteLine($"c={c50}");

                        uint d50 = 0x1234_abcd;     // 16진수 리터럴
                        Console.WriteLine($"d={d50}");
                    }
                    break;

                case 54:
                    {
                        byte a54 = 255;
                        sbyte b54 = (sbyte)a54;

                        Console.WriteLine(a54);
                        Console.WriteLine(b54);
                    }
                    break;

                case 55:
                    {
                        uint a55 = uint.MaxValue;

                        Console.WriteLine(a55);

                        a55 = a55 + 1;

                        Console.WriteLine(a55);
                    }
                    break;

                case 58:
                    {
                        float a58 = 3.1415_9265_3589_7932_7846f;
                        Console.WriteLine(a58);

                        double b58 = 3.1415_9265_3589_7932_3846;
                        Console.WriteLine(b58);
                    }
                    break;

                case 60:
                    {
                        float   a60 = 3.1415_9265_3589_7932_3846_2643_3832_79f;
                        double  b60 = 3.1415_9265_3589_7932_3846_2643_3832_79;
                        decimal c60 = 3.1415_9265_3589_7932_3846_2643_3832_79m;

                        Console.WriteLine(a60);
                        Console.WriteLine(b60);
                        Console.WriteLine(c60);
                    }
                    break;

                case 61:
                    {
                        char a61 = '안';
                        char b61 = '녕';
                        char c61 = '하';
                        char d61 = '세';
                        char e61 = '요';

                        Console.Write(a61);
                        Console.Write(b61);
                        Console.Write(c61);
                        Console.Write(d61);
                        Console.Write(e61);
                        Console.WriteLine();
                    }
                    break;

                case 63:
                    {
                        string a63 = "안녕하세요?";
                        string b63 = "Hamm입니다.";

                        Console.WriteLine(a63);
                        Console.WriteLine(b63);
                    }
                    break;

                case 65:
                    {
                        bool a65 = true;
                        bool b65 = false;

                        Console.WriteLine(a65);
                        Console.WriteLine(b65);
                    }
                    break;

                case 67:
                    {

                        object a67 = 123;
                        object b67 = 3.141592653589793238462643383279m;
                        object c67 = true;
                        object d67 = "안녕하세요";

                        Console.WriteLine(a67);
                        Console.WriteLine(b67);
                        Console.WriteLine(c67);
                        Console.WriteLine(d67);

                    }
                    break;

                case 69:
                    {
                        int a69 = 123;
                        object b69 = (object)a69;       // a에 담긴 값을 박싱해서 힙에 저장
                        int c69 = (int)b69;             // b에 담긴 값을 언박싱해서 스택에 저장

                        Console.WriteLine(a69);
                        Console.WriteLine(b69);
                        Console.WriteLine(c69);

                        double x69 = 3.141213;
                        // object 형식에 저장할 때 형식 변환 연산자를 지정하지 않으면
                        // 암시적으로 object 형식으로 변환된다.
                        object y69 = x69;               // x에 담긴 값을 박싱해서 힙에 저장
                        double z69 = (double)y69;       // y에 담긴 값을 언박싱해서 스택에 저장

                        Console.WriteLine(x69);
                        Console.WriteLine(y69);
                        Console.WriteLine(z69);

                    }
                    break;

                case 71:
                    {
                        sbyte a71 = 127;
                        Console.WriteLine(a71);

                        int b71 = (int)a71;
                        Console.WriteLine(b71);

                        int x71 = 128;              // sbyte의 최대값 127보다 1 큰 수
                        Console.WriteLine(x71);

                        sbyte y71 = (sbyte)x71;     // 오버플로우 발생
                        Console.WriteLine(y71);
                    }
                    break;

                case 72:
                    {
                        float a72 = 69.6875f;
                        Console.WriteLine("a : {0}", a72);

                        double b72 = (double)a72;
                        Console.WriteLine("b : {0}", b72);

                        Console.WriteLine("69.6875 == b : {0}", 69.6875 == b72);

                        float x72 = 0.1f;
                        Console.WriteLine("x ; {0}", x72);

                        double y72 = (double)x72;
                        Console.WriteLine("y : {0}", y72);

                        Console.WriteLine("0.1 == y : {0}", 0.1 == y72);
                    }
                    break;

                case 74:
                    {
                        int a74 = 500;
                        Console.WriteLine(a74);

                        uint b74 = (uint)a74;
                        Console.WriteLine(b74);

                        int x74 = -30;
                        Console.WriteLine(x74);

                        uint y74 = (uint)x74;       // 언더플로우
                        Console.WriteLine(y74);
                    }
                    break;

                case 75:
                    {
                        float a75 = 0.9f;
                        int b75 = (int)a75;
                        Console.WriteLine(b75);

                        float c75 = 1.1f;
                        int d75 = (int)c75;
                        Console.WriteLine(d75);
                    }
                    break;

                case 77:
                    {
                        int a77 = 123;
                        string b77 = a77.ToString();
                        Console.WriteLine(b77);

                        float c77 = 3.14f;
                        string d77 = c77.ToString();
                        Console.WriteLine(d77);

                        string e77 = "123456";
                        int f77 = Convert.ToInt32(e77);
                        Console.WriteLine(f77);

                        string g77 = "1.2345";
                        float h77 = float.Parse(g77);
                        Console.WriteLine(h77);
                    }
                    break;

                case 79:
                    {
                        const int MAX_INT = 2147483647;
                        const int MIN_INT = -2147483648;

                        Console.WriteLine(MAX_INT);
                        Console.WriteLine(MIN_INT);
                    }
                    break;

                case 82:
                    {
                        Console.WriteLine((int)DialogResult82.YES);
                        Console.WriteLine((int)DialogResult82.NO);
                        Console.WriteLine((int)DialogResult82.CANCEL);
                        Console.WriteLine((int)DialogResult82.CONFIRM);
                        Console.WriteLine((int)DialogResult82.OK);
                    }
                    break;

                case 83:
                    {
                        DialogResult82 result = DialogResult82.YES;

                        Console.WriteLine(result == DialogResult82.YES);
                        Console.WriteLine(result == DialogResult82.NO);
                        Console.WriteLine(result == DialogResult82.CANCEL);
                        Console.WriteLine(result == DialogResult82.CONFIRM);
                        Console.WriteLine(result == DialogResult82.OK);
                    }
                    break;

                case 87:
                    {
                        int? a87 = null;

                        Console.WriteLine(a87.HasValue);
                        Console.WriteLine(a87 != null);

                        a87 = 3;

                        Console.WriteLine(a87.HasValue);
                        Console.WriteLine(a87 != null);
                        Console.WriteLine(a87.Value);
                    }
                    break;

                case 89:
                    {
                        var a89 = 20;       // var로 선언하는 변수는 반드시 초기화해야 한다.
                        Console.WriteLine("Type : {0}, Value : {1}", a89.GetType(), a89);

                        var b89 = 3.1414213;
                        Console.WriteLine("type : {0}, Value : {1}", b89.GetType(), b89);

                        var c89 = "Hello, World!";
                        Console.WriteLine("type : {0}, Value : {1}", c89.GetType(), c89);

                        var d89 = new int[] { 10, 20, 30 };
                        Console.WriteLine("type : {0}, Value : {1}", d89.GetType(), d89);

                        foreach (var e89 in d89)
                            Console.Write("{0} ", e89);

                        Console.WriteLine();
                    }
                    break;

                case 92:
                    {
                        System.Int32 a92 = 123;
                        int b92 = 456;

                        Console.WriteLine("a92 type:{0}, value:{1}", a92.GetType().ToString(), a92);
                        Console.WriteLine("b92 type:{0}, value:{1}", b92.GetType().ToString(), b92);

                        System.String c92 = "abc";
                        string d92 = "def";

                        Console.WriteLine("c92 type:{0}, value:{1}", c92.GetType().ToString(), c92);
                        Console.WriteLine("d92 type:{0}, value:{1}", d92.GetType().ToString(), d92);
                    }
                    break;
            }
        }

    }
}
