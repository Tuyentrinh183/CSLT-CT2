// See https://aka.ms/new-console-template for more information

namespace baitap4
{
    class program
    {
        public static void Main(string[] args)
        {
            //baitap01(); 
            //baitap02();
            //baitap03();
            //baitap04();
            //baitap05();
            //baitap06();
            //baitap0701();
            //baitap0702
            //baitap0703
            //baitap08();
            //baitap9();
            baitap10();
        }

        static void baitap01()
        {
            Console.WriteLine("Nhap so: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine($"{a} la so chan");
            }
            else
            {
                Console.WriteLine($"{a} la so le");
            }
        }

        static void baitap02()
        {
            int a, b, c;
            Console.WriteLine("Nhap so thu nhat");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap so thu hai");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap so thu ba");
            c = Convert.ToInt32(Console.ReadLine());
            int max = a;

            if (b > max) max = b;
            if (c > max) max = c;

            Console.WriteLine($"Vay so lon nhat trong 3 so {a}, {b}, {c} la: " + max);
        }

        static void baitap03()
        {
            double a, b;
            Console.WriteLine("Nhap x");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhap y");
            b = Convert.ToDouble(Console.ReadLine());

            if (a > 0 && b > 0)
            {
                Console.WriteLine($"Toa do ({a}:{b}) thuoc goc phan tu thu nhat");
            }
            else if (a < 0 && b > 0)
            {
                Console.WriteLine($"Toa do ({a}:{b}) thuoc goc phan tu thu hai");
            }
            else if (a < 0 && b < 0)
            {
                Console.WriteLine($"Toa do ({a}:{b}) thuoc goc phan tu thu ba");
            }
            else if (a > 0 && b < 0)
            {
                Console.WriteLine($"Toa do ({a}:{b}) thuoc goc phan tu thu tu");
            }
            else
            {
                Console.WriteLine($"Toa do ({a}:{b}) nam tren mot trong cac truc toa do");
            }
        }

        static void baitap04()
        {
            double a, b, c;
            Console.WriteLine("Nhap canh thu nhat cua tam giac");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhap canh thu hai cua tam giac");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhap canh thu ba cua tam giac");
            c = Convert.ToDouble(Console.ReadLine());

            if (a > 0 && b > 0 && c > 0 && a + b > c && b + c > a && c + a > b)
            {
                if (a == b && b == c)
                {
                    Console.WriteLine($"3 canh {a},{b},{c} ma ban nhap tao thanh tam giac deu");
                }
                else if (a == b || b == c || c == a)
                {
                    Console.WriteLine($"3 canh {a},{b},{c} ma ban nhap tao thanh tam giac can");
                }
                else
                {
                    Console.WriteLine($"3 canh {a},{b},{c} ma ban nhap tao thanh tam giac thuong");
                }
            }
            else
            {
                Console.WriteLine($"3 canh {a},{b},{c} ma ban nhap khong tao thanh mot tam giac");
            }
        }

        static void baitap05()
        {
            double sum = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Nhap so thu {i + 1}: ");
                double num = Convert.ToDouble(Console.ReadLine());
                sum += num;
            }
            double average = sum / 10;
            Console.WriteLine($"Tong: {sum}");
            Console.WriteLine($"Trung bình: {average}");
        }
        static void baitap06()
        {
            Console.WriteLine("Nhap so:");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            { Console.WriteLine($"{num}.{i}={num * i}"); }
        }
               static void baitap0701()
        {
            Console.WriteLine("Nhap so dong: ");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= a; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write($"{j} ");
                Console.Write("\n");
            }
            static void baitap0702()
            {
                int b = 1;
                Console.WriteLine("Nhap so dong: ");
                int a = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i <= a; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write($"{b} ");
                        ++b;
                    }
                    Console.Write($"\n");
                }
                static void baitap0703()
                {
                    int b = 1;
                    int c;
                    Console.WriteLine("Nhap so dong: ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    for (int i = 1; i <= a; i++)
                    {
                        for (c = 1; c <= a - i; c++) Console.Write(" ");
                        for (int j = 1; j <= i; j++)
                        {
                            Console.Write($"{b} ");
                            ++b;
                        }
                        Console.Write($"\n");
                    }
                    static void baitap08()
                    {
                        Console.Write("n=");
                        int n = Convert.ToInt32(Console.ReadLine());
                        double sum = 0.0;
                        for (int i = 1; i <= n; i++)
                        { sum += 1.0 / i; }
                        Console.WriteLine($"{sum}");
                    }
                    static void baitap09()
                    {
                        Console.Write("Nhap so bat dau: ");
                        int start = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Nhap so ket thuc: ");
                        int end = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("So hoan hao");
                        for (int num = start; num <= end; num++)
                        {
                            int sum = 0;
                            for (int i = 1; i < num; i++)
                            {
                                if (num % i == 0)
                                { sum += i; }
                            }
                            if (sum == num)
                            { Console.WriteLine(num); }
                        }
                    }
                    static void baitap10()
                    {
                        int a = 0;
                        Console.WriteLine("Nhap so nguyen duong n: ");
                        int n = Convert.ToInt32(Console.ReadLine());
                        for (int i = 2; i <= n / 2; i++)
                        {
                            if (n % i == 0)
                            {
                                a++; Console.WriteLine($"{n} khong phai so nguyen to");
                                break;
                            }
                        }
                        if (a == 0 && n != 1) Console.WriteLine($"{n} la so nguyen to");
                    }


                }
            }
        }
    }