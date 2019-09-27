using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole5
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введіть число");
                int n = int.Parse(Console.ReadLine());
                if (n > 0)
                {
                    int f = 1, r = 0;
                    for (int i = 1; i <= n; i++)
                    {
                        f = f * i;
                        r = r + f;
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
