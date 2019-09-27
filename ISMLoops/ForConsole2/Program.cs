using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введіть число n");
                int n = int.Parse(Console.ReadLine());
                if (n > 0)
                {
                    double r = 1;
                    for (int i = 2; i <= n; i++)
                    {
                        r += (1.0 / i);
                    }
                    Console.WriteLine(r);
                }
                else
                    Console.WriteLine("Помилка вводу");

            }
            catch
            {
                Console.WriteLine("Помилка вводу");
            }
            Console.ReadKey();
        }
    }
}
