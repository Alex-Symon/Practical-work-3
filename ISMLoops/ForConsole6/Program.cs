using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ForConsole6
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
                    double r = 0;
                    for (int i = 1; i <= n; i++)
                    {
                        r = r + Math.Pow(i, n + 1 - i);
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
