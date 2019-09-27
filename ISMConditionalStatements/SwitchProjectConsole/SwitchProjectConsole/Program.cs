using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchProjectConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            do
            {
                Console.WriteLine("1.Расшифровка дня недели.\n" +
                    "2.Расшифровка месяца.\n" +
                    "3.Выполнение операций над числами.\n" +
                    "4.Выход\n");
                x = int.Parse(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        Console.WriteLine("Введите день недели");
                        y = int.Parse(Console.ReadLine());
                        switch (y)
                        {
                            case 1:
                                Console.WriteLine("Понедельник");
                                break;
                            case 2:
                                Console.WriteLine("Вторник");
                                break;
                            case 3:
                                Console.WriteLine("Среда");
                                break;
                            case 4:
                                Console.WriteLine("Четверг");
                                break;
                            case 5:
                                Console.WriteLine("Пятница");
                                break;
                            case 6:
                                Console.WriteLine("Суббота");
                                break;
                            case 7:
                                Console.WriteLine("Воскресенье");
                                break;
                            default:
                                Console.WriteLine("Такого дня не существует");
                                break;
                        }
                        break;
                    case 2:
                        Console.WriteLine("Введите месяц");
                        y = int.Parse(Console.ReadLine());
                        switch (y)
                        {
                            case 1:
                                Console.WriteLine("Январь");
                                break;
                            case 2:
                                Console.WriteLine("Февраль");
                                break;
                            case 3:
                                Console.WriteLine("Март");
                                break;
                            case 4:
                                Console.WriteLine("Апрель");
                                break;
                            case 5:
                                Console.WriteLine("Май");
                                break;
                            case 6:
                                Console.WriteLine("Июнь");
                                break;
                            case 7:
                                Console.WriteLine("Июль");
                                break;
                            case 8:
                                Console.WriteLine("Август");
                                break;
                            case 9:
                                Console.WriteLine("Сентябрь");
                                break;
                            case 10:
                                Console.WriteLine("Октябрь");
                                break;
                            case 11:
                                Console.WriteLine("Ноябрь");
                                break;
                            case 12:
                                Console.WriteLine("Декабрь");
                                break;
                            default:
                                Console.WriteLine("Такого месяца не существует");
                                break;
                        }
                        break;
                    case 3:
                        Console.WriteLine("Введите первое число");
                        double a = double.Parse(Console.ReadLine());
                        Console.WriteLine("Введите второе число");
                        double b = double.Parse(Console.ReadLine());
                        double res;
                        Console.WriteLine("1.Сложение\n" +
                                          "2.Умножение\n" +
                                          "3.Вычитание\n" +
                                          "4.Деление");
                        y = int.Parse(Console.ReadLine());
                        switch (y)
                        {
                            case 1:
                                res = a + b;
                                Console.WriteLine("{0}", res);
                                break;
                            case 2:
                                res = a * b;
                                Console.WriteLine("{0}", res);
                                break;
                            case 3:
                                res = a - b;
                                Console.WriteLine("{0}", res);
                                break;
                            case 4:
                                res = a / b;
                                Console.WriteLine("{0}", res);
                                break;
                        }
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Такого пункта меню нет");
                        break;
                }
            } while (true);
            Console.ReadKey();
        }
    }
}
