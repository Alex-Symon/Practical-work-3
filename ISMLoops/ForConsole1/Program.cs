using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введіть число a");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Введіть число b");
                int b = int.Parse(Console.ReadLine());
                if (a < b)
                {
                    int r = 1;
                    while (a <= b)
                    {
                        r = r * a;
                        a++;
                    }
                    Console.WriteLine(r);
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
