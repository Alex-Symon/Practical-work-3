using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Число a");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Число b");
                int b = int.Parse(Console.ReadLine());
                if (a < b)
                {
                    int r = 1, res = 0;
                    for (int i = a; i <= b; i++)
                    {
                        r = a * a;
                        a++;
                        res += r;
                        Console.WriteLine(res);
                    }
                }
                else
                    Console.WriteLine("Помилка вводу");
            }
            catch {
                Console.WriteLine("Помилка вводу");
            }
            Console.ReadKey();
        }
    }
}
