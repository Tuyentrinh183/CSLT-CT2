using System;
using System.Threading.Channels;
namespace Sample
{
    internal class Exercise_1
    {
        static void Main(string[] args)
        {
            Bai_1();
            Bai_2();
            Bai_3();
            Bai_4();   
            Bai_5();
            Bai_6();
            Bai_8();
            Bai_9();
            Bai_10();
        }

        static void Bai_1()
        {
            Console.Write("a = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b = ");
            int b = Convert.ToInt32(Console.ReadLine());
            int sum = a + b;
            Console.WriteLine($"{a} + {b} = {sum}");
        }

        static void Bai_2()
        {
            Console.Write("a = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b = ");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = a;
            a = b;
            b = c;
            Console.WriteLine($"{a}, {b}");
        }
        static void Bai_3()
        {

            float a, b, kqua;
            a = 10.5f;
            b = 5.75f;
            kqua = a * b;
            Console.WriteLine("{0} * {1} = {2}", a, b, kqua);
            Console.ReadLine();
        }
        static void Bai_4()
        {
            double feet, meter;
            Console.WriteLine("Input Feet :");
            feet = Convert.ToDouble(Console.ReadLine());
            meter = feet / 3.2808399;
            Console.WriteLine("\n feet in meter =" + meter);
        }
        static void Bai_5()
        {

            double f, c;
            Console.WriteLine("Enter độ C:");
            c = Convert.ToDouble(Console.ReadLine());
            f = c * 9 / 5 + 32;
            Console.WriteLine(c + " độ C sang độ F = : " + f + "°F");
            Console.WriteLine("Enter độ F:");
            f = Convert.ToDouble(Console.ReadLine());
            c = (f - 32) * 5 / 9;
            Console.WriteLine(f + "°F sang độ C: " + c + "°C");
            Console.ReadLine();
        }
        static void Bai_6()
        {
            Console.WriteLine("size of (int): {0}", sizeof(int));
            Console.WriteLine("size of (float): {0}", sizeof(float));
            Console.WriteLine("size of (decimal): {0}", sizeof(decimal));
            Console.WriteLine("size of (double): {0}", sizeof(double));
            Console.WriteLine("size of (byte): {0}", sizeof(byte));
            Console.ReadLine();
        }
        static void Bai_8()
        {
            Console.Write("nhập bán kính đường tròn: ");
            double rad = Convert.ToDouble(Console.ReadLine());
            double area = Math.PI * rad * rad; //đường kính (rad*rad) * 3.14 (pi)
            Console.WriteLine("Diện tích đường tròn : " + area);
        }
        static void Bai_9()
        {
            Console.Write("nhập gtri cạnh hình vuông: ");
            double a = Convert.ToDouble(Console.ReadLine());
            double area = a * a; //cạnh*c
            Console.WriteLine("Diện tích hình vuong: " + area);
        }
        static void Bai_10()
        {
            int num = 0;
            int years = 0;
            int weeks = 0;
            int days = 0;
            Console.Write("nhập số ngày: ");
            num = Convert.ToInt32(Console.ReadLine());
            years = num / 365;
            weeks = (num % 365) / 7;
            days = (num % 365) % 7;
            Console.WriteLine("Years : " + years);
            Console.WriteLine("Weeks : " + weeks);
            Console.WriteLine("Days  : " + days);
        }
    }
}