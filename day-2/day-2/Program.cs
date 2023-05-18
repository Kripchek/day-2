using System;

namespace day_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("выберите группу заданий: 1- if...else,switch; 2-циклы");
            int modequest = int.Parse(Console.ReadLine());
            switch (modequest) {
                case 1:
                    Console.WriteLine("выберите задание из группы 'if...else,switch': 1; 2; 3; 4; 5");
                    int modequest1 = int.Parse(Console.ReadLine());
                    switch (modequest1)
                    {
                        case 1:
                            Console.WriteLine("вы выбрали 1 задание");
                            Console.WriteLine("Введите число");
                            int a = Convert.ToInt32(Console.ReadLine());
                            if (a > 0)
                            {
                                a += 5;
                                Console.WriteLine("к вашему числу прибавлено 5 и оно равно:" + a);
                            }
                            else
                            {
                                a -= 5;
                                Console.WriteLine("от вашего числа отнято 5 и оно равно:" + a);
                            }
                            break;
                        case 2:

                            Console.WriteLine("вы выбрали 2 задание");
                            Console.WriteLine("Введите 1 число");
                            int b = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите 2 число");
                            int c = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите 3 число");
                            int d = Convert.ToInt32(Console.ReadLine());
                            if (b > c && b > d)
                            {
                                Console.WriteLine("Наибольшее число: " + b);
                            }
                            else if (c > b && c > d)
                            {
                                Console.WriteLine("Наибольшее число: " + c);
                            }
                            else if (d > c && d > b)
                            {
                                Console.WriteLine("Наибольшее число: " + d);
                            }
                            else
                            {
                                Console.WriteLine("Наибольшее число: " + d);
                            }
                            break;
                        case 3:
                            Console.WriteLine("вы выбрали 3 задание");
                            Console.WriteLine("Введите 1 число");
                            int e = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите 2 число");
                            int f = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите 3 число");
                            int g = Convert.ToInt32(Console.ReadLine());
                            if (e > 0 && f > 0)
                            {
                                int l = e + f;
                                if (l > 0 && g > 0)
                                {
                                    int k = l + g;
                                    Console.WriteLine("cумма положительных чисел: " + k);
                                }
                                else
                                {
                                    Console.WriteLine("cумма положительных чисел: " + l);
                                }
                            }
                            else if (e > 0 && g > 0)
                            {
                                int ll = e + g;
                                if (ll > 0 && f > 0)
                                {
                                    int kk = ll + f;
                                    Console.WriteLine("cумма положительных чисел: " + kk);
                                }
                                else
                                {
                                    Console.WriteLine("cумма положительных чисел: " + ll);
                                }
                            }
                            else if (f > 0 && g > 0)
                            {
                                int lll = f + g;
                                if (lll > 0 && e > 0)
                                {
                                    int kkk = lll + e;
                                    Console.WriteLine("cумма положительных чисел: " + kkk);
                                }

                            }
                            else if (e > 0)
                            {
                                Console.WriteLine("cумма положительных чисел: " + e);
                            }
                            else if (f > 0)
                            {
                                Console.WriteLine("cумма положительных чисел: " + f);
                            }
                            else if (g > 0)
                            {
                                Console.WriteLine("cумма положительных чисел: " + g);
                            }
                            else
                            {
                                Console.WriteLine("вы не ввели не одного положительного числа");
                            }
                            break;
                        case 4:
                            Console.WriteLine("вы выбрали 4 задание");
                            Console.WriteLine("Введите число");
                            int y = Convert.ToInt32(Console.ReadLine());
                            if (y > 10)
                            {
                                y *= 2;
                                Console.WriteLine("Ваше число было удвоено: " + y);
                            }
                            else
                            {
                                Console.WriteLine("Ваше число: " + y);
                            }
                            break;
                        case 5:
                            Console.WriteLine("вы выбрали 5 задание");
                            Console.WriteLine("Введите номер дня недели");
                            int mode = int.Parse(Console.ReadLine());
                            switch (mode)
                            {
                                case 1:
                                    Console.WriteLine("Сегодня понедельник");
                                    break;
                                case 2:
                                    Console.WriteLine("Сегодня вторник");
                                    break;
                                case 3:
                                    Console.WriteLine("Сегодня среда");
                                    break;
                                case 4:
                                    Console.WriteLine("Сегодня четверг");
                                    break;
                                case 5:
                                    Console.WriteLine("Сегодня пятница");
                                    break;
                                case 6:
                                    Console.WriteLine("Сегодня суббота");
                                    break;
                                case 7:
                                    Console.WriteLine("Сегодня воскресенье");
                                    break;
                            }
                            break;
                    }
            
                    break;
                case 2:
                    Console.WriteLine("выберите задание из группы 'циклы': 1; 2; 3; 4");
                    int modequest2 = int.Parse(Console.ReadLine());
                    switch (modequest2)
                    {
                        case 1:
                            Console.WriteLine("вы выбрали 1 задание");
                            int n = 200;


                            while (n < 800)
                            {
                                if (n % 17 == 0)
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("нет числа которое делиться на 17");
                                }
                                n++;
                            }
                            Console.WriteLine("наименьшее число которое делиться на 17 это :" + n);
                            break;
                        case 2:
                            Console.WriteLine("вы выбрали 2 задание");
                            int i = 1;
                            double run = 10;
                            double sum = 10;
                            while (run <= 20 && run <= 21)
                            {
                                sum += run;
                                run = run + run * 0.05;
                                if (sum >= 100 && sum <= 120)
                                {
                                    Console.WriteLine("100км человек пробежал на " + i + " день");
                                }

                                i++;

                            }
                            Console.WriteLine("человек пробежал за 1 раз - 20км в " + i + " день");
                            break;
                                case 3:
                            Console.WriteLine("вы выбрали 3 задание");
                            Console.WriteLine("введите факториал");
                            int fac = int.Parse(Console.ReadLine());
                            int factor = fac;
                            for (int qq = 1; qq < fac; qq++)
                            {
                                factor = factor * qq;

                            }
                            Console.WriteLine("факториал вашего числа равен: " + factor);
                            break;
                        case 4:
                            Console.WriteLine("вы выбрали 4 задание");
                            int s, z;
                            Console.Write("Введите натуральное число не меньше двух: ");
                            s = Convert.ToInt32(Console.ReadLine());
                            for (z = 2; z * z <= s; z++)
                            {
                                if (s % z == 0)
                                {
                                    Console.WriteLine(z);
                                    break;
                                }
                            }
                            break;
                    }
                    break;       
            }
            Console.ReadKey();
        }
    }
}
